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
    public partial class ListOfElements : MetroFramework.Forms.MetroForm
    {

        

        public ListOfElements()
        {
            InitializeComponent();

            ListViewItem item;
            AllData ad = new AllData();
            for (int i=1; i<=111; i++)
            {
                item = listView1.Items.Add(""+i);
                item.SubItems.Add(ad.symble[i]);
                item.SubItems.Add(ad.nameBangla[i]);
                item.SubItems.Add(ad.nameEnglish[i]);
                item.SubItems.Add(ad.atomic_mass[i]);
                if (ad.state[i].Equals("metal"))
                {
                    item.SubItems.Add("ধাতু");
                    item.BackColor = Color.GreenYellow;
                } else
                {
                    item.SubItems.Add("অধাতু");
                    item.BackColor = Color.DeepSkyBlue;
                }
                   
            }
            

        }

        void setDAta(int x)
        {
            ElementsInfo ei = new ElementsInfo(x, 1);
            ei.Show();
            Visible = false;
        }
        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            var x = listView1.SelectedIndices;
            MessageBox.Show("" + x);

        }

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var x = listView1.SelectedIndices;
            MessageBox.Show("" + x);
        }

        

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show(listView1.SelectedItems[0].SubItems[0].Text);
            setDAta(Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text));
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            HomeMenu hm = new HomeMenu();
            hm.Show();
            Visible = false;
        }

        private void listView1_SizeChanged(object sender, EventArgs e)
        {
            //ListView listView = sender as ListView;
            //if (listView != null)
            //{
            //    float totalColumnWidth = 0;

            //    // Get the sum of all column tags
            //    for (int i = 0; i < listView.Columns.Count; i++)
            //        totalColumnWidth += Convert.ToInt32(listView.Columns[i].Tag);

            //    // Calculate the percentage of space each column should 
            //    // occupy in reference to the other columns and then set the 
            //    // width of the column to that percentage of the visible space.
            //    for (int i = 0; i < listView.Columns.Count; i++)
            //    {
            //        float colPercentage = (Convert.ToInt32(listView.Columns[i].Tag) / totalColumnWidth);
            //        listView.Columns[i].Width = (int)(colPercentage * listView.ClientRectangle.Width);
            //    }
            //}
        }
    }
}
