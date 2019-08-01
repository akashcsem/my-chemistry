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
    public partial class frmInventor : Form
    {
        public frmInventor()
        {
            InitializeComponent();
            myText.Text = "আধুনিক পর্যায় সারণির জনক বলা হয় রাশিয়ান বিজ্ঞানী দিমিত্রি মেন্ডেলিফকে। যিনি ভরের পরিবর্তন আণবিক সংখ্যা দিয়ে সারণিটি তৈরি করেন। ১৮৩৪ সালের ৮ ফেব্রুয়ারি রাশিয়ার সাইবেরিয়া অঞ্চলে জন্মগ্রহণ করেন দিমিত্রি ইভানোভিচ মেন্ডেলিফ। রসায়ন শাস্ত্রের বিভিন্ন বিষয় নিয়ে দিমিত্রি মেন্ডেলিফ কাজ করেছেন। ১৮৬৩ সালে তিনি সেন্ট পিটার্সবার্গ বিশ্ববিদ্যালয়ে রসায়নের অধ্যাপক হিসেবে নিযুক্ত হন। তিনি অ্যালকোহল ও পানির মিশ্রণের ওপর গবেষণা করেন। এ গবেষণাকর্মের সাফল্যের স্বীকৃতিস্বরূপ ১৮৬৫ সালে মেন্ডেলিফ ডক্টর অব সায়েন্স ডিগ্রি লাভ করেন।";
            this.Opacity = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
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
