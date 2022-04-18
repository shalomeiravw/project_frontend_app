
namespace SAA_AD_Revisi
{
    partial class FormComplete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComplete));
            this.btnOngoing = new System.Windows.Forms.Button();
            this.panelProfil = new System.Windows.Forms.Panel();
            this.pBoxHome = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbDisplay = new System.Windows.Forms.PictureBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPesanan = new System.Windows.Forms.Label();
            this.labelPoin = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.panelProfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOngoing
            // 
            this.btnOngoing.BackColor = System.Drawing.Color.Transparent;
            this.btnOngoing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOngoing.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOngoing.Location = new System.Drawing.Point(300, 0);
            this.btnOngoing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOngoing.Name = "btnOngoing";
            this.btnOngoing.Size = new System.Drawing.Size(380, 60);
            this.btnOngoing.TabIndex = 54;
            this.btnOngoing.Text = "Ongoing";
            this.btnOngoing.UseVisualStyleBackColor = false;
            this.btnOngoing.Click += new System.EventHandler(this.btnOngoing_Click);
            // 
            // panelProfil
            // 
            this.panelProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelProfil.Controls.Add(this.pBoxHome);
            this.panelProfil.Controls.Add(this.label2);
            this.panelProfil.Controls.Add(this.pbDisplay);
            this.panelProfil.Controls.Add(this.labelUsername);
            this.panelProfil.Controls.Add(this.labelPesanan);
            this.panelProfil.Controls.Add(this.labelPoin);
            this.panelProfil.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelProfil.Location = new System.Drawing.Point(0, 0);
            this.panelProfil.Margin = new System.Windows.Forms.Padding(4);
            this.panelProfil.Name = "panelProfil";
            this.panelProfil.Size = new System.Drawing.Size(300, 673);
            this.panelProfil.TabIndex = 53;
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
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnComplete.Enabled = false;
            this.btnComplete.FlatAppearance.BorderSize = 0;
            this.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplete.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.Location = new System.Drawing.Point(679, 0);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(380, 60);
            this.btnComplete.TabIndex = 55;
            this.btnComplete.Text = "Completed";
            this.btnComplete.UseVisualStyleBackColor = false;
            // 
            // FormComplete
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.btnOngoing);
            this.Controls.Add(this.panelProfil);
            this.Controls.Add(this.btnComplete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormComplete";
            this.Text = "Eatez";
            this.Load += new System.EventHandler(this.FormComplete_Load);
            this.panelProfil.ResumeLayout(false);
            this.panelProfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOngoing;
        private System.Windows.Forms.Panel panelProfil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbDisplay;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPesanan;
        private System.Windows.Forms.Label labelPoin;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.PictureBox pBoxHome;
    }
}