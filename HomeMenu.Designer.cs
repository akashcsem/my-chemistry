namespace PeriodicTable
{
    partial class HomeMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeMenu));
            this.titlebar = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.maintable = new System.Windows.Forms.Button();
            this.sonketAndAkorik = new System.Windows.Forms.Button();
            this.metalAndNonMetal = new System.Windows.Forms.Button();
            this.elementsList = new System.Windows.Forms.Button();
            this.shortcutTechniqe = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.sinonym = new System.Windows.Forms.Button();
            this.moreOption = new System.Windows.Forms.Button();
            this.andMe = new System.Windows.Forms.Button();
            this.inventor = new System.Windows.Forms.Button();
            this.moreShortCut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.titlebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.SkyBlue;
            this.titlebar.Controls.Add(this.label3);
            this.titlebar.Controls.Add(this.label1);
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(785, 29);
            this.titlebar.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(329, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "মেইন মেনু";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(761, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.titlebar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Location = new System.Drawing.Point(379, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 339);
            this.panel1.TabIndex = 1;
            // 
            // maintable
            // 
            this.maintable.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.maintable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maintable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.maintable.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintable.Location = new System.Drawing.Point(23, 58);
            this.maintable.Name = "maintable";
            this.maintable.Size = new System.Drawing.Size(338, 42);
            this.maintable.TabIndex = 2;
            this.maintable.Text = "পর্যায় সারণি";
            this.maintable.UseVisualStyleBackColor = false;
            this.maintable.Click += new System.EventHandler(this.maintable_Click);
            this.maintable.MouseEnter += new System.EventHandler(this.maintable_MouseEnter);
            this.maintable.MouseLeave += new System.EventHandler(this.maintable_MouseLeave);
            // 
            // sonketAndAkorik
            // 
            this.sonketAndAkorik.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.sonketAndAkorik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sonketAndAkorik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sonketAndAkorik.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sonketAndAkorik.Location = new System.Drawing.Point(23, 305);
            this.sonketAndAkorik.Name = "sonketAndAkorik";
            this.sonketAndAkorik.Size = new System.Drawing.Size(338, 42);
            this.sonketAndAkorik.TabIndex = 3;
            this.sonketAndAkorik.Text = "সংকেত এবং আকরিক";
            this.sonketAndAkorik.UseVisualStyleBackColor = false;
            this.sonketAndAkorik.Click += new System.EventHandler(this.sonketAndAkorik_Click);
            this.sonketAndAkorik.MouseEnter += new System.EventHandler(this.sonketAndAkorik_MouseEnter);
            this.sonketAndAkorik.MouseLeave += new System.EventHandler(this.sonketAndAkorik_MouseLeave);
            // 
            // metalAndNonMetal
            // 
            this.metalAndNonMetal.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.metalAndNonMetal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metalAndNonMetal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.metalAndNonMetal.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metalAndNonMetal.Location = new System.Drawing.Point(23, 248);
            this.metalAndNonMetal.Name = "metalAndNonMetal";
            this.metalAndNonMetal.Size = new System.Drawing.Size(338, 42);
            this.metalAndNonMetal.TabIndex = 4;
            this.metalAndNonMetal.Text = "ধাতু এবং অধাতু";
            this.metalAndNonMetal.UseVisualStyleBackColor = false;
            this.metalAndNonMetal.Click += new System.EventHandler(this.metalAndNonMetal_Click);
            this.metalAndNonMetal.MouseEnter += new System.EventHandler(this.metalAndNonMetal_MouseEnter);
            this.metalAndNonMetal.MouseLeave += new System.EventHandler(this.metalAndNonMetal_MouseLeave);
            // 
            // elementsList
            // 
            this.elementsList.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.elementsList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elementsList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.elementsList.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementsList.Location = new System.Drawing.Point(23, 187);
            this.elementsList.Name = "elementsList";
            this.elementsList.Size = new System.Drawing.Size(338, 42);
            this.elementsList.TabIndex = 5;
            this.elementsList.Text = "মৌলসমুহের তালিকা";
            this.elementsList.UseVisualStyleBackColor = false;
            this.elementsList.Click += new System.EventHandler(this.elementsList_Click);
            this.elementsList.MouseEnter += new System.EventHandler(this.elementsList_MouseEnter);
            this.elementsList.MouseLeave += new System.EventHandler(this.elementsList_MouseLeave);
            // 
            // shortcutTechniqe
            // 
            this.shortcutTechniqe.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.shortcutTechniqe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shortcutTechniqe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.shortcutTechniqe.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortcutTechniqe.Location = new System.Drawing.Point(23, 122);
            this.shortcutTechniqe.Name = "shortcutTechniqe";
            this.shortcutTechniqe.Size = new System.Drawing.Size(338, 42);
            this.shortcutTechniqe.TabIndex = 6;
            this.shortcutTechniqe.Text = "শর্টকাট টেকনিক";
            this.shortcutTechniqe.UseVisualStyleBackColor = false;
            this.shortcutTechniqe.Click += new System.EventHandler(this.shortcutTechniqe_Click);
            this.shortcutTechniqe.MouseEnter += new System.EventHandler(this.shortcutTechniqe_MouseEnter);
            this.shortcutTechniqe.MouseLeave += new System.EventHandler(this.shortcutTechniqe_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 367);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 24);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(531, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "All Rights Reserved- AL KAZI AKASH";
            // 
            // sinonym
            // 
            this.sinonym.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.sinonym.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sinonym.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sinonym.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinonym.Location = new System.Drawing.Point(408, 58);
            this.sinonym.Name = "sinonym";
            this.sinonym.Size = new System.Drawing.Size(355, 42);
            this.sinonym.TabIndex = 2;
            this.sinonym.Text = "মৌল ও পদার্থের অপর নাম";
            this.sinonym.UseVisualStyleBackColor = false;
            this.sinonym.Click += new System.EventHandler(this.sinonym_Click);
            this.sinonym.MouseEnter += new System.EventHandler(this.sinonym_MouseEnter);
            this.sinonym.MouseLeave += new System.EventHandler(this.sinonym_MouseLeave);
            // 
            // moreOption
            // 
            this.moreOption.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.moreOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moreOption.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.moreOption.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreOption.Location = new System.Drawing.Point(408, 184);
            this.moreOption.Name = "moreOption";
            this.moreOption.Size = new System.Drawing.Size(355, 42);
            this.moreOption.TabIndex = 3;
            this.moreOption.Text = "ক্রম এবং সারি";
            this.moreOption.UseVisualStyleBackColor = false;
            this.moreOption.Click += new System.EventHandler(this.moreOption_Click);
            this.moreOption.MouseEnter += new System.EventHandler(this.moreOption_MouseEnter);
            this.moreOption.MouseLeave += new System.EventHandler(this.moreOption_MouseLeave);
            // 
            // andMe
            // 
            this.andMe.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.andMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.andMe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.andMe.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.andMe.Location = new System.Drawing.Point(408, 305);
            this.andMe.Name = "andMe";
            this.andMe.Size = new System.Drawing.Size(355, 42);
            this.andMe.TabIndex = 4;
            this.andMe.Text = "এবং আমি";
            this.andMe.UseVisualStyleBackColor = false;
            this.andMe.Click += new System.EventHandler(this.andMe_Click);
            this.andMe.MouseEnter += new System.EventHandler(this.andMe_MouseEnter);
            this.andMe.MouseLeave += new System.EventHandler(this.andMe_MouseLeave);
            // 
            // inventor
            // 
            this.inventor.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.inventor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inventor.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventor.Location = new System.Drawing.Point(408, 244);
            this.inventor.Name = "inventor";
            this.inventor.Size = new System.Drawing.Size(355, 42);
            this.inventor.TabIndex = 5;
            this.inventor.Text = "আবিস্কারক";
            this.inventor.UseVisualStyleBackColor = false;
            this.inventor.Click += new System.EventHandler(this.inventor_Click);
            this.inventor.MouseEnter += new System.EventHandler(this.inventor_MouseEnter);
            this.inventor.MouseLeave += new System.EventHandler(this.inventor_MouseLeave);
            // 
            // moreShortCut
            // 
            this.moreShortCut.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.moreShortCut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moreShortCut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.moreShortCut.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreShortCut.Location = new System.Drawing.Point(408, 122);
            this.moreShortCut.Name = "moreShortCut";
            this.moreShortCut.Size = new System.Drawing.Size(355, 42);
            this.moreShortCut.TabIndex = 6;
            this.moreShortCut.Text = "আরো শর্টকাট টেকনিক";
            this.moreShortCut.UseVisualStyleBackColor = false;
            this.moreShortCut.Click += new System.EventHandler(this.moreShortCut_Click);
            this.moreShortCut.MouseEnter += new System.EventHandler(this.moreShortCut_MouseEnter);
            this.moreShortCut.MouseLeave += new System.EventHandler(this.moreShortCut_MouseLeave);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SkyBlue;
            this.label4.Location = new System.Drawing.Point(-3, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 345);
            this.label4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SkyBlue;
            this.label5.Location = new System.Drawing.Point(775, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 345);
            this.label5.TabIndex = 9;
            // 
            // HomeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(783, 391);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.moreShortCut);
            this.Controls.Add(this.shortcutTechniqe);
            this.Controls.Add(this.inventor);
            this.Controls.Add(this.elementsList);
            this.Controls.Add(this.andMe);
            this.Controls.Add(this.metalAndNonMetal);
            this.Controls.Add(this.moreOption);
            this.Controls.Add(this.sonketAndAkorik);
            this.Controls.Add(this.sinonym);
            this.Controls.Add(this.maintable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.HomeMenu_Load);
            this.titlebar.ResumeLayout(false);
            this.titlebar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlebar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button maintable;
        private System.Windows.Forms.Button sonketAndAkorik;
        private System.Windows.Forms.Button metalAndNonMetal;
        private System.Windows.Forms.Button elementsList;
        private System.Windows.Forms.Button shortcutTechniqe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sinonym;
        private System.Windows.Forms.Button moreOption;
        private System.Windows.Forms.Button andMe;
        private System.Windows.Forms.Button inventor;
        private System.Windows.Forms.Button moreShortCut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}