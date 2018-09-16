using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTeam06TermProject.EF_Classes;
using System.Data.Entity;
using System.Diagnostics;
using System.Globalization;

namespace ProjectTeam06TermProject
{
    public partial class FormBuyWindow : Form
    {
		//create variables to store in the tables
        decimal minPrice;
		decimal maxPrice;
		ECommerceEntities context;
        Random rnd = new Random();
        decimal money = 0;

        public FormBuyWindow()
        {
            InitializeComponent();

            //create instance of EF
            context = new ECommerceEntities();

            //Set the balance
            SetMoney(ref money, rnd);

            //Register event handlers
            this.Load += FormBuyWindow_Load;
            buttonPurchaseItem.Click += buttonPurchaseItem_Click;
			checkBoxPriceSearch.Click += CheckBoxPriceSearch_Click;
            listBoxCategories.SelectedIndexChanged += ListBoxCategories_SelectedIndexChanged;
        }

        /// <summary>
        /// Event listener for the list to display the items on select
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowPostingItems();
        }

        /// <summary>
        /// set the balance for the buyer
        /// </summary>
        /// <param name="mon"></param>
        /// <param name="rnd"></param>
        /// <returns></returns>
        public decimal SetMoney(ref decimal mon,  Random rnd)
		{
			mon = rnd.Next(200, 1000);
			labelBalance.Text = (money.ToString("c2"));
			return mon;
		}

		/// <summary>
		/// Event listener for the checkbox of price search
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckBoxPriceSearch_Click(object sender, EventArgs e)
		{
			if (checkBoxPriceSearch.Checked == true)
			{
				//Declare variables
				int minPrice;
				int maxPrice;
				string errorMessagePrice = "Price is missing or is not a number.";

				//Test and assign values
				if (textBoxMinPrice.Text != "" && textBoxMaxPrice.Text != "")
				{
					//next we need to parse all user inputs (textboxes) and store them in our created ints in the previous step
					if (int.TryParse(textBoxMinPrice.Text, out maxPrice) == false || int.TryParse(textBoxMaxPrice.Text, out minPrice) == false)
					{
						//always display result so that the tabe isn't empty
						MessageBox.Show(errorMessagePrice);
                        ResetControls();
                        ShowPostingItems();
					}
				}
				else
				{
					MessageBox.Show(errorMessagePrice);
					checkBoxPriceSearch.Checked = false;
					ShowPostingItems(); 
				}
			}
			else
			{
				// when the checkbox is unchecked, reset the Price Min & Max textbox
				textBoxMaxPrice.Clear();
				textBoxMinPrice.Clear();
			}
			ShowPostingItems();
		}

		/// <summary>
		/// Event listener for the form Load
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FormBuyWindow_Load(object sender, EventArgs e)
        {
           
            //initialize the listbox
            InitializeFormListbox();
            
            //reset the controls
            ResetControls();

            //set debug after classes are created
            context.Database.Log = (s => Debug.Write(s));
            context.SaveChanges();           
     
        }

		/// <summary>
		/// Event Listener for the purchase Item button listener
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void buttonPurchaseItem_Click(object sender, EventArgs e)
		{
			
			string enteredBuyerName;

            //enter the log 
            context.Database.Log = (s => Debug.Write(s));
            context.SaveChanges();

			//get user input
            enteredBuyerName = textBoxBuyerName.Text;

            //create variables to process the transaction
            string temporaryPrice = dataGridViewProductsForSale.SelectedRows[0].Cells[3].Value.ToString();
            decimal itemPrice = decimal.Parse(temporaryPrice, NumberStyles.AllowCurrencySymbol | NumberStyles.Number);
            string sellerId = dataGridViewProductsForSale.SelectedRows[0].Cells[5].Value.ToString();
            decimal newBalance = money - itemPrice;
            labelBalance.Text = newBalance.ToString("c2");

            //create buyer and enter the record in participants table
            Participant buyer = new Participant();
			buyer.Name = enteredBuyerName;
			buyer.Balance = money;
			context.Participants.Add(buyer);

			//create order and enter ItemId and ParticipantId
            Order orderedItem = new Order();
            orderedItem.ItemNum = Convert.ToInt32(dataGridViewProductsForSale.SelectedRows[0].Cells[0].Value);
			orderedItem.BuyerNum = buyer.ParticipantId;
			context.Orders.Add(orderedItem);

            //execute SQL to change the balance of the participants
            context.Database.ExecuteSqlCommand("Update Items SET  Status = 1 where ItemId = " + orderedItem.ItemNum);
            context.Database.ExecuteSqlCommand("Update Participants SET  Balance += "   
                                                + itemPrice.ToString() +" where ParticipantId = " + sellerId);

            //update the gridview, reset and assign a new balance
            SetMoney(ref money, rnd);
            ResetControls();
            context.SaveChanges();
			ShowPostingItems();
           
        }

