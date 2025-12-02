namespace stegnographyLSB
{
    partial class StartSplashScreen1
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
            this.components = new System.ComponentModel.Container();
            this.WelcomeMessageLabel = new System.Windows.Forms.Label();
            this.WaitingTimer = new System.Windows.Forms.Timer(this.components);
            this.txtLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogoPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeMessageLabel
            // 
            this.WelcomeMessageLabel.AutoSize = true;
            this.WelcomeMessageLabel.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeMessageLabel.Location = new System.Drawing.Point(41, 9);
            this.WelcomeMessageLabel.Name = "WelcomeMessageLabel";
            this.WelcomeMessageLabel.Size = new System.Drawing.Size(137, 25);
            this.WelcomeMessageLabel.TabIndex = 1;
            this.WelcomeMessageLabel.Text = "StegnoImage";
            // 
            // WaitingTimer
            // 
            this.WaitingTimer.Enabled = true;
            this.WaitingTimer.Interval = 5000;
            this.WaitingTimer.Tick += new System.EventHandler(this.WaitingTimer_Tick);
            // 
            // txtLabel
            // 
            this.txtLabel.AutoSize = true;
            this.txtLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabel.Location = new System.Drawing.Point(22, 116);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(660, 21);
            this.txtLabel.TabIndex = 3;
            this.txtLabel.Text = "This program was developed by students from the BIS department at Future Academy";
            this.txtLabel.Click += new System.EventHandler(this.txtLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::stegnographyLSB.Properties.Resources.logo_mob_en;
            this.pictureBox1.Location = new System.Drawing.Point(252, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // LogoPicBox
            // 
            this.LogoPicBox.Image = global::stegnographyLSB.Properties.Resources.visibility_off;
            this.LogoPicBox.Location = new System.Drawing.Point(5, 9);
            this.LogoPicBox.Name = "LogoPicBox";
            this.LogoPicBox.Size = new System.Drawing.Size(30, 28);
            this.LogoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPicBox.TabIndex = 2;
            this.LogoPicBox.TabStop = false;
            // 
            // StartSplashScreen1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(710, 178);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.LogoPicBox);
            this.Controls.Add(this.WelcomeMessageLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartSplashScreen1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label WelcomeMessageLabel;
        private System.Windows.Forms.Timer WaitingTimer;
        private System.Windows.Forms.PictureBox LogoPicBox;
        private System.Windows.Forms.Label txtLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}