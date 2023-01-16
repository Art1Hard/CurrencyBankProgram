using CurrencyBank.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyBank.UI
{
    public partial class Avtorization : Form
    {
        public Avtorization()
        {
            CenterToScreen();
            InitializeComponent();
        }

        private void SignBtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            User.Avtorization(this, form, LoginSignTb.Text, PasswordSignTb.Text).GetAwaiter();
        }

        private void Avtorization_Load(object sender, EventArgs e)
        {
            RegL.Cursor = Cursors.Hand;
        }

        private void RegL_MouseMove(object sender, MouseEventArgs e)
        {
            RegL.ForeColor = Color.Blue;
        }

        private void RegL_MouseLeave(object sender, EventArgs e)
        {
            RegL.ForeColor = Color.Black;
        }

        private void RegL_MouseClick(object sender, MouseEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }
    }
}
