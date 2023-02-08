using CurrencyBank.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyBank.UI
{
    public partial class CourseVal : Form
    {
        public CourseVal()
        {
            InitializeComponent();
            Valuta.Show(valutaDgw);
        }

        private void CourseVal_Load(object sender, EventArgs e)
        {
            Valuta.Parse();
        }
    }
}
