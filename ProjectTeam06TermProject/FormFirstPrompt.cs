using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTeam06TermProject
{
    public partial class FormFirstPrompt : Form
    {
        public FormFirstPrompt()
        {
            InitializeComponent();
			buttonSellWindow.Click += ButtonSellWindow_Click;
		}

		private void ButtonSellWindow_Click(object sender, EventArgs e)
		{
			FormSellWindow formSellWindow = new FormSellWindow();
			formSellWindow.Show();
		}

		private void buttonBuyWindow_Click(object sender, EventArgs e)
		{
			FormBuyWindow formBuyWindow = new FormBuyWindow();
			formBuyWindow.Show();
		}

        private void buttonAdminWindow_Click(object sender, EventArgs e)
        {
            FormAdminWindow formAdminWindow = new FormAdminWindow();
            formAdminWindow.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                System.Environment.Exit(1);
            }
        }
    }
}
