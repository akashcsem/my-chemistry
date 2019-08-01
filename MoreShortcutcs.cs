using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeriodicTable
{
    public partial class MoreShortcutcs : MetroFramework.Forms.MetroForm
    {
        int x = 0, y = 0, panel = 1;
       // Boolean slide = true;
        Bitmap[] bi = { Properties.Resources._1, Properties.Resources._2, Properties.Resources._3, Properties.Resources._4, Properties.Resources._5,  Properties.Resources._7, Properties.Resources._8, Properties.Resources._9, Properties.Resources._10, Properties.Resources._11,
        Properties.Resources._11, Properties.Resources._12, Properties.Resources._13, Properties.Resources._14, Properties.Resources._15, Properties.Resources._16, Properties.Resources._17, Properties.Resources._18, Properties.Resources._19, Properties.Resources._20,
        Properties.Resources._21, Properties.Resources._22, Properties.Resources._23, Properties.Resources._24, Properties.Resources._25, Properties.Resources._26, Properties.Resources._27, Properties.Resources._28, Properties.Resources._29, Properties.Resources._30,
        Properties.Resources._31, Properties.Resources._32, Properties.Resources._33, Properties.Resources._34, Properties.Resources._35, Properties.Resources._36, Properties.Resources._37, Properties.Resources._38, Properties.Resources._39, Properties.Resources._40,
        Properties.Resources._41, Properties.Resources._42, Properties.Resources._43, Properties.Resources._44, Properties.Resources._45, Properties.Resources._46, Properties.Resources._47, Properties.Resources._48};

        Bitmap[] cs = {Properties.Resources.sc_1, Properties.Resources.sc_2, Properties.Resources.sc_3, Properties.Resources.sc_4, Properties.Resources.sc_5, Properties.Resources.sc_6, Properties.Resources.sc_7, Properties.Resources.sc_8, Properties.Resources.sc_9, Properties.Resources.sc_10};

        public MoreShortcutcs()
        {
            InitializeComponent();
        }
        public MoreShortcutcs (int x)
        {
            panel = x;
            InitializeComponent();
            if (panel == 1)
            {
                this.Text = "আরো কিছু সংক্ষিপ্ত কৌশল";
            } else
            {
                this.Text = "ক্রম এবং সারি";
                pictureBox1.Image = Properties.Resources.sc_1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeMenu hm = new HomeMenu();
            hm.Show();
            Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel == 1)
            {
                if (x == 0)
                    x = 48;
                x--;
                pictureBox1.Image = bi[x];
            } else
            {
                if (y == 0)
                    y = 10;
                y--;
                pictureBox1.Image = cs[y];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (panel == 1)
            {
                if (x == 47)
                    x = -1;
                x++;
                pictureBox1.Image = bi[x];
            } else
            {
                if (y == 9)
                    y = -1;
                y++;
                pictureBox1.Image = cs[y];
            }
        }



        ManualResetEvent _shutdownEvent = new ManualResetEvent(false);
        Thread _thread;

        public void DoWork()
        {
            while (true)
            {
                if (_shutdownEvent.WaitOne(0))
                    break;
                if (panel == 1)
                {
                    while (true)
                    {
                        if (x == 47)
                            x = -1;
                        x++;
                        pictureBox1.Image = bi[x];
                        Thread.Sleep(800);
                    }
                } else
                {
                    while (true)
                    {
                        if (y == 9)
                            y = -1;
                        y++;
                        pictureBox1.Image = cs[y];
                        Thread.Sleep(800);
                    }
                }
            }
        }


        private void button7_Click(object sender, EventArgs e)
        {
            _thread.Abort();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _thread = new Thread(DoWork);
            _thread.Start();
        }

    }
}
