namespace LucerosLaundry
{
    partial class frmsearchcustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsearchcustomer));
            this.datagridvalue = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FULLNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BIRTHDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTACTNUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAILADD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btncustomerdelete = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pictureBoxsearch = new System.Windows.Forms.PictureBox();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridvalue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxsearch)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridvalue
            // 
            this.datagridvalue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datagridvalue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.datagridvalue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridvalue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.FULLNAME,
            this.BIRTHDATE,
            this.GENDER,
            this.ADDRESS,
            this.CONTACTNUMBER,
            this.EMAILADD});
            this.datagridvalue.Location = new System.Drawing.Point(-2, 51);
            this.datagridvalue.Name = "datagridvalue";
            this.datagridvalue.RowHeadersWidth = 51;
            this.datagridvalue.RowTemplate.Height = 24;
            this.datagridvalue.Size = new System.Drawing.Size(662, 276);
            this.datagridvalue.TabIndex = 1;
            this.datagridvalue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridvalue_CellContentClick);
            // 
            // clmID
            // 
            this.clmID.FillWeight = 83.60071F;
            this.clmID.HeaderText = "ID";
            this.clmID.MinimumWidth = 6;
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.Width = 49;
            // 
            // FULLNAME
            // 
            this.FULLNAME.FillWeight = 83.60071F;
            this.FULLNAME.HeaderText = "FULLNAME";
            this.FULLNAME.MinimumWidth = 6;
            this.FULLNAME.Name = "FULLNAME";
            this.FULLNAME.Width = 107;
            // 
            // BIRTHDATE
            // 
            this.BIRTHDATE.FillWeight = 83.60071F;
            this.BIRTHDATE.HeaderText = "BIRTHDATE";
            this.BIRTHDATE.MinimumWidth = 6;
            this.BIRTHDATE.Name = "BIRTHDATE";
            this.BIRTHDATE.Width = 114;
            // 
            // GENDER
            // 
            this.GENDER.FillWeight = 83.60071F;
            this.GENDER.HeaderText = "GENDER";
            this.GENDER.MinimumWidth = 6;
            this.GENDER.Name = "GENDER";
            this.GENDER.Width = 94;
            // 
            // ADDRESS
            // 
            this.ADDRESS.FillWeight = 198.3957F;
            this.ADDRESS.HeaderText = "ADDRESS";
            this.ADDRESS.MinimumWidth = 6;
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.Width = 102;
            // 
            // CONTACTNUMBER
            // 
            this.CONTACTNUMBER.FillWeight = 83.60071F;
            this.CONTACTNUMBER.HeaderText = "CONTACTNUMBER";
            this.CONTACTNUMBER.MinimumWidth = 6;
            this.CONTACTNUMBER.Name = "CONTACTNUMBER";
            this.CONTACTNUMBER.Width = 160;
            // 
            // EMAILADD
            // 
            this.EMAILADD.FillWeight = 83.60071F;
            this.EMAILADD.HeaderText = "EMAILADD";
            this.EMAILADD.MinimumWidth = 6;
            this.EMAILADD.Name = "EMAILADD";
            this.EMAILADD.Width = 104;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(140, 22);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(299, 22);
            this.txtsearch.TabIndex = 2;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // btnsearch
            // 
            this.btnsearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsearch.BackgroundImage")));
            this.btnsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsearch.Location = new System.Drawing.Point(454, 22);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(99, 23);
            this.btnsearch.TabIndex = 0;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btncustomerdelete
            // 
            this.btncustomerdelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btncustomerdelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncustomerdelete.BackgroundImage")));
            this.btncustomerdelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncustomerdelete.Location = new System.Drawing.Point(536, 333);
            this.btncustomerdelete.Name = "btncustomerdelete";
            this.btncustomerdelete.Size = new System.Drawing.Size(110, 23);
            this.btncustomerdelete.TabIndex = 4;
            this.btncustomerdelete.Text = "DELETE";
            this.btncustomerdelete.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(533, 376);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 16);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total:";
            // 
            // pictureBoxsearch
            // 
            this.pictureBoxsearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxsearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxsearch.BackgroundImage")));
            this.pictureBoxsearch.Location = new System.Drawing.Point(32, 343);
            this.pictureBoxsearch.Name = "pictureBoxsearch";
            this.pictureBoxsearch.Size = new System.Drawing.Size(161, 92);
            this.pictureBoxsearch.TabIndex = 6;
            this.pictureBoxsearch.TabStop = false;
            // 
            // btnedit
            // 
            this.btnedit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnedit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnedit.BackgroundImage")));
            this.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnedit.Location = new System.Drawing.Point(420, 333);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(110, 23);
            this.btnedit.TabIndex = 7;
            this.btnedit.Text = "EDIT";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btndelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndelete.BackgroundImage")));
            this.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btndelete.Location = new System.Drawing.Point(304, 333);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(110, 23);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // frmsearchcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(658, 447);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.pictureBoxsearch);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btncustomerdelete);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.datagridvalue);
            this.Controls.Add(this.btnsearch);
            this.Name = "frmsearchcustomer";
            this.Text = "frmsearchcustomer";
            ((System.ComponentModel.ISupportInitialize)(this.datagridvalue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxsearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView datagridvalue;
        private System.Windows.Forms.TextBox txtsearch;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btncustomerdelete;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FULLNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn BIRTHDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn GENDER;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTACTNUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAILADD;
        private System.Windows.Forms.PictureBox pictureBoxsearch;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
    }
}