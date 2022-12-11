namespace AIUtils {
    partial class AIUtils {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pictureboxExit = new System.Windows.Forms.PictureBox();
            this.labelHeadline = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureboxExit
            // 
            this.pictureboxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureboxExit.Image = global::AIUtils.Properties.Resources.cross;
            this.pictureboxExit.Location = new System.Drawing.Point(709, 12);
            this.pictureboxExit.Name = "pictureboxExit";
            this.pictureboxExit.Size = new System.Drawing.Size(40, 40);
            this.pictureboxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxExit.TabIndex = 0;
            this.pictureboxExit.TabStop = false;
            this.pictureboxExit.Click += new System.EventHandler(this.pictureboxExit_Click);
            // 
            // labelHeadline
            // 
            this.labelHeadline.AutoSize = true;
            this.labelHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelHeadline.Location = new System.Drawing.Point(12, 15);
            this.labelHeadline.Name = "labelHeadline";
            this.labelHeadline.Size = new System.Drawing.Size(109, 37);
            this.labelHeadline.TabIndex = 0;
            this.labelHeadline.Text = "AIUtils";
            // 
            // AIUtils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(761, 428);
            this.ControlBox = false;
            this.Controls.Add(this.labelHeadline);
            this.Controls.Add(this.pictureboxExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AIUtils";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AIUtils";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AIUtils_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureboxExit;
        private System.Windows.Forms.Label labelHeadline;
    }
}

