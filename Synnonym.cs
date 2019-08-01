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
    public partial class Synnonym : MetroFramework.Forms.MetroForm
    {
        int x = 1;
        Bitmap[] bi = { Properties.Resources.sn_1, Properties.Resources.sn_2, Properties.Resources.sn_3, Properties.Resources.sn_4, Properties.Resources.sn_5, Properties.Resources.sn_6, Properties.Resources.sn_7, Properties.Resources.sn_8, Properties.Resources.sn_9, Properties.Resources.sn_10};
        public Synnonym()
        {
            InitializeComponent();
         //   for (int i)
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (x == 0)
                x = 9;
            x--;
            pictureBox1.Image = bi[x];
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (x == 9)
                x = -1;
            x++;
            pictureBox1.Image = bi[x];
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            HomeMenu hm = new HomeMenu();
            hm.Show();
            Visible = false;
        }

        private void Synnonym_Load(object sender, EventArgs e)
        {

        }
    }
}
