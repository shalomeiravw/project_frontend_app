
namespace SAA_AD_Revisi
{
    partial class FormOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            this.labelReview = new System.Windows.Forms.Label();
            this.buttonAddCart = new System.Windows.Forms.Button();
            this.tBoxJumlah = new System.Windows.Forms.TextBox();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonKurang = new System.Windows.Forms.Button();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelHarga1 = new System.Windows.Forms.Label();
            this.labelDeskripsi = new System.Windows.Forms.Label();
            this.labelDeskripsi1 = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelNamaMenu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonFav = new System.Windows.Forms.Button();
            this.panelRiview = new System.Windows.Forms.Panel();
            this.pBoxFotoMenu = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFotoMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // labelReview
            // 
            this.labelReview.AutoSize = true;
            this.labelReview.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReview.Location = new System.Drawing.Point(90, 323);
            this.labelReview.Name = "labelReview";
            this.labelReview.Size = new System.Drawing.Size(69, 24);
            this.labelReview.TabIndex = 21;
            this.labelReview.Text = "Review";
            // 
            // buttonAddCart
            // 
            this.buttonAddCart.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCart.Location = new System.Drawing.Point(400, 252);
            this.buttonAddCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddCart.Name = "buttonAddCart";
            this.buttonAddCart.Size = new System.Drawing.Size(112, 26);
            this.buttonAddCart.TabIndex = 3;
            this.buttonAddCart.Text = "Add To Cart";
            this.buttonAddCart.UseVisualStyleBackColor = true;
            this.buttonAddCart.Click += new System.EventHandler(this.buttonAddCart_Click);
            // 
            // tBoxJumlah
            // 
            this.tBoxJumlah.Location = new System.Drawing.Point(400, 221);
            this.tBoxJumlah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxJumlah.Name = "tBoxJumlah";
            this.tBoxJumlah.Size = new System.Drawing.Size(112, 22);
            this.tBoxJumlah.TabIndex = 0;
            this.tBoxJumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTambah
            // 
            this.buttonTambah.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.Location = new System.Drawing.Point(518, 221);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(51, 21);
            this.buttonTambah.TabIndex = 2;
            this.buttonTambah.Text = "+";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // buttonKurang
            // 
            this.buttonKurang.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKurang.Location = new System.Drawing.Point(343, 221);
            this.buttonKurang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKurang.Name = "buttonKurang";
            this.buttonKurang.Size = new System.Drawing.Size(51, 21);
            this.buttonKurang.TabIndex = 2;
            this.buttonKurang.Text = "-";
            this.buttonKurang.UseVisualStyleBackColor = true;
            this.buttonKurang.Click += new System.EventHandler(this.buttonKurang_Click);
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.Location = new System.Drawing.Point(399, 191);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(69, 17);
            this.labelHarga.TabIndex = 16;
            this.labelHarga.Text = "Rp. XX.XXX";
            // 
            // labelHarga1
            // 
            this.labelHarga1.AutoSize = true;
            this.labelHarga1.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga1.Location = new System.Drawing.Point(340, 191);
            this.labelHarga1.Name = "labelHarga1";
            this.labelHarga1.Size = new System.Drawing.Size(50, 17);
            this.labelHarga1.TabIndex = 15;
            this.labelHarga1.Text = "Harga :";
            // 
            // labelDeskripsi
            // 
            this.labelDeskripsi.AutoSize = true;
            this.labelDeskripsi.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeskripsi.Location = new System.Drawing.Point(340, 136);
            this.labelDeskripsi.Name = "labelDeskripsi";
            this.labelDeskripsi.Size = new System.Drawing.Size(12, 51);
            this.labelDeskripsi.TabIndex = 14;
            this.labelDeskripsi.Text = "-\r\n-\r\n-";
            // 
            // labelDeskripsi1
            // 
            this.labelDeskripsi1.AutoSize = true;
            this.labelDeskripsi1.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeskripsi1.Location = new System.Drawing.Point(340, 111);
            this.labelDeskripsi1.Name = "labelDeskripsi1";
            this.labelDeskripsi1.Size = new System.Drawing.Size(65, 17);
            this.labelDeskripsi1.TabIndex = 13;
            this.labelDeskripsi1.Text = "Deskripsi :";
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRating.Location = new System.Drawing.Point(338, 82);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(73, 29);
            this.labelRating.TabIndex = 12;
            this.labelRating.Text = "*****";
            // 
            // labelNamaMenu
            // 
            this.labelNamaMenu.AutoSize = true;
            this.labelNamaMenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaMenu.Location = new System.Drawing.Point(339, 50);
            this.labelNamaMenu.Name = "labelNamaMenu";
            this.labelNamaMenu.Size = new System.Drawing.Size(122, 24);
            this.labelNamaMenu.TabIndex = 11;
            this.labelNamaMenu.Text = "NAMA MENU";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonFav);
            this.panel1.Controls.Add(this.panelRiview);
            this.panel1.Controls.Add(this.labelReview);
            this.panel1.Controls.Add(this.buttonAddCart);
            this.panel1.Controls.Add(this.tBoxJumlah);
            this.panel1.Controls.Add(this.buttonTambah);
            this.panel1.Controls.Add(this.buttonKurang);
            this.panel1.Controls.Add(this.labelHarga);
            this.panel1.Controls.Add(this.labelHarga1);
            this.panel1.Controls.Add(this.labelDeskripsi);
            this.panel1.Controls.Add(this.labelDeskripsi1);
            this.panel1.Controls.Add(this.labelRating);
            this.panel1.Controls.Add(this.labelNamaMenu);
            this.panel1.Controls.Add(this.pBoxFotoMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 553);
            this.panel1.TabIndex = 10;
            // 
            // buttonFav
            // 
            this.buttonFav.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFav.Location = new System.Drawing.Point(536, 50);
            this.buttonFav.Name = "buttonFav";
            this.buttonFav.Size = new System.Drawing.Size(33, 23);
            this.buttonFav.TabIndex = 27;
            this.buttonFav.Text = "<3";
            this.buttonFav.UseVisualStyleBackColor = true;
            this.buttonFav.Click += new System.EventHandler(this.buttonFav_Click);
            // 
            // panelRiview
            // 
            this.panelRiview.AutoScroll = true;
            this.panelRiview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelRiview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRiview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRiview.Location = new System.Drawing.Point(0, 350);
            this.panelRiview.Name = "panelRiview";
            this.panelRiview.Size = new System.Drawing.Size(782, 203);
            this.panelRiview.TabIndex = 26;
            // 
            // pBoxFotoMenu
            // 
            this.pBoxFotoMenu.Location = new System.Drawing.Point(94, 50);
            this.pBoxFotoMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pBoxFotoMenu.Name = "pBoxFotoMenu";
            this.pBoxFotoMenu.Size = new System.Drawing.Size(200, 200);
            this.pBoxFotoMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxFotoMenu.TabIndex = 10;
            this.pBoxFotoMenu.TabStop = false;
            // 
            // FormOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOrder";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFotoMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelReview;
        private System.Windows.Forms.Button buttonAddCart;
        private System.Windows.Forms.TextBox tBoxJumlah;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonKurang;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label labelHarga1;
        private System.Windows.Forms.Label labelDeskripsi;
        private System.Windows.Forms.Label labelDeskripsi1;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelNamaMenu;
        private System.Windows.Forms.PictureBox pBoxFotoMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelRiview;
        private System.Windows.Forms.Button buttonFav;
    }
}