using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyBank.Logic
{
    internal class Password
    {
        public static void VisiblePassword(CheckBox visiblePassword, TextBox password)
        {
            if (!visiblePassword.Checked)
                password.PasswordChar = '*';
            else
                password.PasswordChar = '\0';
        }
    }
}
