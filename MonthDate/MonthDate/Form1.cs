using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthDate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        TimeSpan period = monCal.SelectionEnd
                - monCal.SelectionStart;


            if (period.Days < 1)
            {
                MessageBox.Show("Niste odabrali datum ",
                "GREŠKA",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information) ;
            }
            else
            {
                MessageBox.Show("Rezervirali ste "
                    + monCal.SelectionStart.ToShortDateString
                    + " od "
                    + monCal.SelectionEnd.ToShortDateString
                    + ".",
                    "rezervacija",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
