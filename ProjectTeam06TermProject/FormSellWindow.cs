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
using System.Data.SqlClient;


namespace ProjectTeam06TermProject
{
	public partial class FormSellWindow : Form
	{
        //initialize objects and user balance variables
		ECommerceEntities context;
		Random rnd = new Random();
		decimal money = 0;

		public FormSellWindow()
		{
			InitializeComponent();

			//set balance to the label
			SetMoney(ref money, rnd);

			//create instance of EF
			context = new ECommerceEntities();

			//Register event handlers
			this.Load += FormSellWindow_Load;
			buttonSellItem.Click += ButtonSellItem_Click;
		}

		/// <summary>
		/// set the balance for the buyer
		/// </summary>
		/// <param name="mon"></param>
		/// <param name="rnd"></param>
		/// <returns></returns>
		public decimal SetMoney(ref decimal mon, Random rnd)
		{
			mon = rnd.Next(200, 1000);
			labelBalance.Text = (money.ToString("c2"));
			return mon;
		}

        /// <summary>
        /// Sets the behaviors for the form once it loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void FormSellWindow_Load(object sender, EventArgs e)
		{
            //reset the controls
            ResetControls();

            //initialize the controls
            InitializeFormControls();

            //set debug log
            context.Database.Log = (s => Debug.Write(s));
			context.SaveChanges();
           
		}

		private void ButtonSellItem_Click(object sender, EventArgs e)
		{
            //set log
			context.Database.Log = (s => Debug.Write(s));
			context.SaveChanges();

			try
			{
				//validate all entries
				ValidateCommands();

				//create variables to store in the tables
				decimal enteredProductPrice;
				string enteredProductName = textBoxProductName.Text;
				string enteredProductCategory = listBoxCategories.SelectedItem.ToString();
				string enteredSellerName = textBoxSellerName.Text;

				//create instance of item object
				Item enteredItem = new Item();

				//enter variables
				enteredItem.ItemName = enteredProductName;
				enteredItem.ItemCategory = enteredProductCategory;
				enteredItem.Status = 0;

				//parse numeric input
				if (decimal.TryParse(textBoxItemPrice.Text, out enteredProductPrice) == true)
				{
					enteredItem.ItemPrice = enteredProductPrice;
				}
				else
				{
					MessageBox.Show("check your input");
					return;
				}

				//create instance of Participant object
				Participant seller = new Participant();

				//set values to the Participant object
				seller.Name = enteredSellerName;
				seller.Balance = money;

				//enter all objects in the database
				context.Items.Add(enteredItem);
				context.Participants.Add(seller);

				//reset the controls and save changes
				ResetControls();
				context.SaveChanges();

				//enter both seller and participant Id into the Postings table
				Posting posting = new Posting();
				{
					posting.ItemNum = enteredItem.ItemId;
					posting.SellerNum = seller.ParticipantId;
				};

				context.Postings.Add(posting);

                //set a new the balance
                SetMoney(ref money, rnd);
            }
			catch (Exception)
			{
				MessageBox.Show("Make sure all inputs are entered befor you post your item.");
			}

			context.SaveChanges();
            ResetControls();
		}

		/// <summary>
		/// Query all new entries into the gridview
		/// </summary>
		public void UpdateEntries()
		{
			var results = (from posting in context.Postings
						   from items in context.Items
						   from participants in context.Participants
						   where posting.SellerNum == participants.ParticipantId && items.ItemId == posting.ItemNum
						   group items by new
						   {
							   items.ItemId,
							   items.ItemName,
							   items.ItemCategory,
							   items.ItemPrice,
							   participants.Name
						   } into groupedProducts
						   select new UploadedProducts
						   {
							   ProductId = groupedProducts.Key.ItemId,
							   ProductName = groupedProducts.Key.ItemName,
							   Category = groupedProducts.Key.ItemCategory,
							   SellerName = groupedProducts.Key.Name,
							   Price = "$" + groupedProducts.Key.ItemPrice.ToString()
						   }).ToList();

			dataGridViewProductsForSale.DataSource = results;

			dataGridViewProductsForSale.Refresh();
			context.SaveChanges();
		}

		/// <summary>
		/// Reset all commands
		/// </summary>
		public void ResetControls()
		{
            //clear textboxes
			textBoxItemPrice.Clear();
			textBoxSellerName.Clear();
			textBoxProductName.Clear();

            //unselect listbox items
			for (int i = 0; i < listBoxCategories.Items.Count; i++)
				listBoxCategories.SetSelected(i, false);

            //display entries
            UpdateEntries();
		}

        /// <summary>
        /// Initializes the lisbox of the form and the gridview
        /// </summary>
        public void InitializeFormControls()
        {
            //clear the listbox
            listBoxCategories.Items.Clear();
            listBoxCategories.SelectionMode = SelectionMode.One;


            //set options to the listbox
            listBoxCategories.Items.Add("Laptops");
            listBoxCategories.Items.Add("Toys");
            listBoxCategories.Items.Add("Phones");
            listBoxCategories.Items.Add("Electrodomestics");
            listBoxCategories.Items.Add("Services");
            listBoxCategories.Items.Add("Books");

            //set gridview sizemode to fill
            dataGridViewProductsForSale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            context.SaveChanges();

        }

        /// <summary>
        /// Validate all inputs before all entering them
        /// </summary>
        public void ValidateCommands()
		{
			string errorPrice = "The field 'Price' cannot be empty";
			string errorSeller = "The field 'Seller Name' cannot be empty";
			string errorItemName = "The field 'Product Name' cannot be empty";
			string errorCategory = "You must enter a category";

			if (textBoxItemPrice.Text == "")
			{
				MessageBox.Show(errorPrice);
				return;
			}
			if (textBoxProductName.Text == "")
			{
				MessageBox.Show(errorItemName);
				return;
			}
			if (textBoxSellerName.Text == "")
			{
				MessageBox.Show(errorSeller);
				return;
			}
			if (listBoxCategories.SelectedItem.ToString() == null)
			{
				MessageBox.Show(errorCategory);
				return;
			}
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
		}
	}
}
