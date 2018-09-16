namespace ProjectTeam06TermProject
{
    partial class FormFirstPrompt
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
            this.buttonBuyWindow = new System.Windows.Forms.Button();
            this.buttonSellWindow = new System.Windows.Forms.Button();
            this.buttonAdminWindow = new System.Windows.Forms.Button();
            this.labelDefaultPromptQuestion = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBuyWindow
            // 
            this.buttonBuyWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuyWindow.Location = new System.Drawing.Point(15, 57);
            this.buttonBuyWindow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonBuyWindow.Name = "buttonBuyWindow";
            this.buttonBuyWindow.Size = new System.Drawing.Size(155, 32);
            this.buttonBuyWindow.TabIndex = 0;
            this.buttonBuyWindow.Text = "Buy";
            this.buttonBuyWindow.UseVisualStyleBackColor = true;
            this.buttonBuyWindow.Click += new System.EventHandler(this.buttonBuyWindow_Click);
            // 
            // buttonSellWindow
            // 
            this.buttonSellWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSellWindow.Location = new System.Drawing.Point(177, 57);
            this.buttonSellWindow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSellWindow.Name = "buttonSellWindow";
            this.buttonSellWindow.Size = new System.Drawing.Size(153, 32);
            this.buttonSellWindow.TabIndex = 1;
            this.buttonSellWindow.Text = "Sell";
            this.buttonSellWindow.UseVisualStyleBackColor = true;
            // 
            // buttonAdminWindow
            // 
            this.buttonAdminWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdminWindow.Location = new System.Drawing.Point(15, 96);
            this.buttonAdminWindow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAdminWindow.Name = "buttonAdminWindow";
            this.buttonAdminWindow.Size = new System.Drawing.Size(155, 32);
            this.buttonAdminWindow.TabIndex = 2;
            this.buttonAdminWindow.Text = "Administrator";
            this.buttonAdminWindow.UseVisualStyleBackColor = true;
            this.buttonAdminWindow.Click += new System.EventHandler(this.buttonAdminWindow_Click);
            // 
            // labelDefaultPromptQuestion
            // 
            this.labelDefaultPromptQuestion.AutoSize = true;
            this.labelDefaultPromptQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDefaultPromptQuestion.Location = new System.Drawing.Point(44, 16);
            this.labelDefaultPromptQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDefaultPromptQuestion.Name = "labelDefaultPromptQuestion";
            this.labelDefaultPromptQuestion.Size = new System.Drawing.Size(245, 25);
            this.labelDefaultPromptQuestion.TabIndex = 3;
            this.labelDefaultPromptQuestion.Text = "What would you like to do?";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(177, 96);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(155, 32);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormFirstPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 147);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelDefaultPromptQuestion);
            this.Controls.Add(this.buttonAdminWindow);
            this.Controls.Add(this.buttonSellWindow);
            this.Controls.Add(this.buttonBuyWindow);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormFirstPrompt";
            this.Text = "ProjectTeam06TermProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuyWindow;
        private System.Windows.Forms.Button buttonSellWindow;
        private System.Windows.Forms.Button buttonAdminWindow;
        private System.Windows.Forms.Label labelDefaultPromptQuestion;
        private System.Windows.Forms.Button buttonExit;
    }
}

