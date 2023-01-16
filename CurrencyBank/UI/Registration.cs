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
            User.Registration(this, Avtorization, loginRegTb.Text, passwordRegTb.Text).GetAwaiter();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Avtorization = new Avtorization();
            this.Close();
            Avtorization.Show();
        }
    }
}
