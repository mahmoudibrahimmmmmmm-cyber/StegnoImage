namespace stegnographyLSB
{
    partial class StegnoImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StegnoImage));
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.messages = new System.Windows.Forms.Label();
            this.ClosingMessageLogo = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.LogoPicBox = new System.Windows.Forms.PictureBox();
            this.btnHideText = new System.Windows.Forms.Button();
            this.btnExtractText = new System.Windows.Forms.Button();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            resources.ApplyResources(this.txtMessage, "txtMessage");
            this.txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.ForeColor = System.Drawing.Color.White;
            this.txtMessage.Name = "txtMessage";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // messages
            // 
            resources.ApplyResources(this.messages, "messages");
            this.messages.BackColor = System.Drawing.Color.Transparent;
            this.messages.ForeColor = System.Drawing.Color.White;
            this.messages.Name = "messages";
            // 
            // ClosingMessageLogo
            // 
            resources.ApplyResources(this.ClosingMessageLogo, "ClosingMessageLogo");
            this.ClosingMessageLogo.ForeColor = System.Drawing.Color.White;
            this.ClosingMessageLogo.Name = "ClosingMessageLogo";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.button3.Image = global::stegnographyLSB.Properties.Resources.question_mark_24dp_151B23_FILL0_wght400_GRAD0_opsz24;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LogoPicBox
            // 
            this.LogoPicBox.Image = global::stegnographyLSB.Properties.Resources.visibility_off;
            resources.ApplyResources(this.LogoPicBox, "LogoPicBox");
            this.LogoPicBox.Name = "LogoPicBox";
            this.LogoPicBox.TabStop = false;
            // 
            // btnHideText
            // 
            resources.ApplyResources(this.btnHideText, "btnHideText");
            this.btnHideText.BackColor = System.Drawing.Color.White;
            this.btnHideText.FlatAppearance.BorderSize = 0;
            this.btnHideText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnHideText.Image = global::stegnographyLSB.Properties.Resources.encode;
            this.btnHideText.Name = "btnHideText";
            this.btnHideText.UseVisualStyleBackColor = false;
            this.btnHideText.Click += new System.EventHandler(this.btnHideText_Click);
            // 
            // btnExtractText
            // 
            resources.ApplyResources(this.btnExtractText, "btnExtractText");
            this.btnExtractText.BackColor = System.Drawing.Color.White;
            this.btnExtractText.FlatAppearance.BorderSize = 0;
            this.btnExtractText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnExtractText.Image = global::stegnographyLSB.Properties.Resources.decode;
            this.btnExtractText.Name = "btnExtractText";
            this.btnExtractText.UseVisualStyleBackColor = false;
            this.btnExtractText.Click += new System.EventHandler(this.btnExtractText_Click);
            // 
            // btnLoadImage
            // 
            resources.ApplyResources(this.btnLoadImage, "btnLoadImage");
            this.btnLoadImage.BackColor = System.Drawing.Color.White;
            this.btnLoadImage.FlatAppearance.BorderSize = 0;
            this.btnLoadImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnLoadImage.Image = global::stegnographyLSB.Properties.Resources.upload_24dp_151B23_FILL0_wght400_GRAD0_opsz24;
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.UseVisualStyleBackColor = false;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::stegnographyLSB.Properties.Resources.image;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // StegnoImage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.button3);
            this.Controls.Add(this.LogoPicBox);
            this.Controls.Add(this.ClosingMessageLogo);
            this.Controls.Add(this.messages);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHideText);
            this.Controls.Add(this.btnExtractText);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StegnoImage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StegnoImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnExtractText;
        private System.Windows.Forms.Button btnHideText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label messages;
        private System.Windows.Forms.Label ClosingMessageLogo;
        private System.Windows.Forms.PictureBox LogoPicBox;
        private System.Windows.Forms.Button button3;
    }
}

