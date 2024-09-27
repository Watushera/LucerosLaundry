namespace LucerosLaundry
{
    partial class frmcustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcustomer));
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.dateTimePickerdashboard = new System.Windows.Forms.DateTimePicker();
            this.picBoxInsert = new System.Windows.Forms.PictureBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnreturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmboxgender = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInsert)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfullname
            // 
            this.txtfullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtfullname.Location = new System.Drawing.Point(177, 83);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(176, 22);
            this.txtfullname.TabIndex = 0;
            this.txtfullname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtaddress
            // 
            this.txtaddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtaddress.Location = new System.Drawing.Point(177, 117);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(176, 22);
            this.txtaddress.TabIndex = 2;
            // 
            // txtemail
            // 
            this.txtemail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtemail.Location = new System.Drawing.Point(177, 145);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(176, 22);
            this.txtemail.TabIndex = 3;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // txtnumber
            // 
            this.txtnumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnumber.Location = new System.Drawing.Point(177, 202);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(176, 22);
            this.txtnumber.TabIndex = 4;
            // 
            // dateTimePickerdashboard
            // 
            this.dateTimePickerdashboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerdashboard.Location = new System.Drawing.Point(177, 174);
            this.dateTimePickerdashboard.Name = "dateTimePickerdashboard";
            this.dateTimePickerdashboard.Size = new System.Drawing.Size(176, 22);
            this.dateTimePickerdashboard.TabIndex = 5;
            // 
            // picBoxInsert
            // 
            this.picBoxInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBoxInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxInsert.BackgroundImage")));
            this.picBoxInsert.Location = new System.Drawing.Point(440, 83);
            this.picBoxInsert.Name = "picBoxInsert";
            this.picBoxInsert.Size = new System.Drawing.Size(153, 106);
            this.picBoxInsert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxInsert.TabIndex = 8;
            this.picBoxInsert.TabStop = false;
            // 
            // btninsert
            // 
            this.btninsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btninsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btninsert.BackgroundImage")));
            this.btninsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btninsert.Location = new System.Drawing.Point(479, 195);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 37);
            this.btninsert.TabIndex = 9;
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnadd
            // 
            this.btnadd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnadd.BackgroundImage")));
            this.btnadd.Location = new System.Drawing.Point(479, 345);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 10;
            this.btnadd.Text = "ADD CUSTOMER";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnreturn
            // 
            this.btnreturn.Location = new System.Drawing.Point(304, 412);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(75, 23);
            this.btnreturn.TabIndex = 11;
            this.btnreturn.Text = "RETURN";
            this.btnreturn.UseVisualStyleBackColor = true;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "FULL NAME";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "ADDRESS";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "EMAIL ADDRESS";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "BIRTHDAY";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "CONTACT NUMBER";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "GENDER";
            // 
            // cmboxgender
            // 
            this.cmboxgender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmboxgender.FormattingEnabled = true;
            this.cmboxgender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cmboxgender.Location = new System.Drawing.Point(177, 233);
            this.cmboxgender.Name = "cmboxgender";
            this.cmboxgender.Size = new System.Drawing.Size(176, 24);
            this.cmboxgender.TabIndex = 19;
            // 
            // frmcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(658, 447);
            this.Controls.Add(this.cmboxgender);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.picBoxInsert);
            this.Controls.Add(this.dateTimePickerdashboard);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtfullname);
            this.Name = "frmcustomer";
            this.Text = "frmcustomer";
            this.Load += new System.EventHandler(this.frmcustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInsert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.DateTimePicker dateTimePickerdashboard;
        private System.Windows.Forms.PictureBox picBoxInsert;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmboxgender;
    }
}