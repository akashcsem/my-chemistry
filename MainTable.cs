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
    public partial class MainTable : MetroFramework.Forms.MetroForm
    {

        public MainTable()
        {
            InitializeComponent();
        }

        void setDAta(int x)
        {
            ElementsInfo ei = new ElementsInfo(x, 0);
            ei.Show();
            Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            Visible = false;
        }

        private void label138_Click(object sender, EventArgs e)
        {
            LanthanideActinide la = new LanthanideActinide(2);
            la.Show();
            Visible = false;
        }



        private void label139_Click(object sender, EventArgs e)
        {
            LanthanideActinide la = new LanthanideActinide(3);
            la.Show();
            Visible = false;
        }

        private void label27_Click(object sender, EventArgs e)
        {
            setDAta(1);
        }

        private void label28_Click(object sender, EventArgs e)
        {
            setDAta(1);
        }

        private void label31_Click(object sender, EventArgs e)
        {
            setDAta(2);
        }

        private void label254_Click(object sender, EventArgs e)
        {
            setDAta(2);
        }

        private void label29_Click(object sender, EventArgs e)
        {
            setDAta(3);
        }

        private void label30_Click(object sender, EventArgs e)
        {
            setDAta(3);
        }

        private void label34_Click(object sender, EventArgs e)
        {
            setDAta(4);
        }

        private void label33_Click(object sender, EventArgs e)
        {
            setDAta(4);
        }

        private void label82_Click(object sender, EventArgs e)
        {
            setDAta(5);
        }

        private void label275_Click(object sender, EventArgs e)
        {
            setDAta(5);
        }

        private void label80_Click(object sender, EventArgs e)
        {
            setDAta(6);
        }

        private void label274_Click(object sender, EventArgs e)
        {
            setDAta(6);
        }

        private void label77_Click(object sender, EventArgs e)
        {
            setDAta(7);
        }

        private void label273_Click(object sender, EventArgs e)
        {
            setDAta(7);
        }

        private void label73_Click(object sender, EventArgs e)
        {
            setDAta(8);
        }

        private void label267_Click(object sender, EventArgs e)
        {
            setDAta(8);
        }

        private void label67_Click(object sender, EventArgs e)
        {
            setDAta(9);
        }

        private void label266_Click(object sender, EventArgs e)
        {
            setDAta(9);
        }

        private void label32_Click(object sender, EventArgs e)
        {
            setDAta(10);
        }

        private void label255_Click(object sender, EventArgs e)
        {
            setDAta(10);
        }

        private void label43_Click(object sender, EventArgs e)
        {
            setDAta(11);
        }

        private void label42_Click(object sender, EventArgs e)
        {
            setDAta(11);
        }

        private void label45_Click(object sender, EventArgs e)
        {
            setDAta(12);
        }

        private void label44_Click(object sender, EventArgs e)
        {
            setDAta(12);
        }

        private void label85_Click(object sender, EventArgs e)
        {
            setDAta(13);
        }

        private void label239_Click(object sender, EventArgs e)
        {
            setDAta(13);
        }

        private void label81_Click(object sender, EventArgs e)
        {
            setDAta(14);
        }

        private void label253_Click(object sender, EventArgs e)
        {
            setDAta(14);
        }

        private void label78_Click(object sender, EventArgs e)
        {
            setDAta(15);
        }

        private void label272_Click(object sender, EventArgs e)
        {
            setDAta(15);
        }

        private void label74_Click(object sender, EventArgs e)
        {
            setDAta(16);
        }

        private void label268_Click(object sender, EventArgs e)
        {
            setDAta(16);
        }

        private void label68_Click(object sender, EventArgs e)
        {
            setDAta(17);
        }

        private void label265_Click(object sender, EventArgs e)
        {
            setDAta(17);
        }

        private void label62_Click(object sender, EventArgs e)
        {
            setDAta(18);
        }

        private void label256_Click(object sender, EventArgs e)
        {
            setDAta(18);
        }

        private void label47_Click(object sender, EventArgs e)
        {
            setDAta(19);
        }

        private void label46_Click(object sender, EventArgs e)
        {
            setDAta(19);
        }

        private void label49_Click(object sender, EventArgs e)
        {
            setDAta(20);
        }

        private void label48_Click(object sender, EventArgs e)
        {
            setDAta(20);
        }

        private void label83_Click(object sender, EventArgs e)
        {
            setDAta(21);
        }

        private void label84_Click(object sender, EventArgs e)
        {
            setDAta(21);
        }

        private void label99_Click(object sender, EventArgs e)
        {
            setDAta(22);
        }

        private void label170_Click(object sender, EventArgs e)
        {
            setDAta(22);
        }

        private void label100_Click(object sender, EventArgs e)
        {
            setDAta(23);
        }

        private void label171_Click(object sender, EventArgs e)
        {
            setDAta(23);
        }

        private void label101_Click(object sender, EventArgs e)
        {
            setDAta(24);
        }

        private void label172_Click(object sender, EventArgs e)
        {
            setDAta(24);
        }

        private void label102_Click(object sender, EventArgs e)
        {
            setDAta(25);
        }

        private void label173_Click(object sender, EventArgs e)
        {
            setDAta(25);
        }

        private void label103_Click(object sender, EventArgs e)
        {
            setDAta(26);
        }

        private void label174_Click(object sender, EventArgs e)
        {
            setDAta(26);
        }

        private void label104_Click(object sender, EventArgs e)
        {
            setDAta(27);
        }

        private void label175_Click(object sender, EventArgs e)
        {
            setDAta(27);
        }

        private void label105_Click(object sender, EventArgs e)
        {
            setDAta(28);
        }

        private void label176_Click(object sender, EventArgs e)
        {
            setDAta(28);
        }

        private void label106_Click(object sender, EventArgs e)
        {
            setDAta(29);
        }

        private void label177_Click(object sender, EventArgs e)
        {
            setDAta(29);
        }

        private void label107_Click(object sender, EventArgs e)
        {
            setDAta(30);
        }

        private void label178_Click(object sender, EventArgs e)
        {
            setDAta(30);
        }

        private void label86_Click(object sender, EventArgs e)
        {
            setDAta(31);
        }

        private void label240_Click(object sender, EventArgs e)
        {
            setDAta(31);
        }

        private void label90_Click(object sender, EventArgs e)
        {
            setDAta(32);
        }

        private void label252_Click(object sender, EventArgs e)
        {
            setDAta(32);
        }

        private void label79_Click(object sender, EventArgs e)
        {
            setDAta(33);
        }

        private void label271_Click(object sender, EventArgs e)
        {
            setDAta(33);
        }

        private void label75_Click(object sender, EventArgs e)
        {
            setDAta(34);
        }

        private void label269_Click(object sender, EventArgs e)
        {
            setDAta(34);
        }

        private void label69_Click(object sender, EventArgs e)
        {
            setDAta(35);
        }

        private void label264_Click(object sender, EventArgs e)
        {
            setDAta(35);
        }

        private void label63_Click(object sender, EventArgs e)
        {
            setDAta(36);
        }

        private void label257_Click(object sender, EventArgs e)
        {
            setDAta(36);
        }

        private void label51_Click(object sender, EventArgs e)
        {
            setDAta(37);
        }

        private void label50_Click(object sender, EventArgs e)
        {
            setDAta(37);
        }

        private void label53_Click(object sender, EventArgs e)
        {
            setDAta(38);
        }

        private void label52_Click(object sender, EventArgs e)
        {
            setDAta(38);
        }

        private void label108_Click(object sender, EventArgs e)
        {
            setDAta(39);
        }

        private void label179_Click(object sender, EventArgs e)
        {
            setDAta(39);
        }

        private void label109_Click(object sender, EventArgs e)
        {
            setDAta(40);
        }

        private void label180_Click(object sender, EventArgs e)
        {
            setDAta(40);
        }

        private void label110_Click(object sender, EventArgs e)
        {
            setDAta(41);
        }

        private void label181_Click(object sender, EventArgs e)
        {
            setDAta(41);
        }

        private void label111_Click(object sender, EventArgs e)
        {
            setDAta(42);
        }

        private void label182_Click(object sender, EventArgs e)
        {
            setDAta(42);
        }

        private void label112_Click(object sender, EventArgs e)
        {
            setDAta(43);
        }

        private void label183_Click(object sender, EventArgs e)
        {
            setDAta(43);
        }

        private void label113_Click(object sender, EventArgs e)
        {
            setDAta(44);
        }

        private void label184_Click(object sender, EventArgs e)
        {
            setDAta(44);
        }

        private void label114_Click(object sender, EventArgs e)
        {
            setDAta(45);
        }

        private void label185_Click(object sender, EventArgs e)
        {
            setDAta(45);
        }

        private void label115_Click(object sender, EventArgs e)
        {
            setDAta(46);
        }

        private void label186_Click(object sender, EventArgs e)
        {
            setDAta(46);
        }

        private void label116_Click(object sender, EventArgs e)
        {
            setDAta(47);
        }

        private void label187_Click(object sender, EventArgs e)
        {
            setDAta(47);
        }

        private void label117_Click(object sender, EventArgs e)
        {
            setDAta(48);
        }

        private void label188_Click(object sender, EventArgs e)
        {
            setDAta(48);
        }

        private void label87_Click(object sender, EventArgs e)
        {
            setDAta(49);
        }

        private void label241_Click(object sender, EventArgs e)
        {
            setDAta(49);
        }

        private void label91_Click(object sender, EventArgs e)
        {
            setDAta(50);
        }

        private void label251_Click(object sender, EventArgs e)
        {
            setDAta(50);
        }

        private void label94_Click(object sender, EventArgs e)
        {
            setDAta(51);
        }

        private void label250_Click(object sender, EventArgs e)
        {
            setDAta(51);
        }

        private void label76_Click(object sender, EventArgs e)
        {
            setDAta(52);
        }

        private void label270_Click(object sender, EventArgs e)
        {
            setDAta(52);
        }

        private void label70_Click(object sender, EventArgs e)
        {
            setDAta(53);
        }

        private void label263_Click(object sender, EventArgs e)
        {
            setDAta(53);
        }

        private void label64_Click(object sender, EventArgs e)
        {
            setDAta(54);
        }

        private void label258_Click(object sender, EventArgs e)
        {
            setDAta(54);
        }

        private void label55_Click(object sender, EventArgs e)
        {
            setDAta(55);
        }

        private void label54_Click(object sender, EventArgs e)
        {
            setDAta(55);
        }

        private void label57_Click(object sender, EventArgs e)
        {
            setDAta(56);
        }

        private void label56_Click(object sender, EventArgs e)
        {
            setDAta(56);
        }

        private void label140_Click(object sender, EventArgs e)
        {
            setDAta(57);
        }

        private void label209_Click(object sender, EventArgs e)
        {
            setDAta(57);
        }

        private void label141_Click(object sender, EventArgs e)
        {
            setDAta(58);
        }

        private void label210_Click(object sender, EventArgs e)
        {
            setDAta(58);
        }

        private void label142_Click(object sender, EventArgs e)
        {
            setDAta(59);
        }

        private void label211_Click(object sender, EventArgs e)
        {
            setDAta(59);
        }

        private void label143_Click(object sender, EventArgs e)
        {
            setDAta(60);
        }

        private void label212_Click(object sender, EventArgs e)
        {
            setDAta(60);
        }

        private void label144_Click(object sender, EventArgs e)
        {
            setDAta(61);
        }

        private void label213_Click(object sender, EventArgs e)
        {
            setDAta(61);
        }

        private void label145_Click(object sender, EventArgs e)
        {
            setDAta(62);
        }

        private void label214_Click(object sender, EventArgs e)
        {
            setDAta(62);
        }

        private void label146_Click(object sender, EventArgs e)
        {
            setDAta(63);
        }

        private void label215_Click(object sender, EventArgs e)
        {
            setDAta(63);
        }

        private void label147_Click(object sender, EventArgs e)
        {
            setDAta(64);
        }

        private void label216_Click(object sender, EventArgs e)
        {
            setDAta(64);
        }

        private void label148_Click(object sender, EventArgs e)
        {
            setDAta(65);
        }

        private void label217_Click(object sender, EventArgs e)
        {
            setDAta(65);
        }

        private void label149_Click(object sender, EventArgs e)
        {
            setDAta(66);
        }

        private void label218_Click(object sender, EventArgs e)
        {
            setDAta(66);
        }

        private void label150_Click(object sender, EventArgs e)
        {
            setDAta(67);
        }

        private void label219_Click(object sender, EventArgs e)
        {
            setDAta(67);
        }

        private void label151_Click(object sender, EventArgs e)
        {
            setDAta(68);
        }

        private void label220_Click(object sender, EventArgs e)
        {
            setDAta(68);
        }

        private void label152_Click(object sender, EventArgs e)
        {
            setDAta(69);
        }

        private void label221_Click(object sender, EventArgs e)
        {
            setDAta(69);
        }

        private void label153_Click(object sender, EventArgs e)
        {
            setDAta(70);
        }

        private void label222_Click(object sender, EventArgs e)
        {
            setDAta(70);
        }

        private void label154_Click(object sender, EventArgs e)
        {
            setDAta(71);
        }

        private void label223_Click(object sender, EventArgs e)
        {
            setDAta(71);
        }

        private void label119_Click(object sender, EventArgs e)
        {
            setDAta(72);
        }

        private void label190_Click(object sender, EventArgs e)
        {
            setDAta(72);
        }

        private void label120_Click(object sender, EventArgs e)
        {
            setDAta(73);
        }

        private void label191_Click(object sender, EventArgs e)
        {
            setDAta(73);
        }

        private void label121_Click(object sender, EventArgs e)
        {
            setDAta(74);
        }

        private void label192_Click(object sender, EventArgs e)
        {
            setDAta(74);
        }

        private void label122_Click(object sender, EventArgs e)
        {
            setDAta(75);
        }

        private void label193_Click(object sender, EventArgs e)
        {
            setDAta(75);
        }

        private void label123_Click(object sender, EventArgs e)
        {
            setDAta(76);
        }

        private void label194_Click(object sender, EventArgs e)
        {
            setDAta(76);
        }

        private void label124_Click(object sender, EventArgs e)
        {
            setDAta(77);
        }

        private void label195_Click(object sender, EventArgs e)
        {
            setDAta(77);
        }

        private void label125_Click(object sender, EventArgs e)
        {
            setDAta(78);
        }

        private void label196_Click(object sender, EventArgs e)
        {
            setDAta(78);
        }

        private void label126_Click(object sender, EventArgs e)
        {
            setDAta(79);
        }

        private void label197_Click(object sender, EventArgs e)
        {
            setDAta(79);
        }

        private void label127_Click(object sender, EventArgs e)
        {
            setDAta(80);
        }

        private void label198_Click(object sender, EventArgs e)
        {
            setDAta(80);
        }

        private void label88_Click(object sender, EventArgs e)
        {
            setDAta(81);
        }

        private void label242_Click(object sender, EventArgs e)
        {
            setDAta(81);
        }

        private void label92_Click(object sender, EventArgs e)
        {
            setDAta(82);
        }

        private void label249_Click(object sender, EventArgs e)
        {
            setDAta(82);
        }

        private void label95_Click(object sender, EventArgs e)
        {
            setDAta(83);
        }

        private void label248_Click(object sender, EventArgs e)
        {
            setDAta(83);
        }

        private void label97_Click(object sender, EventArgs e)
        {
            setDAta(84);
        }

        private void label247_Click(object sender, EventArgs e)
        {
            setDAta(84);
        }

        private void label71_Click(object sender, EventArgs e)
        {
            setDAta(85);
        }

        private void label262_Click(object sender, EventArgs e)
        {
            setDAta(85);
        }

        private void label65_Click(object sender, EventArgs e)
        {
            setDAta(86);
        }

        private void label259_Click(object sender, EventArgs e)
        {
            setDAta(86);
        }

        private void label59_Click(object sender, EventArgs e)
        {
            setDAta(87);
        }

        private void label58_Click(object sender, EventArgs e)
        {
            setDAta(87);
        }

        private void label61_Click(object sender, EventArgs e)
        {
            setDAta(88);
        }

        private void label60_Click(object sender, EventArgs e)
        {
            setDAta(88);
        }

        private void label155_Click(object sender, EventArgs e)
        {
            setDAta(89);
        }

        private void label224_Click(object sender, EventArgs e)
        {
            setDAta(89);
        }

        private void label156_Click(object sender, EventArgs e)
        {
            setDAta(90);
        }

        private void label225_Click(object sender, EventArgs e)
        {
            setDAta(90);
        }

        private void label157_Click(object sender, EventArgs e)
        {
            setDAta(91);
        }

        private void label226_Click(object sender, EventArgs e)
        {
            setDAta(91);
        }

        private void label158_Click(object sender, EventArgs e)
        {
            setDAta(92);
        }

        private void label227_Click(object sender, EventArgs e)
        {
            setDAta(92);
        }

        private void label159_Click(object sender, EventArgs e)
        {
            setDAta(93);
        }

        private void label228_Click(object sender, EventArgs e)
        {
            setDAta(93);
        }

        private void label160_Click(object sender, EventArgs e)
        {
            setDAta(94);
        }

        private void label229_Click(object sender, EventArgs e)
        {
            setDAta(94);
        }

        private void label161_Click(object sender, EventArgs e)
        {
            setDAta(95);
        }

        private void label230_Click(object sender, EventArgs e)
        {
            setDAta(95);
        }

        private void label162_Click(object sender, EventArgs e)
        {
            setDAta(96);
        }

        private void label231_Click(object sender, EventArgs e)
        {
            setDAta(96);
        }

        private void label163_Click(object sender, EventArgs e)
        {
            setDAta(97);
        }

        private void label232_Click(object sender, EventArgs e)
        {
            setDAta(97);
        }

        private void label164_Click(object sender, EventArgs e)
        {
            setDAta(98);
        }

        private void label233_Click(object sender, EventArgs e)
        {
            setDAta(98);
        }

        private void label165_Click(object sender, EventArgs e)
        {
            setDAta(99);
        }

        private void label234_Click(object sender, EventArgs e)
        {
            setDAta(99);
        }

        private void label166_Click(object sender, EventArgs e)
        {
            setDAta(100);
        }

        private void label235_Click(object sender, EventArgs e)
        {
            setDAta(100);
        }

        private void label167_Click(object sender, EventArgs e)
        {
            setDAta(101);
        }

        private void label236_Click(object sender, EventArgs e)
        {
            setDAta(101);
        }

        private void label168_Click(object sender, EventArgs e)
        {
            setDAta(102);
        }

        private void label237_Click(object sender, EventArgs e)
        {
            setDAta(102);
        }

        private void label169_Click(object sender, EventArgs e)
        {
            setDAta(103);
        }

        private void label238_Click(object sender, EventArgs e)
        {
            setDAta(103);
        }

        private void label129_Click(object sender, EventArgs e)
        {
            setDAta(104);
        }

        private void label200_Click(object sender, EventArgs e)
        {
            setDAta(104);
        }

        private void label130_Click(object sender, EventArgs e)
        {
            setDAta(105);
        }

        private void label201_Click(object sender, EventArgs e)
        {
            setDAta(105);
        }

        private void label131_Click(object sender, EventArgs e)
        {
            setDAta(106);
        }

        private void label202_Click(object sender, EventArgs e)
        {
            setDAta(106);
        }

        private void label132_Click(object sender, EventArgs e)
        {
            setDAta(107);
        }

        private void label203_Click(object sender, EventArgs e)
        {
            setDAta(107);
        }

        private void label133_Click(object sender, EventArgs e)
        {
            setDAta(108);
        }

        private void label204_Click(object sender, EventArgs e)
        {
            setDAta(108);
        }

        private void label134_Click(object sender, EventArgs e)
        {
            setDAta(109);
        }

        private void label205_Click(object sender, EventArgs e)
        {
            setDAta(109);
        }

        private void label135_Click(object sender, EventArgs e)
        {
            setDAta(110);
        }

        private void label206_Click(object sender, EventArgs e)
        {
            setDAta(110);
        }

        private void label136_Click(object sender, EventArgs e)
        {
            setDAta(111);
        }

        private void label207_Click(object sender, EventArgs e)
        {
            setDAta(111);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new HomeMenu().Show();
            Visible = false;
        }
    }
        
}
