
namespace SAA_AD_Revisi
{
    partial class FormPesanan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesanan));
            this.label2 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPesanan = new System.Windows.Forms.Label();
            this.labelPoin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBoxHome = new System.Windows.Forms.PictureBox();
            this.pbDisplay = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).BeginInit();
            this.SuspendLayout();
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
            this.labelPesanan.Location = new System.Drawing.Point(96, 529);
            this.labelPesanan.Name = "labelPesanan";
            this.labelPesanan.Size = new System.Drawing.Size(89, 35);
            this.labelPesanan.TabIndex = 1;
            this.labelPesanan.Text = "Profile";
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(301, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(380, 60);
            this.button1.TabIndex = 48;
            this.button1.Text = "Ongoing";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(682, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(380, 60);
            this.button2.TabIndex = 49;
            this.button2.Text = "Completed";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pBoxHome);
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
            this.panel1.TabIndex = 47;
            // 
            // pBoxHome
            // 
            this.pBoxHome.Image = global::SAA_AD_Revisi.Properties.Resources.HOME;
            this.pBoxHome.Location = new System.Drawing.Point(11, 11);
            this.pBoxHome.Margin = new System.Windows.Forms.Padding(2);
            this.pBoxHome.Name = "pBoxHome";
            this.pBoxHome.Size = new System.Drawing.Size(37, 37);
            this.pBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxHome.TabIndex = 41;
            this.pBoxHome.TabStop = false;
            this.pBoxHome.Click += new System.EventHandler(this.pBoxHome_Click);
            // 
            // pbDisplay
            // 
            this.pbDisplay.Image = global::SAA_AD_Revisi.Properties.Resources.user;
            this.pbDisplay.Location = new System.Drawing.Point(74, 65);
            this.pbDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbDisplay.Name = "pbDisplay";
            this.pbDisplay.Size = new System.Drawing.Size(150, 150);
            this.pbDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDisplay.TabIndex = 12;
            this.pbDisplay.TabStop = false;
            // 
            // FormPesanan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPesanan";
            this.Text = "Eatez";
            this.Load += new System.EventHandler(this.FormPesanan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbDisplay;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPesanan;
        private System.Windows.Forms.Label labelPoin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBoxHome;
    }
}