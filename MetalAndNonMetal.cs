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
    public partial class MetalAndNonMetal : MetroFramework.Forms.MetroForm
    {
        public MetalAndNonMetal()
        {
            InitializeComponent();
        }

        void setDAta(int x)
        {
            ElementsInfo ei = new ElementsInfo(x, 3);
            ei.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeMenu hm = new HomeMenu();
            hm.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setDAta(1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            setDAta(2);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            setDAta(3);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            setDAta(4);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            setDAta(5);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            setDAta(6);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            setDAta(7);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            setDAta(8);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            setDAta(9);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            setDAta(10);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            setDAta(11);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            setDAta(12);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            setDAta(13);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            setDAta(14);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            setDAta(15);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            setDAta(16);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            setDAta(17);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            setDAta(18);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            setDAta(19);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            setDAta(20);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            setDAta(31);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            setDAta(32);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            setDAta(33);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            setDAta(34);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            setDAta(35);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            setDAta(36);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            setDAta(37);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            setDAta(38);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            setDAta(49);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            setDAta(50);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            setDAta(51);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            setDAta(52);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            setDAta(53);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            setDAta(54);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            setDAta(55);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            setDAta(56);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            setDAta(81);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            setDAta(82);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            setDAta(83);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            setDAta(84);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            setDAta(85);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            setDAta(86);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            setDAta(87);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            setDAta(88);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShortCutTecnic sct = new ShortCutTecnic();
            sct.Show();
            Visible = false;
        }
    }
}
