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
    public partial class ElementsInfo : MetroFramework.Forms.MetroForm
    {
        AllData ad = new AllData();
        public int x = 0;
        MainTable mt = new MainTable();
        int preveousForm = 1;

        public ElementsInfo()
        {
            InitializeComponent();
        }

        public ElementsInfo (int X, int formNo)
        {
            InitializeComponent();
            x = X;
            preveousForm = formNo;
            setInfo(x);
        }

        public void setInfo(int y)
        {
            showAll();
            if (ad.symble[y].Length == 2)
            {
                symbol1.Location = new Point
                {
                    X = 27,
                    Y = symbol1.Location.Y
                };
            } else
            {
                symbol1.Location = new Point
                {
                    X = 43,
                    Y = symbol1.Location.Y
                };
            }
            if (ad.images[y-1] == null)
            {
                elementPic.Image = Properties.Resources.e;
            } else
            {
                elementPic.Image = ad.images[y - 1];
            }
            
            atomicNo1.Text = "" + y;
            symbol1.Text = "" + ad.symble[y];
            banglaName1.Text = "" + ad.nameBangla[y];

            // Panel 1
            // txtPanel1.Text = "সাধারণ বৈশিষ্ট ";
            atomicNo.Text = "পারমানবিক সংখ্যা : " + y;
            symbol.Text = "সংকেত : " + ad.symble[y];
            banglaName.Text = "বাংলা নাম : " + ad.nameBangla[y];
            englishName.Text = "ইংরেজি নাম : " + ad.nameEnglish[y];
            atomicMass.Text = "পারমানবিক ভর : " + ad.atomic_mass[y];
            classElement.Text = "মৌলের শ্রেণী : " + ad.classElement1[y];
            groupPeriod.Text = "পর্যায় এবং গ্রুপ : গ্রুপ  " + ad.location1[y] + ", পর্যায় " + ad.location2[y];
            block.Text = "ব্লক : " + ad.blocks[y] + " - block মৌল";
            inventor.Text = "আবিষ্কারক : " + ad.inventor[y];
            // electronBInnas.Text = "";

            
            // Panel 2
            //  txtPanel2.Text = "ভৌত বৈশিষ্ট ";
            color.Text = "বর্ণ : " + ad.color[y];
            state.Text = "দশা : " + ad.state[y];
            freezingPoint.Text = "গলনাংক : " + ad.freezing_point[y];
            meltingPoint.Text = "স্ফুটনাংক : " + ad.meltting_point[y];
            density.Text = "ঘনত্ব : " + ad.density[y];
            fluidDensity.Text = "তরলের ঘনত্ব : " + ad.fluidDensity[y];
            triplePoint.Text = "ত্রৈধ বিন্দু : " + ad.triplePoint[y];
            criticalPoint.Text = "গুরুতর বিন্দু : " + ad.criticalPoint[y];
            phusionsEnthalpi.Text = "ফিউশনের এনথালপি : " + ad.fusionsEnthalpi[y];
            speedOfSound.Text = "শব্দের গতি : " + ad.speedOfSound[y];
            criticalHeat.Text = "বাষ্পীয়করণের তাপ : " + ad.criticalHeat[y];
            heatCapacity.Text = "তাপ ধারকত্ব : " + ad.heatCapacity[y];
            oxidation.Text = "জারণ অবস্থা : " + ad.oxidation[y];
            electronegativity.Text = "তাড়িৎচুম্বকত্ব : " + ad.electronegativity[y];
            cristalStructure.Text = "ক্লাসের গঠন : " + ad.crystalStructure[y];
            magnetism.Text = "চুম্বকত্ব : " + ad.magnetism[y];
            cashRegNo.Text = "ক্যাস নিবন্ধন নম্বর : " + ad.cashRegiNo[y];
            vandarWalsRadius.Text = "ভ্যান ডার ওয়ালেস ব্যাসার্ধ : " + ad.vanderWallasRadius[y];
            heatPoribahokotto.Text = "তাপ পরিবহকত্ব : " + ad.heatPoribahokotto[y];
            electricalMagnetism.Text = "তাড়িৎচুম্বকত্ব : " + ad.electricalMagnetism[y];
            covalentRadius.Text = "সমযোজী ব্যাসার্ধ : " + ad.covalentRadius[y];
            nuclearRadius.Text = "পারমানবিক ব্যাসার্ধ : " + ad.covalentRadius[y];
            
            // Panel 3
            hideAll(y);
        }

     


        ///   left arrow button
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            timer1.Start();
            x++;
            if (x == 112)
                x = 1;
            setInfo(x);
        }

        // right arrow button
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            timer1.Start();
            x--;
            if (x == -1)
                x = 111;
            setInfo(x);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.05;
            } else
            {
                timer1.Stop();
            }
        }

        void showAll()
        {
            // panel 1
            atomicNo.Show();
            satomicNo.Show();
            symbol.Show();
            ssymbol.Show();
            banglaName.Show();
            sbanglaName.Show();
            englishName.Show();
            senglishName.Show();
            atomicMass.Show();
            satomicMass.Show();
            classElement.Show();
            sclassElement.Show();
            groupPeriod.Show();
            sgroupPeriod.Show();
            block.Show();
            sblock.Show();
            inventor.Show();
            sinventor.Show();
            // electronBInnas.Text = "";
            // Panel 2
            color.Show();
            scolor.Show();
            state.Show();
            sstate.Show();
            freezingPoint.Show();
            sfreezingPoint.Show();
            meltingPoint.Show();
            smeltingPoint.Show();
            density.Show();
            sdensity.Show();
            fluidDensity.Show();
            sfluidDensity.Show();
            triplePoint.Show();
            striplePoint.Show();
            criticalPoint.Show();
            scriticalPoint.Show();
            phusionsEnthalpi.Show();
            sphusionEnthalpi.Show();
            speedOfSound.Show();
            sspeedOfSound.Show();
            criticalHeat.Show();
            scriticalHeat.Show();
            heatCapacity.Show();
            sheatCapacity.Show();
            oxidation.Show();
            soxidation.Show();
            electronegativity.Show();
            selectronegativity.Show();
            cristalStructure.Show();
            scristalStructure.Show();
            magnetism.Show();
            smagnetism.Show();
            cashRegNo.Show();
            scashRegNo.Show();
            vandarWalsRadius.Show();
            svandarWalsRadius.Show();
            heatPoribahokotto.Show();
            sheatPoribahokotto.Show();
            electricalMagnetism.Show();
            selectricalMagnetism.Show();
            covalentRadius.Show();
            scovalentRadius.Show();
            nuclearRadius.Show();
            snuclearRadius.Show();
        }

        void hideAll(int y)
        {
            // panel 1
            if (ad.color[y] == "")
            {
                color.Hide();
                scolor.Hide();
            }
            if (ad.state[y] == "")
            {
                state.Hide();
                sstate.Hide();
            }
            if (ad.freezing_point[y] == "")
            {
                freezingPoint.Hide();
                sfreezingPoint.Hide();
            }
            if (ad.meltting_point[y] == "")
            {
                meltingPoint.Hide();
                smeltingPoint.Hide();
            }
            if (ad.density[y] == "")
            {
                density.Hide();
                sdensity.Hide();
            }
            if (ad.fluidDensity[y] == "")
            {
                fluidDensity.Hide();
                sfluidDensity.Hide();
            }
            if (ad.triplePoint[y] == "")
            {
                triplePoint.Hide();
                striplePoint.Hide();
            }
            if (ad.criticalPoint[y] == "")
            {
                criticalPoint.Hide();
                scriticalPoint.Hide();
            }
            if (ad.fusionsEnthalpi[y] == "")
            {
                phusionsEnthalpi.Hide();
                sphusionEnthalpi.Hide();
            }
            if (ad.speedOfSound[y] == "")
            {
                speedOfSound.Hide();
                sspeedOfSound.Hide();
            }
            if (ad.criticalHeat[y] == "")
            {
                criticalHeat.Hide();
                scriticalHeat.Hide();
            }
            if (ad.heatCapacity[y] == "")
            {
                heatCapacity.Hide();
                sheatCapacity.Hide();
            }
            if (ad.oxidation[y] == "")
            {
                oxidation.Hide();
                soxidation.Hide();
            }
            if (ad.electronegativity[y] == "")
            {
                electronegativity.Hide();
                selectronegativity.Hide();
            }
            if (ad.crystalStructure[y] == "")
            {
                cristalStructure.Hide();
                scristalStructure.Hide();
            }
            if (ad.magnetism[y] == "")
            {
                magnetism.Hide();
                smagnetism.Hide();
            }
            if (ad.cashRegiNo[y] == "")
            {
                cashRegNo.Hide();
                scashRegNo.Hide();
            }
            if (ad.vanderWallasRadius[y] == "")
            {
                vandarWalsRadius.Hide();
                svandarWalsRadius.Hide();
            }
            if (ad.heatPoribahokotto[y] == "")
            {
                heatPoribahokotto.Hide();
                sheatPoribahokotto.Hide();
            }
            if (ad.electricalMagnetism[y] == "")
            {
                electricalMagnetism.Hide();
                selectricalMagnetism.Hide();
            }
            if (ad.covalentRadius[y] == "")
            {
                covalentRadius.Hide();
                scovalentRadius.Hide();
            }
            if (ad.nuclearRadius[y] == "")
            {
                nuclearRadius.Hide();
                snuclearRadius.Hide();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainTable mt = new MainTable();
            mt.Show();
            Visible = false;
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            if (preveousForm == 1)
            {
                ListOfElements mt = new ListOfElements();
                mt.Show();
            }
            else if (preveousForm == 2)
            {
                LanthanideActinide mt = new LanthanideActinide();
                mt.Show();
            }
            else if (preveousForm == 3)
            {
                MetalAndNonMetal mt = new MetalAndNonMetal();
                mt.Show();
            }
            else
            {
                MainTable mt = new MainTable();
                mt.Show();
            }
            Visible = false;
        }
    }
}
