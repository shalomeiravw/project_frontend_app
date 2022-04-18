
namespace SAA_AD_Revisi
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.buttonHi = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonPoin = new System.Windows.Forms.Button();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.dtpTanggalPesan = new System.Windows.Forms.DateTimePicker();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pBCart = new System.Windows.Forms.PictureBox();
            this.pBLogo = new System.Windows.Forms.PictureBox();
            this.pBFAQ = new System.Windows.Forms.PictureBox();
            this.panelProfile.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBFAQ)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHi
            // 
            this.buttonHi.BackColor = System.Drawing.Color.White;
            this.buttonHi.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHi.FlatAppearance.BorderSize = 0;
            this.buttonHi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHi.Location = new System.Drawing.Point(0, 0);
            this.buttonHi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHi.Name = "buttonHi";
            this.buttonHi.Size = new System.Drawing.Size(192, 34);
            this.buttonHi.TabIndex = 0;
            this.buttonHi.Text = "Hi, ...";
            this.buttonHi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHi.UseVisualStyleBackColor = false;
            this.buttonHi.Click += new System.EventHandler(this.buttonHi_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProfile.FlatAppearance.BorderSize = 0;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Location = new System.Drawing.Point(0, 34);
            this.buttonProfile.Margin = new System.Windows.Forms.Padding(2);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(192, 34);
            this.buttonProfile.TabIndex = 1;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonPoin
            // 
            this.buttonPoin.BackColor = System.Drawing.Color.White;
            this.buttonPoin.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPoin.Enabled = false;
            this.buttonPoin.FlatAppearance.BorderSize = 0;
            this.buttonPoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPoin.Location = new System.Drawing.Point(0, 68);
            this.buttonPoin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPoin.Name = "buttonPoin";
            this.buttonPoin.Size = new System.Drawing.Size(192, 34);
            this.buttonPoin.TabIndex = 3;
            this.buttonPoin.Text = "Poin                                000";
            this.buttonPoin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPoin.UseVisualStyleBackColor = false;
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonSignOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSignOut.FlatAppearance.BorderSize = 0;
            this.buttonSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignOut.Location = new System.Drawing.Point(0, 102);
            this.buttonSignOut.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(192, 36);
            this.buttonSignOut.TabIndex = 4;
            this.buttonSignOut.Text = "Sign Out";
            this.buttonSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSignOut.UseVisualStyleBackColor = false;
            this.buttonSignOut.Click += new System.EventHandler(this.buttonSignOut_Click);
            // 
            // panelProfile
            // 
            this.panelProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelProfile.Controls.Add(this.buttonSignOut);
            this.panelProfile.Controls.Add(this.buttonPoin);
            this.panelProfile.Controls.Add(this.buttonProfile);
            this.panelProfile.Controls.Add(this.buttonHi);
            this.panelProfile.Location = new System.Drawing.Point(790, 30);
            this.panelProfile.Margin = new System.Windows.Forms.Padding(2);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(192, 32);
            this.panelProfile.TabIndex = 7;
            // 
            // dtpTanggalPesan
            // 
            this.dtpTanggalPesan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggalPesan.Location = new System.Drawing.Point(418, 30);
            this.dtpTanggalPesan.Name = "dtpTanggalPesan";
            this.dtpTanggalPesan.Size = new System.Drawing.Size(215, 32);
            this.dtpTanggalPesan.TabIndex = 11;
            this.dtpTanggalPesan.ValueChanged += new System.EventHandler(this.dtpTanggalPesan_ValueChanged);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelMenu.Controls.Add(this.dtpTanggalPesan);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.pBCart);
            this.panelMenu.Controls.Add(this.pBLogo);
            this.panelMenu.Controls.Add(this.pBFAQ);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1062, 93);
            this.panelMenu.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pesan untuk tanggal: ";
            // 
            // pBCart
            // 
            this.pBCart.Image = global::SAA_AD_Revisi.Properties.Resources.CART;
            this.pBCart.Location = new System.Drawing.Point(1010, 35);
            this.pBCart.Name = "pBCart";
            this.pBCart.Size = new System.Drawing.Size(30, 30);
            this.pBCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBCart.TabIndex = 9;
            this.pBCart.TabStop = false;
            this.pBCart.Click += new System.EventHandler(this.pBCart_Click);
            // 
            // pBLogo
            // 
            this.pBLogo.Image = global::SAA_AD_Revisi.Properties.Resources.LOGO;
            this.pBLogo.Location = new System.Drawing.Point(12, 12);
            this.pBLogo.Name = "pBLogo";
            this.pBLogo.Size = new System.Drawing.Size(118, 66);
            this.pBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBLogo.TabIndex = 11;
            this.pBLogo.TabStop = false;
            this.pBLogo.Click += new System.EventHandler(this.FormHome_Load);
            // 
            // pBFAQ
            // 
            this.pBFAQ.Image = global::SAA_AD_Revisi.Properties.Resources.FAQ;
            this.pBFAQ.Location = new System.Drawing.Point(667, 32);
            this.pBFAQ.Name = "pBFAQ";
            this.pBFAQ.Size = new System.Drawing.Size(30, 30);
            this.pBFAQ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBFAQ.TabIndex = 10;
            this.pBFAQ.TabStop = false;
            this.pBFAQ.Click += new System.EventHandler(this.pBFAQ_Click);
            // 
            // FormHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.panelProfile);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.Text = "Eatez";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.panelProfile.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBFAQ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBLogo;
        private System.Windows.Forms.PictureBox pBCart;
        private System.Windows.Forms.PictureBox pBFAQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHi;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonPoin;
        private System.Windows.Forms.Button buttonSignOut;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.DateTimePicker dtpTanggalPesan;
        private System.Windows.Forms.Panel panelMenu;
    }
}