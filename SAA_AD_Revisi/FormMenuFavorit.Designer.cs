
namespace SAA_AD_Revisi
{
    partial class FormMenuFavorit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuFavorit));
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.buttonMenuFav = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbDisplay = new System.Windows.Forms.PictureBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPesanan = new System.Windows.Forms.Label();
            this.labelPoin = new System.Windows.Forms.Label();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonBackHome = new System.Windows.Forms.Button();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(368, 84);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(256, 30);
            this.tbSearch.TabIndex = 66;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // buttonMenuFav
            // 
            this.buttonMenuFav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonMenuFav.FlatAppearance.BorderSize = 0;
            this.buttonMenuFav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuFav.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuFav.Location = new System.Drawing.Point(681, 0);
            this.buttonMenuFav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMenuFav.Name = "buttonMenuFav";
            this.buttonMenuFav.Size = new System.Drawing.Size(380, 60);
            this.buttonMenuFav.TabIndex = 63;
            this.buttonMenuFav.Text = "Menu Favorit";
            this.buttonMenuFav.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pbHome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pbDisplay);
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Controls.Add(this.labelPesanan);
            this.panel1.Controls.Add(this.labelPoin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 673);
            this.panel1.TabIndex = 62;
            // 
            // pbHome
            // 
            this.pbHome.Image = global::SAA_AD_Revisi.Properties.Resources.HOME;
            this.pbHome.Location = new System.Drawing.Point(11, 11);
            this.pbHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(40, 37);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHome.TabIndex = 61;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.Location = new System.Drawing.Point(47, 297);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Point";
            // 
            // pbDisplay
            // 
            this.pbDisplay.Image = global::SAA_AD_Revisi.Properties.Resources.user;
            this.pbDisplay.Location = new System.Drawing.Point(74, 65);
            this.pbDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbDisplay.Name = "pbDisplay";
            this.pbDisplay.Size = new System.Drawing.Size(150, 150);
            this.pbDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDisplay.TabIndex = 12;
            this.pbDisplay.TabStop = false;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(97, 237);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(105, 24);
            this.labelUsername.TabIndex = 13;
            this.labelUsername.Text = "USERNAME";
            // 
            // labelPesanan
            // 
            this.labelPesanan.AutoSize = true;
            this.labelPesanan.BackColor = System.Drawing.Color.Transparent;
            this.labelPesanan.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesanan.ForeColor = System.Drawing.Color.White;
            this.labelPesanan.Location = new System.Drawing.Point(109, 552);
            this.labelPesanan.Name = "labelPesanan";
            this.labelPesanan.Size = new System.Drawing.Size(109, 35);
            this.labelPesanan.TabIndex = 1;
            this.labelPesanan.Text = "Pesanan";
            this.labelPesanan.Click += new System.EventHandler(this.labelPesanan_Click);
            // 
            // labelPoin
            // 
            this.labelPoin.AutoSize = true;
            this.labelPoin.BackColor = System.Drawing.Color.Transparent;
            this.labelPoin.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelPoin.ForeColor = System.Drawing.Color.White;
            this.labelPoin.Location = new System.Drawing.Point(212, 294);
            this.labelPoin.Name = "labelPoin";
            this.labelPoin.Size = new System.Drawing.Size(49, 29);
            this.labelPoin.TabIndex = 14;
            this.labelPoin.Text = "000";
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.Color.Transparent;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfile.Location = new System.Drawing.Point(300, 0);
            this.buttonProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(380, 60);
            this.buttonProfile.TabIndex = 64;
            this.buttonProfile.Text = "Edit Profile";
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonBackHome
            // 
            this.buttonBackHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonBackHome.FlatAppearance.BorderSize = 0;
            this.buttonBackHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackHome.Location = new System.Drawing.Point(166, 32);
            this.buttonBackHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBackHome.Name = "buttonBackHome";
            this.buttonBackHome.Size = new System.Drawing.Size(69, 54);
            this.buttonBackHome.TabIndex = 61;
            this.buttonBackHome.UseVisualStyleBackColor = false;
            // 
            // pbSearch
            // 
            this.pbSearch.Image = global::SAA_AD_Revisi.Properties.Resources.search;
            this.pbSearch.Location = new System.Drawing.Point(319, 84);
            this.pbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(30, 30);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 65;
            this.pbSearch.TabStop = false;
            // 
            // FormMenuFavorit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.buttonMenuFav);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.buttonProfile);
            this.Controls.Add(this.buttonBackHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenuFavorit";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.FormMenuFavorit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button buttonMenuFav;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbDisplay;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPesanan;
        private System.Windows.Forms.Label labelPoin;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonBackHome;
    }
}