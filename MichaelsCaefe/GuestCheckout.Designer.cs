namespace MichaelsCaefe
{
    partial class GuestCheckout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestCheckout));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Guest_Checkout_lable = new System.Windows.Forms.Label();
            this.GuestCheckout_name_textbox = new System.Windows.Forms.TextBox();
            this.GuestCheckout_Cardnumber_textbox = new System.Windows.Forms.TextBox();
            this.GuestCheckout_cvv_textbox = new System.Windows.Forms.TextBox();
            this.GuestCheckout_expiration_textbox = new System.Windows.Forms.TextBox();
            this.GuestCheckout_cardholder_textbox = new System.Windows.Forms.TextBox();
            this.GuestCheckout_email_textbox = new System.Windows.Forms.TextBox();
            this.GuestCheckout_billingAddress_textbox = new System.Windows.Forms.TextBox();
            this.GuestCheckout_phone_textbox = new System.Windows.Forms.TextBox();
            this.GuestCheckout_GoToDelivery_button = new System.Windows.Forms.Button();
            this.GuestCheckout_GoToPickup_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(121, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(325, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Guest_Checkout_lable
            // 
            this.Guest_Checkout_lable.AutoSize = true;
            this.Guest_Checkout_lable.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Guest_Checkout_lable.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Guest_Checkout_lable.Location = new System.Drawing.Point(99, 121);
            this.Guest_Checkout_lable.Name = "Guest_Checkout_lable";
            this.Guest_Checkout_lable.Size = new System.Drawing.Size(160, 28);
            this.Guest_Checkout_lable.TabIndex = 2;
            this.Guest_Checkout_lable.Text = "Guest Checkout";
            this.Guest_Checkout_lable.Click += new System.EventHandler(this.label1_Click);
            // 
            // GuestCheckout_name_textbox
            // 
            this.GuestCheckout_name_textbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GuestCheckout_name_textbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GuestCheckout_name_textbox.Location = new System.Drawing.Point(99, 189);
            this.GuestCheckout_name_textbox.Name = "GuestCheckout_name_textbox";
            this.GuestCheckout_name_textbox.Size = new System.Drawing.Size(160, 25);
            this.GuestCheckout_name_textbox.TabIndex = 3;
            this.GuestCheckout_name_textbox.Text = "Name";
            // 
            // GuestCheckout_Cardnumber_textbox
            // 
            this.GuestCheckout_Cardnumber_textbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GuestCheckout_Cardnumber_textbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GuestCheckout_Cardnumber_textbox.Location = new System.Drawing.Point(99, 220);
            this.GuestCheckout_Cardnumber_textbox.Name = "GuestCheckout_Cardnumber_textbox";
            this.GuestCheckout_Cardnumber_textbox.Size = new System.Drawing.Size(160, 25);
            this.GuestCheckout_Cardnumber_textbox.TabIndex = 4;
            this.GuestCheckout_Cardnumber_textbox.Text = "Card Number";
            // 
            // GuestCheckout_cvv_textbox
            // 
            this.GuestCheckout_cvv_textbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GuestCheckout_cvv_textbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GuestCheckout_cvv_textbox.Location = new System.Drawing.Point(99, 251);
            this.GuestCheckout_cvv_textbox.Name = "GuestCheckout_cvv_textbox";
            this.GuestCheckout_cvv_textbox.Size = new System.Drawing.Size(64, 25);
            this.GuestCheckout_cvv_textbox.TabIndex = 5;
            this.GuestCheckout_cvv_textbox.Text = "CVV";
            this.GuestCheckout_cvv_textbox.TextChanged += new System.EventHandler(this.GuestCheckout_cvv_textbox_TextChanged);
            // 
            // GuestCheckout_expiration_textbox
            // 
            this.GuestCheckout_expiration_textbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GuestCheckout_expiration_textbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GuestCheckout_expiration_textbox.Location = new System.Drawing.Point(178, 251);
            this.GuestCheckout_expiration_textbox.Name = "GuestCheckout_expiration_textbox";
            this.GuestCheckout_expiration_textbox.Size = new System.Drawing.Size(81, 25);
            this.GuestCheckout_expiration_textbox.TabIndex = 6;
            this.GuestCheckout_expiration_textbox.Text = "MM/YY";
            // 
            // GuestCheckout_cardholder_textbox
            // 
            this.GuestCheckout_cardholder_textbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GuestCheckout_cardholder_textbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GuestCheckout_cardholder_textbox.Location = new System.Drawing.Point(99, 315);
            this.GuestCheckout_cardholder_textbox.Name = "GuestCheckout_cardholder_textbox";
            this.GuestCheckout_cardholder_textbox.Size = new System.Drawing.Size(160, 25);
            this.GuestCheckout_cardholder_textbox.TabIndex = 7;
            this.GuestCheckout_cardholder_textbox.Text = "Cardholder Name";
            // 
            // GuestCheckout_email_textbox
            // 
            this.GuestCheckout_email_textbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GuestCheckout_email_textbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GuestCheckout_email_textbox.Location = new System.Drawing.Point(99, 346);
            this.GuestCheckout_email_textbox.Name = "GuestCheckout_email_textbox";
            this.GuestCheckout_email_textbox.Size = new System.Drawing.Size(160, 25);
            this.GuestCheckout_email_textbox.TabIndex = 8;
            this.GuestCheckout_email_textbox.Text = "Enter Email";
            // 
            // GuestCheckout_billingAddress_textbox
            // 
            this.GuestCheckout_billingAddress_textbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GuestCheckout_billingAddress_textbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GuestCheckout_billingAddress_textbox.Location = new System.Drawing.Point(99, 377);
            this.GuestCheckout_billingAddress_textbox.Name = "GuestCheckout_billingAddress_textbox";
            this.GuestCheckout_billingAddress_textbox.Size = new System.Drawing.Size(160, 25);
            this.GuestCheckout_billingAddress_textbox.TabIndex = 9;
            this.GuestCheckout_billingAddress_textbox.Text = "Enter Billing Address";
            // 
            // GuestCheckout_phone_textbox
            // 
            this.GuestCheckout_phone_textbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GuestCheckout_phone_textbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GuestCheckout_phone_textbox.Location = new System.Drawing.Point(99, 406);
            this.GuestCheckout_phone_textbox.Name = "GuestCheckout_phone_textbox";
            this.GuestCheckout_phone_textbox.Size = new System.Drawing.Size(160, 25);
            this.GuestCheckout_phone_textbox.TabIndex = 10;
            this.GuestCheckout_phone_textbox.Text = "Phone Number";
            this.GuestCheckout_phone_textbox.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // GuestCheckout_GoToDelivery_button
            // 
            this.GuestCheckout_GoToDelivery_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GuestCheckout_GoToDelivery_button.Location = new System.Drawing.Point(99, 476);
            this.GuestCheckout_GoToDelivery_button.Name = "GuestCheckout_GoToDelivery_button";
            this.GuestCheckout_GoToDelivery_button.Size = new System.Drawing.Size(160, 48);
            this.GuestCheckout_GoToDelivery_button.TabIndex = 11;
            this.GuestCheckout_GoToDelivery_button.Text = "Delivery";
            this.GuestCheckout_GoToDelivery_button.UseVisualStyleBackColor = true;
            this.GuestCheckout_GoToDelivery_button.Click += new System.EventHandler(this.GuestCheckout_GoToDelivery_button_Click);
            // 
            // GuestCheckout_GoToPickup_button
            // 
            this.GuestCheckout_GoToPickup_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GuestCheckout_GoToPickup_button.Location = new System.Drawing.Point(99, 553);
            this.GuestCheckout_GoToPickup_button.Name = "GuestCheckout_GoToPickup_button";
            this.GuestCheckout_GoToPickup_button.Size = new System.Drawing.Size(160, 45);
            this.GuestCheckout_GoToPickup_button.TabIndex = 12;
            this.GuestCheckout_GoToPickup_button.Text = "Pick Up";
            this.GuestCheckout_GoToPickup_button.UseVisualStyleBackColor = true;
            this.GuestCheckout_GoToPickup_button.Click += new System.EventHandler(this.GuestCheckout_GoToPickup_button_Click);
            // 
            // GuestCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(362, 655);
            this.Controls.Add(this.GuestCheckout_GoToPickup_button);
            this.Controls.Add(this.GuestCheckout_GoToDelivery_button);
            this.Controls.Add(this.GuestCheckout_phone_textbox);
            this.Controls.Add(this.GuestCheckout_billingAddress_textbox);
            this.Controls.Add(this.GuestCheckout_email_textbox);
            this.Controls.Add(this.GuestCheckout_cardholder_textbox);
            this.Controls.Add(this.GuestCheckout_expiration_textbox);
            this.Controls.Add(this.GuestCheckout_cvv_textbox);
            this.Controls.Add(this.GuestCheckout_Cardnumber_textbox);
            this.Controls.Add(this.GuestCheckout_name_textbox);
            this.Controls.Add(this.Guest_Checkout_lable);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GuestCheckout";
            this.Text = "GuestCheckout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Guest_Checkout_lable;
        private System.Windows.Forms.TextBox GuestCheckout_name_textbox;
        private System.Windows.Forms.TextBox GuestCheckout_Cardnumber_textbox;
        private System.Windows.Forms.TextBox GuestCheckout_cvv_textbox;
        private System.Windows.Forms.TextBox GuestCheckout_expiration_textbox;
        private System.Windows.Forms.TextBox GuestCheckout_cardholder_textbox;
        private System.Windows.Forms.TextBox GuestCheckout_email_textbox;
        private System.Windows.Forms.TextBox GuestCheckout_billingAddress_textbox;
        private System.Windows.Forms.TextBox GuestCheckout_phone_textbox;
        private System.Windows.Forms.Button GuestCheckout_GoToDelivery_button;
        private System.Windows.Forms.Button GuestCheckout_GoToPickup_button;
    }
}