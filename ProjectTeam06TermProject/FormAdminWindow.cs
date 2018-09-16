using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTeam06TermProject.EF_Classes;
using System.Data.Entity;
using System.Diagnostics;

namespace ProjectTeam06TermProject
{
    public partial class FormAdminWindow : Form
    {
        //create instance of EF
        ECommerceEntities context;

        public FormAdminWindow()
        {
            InitializeComponent();

            //create instance of EF
            context = new ECommerceEntities();

            //Register event handlers
            this.Load += FormAdminWindow_Load;
            buttonBackupXML.Click += ButtonBackupXML_Click;
        }

        /// <summary>
        /// Function to back up the schema to an XML file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonBackupXML_Click(object sender, EventArgs e)
        {
            try
            {
                ECommerceDataSet myDataSet = new ECommerceDataSet();
                myDataSet.WriteXml("ECommerceDB.xml");
                myDataSet.WriteXmlSchema("ECommerceDBSchema.xsd");
                MessageBox.Show("Your Database has been backed up.");
            }
            catch
            {
                MessageBox.Show("There has been an error backing up your database. Please try again later");
            }
        }

        private void FormAdminWindow_Load(object sender, EventArgs e)
        {
            //set debug after window is loaded
            context.Database.Log = (s => Debug.Write(s));
            context.SaveChanges();

            //Display all the items on their gridviews and set the view to fill the space
            ShowPostingItems();
            dataGridViewProductsForSale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ShowOrderedItems();
            dataGridViewProductsSold.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            context.SaveChanges();
        }

        /// <summary>
        /// Makes a LINQ query that generater all the items on sale,
        /// together with the categories' stats
        /// </summary>
        /// 

