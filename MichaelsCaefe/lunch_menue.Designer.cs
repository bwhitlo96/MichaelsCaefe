namespace MichaelsCaefe
{
    partial class lunch_menue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lunch_menue));
            this.m1_pb = new System.Windows.Forms.PictureBox();
            this.m1_lable = new System.Windows.Forms.Label();
            this.m1_check = new System.Windows.Forms.CheckBox();
            this.m1_gb = new System.Windows.Forms.GroupBox();
            this.m2_gb = new System.Windows.Forms.GroupBox();
            this.m3_gb = new System.Windows.Forms.GroupBox();
            this.m4_gb = new System.Windows.Forms.GroupBox();
            this.m2_pb = new System.Windows.Forms.PictureBox();
            this.m3_pb = new System.Windows.Forms.PictureBox();
            this.m4_pb = new System.Windows.Forms.PictureBox();
            this.menue_checkout = new System.Windows.Forms.Button();
            this.m2_label = new System.Windows.Forms.Label();
            this.m3_label = new System.Windows.Forms.Label();
            this.m4_lable = new System.Windows.Forms.Label();
            this.m2_check = new System.Windows.Forms.CheckBox();
            this.m3_check = new System.Windows.Forms.CheckBox();
            this.m4_check = new System.Windows.Forms.CheckBox();
            this.lm_logo_pb = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.m1_pb)).BeginInit();
            this.m1_gb.SuspendLayout();
            this.m2_gb.SuspendLayout();
            this.m3_gb.SuspendLayout();
            this.m4_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m2_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m4_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lm_logo_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // m1_pb
            // 
            this.m1_pb.Image = ((System.Drawing.Image)(resources.GetObject("m1_pb.Image")));
            this.m1_pb.Location = new System.Drawing.Point(6, 22);
            this.m1_pb.Name = "m1_pb";
            this.m1_pb.Size = new System.Drawing.Size(119, 93);
            this.m1_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m1_pb.TabIndex = 0;
            this.m1_pb.TabStop = false;
            // 
            // m1_lable
            // 
            this.m1_lable.AutoSize = true;
            this.m1_lable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m1_lable.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.m1_lable.Location = new System.Drawing.Point(131, 44);
            this.m1_lable.Name = "m1_lable";
            this.m1_lable.Size = new System.Drawing.Size(233, 21);
            this.m1_lable.TabIndex = 1;
            this.m1_lable.Text = "Bacon Egg and Cheese...$6.99";
            this.m1_lable.Click += new System.EventHandler(this.label1_Click);
            // 
            // m1_check
            // 
            this.m1_check.AutoSize = true;
            this.m1_check.Location = new System.Drawing.Point(305, 101);
            this.m1_check.Name = "m1_check";
            this.m1_check.Size = new System.Drawing.Size(15, 14);
            this.m1_check.TabIndex = 2;
            this.m1_check.UseVisualStyleBackColor = true;
            this.m1_check.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // m1_gb
            // 
            this.m1_gb.Controls.Add(this.m1_pb);
            this.m1_gb.Controls.Add(this.m1_check);
            this.m1_gb.Controls.Add(this.m1_lable);
            this.m1_gb.Location = new System.Drawing.Point(27, 81);
            this.m1_gb.Name = "m1_gb";
            this.m1_gb.Size = new System.Drawing.Size(374, 131);
            this.m1_gb.TabIndex = 3;
            this.m1_gb.TabStop = false;
            this.m1_gb.Enter += new System.EventHandler(this.m1_gb_Enter);
            // 
            // m2_gb
            // 
            this.m2_gb.Controls.Add(this.m2_check);
            this.m2_gb.Controls.Add(this.m2_label);
            this.m2_gb.Controls.Add(this.m2_pb);
            this.m2_gb.Location = new System.Drawing.Point(27, 206);
            this.m2_gb.Name = "m2_gb";
            this.m2_gb.Size = new System.Drawing.Size(374, 137);
            this.m2_gb.TabIndex = 4;
            this.m2_gb.TabStop = false;
            // 
            // m3_gb
            // 
            this.m3_gb.Controls.Add(this.m3_check);
            this.m3_gb.Controls.Add(this.m3_label);
            this.m3_gb.Controls.Add(this.m3_pb);
            this.m3_gb.Location = new System.Drawing.Point(27, 336);
            this.m3_gb.Name = "m3_gb";
            this.m3_gb.Size = new System.Drawing.Size(374, 121);
            this.m3_gb.TabIndex = 5;
            this.m3_gb.TabStop = false;
            // 
            // m4_gb
            // 
            this.m4_gb.Controls.Add(this.m4_check);
            this.m4_gb.Controls.Add(this.m4_lable);
            this.m4_gb.Controls.Add(this.m4_pb);
            this.m4_gb.Location = new System.Drawing.Point(27, 452);
            this.m4_gb.Name = "m4_gb";
            this.m4_gb.Size = new System.Drawing.Size(374, 115);
            this.m4_gb.TabIndex = 6;
            this.m4_gb.TabStop = false;
            // 
            // m2_pb
            // 
            this.m2_pb.Image = ((System.Drawing.Image)(resources.GetObject("m2_pb.Image")));
            this.m2_pb.Location = new System.Drawing.Point(6, 22);
            this.m2_pb.Name = "m2_pb";
            this.m2_pb.Size = new System.Drawing.Size(119, 97);
            this.m2_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m2_pb.TabIndex = 0;
            this.m2_pb.TabStop = false;
            this.m2_pb.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // m3_pb
            // 
            this.m3_pb.Image = ((System.Drawing.Image)(resources.GetObject("m3_pb.Image")));
            this.m3_pb.Location = new System.Drawing.Point(6, 13);
            this.m3_pb.Name = "m3_pb";
            this.m3_pb.Size = new System.Drawing.Size(132, 93);
            this.m3_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m3_pb.TabIndex = 0;
            this.m3_pb.TabStop = false;
            // 
            // m4_pb
            // 
            this.m4_pb.Image = ((System.Drawing.Image)(resources.GetObject("m4_pb.Image")));
            this.m4_pb.Location = new System.Drawing.Point(6, 11);
            this.m4_pb.Name = "m4_pb";
            this.m4_pb.Size = new System.Drawing.Size(132, 98);
            this.m4_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m4_pb.TabIndex = 0;
            this.m4_pb.TabStop = false;
            // 
            // menue_checkout
            // 
            this.menue_checkout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menue_checkout.Location = new System.Drawing.Point(279, 595);
            this.menue_checkout.Name = "menue_checkout";
            this.menue_checkout.Size = new System.Drawing.Size(148, 46);
            this.menue_checkout.TabIndex = 7;
            this.menue_checkout.Text = "Continue to Checkout";
            this.menue_checkout.UseVisualStyleBackColor = true;
            this.menue_checkout.Click += new System.EventHandler(this.menue_checkout_Click);
            // 
            // m2_label
            // 
            this.m2_label.AutoSize = true;
            this.m2_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m2_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.m2_label.Location = new System.Drawing.Point(131, 60);
            this.m2_label.Name = "m2_label";
            this.m2_label.Size = new System.Drawing.Size(168, 21);
            this.m2_label.TabIndex = 1;
            this.m2_label.Text = "Brioche Toast... $7.99";
            // 
            // m3_label
            // 
            this.m3_label.AutoSize = true;
            this.m3_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m3_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.m3_label.Location = new System.Drawing.Point(144, 59);
            this.m3_label.Name = "m3_label";
            this.m3_label.Size = new System.Drawing.Size(112, 21);
            this.m3_label.TabIndex = 1;
            this.m3_label.Text = "Coffee...$4.99";
            // 
            // m4_lable
            // 
            this.m4_lable.AutoSize = true;
            this.m4_lable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m4_lable.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.m4_lable.Location = new System.Drawing.Point(138, 52);
            this.m4_lable.Name = "m4_lable";
            this.m4_lable.Size = new System.Drawing.Size(161, 21);
            this.m4_lable.TabIndex = 1;
            this.m4_lable.Text = "French Toast... $7.99";
            // 
            // m2_check
            // 
            this.m2_check.AutoSize = true;
            this.m2_check.Location = new System.Drawing.Point(305, 60);
            this.m2_check.Name = "m2_check";
            this.m2_check.Size = new System.Drawing.Size(15, 14);
            this.m2_check.TabIndex = 2;
            this.m2_check.UseVisualStyleBackColor = true;
            // 
            // m3_check
            // 
            this.m3_check.AutoSize = true;
            this.m3_check.Location = new System.Drawing.Point(305, 66);
            this.m3_check.Name = "m3_check";
            this.m3_check.Size = new System.Drawing.Size(15, 14);
            this.m3_check.TabIndex = 2;
            this.m3_check.UseVisualStyleBackColor = true;
            // 
            // m4_check
            // 
            this.m4_check.AutoSize = true;
            this.m4_check.Location = new System.Drawing.Point(305, 52);
            this.m4_check.Name = "m4_check";
            this.m4_check.Size = new System.Drawing.Size(15, 14);
            this.m4_check.TabIndex = 2;
            this.m4_check.UseVisualStyleBackColor = true;
            // 
            // lm_logo_pb
            // 
            this.lm_logo_pb.Image = ((System.Drawing.Image)(resources.GetObject("lm_logo_pb.Image")));
            this.lm_logo_pb.Location = new System.Drawing.Point(171, 2);
            this.lm_logo_pb.Name = "lm_logo_pb";
            this.lm_logo_pb.Size = new System.Drawing.Size(112, 73);
            this.lm_logo_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lm_logo_pb.TabIndex = 8;
            this.lm_logo_pb.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(419, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lunch_menue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(454, 653);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lm_logo_pb);
            this.Controls.Add(this.menue_checkout);
            this.Controls.Add(this.m4_gb);
            this.Controls.Add(this.m3_gb);
            this.Controls.Add(this.m2_gb);
            this.Controls.Add(this.m1_gb);
            this.Name = "lunch_menue";
            this.Text = "lunch_menue";
            ((System.ComponentModel.ISupportInitialize)(this.m1_pb)).EndInit();
            this.m1_gb.ResumeLayout(false);
            this.m1_gb.PerformLayout();
            this.m2_gb.ResumeLayout(false);
            this.m2_gb.PerformLayout();
            this.m3_gb.ResumeLayout(false);
            this.m3_gb.PerformLayout();
            this.m4_gb.ResumeLayout(false);
            this.m4_gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m2_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m4_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lm_logo_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox m1_pb;
        private System.Windows.Forms.Label m1_lable;
        private System.Windows.Forms.CheckBox m1_check;
        private System.Windows.Forms.GroupBox m1_gb;
        private System.Windows.Forms.Label LE;
        private System.Windows.Forms.GroupBox m2_gb;
        private System.Windows.Forms.PictureBox m2_pb;
        private System.Windows.Forms.GroupBox m3_gb;
        private System.Windows.Forms.PictureBox m3_pb;
        private System.Windows.Forms.GroupBox m4_gb;
        private System.Windows.Forms.PictureBox m4_pb;
        private System.Windows.Forms.Label m2_label;
        private System.Windows.Forms.Label m3_label;
        private System.Windows.Forms.Label m4_lable;
        private System.Windows.Forms.Button menue_checkout;
        private System.Windows.Forms.CheckBox m2_check;
        private System.Windows.Forms.CheckBox m3_check;
        private System.Windows.Forms.CheckBox m4_check;
        private System.Windows.Forms.PictureBox lm_logo_pb;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}