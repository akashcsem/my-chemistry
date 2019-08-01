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
    public partial class frmAndMe : Form
    {
        public frmAndMe()
        {
            InitializeComponent();
            myText.Text = "I would like to enjoy coding. This is very enoyable for developing new thing. Always I try to develop";
            myText.Text += " amazing games and software. I develop android app windows app and wonderful web designing. If you need ";
            myText.Text += "any kind of applicatin software and website please contact with me.";
            this.Opacity = 0;
            timer1.Start();
        }

       

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.05;
            }
            else
            {
                timer1.Stop();
            }
        }


        private void label10_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
