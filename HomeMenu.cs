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
    public partial class HomeMenu : Form
{

  
        public HomeMenu()
        {
            InitializeComponent();
        }

        private void HomeMenu_Load(object sender, EventArgs e)
        {

        }

        private void maintable_MouseEnter(object sender, EventArgs e)
        {
            maintable.BackColor = Color.Peru;
        }

        private void maintable_MouseLeave(object sender, EventArgs e)
        {
            maintable.BackColor = Color.BlanchedAlmond;
        }

        private void shortcutTechniqe_MouseEnter(object sender, EventArgs e)
        {
            shortcutTechniqe.BackColor = Color.Peru;
        }

        private void elementsList_MouseEnter(object sender, EventArgs e)
        {
            elementsList.BackColor = Color.Peru;
        }

        private void metalAndNonMetal_MouseEnter(object sender, EventArgs e)
        {
            metalAndNonMetal.BackColor = Color.Peru;
        }

        private void sonketAndAkorik_MouseEnter(object sender, EventArgs e)
        {
            sonketAndAkorik.BackColor = Color.Peru;
        }

        private void sinonym_MouseEnter(object sender, EventArgs e)
        {
            sinonym.BackColor = Color.Peru;
        }

        private void moreShortCut_MouseEnter(object sender, EventArgs e)
        {
            moreShortCut.BackColor = Color.Peru;
        }

        private void inventor_MouseEnter(object sender, EventArgs e)
        {
            inventor.BackColor = Color.Peru;
        }

        private void andMe_MouseEnter(object sender, EventArgs e)
        {
            andMe.BackColor = Color.Peru;
        }

        private void moreOption_MouseEnter(object sender, EventArgs e)
        {
            moreOption.BackColor = Color.Peru;
        }

        private void shortcutTechniqe_MouseLeave(object sender, EventArgs e)
        {
            shortcutTechniqe.BackColor = Color.BlanchedAlmond;
        }

        private void elementsList_MouseLeave(object sender, EventArgs e)
        {
            elementsList.BackColor = Color.BlanchedAlmond;
        }

        private void metalAndNonMetal_MouseLeave(object sender, EventArgs e)
        {
            metalAndNonMetal.BackColor = Color.BlanchedAlmond;
        }

        private void sonketAndAkorik_MouseLeave(object sender, EventArgs e)
        {
            sonketAndAkorik.BackColor = Color.BlanchedAlmond;
        }

        private void sinonym_MouseLeave(object sender, EventArgs e)
        {
            sinonym.BackColor = Color.BlanchedAlmond;
        }

        private void moreShortCut_MouseLeave(object sender, EventArgs e)
        {
            moreShortCut.BackColor = Color.BlanchedAlmond;
        }

        private void inventor_MouseLeave(object sender, EventArgs e)
        {
            inventor.BackColor = Color.BlanchedAlmond;
        }

        private void andMe_MouseLeave(object sender, EventArgs e)
        {
            andMe.BackColor = Color.BlanchedAlmond;
        }

        private void moreOption_MouseLeave(object sender, EventArgs e)
        {
            moreOption.BackColor = Color.BlanchedAlmond;
        }

        private void maintable_Click(object sender, EventArgs e)
        {
            MainTable mt = new MainTable();
            mt.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void elementsList_Click(object sender, EventArgs e)
        {
            ListOfElements le = new ListOfElements();
            le.Show();
            Visible = false;
        }

        private void sinonym_Click(object sender, EventArgs e)
        {
            Synnonym sn = new Synnonym();
            sn.Show();
            Visible = false;
        }

        private void andMe_Click(object sender, EventArgs e)
        {
            new frmAndMe().Show();
        }

        private void metalAndNonMetal_Click(object sender, EventArgs e)
        {
            MetalAndNonMetal m = new MetalAndNonMetal();
            m.Show();
            Visible = false;
        }

        private void shortcutTechniqe_Click(object sender, EventArgs e)
        {
            ShortCutTecnic st = new ShortCutTecnic();
            st.Show();
            Visible = false;
        }

        private void sonketAndAkorik_Click(object sender, EventArgs e)
        {
            SonketAndAkorik ms = new SonketAndAkorik();
            ms.Show();
            Visible = false;
        }

        private void moreShortCut_Click(object sender, EventArgs e)
        {
            MoreShortcutcs ms = new MoreShortcutcs(1);
            ms.Show();
            Visible = false;
        }

        private void moreOption_Click(object sender, EventArgs e)
        {
            MoreShortcutcs ms = new MoreShortcutcs(2);
            ms.Show();
            Visible = false;
        }

        private void inventor_Click(object sender, EventArgs e)
        {
            frmInventor ms = new frmInventor();
            ms.Show();
        }
    }
}
