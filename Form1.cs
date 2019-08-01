using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeriodicTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //int x = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            splush.Width += 5;
            int x = Convert.ToInt32( splush.Width/5);
            if (x > 100)
                x = 100;
            if (x%2 == 0)
                loadingLevel.Text = "Loading....." +  (x.ToString() + " %");
            

            if (splush.Width >= 550)
            {
                timer1.Stop();
                HomeMenu mt = new HomeMenu();
                mt.Show();
                this.Hide();
            }
        }
    }
}
