namespace PeriodicTable
{
    partial class ListOfElements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListOfElements));
            this.listView1 = new System.Windows.Forms.ListView();
            this.no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.symbol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.no,
            this.symbol,
            this.name1,
            this.name2,
            this.mass,
            this.status});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HoverSelection = true;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(5, 60);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(845, 444);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SizeChanged += new System.EventHandler(this.listView1_SizeChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // no
            // 
            this.no.Text = "পারমানবিক সংখ্যা";
            this.no.Width = 123;
            // 
            // symbol
            // 
            this.symbol.Text = "প্রতীক";
            this.symbol.Width = 86;
            // 
            // name1
            // 
            this.name1.Text = "বাংলা নাম";
            this.name1.Width = 141;
            // 
            // name2
            // 
            this.name2.Text = "ইংরেজি নাম";
            this.name2.Width = 140;
            // 
            // mass
            // 
            this.mass.Text = "পারমানবিক ভর";
            this.mass.Width = 139;
            // 
            // status
            // 
            this.status.Text = "প্রকৃতি";
            this.status.Width = 278;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Image = global::PeriodicTable.Properties.Resources.back_512;
            this.back.Location = new System.Drawing.Point(10, 25);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(49, 26);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back.TabIndex = 6;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // ListOfElements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 509);
            this.Controls.Add(this.back);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListOfElements";
            this.Padding = new System.Windows.Forms.Padding(5, 60, 5, 5);
            this.Text = "     মৌল সমুহের তালিকা";
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader no;
        private System.Windows.Forms.ColumnHeader symbol;
        private System.Windows.Forms.ColumnHeader name1;
        private System.Windows.Forms.ColumnHeader name2;
        private System.Windows.Forms.ColumnHeader mass;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.PictureBox back;
    }
}