namespace MichaelsCaefe
{
    partial class Order_details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_details));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.od_heading = new System.Windows.Forms.Label();
            this.od_checkout_button = new System.Windows.Forms.Button();
            this.od_guest_checkout_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(141, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // od_heading
            // 
            this.od_heading.AutoSize = true;
            this.od_heading.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.od_heading.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.od_heading.Location = new System.Drawing.Point(126, 163);
            this.od_heading.Name = "od_heading";
            this.od_heading.Size = new System.Drawing.Size(198, 43);
            this.od_heading.TabIndex = 1;
            this.od_heading.Text = "Order Details";
            // 
            // od_checkout_button
            // 
            this.od_checkout_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.od_checkout_button.Location = new System.Drawing.Point(141, 485);
            this.od_checkout_button.Name = "od_checkout_button";
            this.od_checkout_button.Size = new System.Drawing.Size(183, 58);
            this.od_checkout_button.TabIndex = 2;
            this.od_checkout_button.Text = "Checkout";
            this.od_checkout_button.UseVisualStyleBackColor = true;
            this.od_checkout_button.Click += new System.EventHandler(this.od_checkout_button_Click);
            // 
            // od_guest_checkout_button
            // 
            this.od_guest_checkout_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.od_guest_checkout_button.Location = new System.Drawing.Point(141, 579);
            this.od_guest_checkout_button.Name = "od_guest_checkout_button";
            this.od_guest_checkout_button.Size = new System.Drawing.Size(183, 54);
            this.od_guest_checkout_button.TabIndex = 3;
            this.od_guest_checkout_button.Text = "Guest Checkout";
            this.od_guest_checkout_button.UseVisualStyleBackColor = true;
            this.od_guest_checkout_button.Click += new System.EventHandler(this.od_guest_checkout_button_Click);
            // 
            // Order_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(417, 663);
            this.Controls.Add(this.od_guest_checkout_button);
            this.Controls.Add(this.od_checkout_button);
            this.Controls.Add(this.od_heading);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Order_details";
            this.Text = "Order_details";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label od_heading;
        private System.Windows.Forms.Button od_checkout_button;
        private System.Windows.Forms.Button od_guest_checkout_button;
    }
}