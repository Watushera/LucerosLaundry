namespace LucerosLaundry
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.paneldashboardoutput = new System.Windows.Forms.Panel();
            this.paneldashboardselect = new System.Windows.Forms.Panel();
            this.btnsearchcustomer = new System.Windows.Forms.Button();
            this.btndashboardgarments = new System.Windows.Forms.Button();
            this.btnservices = new System.Windows.Forms.Button();
            this.btnstaff = new System.Windows.Forms.Button();
            this.btncustomer = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnprofile = new System.Windows.Forms.Button();
            this.paneldashboardselect.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneldashboardoutput
            // 
            this.paneldashboardoutput.BackColor = System.Drawing.Color.Transparent;
            this.paneldashboardoutput.Location = new System.Drawing.Point(228, 3);
            this.paneldashboardoutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paneldashboardoutput.Name = "paneldashboardoutput";
            this.paneldashboardoutput.Size = new System.Drawing.Size(676, 494);
            this.paneldashboardoutput.TabIndex = 0;
            this.paneldashboardoutput.Paint += new System.Windows.Forms.PaintEventHandler(this.paneldashboardoutput_Paint);
            // 
            // paneldashboardselect
            // 
            this.paneldashboardselect.BackColor = System.Drawing.Color.Transparent;
            this.paneldashboardselect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.paneldashboardselect.Controls.Add(this.btnsearchcustomer);
            this.paneldashboardselect.Controls.Add(this.btndashboardgarments);
            this.paneldashboardselect.Controls.Add(this.btnservices);
            this.paneldashboardselect.Controls.Add(this.btnstaff);
            this.paneldashboardselect.Controls.Add(this.btncustomer);
            this.paneldashboardselect.Controls.Add(this.btnlogout);
            this.paneldashboardselect.Controls.Add(this.btnprofile);
            this.paneldashboardselect.Location = new System.Drawing.Point(12, 3);
            this.paneldashboardselect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paneldashboardselect.Name = "paneldashboardselect";
            this.paneldashboardselect.Size = new System.Drawing.Size(211, 494);
            this.paneldashboardselect.TabIndex = 1;
            // 
            // btnsearchcustomer
            // 
            this.btnsearchcustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsearchcustomer.BackgroundImage")));
            this.btnsearchcustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsearchcustomer.Location = new System.Drawing.Point(11, 139);
            this.btnsearchcustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsearchcustomer.Name = "btnsearchcustomer";
            this.btnsearchcustomer.Size = new System.Drawing.Size(197, 53);
            this.btnsearchcustomer.TabIndex = 8;
            this.btnsearchcustomer.UseVisualStyleBackColor = true;
            this.btnsearchcustomer.Click += new System.EventHandler(this.btnsearchcustomer_Click);
            // 
            // btndashboardgarments
            // 
            this.btndashboardgarments.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndashboardgarments.BackgroundImage")));
            this.btndashboardgarments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndashboardgarments.Location = new System.Drawing.Point(11, 196);
            this.btndashboardgarments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndashboardgarments.Name = "btndashboardgarments";
            this.btndashboardgarments.Size = new System.Drawing.Size(197, 57);
            this.btndashboardgarments.TabIndex = 7;
            this.btndashboardgarments.UseVisualStyleBackColor = true;
            this.btndashboardgarments.Click += new System.EventHandler(this.btndashboardgarments_Click);
            // 
            // btnservices
            // 
            this.btnservices.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnservices.BackgroundImage")));
            this.btnservices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnservices.Location = new System.Drawing.Point(11, 318);
            this.btnservices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnservices.Name = "btnservices";
            this.btnservices.Size = new System.Drawing.Size(197, 57);
            this.btnservices.TabIndex = 4;
            this.btnservices.UseVisualStyleBackColor = true;
            this.btnservices.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnstaff
            // 
            this.btnstaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnstaff.BackgroundImage")));
            this.btnstaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnstaff.Location = new System.Drawing.Point(11, 257);
            this.btnstaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnstaff.Name = "btnstaff";
            this.btnstaff.Size = new System.Drawing.Size(197, 57);
            this.btnstaff.TabIndex = 3;
            this.btnstaff.UseVisualStyleBackColor = true;
            this.btnstaff.Click += new System.EventHandler(this.btnstaff_Click);
            // 
            // btncustomer
            // 
            this.btncustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncustomer.BackgroundImage")));
            this.btncustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncustomer.Location = new System.Drawing.Point(11, 82);
            this.btncustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Size = new System.Drawing.Size(197, 53);
            this.btncustomer.TabIndex = 1;
            this.btncustomer.UseVisualStyleBackColor = true;
            this.btncustomer.Click += new System.EventHandler(this.btncustomer_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnlogout.Location = new System.Drawing.Point(7, 459);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(195, 23);
            this.btnlogout.TabIndex = 5;
            this.btnlogout.Text = "LOG OUT";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnprofile
            // 
            this.btnprofile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnprofile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnprofile.BackgroundImage")));
            this.btnprofile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnprofile.Location = new System.Drawing.Point(11, 25);
            this.btnprofile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnprofile.Name = "btnprofile";
            this.btnprofile.Size = new System.Drawing.Size(197, 53);
            this.btnprofile.TabIndex = 0;
            this.btnprofile.UseVisualStyleBackColor = true;
            this.btnprofile.Click += new System.EventHandler(this.btnprofile_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(923, 510);
            this.Controls.Add(this.paneldashboardselect);
            this.Controls.Add(this.paneldashboardoutput);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.paneldashboardselect.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneldashboardoutput;
        private System.Windows.Forms.Panel paneldashboardselect;
        private System.Windows.Forms.Button btnprofile;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnservices;
        private System.Windows.Forms.Button btnstaff;
        private System.Windows.Forms.Button btncustomer;
        private System.Windows.Forms.Button btndashboardgarments;
        private System.Windows.Forms.Button btnsearchcustomer;
    }
}