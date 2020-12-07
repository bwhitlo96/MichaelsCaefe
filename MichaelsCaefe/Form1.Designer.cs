namespace MichaelsCaefe
{
    partial class form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.usernameInput = new System.Windows.Forms.MaskedTextBox();
            this.UsernameLable = new System.Windows.Forms.Label();
            this.loginLogo = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.MaskedTextBox();
            this.signIn_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.login_gb = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogo)).BeginInit();
            this.login_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameInput
            // 
            this.usernameInput.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.usernameInput.Location = new System.Drawing.Point(136, 309);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(176, 23);
            this.usernameInput.TabIndex = 0;
            this.usernameInput.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.usernameInput_MaskInputRejected);
            // 
            // UsernameLable
            // 
            this.UsernameLable.AutoSize = true;
            this.UsernameLable.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.UsernameLable.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.UsernameLable.Location = new System.Drawing.Point(136, 278);
            this.UsernameLable.Name = "UsernameLable";
            this.UsernameLable.Size = new System.Drawing.Size(112, 28);
            this.UsernameLable.TabIndex = 1;
            this.UsernameLable.Text = "Username:";
            this.UsernameLable.Click += new System.EventHandler(this.UsernameLable_Click);
            // 
            // loginLogo
            // 
            this.loginLogo.Image = ((System.Drawing.Image)(resources.GetObject("loginLogo.Image")));
            this.loginLogo.Location = new System.Drawing.Point(136, 29);
            this.loginLogo.Name = "loginLogo";
            this.loginLogo.Size = new System.Drawing.Size(176, 149);
            this.loginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginLogo.TabIndex = 2;
            this.loginLogo.TabStop = false;
            this.loginLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(136, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.passwordTextbox.Location = new System.Drawing.Point(136, 387);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(176, 23);
            this.passwordTextbox.TabIndex = 4;
            // 
            // signIn_button
            // 
            this.signIn_button.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.signIn_button.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signIn_button.Location = new System.Drawing.Point(237, 438);
            this.signIn_button.Name = "signIn_button";
            this.signIn_button.Size = new System.Drawing.Size(75, 23);
            this.signIn_button.TabIndex = 5;
            this.signIn_button.Text = "Sign-In";
            this.signIn_button.UseVisualStyleBackColor = false;
            this.signIn_button.Click += new System.EventHandler(this.signIn_button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(80, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 52);
            this.button2.TabIndex = 6;
            this.button2.Text = "Create Account";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(80, 550);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(232, 54);
            this.button3.TabIndex = 7;
            this.button3.Text = "Guest Checkout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Firebrick;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(375, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 40);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // login_gb
            // 
            this.login_gb.Controls.Add(this.button4);
            this.login_gb.Controls.Add(this.button3);
            this.login_gb.Controls.Add(this.loginLogo);
            this.login_gb.Controls.Add(this.button2);
            this.login_gb.Controls.Add(this.UsernameLable);
            this.login_gb.Controls.Add(this.signIn_button);
            this.login_gb.Controls.Add(this.usernameInput);
            this.login_gb.Controls.Add(this.passwordTextbox);
            this.login_gb.Controls.Add(this.label1);
            this.login_gb.Location = new System.Drawing.Point(-7, 0);
            this.login_gb.Name = "login_gb";
            this.login_gb.Size = new System.Drawing.Size(422, 662);
            this.login_gb.TabIndex = 9;
            this.login_gb.TabStop = false;
            this.login_gb.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(418, 656);
            this.Controls.Add(this.login_gb);
            this.Name = "form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.loginLogo)).EndInit();
            this.login_gb.ResumeLayout(false);
            this.login_gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox usernameInput;
        private System.Windows.Forms.Label UsernameLable;
        private System.Windows.Forms.PictureBox loginLogo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox passwordTextbox;
        private System.Windows.Forms.Button signIn_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox login_gb;
    }
}

