namespace ProjectTeam06TermProject
{
    partial class FormAdminWindow
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
            this.labelForSaleText = new System.Windows.Forms.Label();
            this.labelProductSoldText = new System.Windows.Forms.Label();
            this.labelNumberProductsForSale = new System.Windows.Forms.Label();
            this.labelNumberProductsSold = new System.Windows.Forms.Label();
            this.buttonBackupXML = new System.Windows.Forms.Button();
            this.labelSellerNameText = new System.Windows.Forms.Label();
            this.dataGridViewProductsSold = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelAveragePriceforSalesProducts = new System.Windows.Forms.Label();
            this.labelMostCategory = new System.Windows.Forms.Label();
            this.labelAveragePriceOrderedProducts = new System.Windows.Forms.Label();
            this.labelMostOrderedCategory = new System.Windows.Forms.Label();
            this.labelLeastCategory = new System.Windows.Forms.Label();
            this.labelLeastOrderedCategory = new System.Windows.Forms.Label();
            this.listBoxSaleProductsPerCategory = new System.Windows.Forms.ListBox();
            this.listBoxOederedProductsPerCategory = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductsForSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductsSold)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductsForSale
            // 
            this.dataGridViewProductsForSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductsForSale.Location = new System.Drawing.Point(12, 32);
            this.dataGridViewProductsForSale.Name = "dataGridViewProductsForSale";
            this.dataGridViewProductsForSale.Size = new System.Drawing.Size(424, 150);
            this.dataGridViewProductsForSale.TabIndex = 0;
            // 
            // labelForSaleText
            // 
            this.labelForSaleText.AutoSize = true;
            this.labelForSaleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForSaleText.Location = new System.Drawing.Point(12, 9);
            this.labelForSaleText.Name = "labelForSaleText";
            this.labelForSaleText.Size = new System.Drawing.Size(139, 20);
            this.labelForSaleText.TabIndex = 2;
            this.labelForSaleText.Text = "Products for Sale: ";
            // 
            // labelProductSoldText
            // 
            this.labelProductSoldText.AutoSize = true;
            this.labelProductSoldText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductSoldText.Location = new System.Drawing.Point(456, 9);
            this.labelProductSoldText.Name = "labelProductSoldText";
            this.labelProductSoldText.Size = new System.Drawing.Size(116, 20);
            this.labelProductSoldText.TabIndex = 3;
            this.labelProductSoldText.Text = "Products Sold: ";
            // 
            // labelNumberProductsForSale
            // 
            this.labelNumberProductsForSale.AutoSize = true;
            this.labelNumberProductsForSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberProductsForSale.Location = new System.Drawing.Point(147, 9);
            this.labelNumberProductsForSale.Name = "labelNumberProductsForSale";
            this.labelNumberProductsForSale.Size = new System.Drawing.Size(65, 20);
            this.labelNumberProductsForSale.TabIndex = 4;
            this.labelNumberProductsForSale.Text = "Number";
            // 
            // labelNumberProductsSold
            // 
            this.labelNumberProductsSold.AutoSize = true;
            this.labelNumberProductsSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberProductsSold.Location = new System.Drawing.Point(578, 9);
            this.labelNumberProductsSold.Name = "labelNumberProductsSold";
            this.labelNumberProductsSold.Size = new System.Drawing.Size(65, 20);
            this.labelNumberProductsSold.TabIndex = 5;
            this.labelNumberProductsSold.Text = "Number";
            // 
            // buttonBackupXML
            // 
            this.buttonBackupXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackupXML.Location = new System.Drawing.Point(572, 406);
            this.buttonBackupXML.Name = "buttonBackupXML";
            this.buttonBackupXML.Size = new System.Drawing.Size(153, 28);
            this.buttonBackupXML.TabIndex = 6;
            this.buttonBackupXML.Text = "Backup Database";
            this.buttonBackupXML.UseVisualStyleBackColor = true;
            // 
            // labelSellerNameText
            // 
            this.labelSellerNameText.AutoSize = true;
            this.labelSellerNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSellerNameText.Location = new System.Drawing.Point(12, 198);
            this.labelSellerNameText.Name = "labelSellerNameText";
            this.labelSellerNameText.Size = new System.Drawing.Size(111, 20);
            this.labelSellerNameText.TabIndex = 37;
            this.labelSellerNameText.Text = "Average Price:";
            // 
            // dataGridViewProductsSold
            // 
            this.dataGridViewProductsSold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductsSold.Location = new System.Drawing.Point(460, 32);
            this.dataGridViewProductsSold.Name = "dataGridViewProductsSold";
            this.dataGridViewProductsSold.Size = new System.Drawing.Size(424, 150);
            this.dataGridViewProductsSold.TabIndex = 40;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(731, 406);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(153, 28);
            this.buttonExit.TabIndex = 43;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Products for Most Posted Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Least Requested Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Most Requested Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Most Requested Category:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(456, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Least Requested Category:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(456, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Products for Most Ordered Category:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(456, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Average Price:";
            // 
            // labelAveragePriceforSalesProducts
            // 
            this.labelAveragePriceforSalesProducts.AutoSize = true;
            this.labelAveragePriceforSalesProducts.Location = new System.Drawing.Point(115, 204);
            this.labelAveragePriceforSalesProducts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAveragePriceforSalesProducts.Name = "labelAveragePriceforSalesProducts";
            this.labelAveragePriceforSalesProducts.Size = new System.Drawing.Size(13, 13);
            this.labelAveragePriceforSalesProducts.TabIndex = 53;
            this.labelAveragePriceforSalesProducts.Text = "0";
            // 
            // labelMostCategory
            // 
            this.labelMostCategory.AutoSize = true;
            this.labelMostCategory.Location = new System.Drawing.Point(221, 225);
            this.labelMostCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMostCategory.Name = "labelMostCategory";
            this.labelMostCategory.Size = new System.Drawing.Size(75, 13);
            this.labelMostCategory.TabIndex = 54;
            this.labelMostCategory.Text = "Most Category";
            // 
            // labelAveragePriceOrderedProducts
            // 
            this.labelAveragePriceOrderedProducts.AutoSize = true;
            this.labelAveragePriceOrderedProducts.Location = new System.Drawing.Point(560, 204);
            this.labelAveragePriceOrderedProducts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAveragePriceOrderedProducts.Name = "labelAveragePriceOrderedProducts";
            this.labelAveragePriceOrderedProducts.Size = new System.Drawing.Size(13, 13);
            this.labelAveragePriceOrderedProducts.TabIndex = 55;
            this.labelAveragePriceOrderedProducts.Text = "0";
            // 
            // labelMostOrderedCategory
            // 
            this.labelMostOrderedCategory.AutoSize = true;
            this.labelMostOrderedCategory.Location = new System.Drawing.Point(665, 225);
            this.labelMostOrderedCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMostOrderedCategory.Name = "labelMostOrderedCategory";
            this.labelMostOrderedCategory.Size = new System.Drawing.Size(75, 13);
            this.labelMostOrderedCategory.TabIndex = 56;
            this.labelMostOrderedCategory.Text = "Most Category";
            // 
            // labelLeastCategory
            // 
            this.labelLeastCategory.AutoSize = true;
            this.labelLeastCategory.Location = new System.Drawing.Point(221, 247);
            this.labelLeastCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLeastCategory.Name = "labelLeastCategory";
            this.labelLeastCategory.Size = new System.Drawing.Size(78, 13);
            this.labelLeastCategory.TabIndex = 57;
            this.labelLeastCategory.Text = "Least Category";
            // 
            // labelLeastOrderedCategory
            // 
            this.labelLeastOrderedCategory.AutoSize = true;
            this.labelLeastOrderedCategory.Location = new System.Drawing.Point(665, 247);
            this.labelLeastOrderedCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLeastOrderedCategory.Name = "labelLeastOrderedCategory";
            this.labelLeastOrderedCategory.Size = new System.Drawing.Size(78, 13);
            this.labelLeastOrderedCategory.TabIndex = 58;
            this.labelLeastOrderedCategory.Text = "Least Category";
            // 
            // listBoxSaleProductsPerCategory
            // 
            this.listBoxSaleProductsPerCategory.FormattingEnabled = true;
            this.listBoxSaleProductsPerCategory.Location = new System.Drawing.Point(286, 263);
            this.listBoxSaleProductsPerCategory.Name = "listBoxSaleProductsPerCategory";
            this.listBoxSaleProductsPerCategory.Size = new System.Drawing.Size(120, 95);
            this.listBoxSaleProductsPerCategory.TabIndex = 61;
            // 
            // listBoxOederedProductsPerCategory
            // 
            this.listBoxOederedProductsPerCategory.FormattingEnabled = true;
            this.listBoxOederedProductsPerCategory.Location = new System.Drawing.Point(731, 263);
            this.listBoxOederedProductsPerCategory.Name = "listBoxOederedProductsPerCategory";
            this.listBoxOederedProductsPerCategory.Size = new System.Drawing.Size(120, 95);
            this.listBoxOederedProductsPerCategory.TabIndex = 62;
            // 
            // FormAdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 443);
            this.Controls.Add(this.listBoxOederedProductsPerCategory);
            this.Controls.Add(this.listBoxSaleProductsPerCategory);
            this.Controls.Add(this.labelLeastOrderedCategory);
            this.Controls.Add(this.labelLeastCategory);
            this.Controls.Add(this.labelMostOrderedCategory);
            this.Controls.Add(this.labelAveragePriceOrderedProducts);
            this.Controls.Add(this.labelMostCategory);
            this.Controls.Add(this.labelAveragePriceforSalesProducts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dataGridViewProductsSold);
            this.Controls.Add(this.labelSellerNameText);
            this.Controls.Add(this.buttonBackupXML);
            this.Controls.Add(this.labelNumberProductsSold);
            this.Controls.Add(this.labelNumberProductsForSale);
            this.Controls.Add(this.labelProductSoldText);
            this.Controls.Add(this.labelForSaleText);
            this.Controls.Add(this.dataGridViewProductsForSale);
            this.Name = "FormAdminWindow";
            this.Text = "FormAdminWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductsForSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductsSold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProductsForSale;
        private System.Windows.Forms.Label labelForSaleText;
        private System.Windows.Forms.Label labelProductSoldText;
        private System.Windows.Forms.Label labelNumberProductsForSale;
        private System.Windows.Forms.Label labelNumberProductsSold;
        private System.Windows.Forms.Button buttonBackupXML;
        private System.Windows.Forms.Label labelSellerNameText;
        private System.Windows.Forms.DataGridView dataGridViewProductsSold;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelAveragePriceforSalesProducts;
        private System.Windows.Forms.Label labelMostCategory;
        private System.Windows.Forms.Label labelAveragePriceOrderedProducts;
        private System.Windows.Forms.Label labelMostOrderedCategory;
        private System.Windows.Forms.Label labelLeastCategory;
        private System.Windows.Forms.Label labelLeastOrderedCategory;
        private System.Windows.Forms.ListBox listBoxSaleProductsPerCategory;
        private System.Windows.Forms.ListBox listBoxOederedProductsPerCategory;
    }
}