		/// <summary>
		/// removes listeners and clears commands
		/// </summary>
        public void ResetControls()
        {
            //remove listeners
            checkBoxPriceSearch.Click -= CheckBoxPriceSearch_Click;
            listBoxCategories.SelectedIndexChanged -= ListBoxCategories_SelectedIndexChanged;


            //clear controls
            textBoxMaxPrice.Clear();
            textBoxMinPrice.Clear();
            textBoxProductName.Clear();
            textBoxBuyerName.Clear();
            textBoxSellerName.Clear();

            //reselect
            for (int i = 0; i < listBoxCategories.Items.Count; i++)
                listBoxCategories.SetSelected(i, true);

            //uncheck checkbox
            checkBoxPriceSearch.Checked = false;

            //display
            ShowPostingItems();

            //register event listeners again
            checkBoxPriceSearch.Click += CheckBoxPriceSearch_Click;
            listBoxCategories.SelectedIndexChanged += ListBoxCategories_SelectedIndexChanged;

        }

        /// <summary>
        /// Initializes all form controls
        /// </summary>
        public void InitializeFormListbox()
        {
            //clear the listbox
            listBoxCategories.Items.Clear();
            listBoxCategories.SelectionMode = SelectionMode.MultiExtended;


            //set options to the listbox
            listBoxCategories.Items.Add("Laptops");
            listBoxCategories.Items.Add("Toys");
            listBoxCategories.Items.Add("Phones");
            listBoxCategories.Items.Add("Electrodomestics");
            listBoxCategories.Items.Add("Services");
            listBoxCategories.Items.Add("Books");

            // set autosize for the columns of gridview
            dataGridViewProductsForSale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

		/// <summary>
		/// Event listener for the Search button. It will display the entries
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void buttonSearchItem_Click(object sender, EventArgs e)
        {

			context.Database.Log = (s => Debug.Write(s));
			context.SaveChanges();

			ShowPostingItems();

            context.SaveChanges();
        }

       
        public void ShowPostingItems()
        {
            //initialize the posting variables
            string enteredProductName = "";
            string enteredMinPrice;
            string enteredMaxPrice;
            string enteredSellerName = "";
			List<string> selectedCategories = new List<string>();

			//iterate through the items of the listbox and add the to the lists
			for (int i = 0; i < listBoxCategories.SelectedItems.Count; i++)
			    selectedCategories.Add(listBoxCategories.SelectedItems[i].ToString());

            //assing values to variables
            enteredProductName = textBoxProductName.Text;
            enteredMinPrice = textBoxMinPrice.Text;
            enteredMaxPrice = textBoxMaxPrice.Text;
            enteredSellerName = textBoxSellerName.Text;
            minPrice = 0;
            maxPrice = 0;
            bool priceSearch = checkBoxPriceSearch.Checked;
           

            //next we need to parse all user inputs (textboxes) and store them in our created ints in the previous step
            if (enteredMinPrice != "" || enteredMaxPrice != "")
            {
                if (decimal.TryParse(enteredMaxPrice, out maxPrice) == false || decimal.TryParse(enteredMinPrice, out minPrice) == false)
                {
                    checkBoxPriceSearch.Checked = false;
                    textBoxMinPrice.Clear();
                    textBoxMaxPrice.Clear();
                    return;
                }
				
            }

            //finally we develop a query that will return us every 
            var results = (from posting in context.Postings
                           from items in context.Items
                           from participants in context.Participants
                           where 
                           (posting.SellerNum == participants.ParticipantId && items.ItemId == posting.ItemNum && items.Status == 0)

						   where participants.Name.Contains(enteredSellerName) && selectedCategories.Contains(items.ItemCategory.ToString())
							 && posting.Item.ItemName.Contains(enteredProductName) where

                             ((priceSearch == true && items.ItemPrice >= minPrice
                           && items.ItemPrice < maxPrice) || priceSearch == false)

                           group items by new
                           {
                               items.ItemId,
                               items.ItemName,
                               items.ItemCategory,
                               items.ItemPrice,
                               participants.Name,
                               participants.ParticipantId
                           } into groupedProducts
                           select new UploadedProducts
                           {
                               ProductId = groupedProducts.Key.ItemId,
                               ProductName = groupedProducts.Key.ItemName,
                               Category = groupedProducts.Key.ItemCategory,
                               SellerName = groupedProducts.Key.Name,
                               SellerId = groupedProducts.Key.ParticipantId.ToString(),
                               Price = "$" + groupedProducts.Key.ItemPrice.ToString()
                           }).ToList();

            dataGridViewProductsForSale.DataSource = results;

            dataGridViewProductsForSale.Refresh();
            context.SaveChanges();
        }
        /// <summary>
        /// Create a new object to format all entries into the gridview
        /// </summary>
        private class UploadedProducts
		{
			[DisplayName("Product ID")]
			public int ProductId { get; set; }

			[DisplayName("Product Name")]
			public string ProductName { get; set; }

			[DisplayName("Product Category")]
			public string Category { get; set; }

			[DisplayName("Product Price")]
			public string Price { get; set; }

			[DisplayName("Sold by")]
			public string SellerName { get; set; }

            [DisplayName("Seller ID")]
            public string SellerId { get; set; }
        }

      

    }
}
