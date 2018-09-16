namespace ProjectTeam06TermProject
{
    partial class FormBuyWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.dataGridViewProductsForSale = new System.Windows.Forms.DataGridView();
			this.labelItemIDText = new System.Windows.Forms.Label();
			this.buttonPurchaseItem = new System.Windows.Forms.Button();
			this.labelBuyerNameText = new System.Windows.Forms.Label();
			this.textBoxProductName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxMaxPrice = new System.Windows.Forms.TextBox();
			this.textBoxMinPrice = new System.Windows.Forms.TextBox();
			this.checkBoxPriceSearch = new System.Windows.Forms.CheckBox();
			this.listBoxCategories = new System.Windows.Forms.ListBox();
			this.buttonSearchItem = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.labelBalance = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxSellerName = new System.Windows.Forms.TextBox();
			this.textBoxBuyerName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductsForSale)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewProductsForSale
			// 
			this.dataGridViewProductsForSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProductsForSale.Location = new System.Drawing.Point(17, 16);
			this.dataGridViewProductsForSale.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.dataGridViewProductsForSale.Name = "dataGridViewProductsForSale";
			this.dataGridViewProductsForSale.Size = new System.Drawing.Size(908, 290);
			this.dataGridViewProductsForSale.TabIndex = 0;
			// 
			// labelItemIDText
			// 
			this.labelItemIDText.AutoSize = true;
			this.labelItemIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelItemIDText.Location = new System.Drawing.Point(16, 327);
			this.labelItemIDText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelItemIDText.Name = "labelItemIDText";
			this.labelItemIDText.Size = new System.Drawing.Size(105, 25);
			this.labelItemIDText.TabIndex = 1;
			this.labelItemIDText.Text = "Max Price:";
			// 
			// buttonPurchaseItem
			// 
			this.buttonPurchaseItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPurchaseItem.Location = new System.Drawing.Point(749, 446);
			this.buttonPurchaseItem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.buttonPurchaseItem.Name = "buttonPurchaseItem";
			this.buttonPurchaseItem.Size = new System.Drawing.Size(177, 39);
			this.buttonPurchaseItem.TabIndex = 11;
			this.buttonPurchaseItem.Text = "Purchase Item";
			this.buttonPurchaseItem.UseVisualStyleBackColor = true;
			// 
			// labelBuyerNameText
			// 
			this.labelBuyerNameText.AutoSize = true;
			this.labelBuyerNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelBuyerNameText.Location = new System.Drawing.Point(584, 325);
			this.labelBuyerNameText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelBuyerNameText.Name = "labelBuyerNameText";
			this.labelBuyerNameText.Size = new System.Drawing.Size(147, 25);
			this.labelBuyerNameText.TabIndex = 31;
			this.labelBuyerNameText.Text = "Product Name: ";
			// 
			// textBoxProductName
			// 
			this.textBoxProductName.Location = new System.Drawing.Point(792, 327);
			this.textBoxProductName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.textBoxProductName.Name = "textBoxProductName";
			this.textBoxProductName.Size = new System.Drawing.Size(132, 22);
			this.textBoxProductName.TabIndex = 30;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 352);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 25);
			this.label1.TabIndex = 32;
			this.label1.Text = "Min Price:";
			// 
			// textBoxMaxPrice
			// 
			this.textBoxMaxPrice.Location = new System.Drawing.Point(133, 326);
			this.textBoxMaxPrice.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.textBoxMaxPrice.Name = "textBoxMaxPrice";
			this.textBoxMaxPrice.Size = new System.Drawing.Size(132, 22);
			this.textBoxMaxPrice.TabIndex = 33;
			// 
			// textBoxMinPrice
			// 
			this.textBoxMinPrice.Location = new System.Drawing.Point(133, 354);
			this.textBoxMinPrice.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.textBoxMinPrice.Name = "textBoxMinPrice";
			this.textBoxMinPrice.Size = new System.Drawing.Size(132, 22);
			this.textBoxMinPrice.TabIndex = 34;
			// 
			// checkBoxPriceSearch
			// 
			this.checkBoxPriceSearch.AutoSize = true;
			this.checkBoxPriceSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBoxPriceSearch.Location = new System.Drawing.Point(21, 401);
			this.checkBoxPriceSearch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.checkBoxPriceSearch.Name = "checkBoxPriceSearch";
			this.checkBoxPriceSearch.Size = new System.Drawing.Size(174, 29);
			this.checkBoxPriceSearch.TabIndex = 35;
			this.checkBoxPriceSearch.Text = "Lookup by Price";
			this.checkBoxPriceSearch.UseVisualStyleBackColor = true;
			// 
			// listBoxCategories
			// 
			this.listBoxCategories.FormattingEnabled = true;
			this.listBoxCategories.ItemHeight = 16;
			this.listBoxCategories.Location = new System.Drawing.Point(396, 327);
			this.listBoxCategories.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.listBoxCategories.Name = "listBoxCategories";
			this.listBoxCategories.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listBoxCategories.Size = new System.Drawing.Size(159, 116);
			this.listBoxCategories.TabIndex = 36;
			// 
			// buttonSearchItem
			// 
			this.buttonSearchItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSearchItem.Location = new System.Drawing.Point(564, 446);
			this.buttonSearchItem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.buttonSearchItem.Name = "buttonSearchItem";
			this.buttonSearchItem.Size = new System.Drawing.Size(177, 39);
			this.buttonSearchItem.TabIndex = 37;
			this.buttonSearchItem.Text = "Search For Item";
			this.buttonSearchItem.UseVisualStyleBackColor = true;
			this.buttonSearchItem.Click += new System.EventHandler(this.buttonSearchItem_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(285, 326);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 25);
			this.label2.TabIndex = 38;
			this.label2.Text = "Category:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(584, 361);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(125, 25);
			this.label3.TabIndex = 41;
			this.label3.Text = "Seller Name:";
			// 
			// labelBalance
			// 
			this.labelBalance.Location = new System.Drawing.Point(172, 446);
			this.labelBalance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.labelBalance.Name = "labelBalance";
			this.labelBalance.ReadOnly = true;
			this.labelBalance.Size = new System.Drawing.Size(132, 22);
			this.labelBalance.TabIndex = 48;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(20, 442);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(145, 25);
			this.label4.TabIndex = 47;
			this.label4.Text = "Buyer Balance:";
			// 
			// textBoxSellerName
			// 
			this.textBoxSellerName.Location = new System.Drawing.Point(792, 363);
			this.textBoxSellerName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.textBoxSellerName.Name = "textBoxSellerName";
			this.textBoxSellerName.Size = new System.Drawing.Size(132, 22);
			this.textBoxSellerName.TabIndex = 49;
			// 
			// textBoxBuyerName
			// 
			this.textBoxBuyerName.Location = new System.Drawing.Point(792, 405);
			this.textBoxBuyerName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.textBoxBuyerName.Name = "textBoxBuyerName";
			this.textBoxBuyerName.Size = new System.Drawing.Size(132, 22);
			this.textBoxBuyerName.TabIndex = 51;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(584, 402);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(126, 25);
			this.label5.TabIndex = 50;
			this.label5.Text = "Buyer Name:";
			// 
			// FormBuyWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(943, 498);
			this.Controls.Add(this.textBoxBuyerName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxSellerName);
			this.Controls.Add(this.labelBalance);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonSearchItem);
			this.Controls.Add(this.listBoxCategories);
			this.Controls.Add(this.checkBoxPriceSearch);
			this.Controls.Add(this.textBoxMinPrice);
			this.Controls.Add(this.textBoxMaxPrice);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelBuyerNameText);
			this.Controls.Add(this.textBoxProductName);
			this.Controls.Add(this.buttonPurchaseItem);
			this.Controls.Add(this.labelItemIDText);
			this.Controls.Add(this.dataGridViewProductsForSale);
			this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.Name = "FormBuyWindow";
			this.Text = "FormBuyWindow";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductsForSale)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProductsForSale;
        private System.Windows.Forms.Label labelItemIDText;
        private System.Windows.Forms.Button buttonPurchaseItem;
        private System.Windows.Forms.Label labelBuyerNameText;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaxPrice;
        private System.Windows.Forms.TextBox textBoxMinPrice;
        private System.Windows.Forms.CheckBox checkBoxPriceSearch;
        private System.Windows.Forms.ListBox listBoxCategories;
        private System.Windows.Forms.Button buttonSearchItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox labelBalance;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSellerName;
        private System.Windows.Forms.TextBox textBoxBuyerName;
        private System.Windows.Forms.Label label5;
    }
}