        // This method shows information of Products for Sales
        // Gridview for products list
        // Average
        // Most Requested Category
        // Least Requested Category
        // Products for Most Posted Category
        public void ShowPostingItems()
        {
            // Gridview for products list that are posted by seller
            // Columns are ProductID, ProductName, ProductCategory, ProductPrice, Sold by(seller name)
            var results = (from posting in context.Postings
                           from items in context.Items
                           from participants in context.Participants
                           where posting.SellerNum == participants.ParticipantId
                                 && posting.ItemNum == items.ItemId
                                 && items.Status == 0
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

            // The number of products that are posted by seller
            var postingCnt = (from posting in context.Postings
                              from items in context.Items
                              where posting.ItemNum == items.ItemId
                                    && items.Status == 0
                              select posting.PostingId).Count();

            // Average price of all products that are posted by seller
            var averageForSales = from posting in context.Postings
                                  from items in context.Items
                                  where posting.ItemNum == items.ItemId
                                        && items.Status == 0
                                  select items.ItemPrice;

            // The name of category for most posted products by seller
            var mostCategory = from posting in context.Postings
                               from items in context.Items
                               where posting.ItemNum == items.ItemId
                                     && items.Status == 0
                               group items by items.ItemCategory into g
                               orderby g.Count() descending
                               select new
                               {
                                   name = g.Key,
                                   count = g.Count()
                               }.name;

            // The name of category for least posted products by seller
            var leastCategory = from posting in context.Postings
                                from items in context.Items
                                where posting.ItemNum == items.ItemId
                                      && items.Status == 0
                                group items by items.ItemCategory into g
                                orderby g.Count() ascending
                                select new
                                {
                                    name = g.Key,
                                    count = g.Count()
                                }.name;

            // fill the gridview and refresh it
            dataGridViewProductsForSale.DataSource = results;
            dataGridViewProductsForSale.Refresh();

            // fill the stats labels
            labelNumberProductsForSale.Text = postingCnt.ToString();
            labelAveragePriceforSalesProducts.Text = averageForSales.Average().ToString("c");
            labelMostCategory.Text = mostCategory.First().ToString();
            labelLeastCategory.Text = leastCategory.First().ToString();

            // the list of products for most posted category by seller
            ShowProductsForMostPostedCategory();
            context.SaveChanges();
        }

        /// <summary>
        /// Makes a LINQ query that generater all the ordered Items,
        /// together with the categories' stats
        /// </summary>
        /// 
        // This method shows information of Products Sold
        // Gridview for products list
        // Average
        // Most Requested Category
        // Least Requested Category
        // Products for Most ordered Category
        public void ShowOrderedItems()
        {
            // Gridview for products list that are ordered by buyer
            // Columns are OrderID, ProductName, ProductPrice, Buyer Name
            var results = (from orders in context.Orders
                           from items in context.Items
                           from participants in context.Participants
                           where orders.BuyerNum == participants.ParticipantId
                                 && orders.ItemNum == items.ItemId
                                 && items.Status == 1
                           group items by new
                           {
                               orders.OrderId,
                               items.ItemName,
                               items.ItemPrice,
                               items.ItemCategory,
                               participants.Name
                           } into groupedProducts
                           select new OrderedProducts
                           {
                               OrderId = groupedProducts.Key.OrderId,
                               ProductName = groupedProducts.Key.ItemName,
                               Category = groupedProducts.Key.ItemCategory,
                               BuyerName = groupedProducts.Key.Name,
                               Price = "$" + groupedProducts.Key.ItemPrice.ToString()
                           }).Distinct().ToList();

            // The number of products that are ordered by buyer
            var orderCnt = (from order in context.Orders
                            from items in context.Items
                            where order.ItemNum == items.ItemId
                                  && items.Status == 1
                            select order.OrderId).Count();

            // Average price of all products that are posted by buyer
            var averageForSales = from order in context.Orders
                                  from items in context.Items
                                  where order.ItemNum == items.ItemId
                                        && items.Status == 1
                                  select items.ItemPrice;

            // The name of category for most ordered products by buyer
            var mostOrderedCategory = from order in context.Orders
                                      from items in context.Items
                                      where order.ItemNum == items.ItemId
                                            && items.Status == 1
                                      group items by items.ItemCategory into g

                                      orderby g.Count() descending
                                      select new
                                      {
                                          name = g.Key,
                                          count = g.Count()
                                      }.name;

			decimal average = context.Postings.Where(p => p.Item.Status == 0)
							  .Select(i => i.Item.ItemPrice).Average();

			/*string mostCategory = context.Items.Where(i => i.Status == 0)
								.Select(p => p.ItemCategory).Min();*/

			var mostCategory = from postings in context.Postings
							   from postings2 in context.Postings
							   where postings.Item.Status == 0
							   && postings.Item.ItemCategory.Count() > postings2.Item.ItemCategory.Count()
							   select postings.Item.ItemCategory;
							   

			MessageBox.Show(average.ToString());
			MessageBox.Show(mostCategory.ToString());

			// The name of category for least ordered products by buyer
			var leastOrderedCategory = from order in context.Orders
                                       from items in context.Items
                                       where order.ItemNum == items.ItemId
                                             && items.Status == 1
                                       group items by items.ItemCategory into g
                                       orderby g.Count() ascending
                                       select new
                                       {
                                           name = g.Key,
                                           count = g.Count()
                                       }.name;

            //fill the gridview and refresh it
            dataGridViewProductsSold.DataSource = results;
            dataGridViewProductsSold.Refresh();

            //fill the stats labels
            labelNumberProductsSold.Text = orderCnt.ToString();
            labelAveragePriceOrderedProducts.Text = averageForSales.Average().ToString("c");
            labelMostOrderedCategory.Text = mostOrderedCategory.First().ToString();
            labelLeastOrderedCategory.Text = leastOrderedCategory.First().ToString();

            // the list of products for most ordered category by buyer
            ShowProducctsForMostOrderedCategory();
            context.SaveChanges();
        }

        // this method shows the listbox for the products list of most posted category by seller
        public void ShowProductsForMostPostedCategory()
        {
            listBoxSaleProductsPerCategory.MultiColumn = true;
            listBoxSaleProductsPerCategory.Items.Clear();
            listBoxSaleProductsPerCategory.SelectionMode = SelectionMode.MultiExtended;

            var productsPerCategory = from category in context.Items
                                      orderby category.ItemCategory
                                      where category.Status == 0
                                            && category.ItemCategory == labelMostCategory.Text
                                      select category.ItemName;

            listBoxSaleProductsPerCategory.Items.AddRange(productsPerCategory.ToArray());
        }

        // this method shows the listbox for the products list of most ordered category by buyer
        public void ShowProducctsForMostOrderedCategory()
        {
            listBoxOederedProductsPerCategory.MultiColumn = true;
            listBoxOederedProductsPerCategory.Items.Clear();
            listBoxOederedProductsPerCategory.SelectionMode = SelectionMode.MultiExtended;

            var productsPerCategory = from category in context.Items
                                      orderby category.ItemCategory
                                      where category.Status == 1
                                            && category.ItemCategory == labelMostOrderedCategory.Text
                                      select category.ItemName;

            listBoxOederedProductsPerCategory.Items.AddRange(productsPerCategory.ToArray());
        }

        /// <summary>
        /// Class to store all the queried Items on posted gridview
        /// </summary>
        /// 
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

        /// <summary>
        /// Class to store all the queried Items on ordered gridview
        /// </summary>
        /// 
        private class OrderedProducts
        {
            [DisplayName("Order ID")]
            public int OrderId { get; set; }

            [DisplayName("Product Name")]
            public string ProductName { get; set; }

            [DisplayName("Product Category")]
            public string Category { get; set; }

            [DisplayName("Product Price")]
            public string Price { get; set; }

            [DisplayName("Buyer")]
            public string BuyerName { get; set; }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
