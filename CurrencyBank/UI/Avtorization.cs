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
            CourseVal form = new CourseVal();
            User.Avtorization(this, form, LoginSignTb.Text, passwordSignTb.Text);
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

        private void visiblePasswordCB_CheckedChanged(object sender, EventArgs e)
        {
            Password.VisiblePassword(visiblePasswordCB, passwordSignTb);
        }
    }
}
