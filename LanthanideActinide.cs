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
    public partial class LanthanideActinide : MetroFramework.Forms.MetroForm
    {
        int panel = 1;
        public LanthanideActinide()
        {
            InitializeComponent();
        }

        public LanthanideActinide(int panel)
        {
            this.panel = panel;
            InitializeComponent();
            setPanel(panel);
        }

        void setPanel(int panel)
        {
            if (panel == 2)
            {
                panel3.Hide();
                panel2.Show();
                panel2.Dock = DockStyle.Fill;
                this.Text = "ল্যান্থানাইড";
                btn_switch.Text = "Actinide";
                pictureBox1.Image = Properties.Resources.lanthanide;
            }
            if (panel == 3)
            {
                panel2.Hide();
                panel3.Show();
                panel3.Dock = DockStyle.Fill;
                this.Text = "অ্যাক্টিনাইড";
                btn_switch.Text = "Lanthanide";
                pictureBox1.Image = Properties.Resources.actinide;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MainTable mt = new MainTable();
            mt.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomeMenu hm = new HomeMenu();
            hm.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_switch_Click(object sender, EventArgs e)
        {
            if (panel == 2)
            {

                Visible = false;
                LanthanideActinide la = new LanthanideActinide(3);
                la.Show();
            } else
            {
                Visible = false;
                LanthanideActinide la = new LanthanideActinide(2);
                la.Show(); 
            }
        }

        void setDAta(int x)
        {
            ElementsInfo ei = new ElementsInfo(x, 2);
            ei.Show();
            Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            setDAta(57);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            setDAta(57);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            setDAta(58);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            setDAta(58);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            setDAta(59);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            setDAta(59);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            setDAta(60);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            setDAta(60);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            setDAta(61);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            setDAta(61);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            setDAta(62);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            setDAta(62);
        }

        private void label14_Click(object sender, EventArgs e)
        {
            setDAta(63);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            setDAta(63);
        }

        private void label16_Click(object sender, EventArgs e)
        {
            setDAta(66);
        }

        private void label17_Click(object sender, EventArgs e)
        {
            setDAta(66);
        }

        private void label18_Click(object sender, EventArgs e)
        {
            setDAta(65);
        }

        private void label19_Click(object sender, EventArgs e)
        {
            setDAta(65);
        }

        private void label20_Click(object sender, EventArgs e)
        {
            setDAta(66);
        }

        private void label21_Click(object sender, EventArgs e)
        {
            setDAta(66);
        }

        private void label22_Click(object sender, EventArgs e)
        {
            setDAta(67);
        }

        private void label23_Click(object sender, EventArgs e)
        {
            setDAta(67);
        }

        private void label24_Click(object sender, EventArgs e)
        {
            setDAta(68);
        }

        private void label25_Click(object sender, EventArgs e)
        {
            setDAta(68);
        }

        private void label26_Click(object sender, EventArgs e)
        {
            setDAta(69);
        }

        private void label27_Click(object sender, EventArgs e)
        {
            setDAta(69);
        }

        private void label28_Click(object sender, EventArgs e)
        {
            setDAta(70);
        }

        private void label29_Click(object sender, EventArgs e)
        {
            setDAta(70);
        }

        private void label30_Click(object sender, EventArgs e)
        {
            setDAta(71);
        }

        private void label31_Click(object sender, EventArgs e)
        {
            setDAta(71);
        }

        private void label61_Click(object sender, EventArgs e)
        {
            setDAta(89);
        }

        private void label62_Click(object sender, EventArgs e)
        {
            setDAta(89);
        }

        private void label58_Click(object sender, EventArgs e)
        {
            setDAta(90);
        }

        private void label59_Click(object sender, EventArgs e)
        {
            setDAta(90);
        }

        private void label56_Click(object sender, EventArgs e)
        {
            setDAta(91);
        }

        private void label57_Click(object sender, EventArgs e)
        {
            setDAta(91);
        }

        private void label54_Click(object sender, EventArgs e)
        {
            setDAta(92);
        }

        private void label55_Click(object sender, EventArgs e)
        {
            setDAta(92);
        }

        private void label52_Click(object sender, EventArgs e)
        {
            setDAta(93);
        }

        private void label53_Click(object sender, EventArgs e)
        {
            setDAta(93);
        }

        private void label50_Click(object sender, EventArgs e)
        {
            setDAta(94);
        }

        private void label51_Click(object sender, EventArgs e)
        {
            setDAta(94);
        }

        private void label48_Click(object sender, EventArgs e)
        {
            setDAta(95);
        }

        private void label49_Click(object sender, EventArgs e)
        {
            setDAta(95);
        }

        private void label46_Click(object sender, EventArgs e)
        {
            setDAta(96);
        }

        private void label47_Click(object sender, EventArgs e)
        {
            setDAta(96);
        }

        private void label44_Click(object sender, EventArgs e)
        {
            setDAta(97);
        }

        private void label45_Click(object sender, EventArgs e)
        {
            setDAta(97);
        }

        private void label42_Click(object sender, EventArgs e)
        {
            setDAta(98);
        }

        private void label43_Click(object sender, EventArgs e)
        {
            setDAta(98);
        }

        private void label40_Click(object sender, EventArgs e)
        {
            setDAta(99);
        }

        private void label41_Click(object sender, EventArgs e)
        {
            setDAta(99);
        }

        private void label38_Click(object sender, EventArgs e)
        {
            setDAta(100);
        }

        private void label39_Click(object sender, EventArgs e)
        {
            setDAta(100);
        }

        private void label36_Click(object sender, EventArgs e)
        {
            setDAta(101);
        }

        private void label37_Click(object sender, EventArgs e)
        {
            setDAta(101);
        }

        private void label34_Click(object sender, EventArgs e)
        {
            setDAta(102);
        }

        private void label35_Click(object sender, EventArgs e)
        {
            setDAta(102);
        }

        private void label32_Click(object sender, EventArgs e)
        {
            setDAta(103);
        }

        private void label33_Click(object sender, EventArgs e)
        {
            setDAta(103);
        }
    }
}
