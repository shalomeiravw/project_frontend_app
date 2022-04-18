
namespace SAA_AD_Revisi
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.cBShowPass = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmailLogin = new System.Windows.Forms.TextBox();
            this.textBoxPasswordLogin = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelForgotPass = new System.Windows.Forms.Label();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblEmailWarn = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cBShowPass
            // 
            this.cBShowPass.AutoSize = true;
            this.cBShowPass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBShowPass.Location = new System.Drawing.Point(435, 346);
            this.cBShowPass.Name = "cBShowPass";
            this.cBShowPass.Size = new System.Drawing.Size(161, 28);
            this.cBShowPass.TabIndex = 8;
            this.cBShowPass.Text = "Show Password";
            this.cBShowPass.UseVisualStyleBackColor = true;
            this.cBShowPass.CheckedChanged += new System.EventHandler(this.cBShowPass_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "E-mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 98);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome Back";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxEmailLogin
            // 
            this.textBoxEmailLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmailLogin.Location = new System.Drawing.Point(101, 233);
            this.textBoxEmailLogin.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmailLogin.Name = "textBoxEmailLogin";
            this.textBoxEmailLogin.Size = new System.Drawing.Size(445, 34);
            this.textBoxEmailLogin.TabIndex = 0;
            this.textBoxEmailLogin.TextChanged += new System.EventHandler(this.textBoxEmailLogin_TextChanged);
            // 
            // textBoxPasswordLogin
            // 
            this.textBoxPasswordLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordLogin.Location = new System.Drawing.Point(101, 337);
            this.textBoxPasswordLogin.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPasswordLogin.Name = "textBoxPasswordLogin";
            this.textBoxPasswordLogin.Size = new System.Drawing.Size(306, 34);
            this.textBoxPasswordLogin.TabIndex = 1;
            this.textBoxPasswordLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPasswordLogin_KeyDown);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.White;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonLogin.Location = new System.Drawing.Point(294, 453);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(141, 53);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Log In";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelForgotPass
            // 
            this.labelForgotPass.AutoSize = true;
            this.labelForgotPass.BackColor = System.Drawing.Color.Transparent;
            this.labelForgotPass.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForgotPass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelForgotPass.Location = new System.Drawing.Point(96, 383);
            this.labelForgotPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelForgotPass.Name = "labelForgotPass";
            this.labelForgotPass.Size = new System.Drawing.Size(190, 29);
            this.labelForgotPass.TabIndex = 1;
            this.labelForgotPass.Text = "Forgot Password ?";
            this.labelForgotPass.Click += new System.EventHandler(this.labelForgotPass_Click);
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.BackColor = System.Drawing.Color.Transparent;
            this.lblSignUp.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSignUp.Location = new System.Drawing.Point(11, 635);
            this.lblSignUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(245, 29);
            this.lblSignUp.TabIndex = 9;
            this.lblSignUp.Text = "Don\'t have an account?";
            this.lblSignUp.Click += new System.EventHandler(this.labelSignUp_Click);
            // 
            // lblEmailWarn
            // 
            this.lblEmailWarn.AutoSize = true;
            this.lblEmailWarn.Location = new System.Drawing.Point(100, 277);
            this.lblEmailWarn.Name = "lblEmailWarn";
            this.lblEmailWarn.Size = new System.Drawing.Size(0, 17);
            this.lblEmailWarn.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::SAA_AD_Revisi.Properties.Resources._399_IMG_28191;
            this.pictureBox1.Location = new System.Drawing.Point(798, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 673);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEmailWarn);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.cBShowPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelForgotPass);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxEmailLogin);
            this.Controls.Add(this.textBoxPasswordLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Text = "Eatez";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cBShowPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmailLogin;
        private System.Windows.Forms.TextBox textBoxPasswordLogin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelForgotPass;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label lblEmailWarn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}