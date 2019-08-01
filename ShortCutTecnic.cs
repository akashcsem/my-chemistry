using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PeriodicTable
{
    public partial class ShortCutTecnic : MetroFramework.Forms.MetroForm
    {
        int count = 1;
        public ShortCutTecnic()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            setImage(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setImage(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setImage(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            setImage(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setImage(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            setImage(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            setImage(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            setImage(8);
        }

        void setImage (int x)
        {
            setButtonColor();
            if (x == 1)
            {
                count = 1;
                button1.BackColor = Color.Black;
                button1.ForeColor = Color.Lime;
                picture2.BackgroundImage = Properties.Resources.g1;
            }
            if (x == 2)
            {
                count = 2;
                button2.BackColor = Color.Black;
                button2.ForeColor = Color.Lime;
                picture2.BackgroundImage = Properties.Resources.g2;
            }
            if (x == 3)
            {
                count = 3;
                button3.BackColor = Color.Black;
                button3.ForeColor = Color.Lime;
                picture2.BackgroundImage = Properties.Resources.g3;
            }
            if (x == 4)
            {
                count = 4;
                button4.BackColor = Color.Black;
                button4.ForeColor = Color.Lime;
                picture2.BackgroundImage = Properties.Resources.g4;
            }
            if (x == 5)
            {
                count = 5;
                button5.BackColor = Color.Black;
                button5.ForeColor = Color.Lime;
                picture2.BackgroundImage = Properties.Resources.g5;
            }
            if (x == 6)
            {
                count = 6;
                button6.BackColor = Color.Black;
                button6.ForeColor = Color.Lime;
                picture2.BackgroundImage = Properties.Resources.g6;
            }
            if (x == 7)
            {
                count = 7;
                button7.BackColor = Color.Black;
                button7.ForeColor = Color.Lime;
                picture2.BackgroundImage = Properties.Resources.g7;
            }
            if (x == 8)
            {
                count = 8;
                button8.BackColor = Color.Black;
                button8.ForeColor = Color.Lime;
                picture2.BackgroundImage = Properties.Resources.g8;
            }
            if (x == 9)
            {
                count = 9;
                picture2.BackgroundImage = Properties.Resources.g9;
            }
            Util.Animate(picture2, Util.Effect.Center, 100, 0);
            Util.Animate(picture2, Util.Effect.Center, 100, 0);

        }

        void setButtonColor()
        {
            button1.BackColor = Color.Green;
            button2.BackColor = Color.Green;
            button3.BackColor = Color.Green;
            button4.BackColor = Color.Green;
            button5.BackColor = Color.Green;
            button6.BackColor = Color.Green;
            button7.BackColor = Color.Green;
            button8.BackColor = Color.Green;

            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            button6.ForeColor = Color.White;
            button7.ForeColor = Color.White;
            button8.ForeColor = Color.White;
        }


        //  Animation Class
        public static class Util
        {
            public enum Effect { Roll, Slide, Center, Blend }

            public static void Animate(Control ctl, Effect effect, int msec, int angle)
            {
                int flags = effmap[(int)effect];

                if (ctl.Visible)
                {
                    flags |= 0x10000;
                    angle += 180;
                }
                else
                {
                    if (ctl.TopLevelControl == ctl) flags |= 0x20000;
                    else if (effect == Effect.Blend) throw new ArgumentException();
                }

                flags |= dirmap[(angle % 360) / 180];
                bool ok = AnimateWindow(ctl.Handle, msec, flags);

              //  if (!ok) throw new Exception("Animacion Fallida");
                ctl.Visible = !ctl.Visible;

            }


            private static int[] dirmap = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            private static int[] effmap = { 0, 0x40000, 0x10, 0x80000 };

            [DllImport("user32.dll")]

            private static extern bool AnimateWindow(IntPtr handle, int msec, int flags);

        }

        private void back_Click(object sender, EventArgs e)
        {
            HomeMenu hm = new HomeMenu();
            hm.Show();
            Visible = false;
        }
    }
}
