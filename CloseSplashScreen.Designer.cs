namespace stegnographyLSB
{
    partial class CloseSplashScreen
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
            this.ClosingTimer = new System.Windows.Forms.Timer(this.components);
            this.ClosingMessageLogo = new System.Windows.Forms.Label();
            this.LogoPicBox = new System.Windows.Forms.PictureBox();
            this.txtLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ClosingTimer
            // 
            this.ClosingTimer.Enabled = true;
            this.ClosingTimer.Interval = 2000;
            this.ClosingTimer.Tick += new System.EventHandler(this.ClosingTimer_Tick);
            // 
            // ClosingMessageLogo
            // 
            this.ClosingMessageLogo.AutoSize = true;
            this.ClosingMessageLogo.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClosingMessageLogo.Location = new System.Drawing.Point(168, 83);
            this.ClosingMessageLogo.Name = "ClosingMessageLogo";
            this.ClosingMessageLogo.Size = new System.Drawing.Size(248, 47);
            this.ClosingMessageLogo.TabIndex = 2;
            this.ClosingMessageLogo.Text = "StegnoImage";
            // 
            // LogoPicBox
            // 
            this.LogoPicBox.Image = global::stegnographyLSB.Properties.Resources.visibility_off;
            this.LogoPicBox.Location = new System.Drawing.Point(115, 86);
            this.LogoPicBox.Name = "LogoPicBox";
            this.LogoPicBox.Size = new System.Drawing.Size(47, 44);
            this.LogoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPicBox.TabIndex = 3;
            this.LogoPicBox.TabStop = false;
            // 
            // txtLabel2
            // 
            this.txtLabel2.AutoSize = true;
            this.txtLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabel2.Location = new System.Drawing.Point(169, 39);
            this.txtLabel2.Name = "txtLabel2";
            this.txtLabel2.Size = new System.Drawing.Size(192, 25);
            this.txtLabel2.TabIndex = 4;
            this.txtLabel2.Text = "Thank you for using";
            // 
            // CloseSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(531, 213);
            this.Controls.Add(this.txtLabel2);
            this.Controls.Add(this.LogoPicBox);
            this.Controls.Add(this.ClosingMessageLogo);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CloseSplashScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start_SplashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer ClosingTimer;
        private System.Windows.Forms.Label ClosingMessageLogo;
        private System.Windows.Forms.PictureBox LogoPicBox;
        private System.Windows.Forms.Label txtLabel2;
    }
}