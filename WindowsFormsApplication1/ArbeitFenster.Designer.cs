namespace WindowsFormsApplication1
{
    partial class ArbeitFenster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArbeitFenster));
            this.group_prodactTableAdapter = new WindowsFormsApplication1.DatabaseDataSet1TableAdapters.group_prodactTableAdapter();
            this.aktivitat_artTableAdapter = new WindowsFormsApplication1.DatabaseDataSet1TableAdapters.Aktivitat_artTableAdapter();
            this.databaseDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new WindowsFormsApplication1.DatabaseDataSet();
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aktivitatartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new WindowsFormsApplication1.DatabaseDataSet1();
            this.groupprodactBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.подробнееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupprodactBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.group_prodactTableAdapter1 = new WindowsFormsApplication1.DatabaseDataSetTableAdapters.group_prodactTableAdapter();
            this.produktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produktTableAdapter = new WindowsFormsApplication1.DatabaseDataSetTableAdapters.produktTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.prodactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupprodactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktivitatartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupprodactBindingSource2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupprodactBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupprodactBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // group_prodactTableAdapter
            // 
            this.group_prodactTableAdapter.ClearBeforeFill = true;
            // 
            // aktivitat_artTableAdapter
            // 
            this.aktivitat_artTableAdapter.ClearBeforeFill = true;
            // 
            // databaseDataSetBindingSource1
            // 
            this.databaseDataSetBindingSource1.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource1.Position = 0;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseDataSetBindingSource
            // 
            this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource.Position = 0;
            // 
            // aktivitatartBindingSource
            // 
            this.aktivitatartBindingSource.DataMember = "Aktivitat_art";
            this.aktivitatartBindingSource.DataSource = this.databaseDataSet1;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupprodactBindingSource2
            // 
            this.groupprodactBindingSource2.DataMember = "group_prodact";
            this.groupprodactBindingSource2.DataSource = this.databaseDataSet1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подробнееToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 26);
            // 
            // подробнееToolStripMenuItem
            // 
            this.подробнееToolStripMenuItem.Name = "подробнееToolStripMenuItem";
            this.подробнееToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.подробнееToolStripMenuItem.Text = "Подробнее";
            // 
            // groupprodactBindingSource1
            // 
            this.groupprodactBindingSource1.DataMember = "group_prodact";
            this.groupprodactBindingSource1.DataSource = this.databaseDataSet;
            // 
            // group_prodactTableAdapter1
            // 
            this.group_prodactTableAdapter1.ClearBeforeFill = true;
            // 
            // produktBindingSource
            // 
            this.produktBindingSource.DataMember = "produkt";
            this.produktBindingSource.DataSource = this.databaseDataSet;
            // 
            // produktTableAdapter
            // 
            this.produktTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = global::WindowsFormsApplication1.Properties.Resources.SettingsN;
            this.button7.Location = new System.Drawing.Point(3, 370);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 55);
            this.button7.TabIndex = 21;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.MouseLeave += new System.EventHandler(this.button7_MouseLeave);
            this.button7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button7_MouseMove);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::WindowsFormsApplication1.Properties.Resources.HelpN;
            this.button6.Location = new System.Drawing.Point(3, 308);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 55);
            this.button6.TabIndex = 20;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            this.button6.MouseLeave += new System.EventHandler(this.button6_MouseLeave);
            this.button6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button6_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::WindowsFormsApplication1.Properties.Resources.BludoN;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 55);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::WindowsFormsApplication1.Properties.Resources.GrafN;
            this.button5.Location = new System.Drawing.Point(3, 247);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 55);
            this.button5.TabIndex = 19;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            this.button5.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            this.button5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button5_MouseMove);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::WindowsFormsApplication1.Properties.Resources.WesN;
            this.button2.Location = new System.Drawing.Point(3, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 55);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave_1);
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_MouseMove);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::WindowsFormsApplication1.Properties.Resources.KorsN;
            this.button4.Location = new System.Drawing.Point(3, 186);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 55);
            this.button4.TabIndex = 18;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.button4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button4_MouseMove);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::WindowsFormsApplication1.Properties.Resources.KalkN;
            this.button3.Location = new System.Drawing.Point(3, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 55);
            this.button3.TabIndex = 17;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.button3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button3_MouseMove);
            // 
            // ArbeitFenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(980, 434);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "ArbeitFenster";
            this.Text = "ArbeitFenster";
            this.Load += new System.EventHandler(this.ArbeitFenster_Load);
            this.ResizeBegin += new System.EventHandler(this.ArbeitFenster_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.ArbeitFenster_ResizeEnd);
            this.Resize += new System.EventHandler(this.ArbeitFenster_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktivitatartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupprodactBindingSource2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupprodactBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupprodactBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource groupprodactBindingSource2;
        private DatabaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem подробнееToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.BindingSource aktivitatartBindingSource;
        private DatabaseDataSet1TableAdapters.group_prodactTableAdapter group_prodactTableAdapter;
        private DatabaseDataSet1TableAdapters.Aktivitat_artTableAdapter aktivitat_artTableAdapter;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        private System.Windows.Forms.BindingSource groupprodactBindingSource1;
        private DatabaseDataSetTableAdapters.group_prodactTableAdapter group_prodactTableAdapter1;
        private System.Windows.Forms.BindingSource produktBindingSource;
        private System.Windows.Forms.BindingSource prodactBindingSource;
        private System.Windows.Forms.BindingSource groupprodactBindingSource;
        private DatabaseDataSetTableAdapters.produktTableAdapter produktTableAdapter;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}