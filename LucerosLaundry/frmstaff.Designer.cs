namespace LucerosLaundry
{
    partial class frmstaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmstaff));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmboxgender = new System.Windows.Forms.ComboBox();
            this.lblstaffgender = new System.Windows.Forms.Label();
            this.lblstaffnumber = new System.Windows.Forms.Label();
            this.lblstaffbirthday = new System.Windows.Forms.Label();
            this.lblstaffemail = new System.Windows.Forms.Label();
            this.lblstaffaddress = new System.Windows.Forms.Label();
            this.lblstaffname = new System.Windows.Forms.Label();
            this.btnaddstaff = new System.Windows.Forms.Button();
            this.btninsertstaff = new System.Windows.Forms.Button();
            this.picBoxInsertstaff = new System.Windows.Forms.PictureBox();
            this.dateTimePickerdashboard = new System.Windows.Forms.DateTimePicker();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.btnreturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInsertstaff)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(658, 447);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmboxgender
            // 
            this.cmboxgender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmboxgender.FormattingEnabled = true;
            this.cmboxgender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cmboxgender.Location = new System.Drawing.Point(177, 231);
            this.cmboxgender.Name = "cmboxgender";
            this.cmboxgender.Size = new System.Drawing.Size(176, 24);
            this.cmboxgender.TabIndex = 34;
            // 
            // lblstaffgender
            // 
            this.lblstaffgender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblstaffgender.AutoSize = true;
            this.lblstaffgender.Location = new System.Drawing.Point(33, 234);
            this.lblstaffgender.Name = "lblstaffgender";
            this.lblstaffgender.Size = new System.Drawing.Size(65, 16);
            this.lblstaffgender.TabIndex = 33;
            this.lblstaffgender.Text = "GENDER";
            // 
            // lblstaffnumber
            // 
            this.lblstaffnumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblstaffnumber.AutoSize = true;
            this.lblstaffnumber.Location = new System.Drawing.Point(33, 206);
            this.lblstaffnumber.Name = "lblstaffnumber";
            this.lblstaffnumber.Size = new System.Drawing.Size(134, 16);
            this.lblstaffnumber.TabIndex = 32;
            this.lblstaffnumber.Text = "CONTACT NUMBER";
            // 
            // lblstaffbirthday
            // 
            this.lblstaffbirthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblstaffbirthday.AutoSize = true;
            this.lblstaffbirthday.Location = new System.Drawing.Point(33, 172);
            this.lblstaffbirthday.Name = "lblstaffbirthday";
            this.lblstaffbirthday.Size = new System.Drawing.Size(76, 16);
            this.lblstaffbirthday.TabIndex = 31;
            this.lblstaffbirthday.Text = "BIRTHDAY";
            // 
            // lblstaffemail
            // 
            this.lblstaffemail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblstaffemail.AutoSize = true;
            this.lblstaffemail.Location = new System.Drawing.Point(33, 143);
            this.lblstaffemail.Name = "lblstaffemail";
            this.lblstaffemail.Size = new System.Drawing.Size(115, 16);
            this.lblstaffemail.TabIndex = 30;
            this.lblstaffemail.Text = "EMAIL ADDRESS";
            // 
            // lblstaffaddress
            // 
            this.lblstaffaddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblstaffaddress.AutoSize = true;
            this.lblstaffaddress.Location = new System.Drawing.Point(33, 115);
            this.lblstaffaddress.Name = "lblstaffaddress";
            this.lblstaffaddress.Size = new System.Drawing.Size(73, 16);
            this.lblstaffaddress.TabIndex = 29;
            this.lblstaffaddress.Text = "ADDRESS";
            // 
            // lblstaffname
            // 
            this.lblstaffname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblstaffname.AutoSize = true;
            this.lblstaffname.Location = new System.Drawing.Point(33, 82);
            this.lblstaffname.Name = "lblstaffname";
            this.lblstaffname.Size = new System.Drawing.Size(81, 16);
            this.lblstaffname.TabIndex = 28;
            this.lblstaffname.Text = "FULL NAME";
            // 
            // btnaddstaff
            // 
            this.btnaddstaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnaddstaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnaddstaff.BackgroundImage")));
            this.btnaddstaff.Location = new System.Drawing.Point(481, 340);
            this.btnaddstaff.Name = "btnaddstaff";
            this.btnaddstaff.Size = new System.Drawing.Size(75, 23);
            this.btnaddstaff.TabIndex = 27;
            this.btnaddstaff.Text = "ADD CUSTOMER";
            this.btnaddstaff.UseVisualStyleBackColor = true;
            // 
            // btninsertstaff
            // 
            this.btninsertstaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btninsertstaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btninsertstaff.BackgroundImage")));
            this.btninsertstaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btninsertstaff.Location = new System.Drawing.Point(481, 194);
            this.btninsertstaff.Name = "btninsertstaff";
            this.btninsertstaff.Size = new System.Drawing.Size(75, 37);
            this.btninsertstaff.TabIndex = 26;
            this.btninsertstaff.UseVisualStyleBackColor = true;
            // 
            // picBoxInsertstaff
            // 
            this.picBoxInsertstaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBoxInsertstaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxInsertstaff.BackgroundImage")));
            this.picBoxInsertstaff.Location = new System.Drawing.Point(441, 82);
            this.picBoxInsertstaff.Name = "picBoxInsertstaff";
            this.picBoxInsertstaff.Size = new System.Drawing.Size(153, 106);
            this.picBoxInsertstaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxInsertstaff.TabIndex = 25;
            this.picBoxInsertstaff.TabStop = false;
            // 
            // dateTimePickerdashboard
            // 
            this.dateTimePickerdashboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerdashboard.Location = new System.Drawing.Point(177, 172);
            this.dateTimePickerdashboard.Name = "dateTimePickerdashboard";
            this.dateTimePickerdashboard.Size = new System.Drawing.Size(176, 22);
            this.dateTimePickerdashboard.TabIndex = 24;
            // 
            // txtnumber
            // 
            this.txtnumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnumber.Location = new System.Drawing.Point(177, 200);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(176, 22);
            this.txtnumber.TabIndex = 23;
            // 
            // txtemail
            // 
            this.txtemail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtemail.Location = new System.Drawing.Point(177, 144);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(176, 22);
            this.txtemail.TabIndex = 22;
            // 
            // txtaddress
            // 
            this.txtaddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtaddress.Location = new System.Drawing.Point(177, 115);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(176, 22);
            this.txtaddress.TabIndex = 21;
            // 
            // txtfullname
            // 
            this.txtfullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtfullname.Location = new System.Drawing.Point(177, 82);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(176, 22);
            this.txtfullname.TabIndex = 20;
            // 
            // btnreturn
            // 
            this.btnreturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnreturn.Location = new System.Drawing.Point(278, 412);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(117, 23);
            this.btnreturn.TabIndex = 35;
            this.btnreturn.Text = "RETURN";
            this.btnreturn.UseVisualStyleBackColor = true;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // frmstaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(658, 447);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.cmboxgender);
            this.Controls.Add(this.lblstaffgender);
            this.Controls.Add(this.lblstaffnumber);
            this.Controls.Add(this.lblstaffbirthday);
            this.Controls.Add(this.lblstaffemail);
            this.Controls.Add(this.lblstaffaddress);
            this.Controls.Add(this.lblstaffname);
            this.Controls.Add(this.btnaddstaff);
            this.Controls.Add(this.btninsertstaff);
            this.Controls.Add(this.picBoxInsertstaff);
            this.Controls.Add(this.dateTimePickerdashboard);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtfullname);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmstaff";
            this.Text = "frmstaff";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInsertstaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmboxgender;
        private System.Windows.Forms.Label lblstaffgender;
        private System.Windows.Forms.Label lblstaffnumber;
        private System.Windows.Forms.Label lblstaffbirthday;
        private System.Windows.Forms.Label lblstaffemail;
        private System.Windows.Forms.Label lblstaffaddress;
        private System.Windows.Forms.Label lblstaffname;
        private System.Windows.Forms.Button btnaddstaff;
        private System.Windows.Forms.Button btninsertstaff;
        private System.Windows.Forms.PictureBox picBoxInsertstaff;
        private System.Windows.Forms.DateTimePicker dateTimePickerdashboard;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.Button btnreturn;
    }
}