namespace LucerosLaundry
{
    partial class frmeditcustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmeditcustomer));
            this.cmboxgender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnreturn = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.picBoxInsert = new System.Windows.Forms.PictureBox();
            this.dateTimePickerdashboard = new System.Windows.Forms.DateTimePicker();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtfullname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInsert)).BeginInit();
            this.SuspendLayout();
            // 
            // cmboxgender
            // 
            this.cmboxgender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmboxgender.FormattingEnabled = true;
            this.cmboxgender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cmboxgender.Location = new System.Drawing.Point(265, 199);
            this.cmboxgender.Name = "cmboxgender";
            this.cmboxgender.Size = new System.Drawing.Size(176, 24);
            this.cmboxgender.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 50;
            this.label7.Text = "GENDER";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "CONTACT NUMBER";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "BIRTHDAY";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "EMAIL ADDRESS";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "ADDRESS";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "FULL NAME";
            // 
            // btnreturn
            // 
            this.btnreturn.Location = new System.Drawing.Point(392, 378);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(75, 23);
            this.btnreturn.TabIndex = 44;
            this.btnreturn.Text = "RETURN";
            this.btnreturn.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnadd.BackgroundImage")));
            this.btnadd.Location = new System.Drawing.Point(567, 311);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 43;
            this.btnadd.Text = "EDIT";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btninsert
            // 
            this.btninsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btninsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btninsert.BackgroundImage")));
            this.btninsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btninsert.Location = new System.Drawing.Point(567, 161);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 37);
            this.btninsert.TabIndex = 42;
            this.btninsert.UseVisualStyleBackColor = true;
            // 
            // picBoxInsert
            // 
            this.picBoxInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBoxInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxInsert.BackgroundImage")));
            this.picBoxInsert.Location = new System.Drawing.Point(528, 49);
            this.picBoxInsert.Name = "picBoxInsert";
            this.picBoxInsert.Size = new System.Drawing.Size(153, 106);
            this.picBoxInsert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxInsert.TabIndex = 41;
            this.picBoxInsert.TabStop = false;
            // 
            // dateTimePickerdashboard
            // 
            this.dateTimePickerdashboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerdashboard.Location = new System.Drawing.Point(265, 140);
            this.dateTimePickerdashboard.Name = "dateTimePickerdashboard";
            this.dateTimePickerdashboard.Size = new System.Drawing.Size(176, 22);
            this.dateTimePickerdashboard.TabIndex = 40;
            // 
            // txtnumber
            // 
            this.txtnumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnumber.Location = new System.Drawing.Point(265, 168);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(176, 22);
            this.txtnumber.TabIndex = 39;
            // 
            // txtemail
            // 
            this.txtemail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtemail.Location = new System.Drawing.Point(265, 111);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(176, 22);
            this.txtemail.TabIndex = 38;
            // 
            // txtaddress
            // 
            this.txtaddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtaddress.Location = new System.Drawing.Point(265, 83);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(176, 22);
            this.txtaddress.TabIndex = 37;
            // 
            // txtfullname
            // 
            this.txtfullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtfullname.Location = new System.Drawing.Point(265, 49);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(176, 22);
            this.txtfullname.TabIndex = 36;
            // 
            // frmeditcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "frmeditcustomer";
            this.Text = "frmeditcustomer";
            this.Load += new System.EventHandler(this.frmeditcustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInsert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboxgender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.PictureBox picBoxInsert;
        private System.Windows.Forms.DateTimePicker dateTimePickerdashboard;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtfullname;
    }
}