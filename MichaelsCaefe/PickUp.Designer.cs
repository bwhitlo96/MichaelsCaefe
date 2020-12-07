namespace MichaelsCaefe
{
    partial class PickUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PickUp));
            this.PuckUp_logo_pb = new System.Windows.Forms.PictureBox();
            this.Pickup_nav_pb = new System.Windows.Forms.PictureBox();
            this.pickup_mainLable = new System.Windows.Forms.Label();
            this.PickUp_subLable = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Pickup_disclaimer_lable = new System.Windows.Forms.Label();
            this.Pickup_orderReview_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PuckUp_logo_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pickup_nav_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // PuckUp_logo_pb
            // 
            this.PuckUp_logo_pb.Image = ((System.Drawing.Image)(resources.GetObject("PuckUp_logo_pb.Image")));
            this.PuckUp_logo_pb.Location = new System.Drawing.Point(145, 12);
            this.PuckUp_logo_pb.Name = "PuckUp_logo_pb";
            this.PuckUp_logo_pb.Size = new System.Drawing.Size(123, 82);
            this.PuckUp_logo_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PuckUp_logo_pb.TabIndex = 0;
            this.PuckUp_logo_pb.TabStop = false;
            // 
            // Pickup_nav_pb
            // 
            this.Pickup_nav_pb.Image = ((System.Drawing.Image)(resources.GetObject("Pickup_nav_pb.Image")));
            this.Pickup_nav_pb.Location = new System.Drawing.Point(365, 13);
            this.Pickup_nav_pb.Name = "Pickup_nav_pb";
            this.Pickup_nav_pb.Size = new System.Drawing.Size(27, 26);
            this.Pickup_nav_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pickup_nav_pb.TabIndex = 1;
            this.Pickup_nav_pb.TabStop = false;
            // 
            // pickup_mainLable
            // 
            this.pickup_mainLable.AutoSize = true;
            this.pickup_mainLable.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.pickup_mainLable.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.pickup_mainLable.Location = new System.Drawing.Point(130, 108);
            this.pickup_mainLable.Name = "pickup_mainLable";
            this.pickup_mainLable.Size = new System.Drawing.Size(159, 28);
            this.pickup_mainLable.TabIndex = 2;
            this.pickup_mainLable.Text = "Pickup Options";
            // 
            // PickUp_subLable
            // 
            this.PickUp_subLable.AutoSize = true;
            this.PickUp_subLable.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.PickUp_subLable.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.PickUp_subLable.Location = new System.Drawing.Point(74, 196);
            this.PickUp_subLable.Name = "PickUp_subLable";
            this.PickUp_subLable.Size = new System.Drawing.Size(117, 22);
            this.PickUp_subLable.TabIndex = 3;
            this.PickUp_subLable.Text = "Pickup Time: ";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(197, 198);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // Pickup_disclaimer_lable
            // 
            this.Pickup_disclaimer_lable.AutoSize = true;
            this.Pickup_disclaimer_lable.Location = new System.Drawing.Point(23, 241);
            this.Pickup_disclaimer_lable.Name = "Pickup_disclaimer_lable";
            this.Pickup_disclaimer_lable.Size = new System.Drawing.Size(334, 15);
            this.Pickup_disclaimer_lable.TabIndex = 5;
            this.Pickup_disclaimer_lable.Text = "* Available times begin fifteen minutes from the current time. ";
            // 
            // Pickup_orderReview_button
            // 
            this.Pickup_orderReview_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pickup_orderReview_button.Location = new System.Drawing.Point(87, 313);
            this.Pickup_orderReview_button.Name = "Pickup_orderReview_button";
            this.Pickup_orderReview_button.Size = new System.Drawing.Size(246, 46);
            this.Pickup_orderReview_button.TabIndex = 6;
            this.Pickup_orderReview_button.Text = "Continue To Order Review";
            this.Pickup_orderReview_button.UseVisualStyleBackColor = true;
            this.Pickup_orderReview_button.Click += new System.EventHandler(this.Pickup_orderReview_button_Click);
            // 
            // PickUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(404, 655);
            this.Controls.Add(this.Pickup_orderReview_button);
            this.Controls.Add(this.Pickup_disclaimer_lable);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PickUp_subLable);
            this.Controls.Add(this.pickup_mainLable);
            this.Controls.Add(this.Pickup_nav_pb);
            this.Controls.Add(this.PuckUp_logo_pb);
            this.Name = "PickUp";
            this.Text = "PickUp";
            ((System.ComponentModel.ISupportInitialize)(this.PuckUp_logo_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pickup_nav_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PuckUp_logo_pb;
        private System.Windows.Forms.PictureBox Pickup_nav_pb;
        private System.Windows.Forms.Label pickup_mainLable;
        private System.Windows.Forms.Label PickUp_subLable;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Pickup_disclaimer_lable;
        private System.Windows.Forms.Button Pickup_orderReview_button;
    }
}