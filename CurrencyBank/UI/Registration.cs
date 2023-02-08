using CurrencyBank.Logic;
using System;
using System.Windows.Forms;

namespace CurrencyBank.UI
{
    public partial class Registration : Form
    {
        Avtorization Avtorization;
        public Registration()
        {
            CenterToScreen();
            InitializeComponent();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            Avtorization = new Avtorization();
            User.Registration(this, Avtorization, loginRegTb.Text, passwordRegTb.Text);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Avtorization = new Avtorization();
            this.Close();
            Avtorization.Show();
        }

        private void visiblePasswordCB_CheckedChanged(object sender, EventArgs e)
        {
            Password.VisiblePassword(visiblePasswordCB, passwordRegTb);
        }
    }
}
