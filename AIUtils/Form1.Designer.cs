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
            this.labelHeadline = new System.Windows.Forms.Label();
            this.comboboxLevels = new System.Windows.Forms.ComboBox();
            this.labelPlayerX = new System.Windows.Forms.Label();
            this.labelPlayerZ = new System.Windows.Forms.Label();
            this.labelPlayerY = new System.Windows.Forms.Label();
            this.textboxPlayerCoordinateX = new System.Windows.Forms.TextBox();
            this.textboxPlayerCoordinateY = new System.Windows.Forms.TextBox();
            this.textboxPlayerCoordinateZ = new System.Windows.Forms.TextBox();
            this.labelSelectLevel = new System.Windows.Forms.Label();
            this.labelCheatTable = new System.Windows.Forms.Label();
            this.labelDivider = new System.Windows.Forms.Label();
            this.labelOpenCAGE = new System.Windows.Forms.Label();
            this.textboxPlayerCoordinateCalculatedZ = new System.Windows.Forms.TextBox();
            this.textboxPlayerCoordinateCalculatedY = new System.Windows.Forms.TextBox();
            this.textboxPlayerCoordinateCalculatedX = new System.Windows.Forms.TextBox();
            this.labelPlayerCalculatedY = new System.Windows.Forms.Label();
            this.labelPlayerCalculatedZ = new System.Windows.Forms.Label();
            this.labelPlayerCalculatedX = new System.Windows.Forms.Label();
            this.labelDeveloped = new System.Windows.Forms.Label();
            this.checkboxShowWindowOnTop = new System.Windows.Forms.CheckBox();
            this.labelDivider2 = new System.Windows.Forms.Label();
            this.pictureboxExit = new System.Windows.Forms.PictureBox();
            this.pictureboxMinimize = new System.Windows.Forms.PictureBox();
            this.buttonRefreshBaseAddress = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeadline
            // 
            this.labelHeadline.AutoSize = true;
            this.labelHeadline.Font = new System.Drawing.Font("Roboto", 24F);
            this.labelHeadline.Location = new System.Drawing.Point(12, 15);
            this.labelHeadline.Name = "labelHeadline";
            this.labelHeadline.Size = new System.Drawing.Size(111, 38);
            this.labelHeadline.TabIndex = 0;
            this.labelHeadline.Text = "AIUtils";
            // 
            // comboboxLevels
            // 
            this.comboboxLevels.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboboxLevels.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboboxLevels.BackColor = System.Drawing.Color.White;
            this.comboboxLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxLevels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboboxLevels.FormattingEnabled = true;
            this.comboboxLevels.Location = new System.Drawing.Point(94, 79);
            this.comboboxLevels.Name = "comboboxLevels";
            this.comboboxLevels.Size = new System.Drawing.Size(256, 24);
            this.comboboxLevels.TabIndex = 0;
            this.comboboxLevels.TabStop = false;
            this.comboboxLevels.SelectedIndexChanged += new System.EventHandler(this.comboboxLevels_SelectedIndexChanged);
            // 
            // labelPlayerX
            // 
            this.labelPlayerX.AutoSize = true;
            this.labelPlayerX.Font = new System.Drawing.Font("Roboto", 16F);
            this.labelPlayerX.Location = new System.Drawing.Point(12, 195);
            this.labelPlayerX.Name = "labelPlayerX";
            this.labelPlayerX.Size = new System.Drawing.Size(26, 27);
            this.labelPlayerX.TabIndex = 1;
            this.labelPlayerX.Text = "X";
            // 
            // labelPlayerZ
            // 
            this.labelPlayerZ.AutoSize = true;
            this.labelPlayerZ.Font = new System.Drawing.Font("Roboto", 16F);
            this.labelPlayerZ.Location = new System.Drawing.Point(12, 263);
            this.labelPlayerZ.Name = "labelPlayerZ";
            this.labelPlayerZ.Size = new System.Drawing.Size(25, 27);
            this.labelPlayerZ.TabIndex = 2;
            this.labelPlayerZ.Text = "Z";
            // 
            // labelPlayerY
            // 
            this.labelPlayerY.AutoSize = true;
            this.labelPlayerY.Font = new System.Drawing.Font("Roboto", 16F);
            this.labelPlayerY.Location = new System.Drawing.Point(12, 229);
            this.labelPlayerY.Name = "labelPlayerY";
            this.labelPlayerY.Size = new System.Drawing.Size(25, 27);
            this.labelPlayerY.TabIndex = 3;
            this.labelPlayerY.Text = "Y";
            // 
            // textboxPlayerCoordinateX
            // 
            this.textboxPlayerCoordinateX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textboxPlayerCoordinateX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxPlayerCoordinateX.Font = new System.Drawing.Font("Roboto", 16F);
            this.textboxPlayerCoordinateX.Location = new System.Drawing.Point(51, 195);
            this.textboxPlayerCoordinateX.Name = "textboxPlayerCoordinateX";
            this.textboxPlayerCoordinateX.ReadOnly = true;
            this.textboxPlayerCoordinateX.Size = new System.Drawing.Size(133, 26);
            this.textboxPlayerCoordinateX.TabIndex = 0;
            this.textboxPlayerCoordinateX.TabStop = false;
            // 
            // textboxPlayerCoordinateY
            // 
            this.textboxPlayerCoordinateY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textboxPlayerCoordinateY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxPlayerCoordinateY.Font = new System.Drawing.Font("Roboto", 16F);
            this.textboxPlayerCoordinateY.Location = new System.Drawing.Point(51, 229);
            this.textboxPlayerCoordinateY.Name = "textboxPlayerCoordinateY";
            this.textboxPlayerCoordinateY.ReadOnly = true;
            this.textboxPlayerCoordinateY.Size = new System.Drawing.Size(133, 26);
            this.textboxPlayerCoordinateY.TabIndex = 4;
            this.textboxPlayerCoordinateY.TabStop = false;
            // 
            // textboxPlayerCoordinateZ
            // 
            this.textboxPlayerCoordinateZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textboxPlayerCoordinateZ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxPlayerCoordinateZ.Font = new System.Drawing.Font("Roboto", 16F);
            this.textboxPlayerCoordinateZ.Location = new System.Drawing.Point(51, 263);
            this.textboxPlayerCoordinateZ.Name = "textboxPlayerCoordinateZ";
            this.textboxPlayerCoordinateZ.ReadOnly = true;
            this.textboxPlayerCoordinateZ.Size = new System.Drawing.Size(133, 26);
            this.textboxPlayerCoordinateZ.TabIndex = 5;
            this.textboxPlayerCoordinateZ.TabStop = false;
            // 
            // labelSelectLevel
            // 
            this.labelSelectLevel.AutoSize = true;
            this.labelSelectLevel.Font = new System.Drawing.Font("Roboto", 16F);
            this.labelSelectLevel.Location = new System.Drawing.Point(12, 78);
            this.labelSelectLevel.Name = "labelSelectLevel";
            this.labelSelectLevel.Size = new System.Drawing.Size(64, 27);
            this.labelSelectLevel.TabIndex = 6;
            this.labelSelectLevel.Text = "Level";
            // 
            // labelCheatTable
            // 
            this.labelCheatTable.AutoSize = true;
            this.labelCheatTable.Font = new System.Drawing.Font("Roboto", 16F);
            this.labelCheatTable.Location = new System.Drawing.Point(12, 154);
            this.labelCheatTable.Name = "labelCheatTable";
            this.labelCheatTable.Size = new System.Drawing.Size(127, 27);
            this.labelCheatTable.TabIndex = 7;
            this.labelCheatTable.Text = "Cheat Table";
            // 
            // labelDivider
            // 
            this.labelDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDivider.Font = new System.Drawing.Font("Roboto", 16F);
            this.labelDivider.Location = new System.Drawing.Point(10, 130);
            this.labelDivider.Name = "labelDivider";
            this.labelDivider.Size = new System.Drawing.Size(580, 2);
            this.labelDivider.TabIndex = 0;
            // 
            // labelOpenCAGE
            // 
            this.labelOpenCAGE.AutoSize = true;
            this.labelOpenCAGE.Font = new System.Drawing.Font("Roboto", 16F);
            this.labelOpenCAGE.Location = new System.Drawing.Point(259, 154);
            this.labelOpenCAGE.Name = "labelOpenCAGE";
            this.labelOpenCAGE.Size = new System.Drawing.Size(119, 27);
            this.labelOpenCAGE.TabIndex = 14;
            this.labelOpenCAGE.Text = "OpenCAGE";
            // 
            // textboxPlayerCoordinateCalculatedZ
            // 
            this.textboxPlayerCoordinateCalculatedZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textboxPlayerCoordinateCalculatedZ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxPlayerCoordinateCalculatedZ.Font = new System.Drawing.Font("Roboto", 16F);
            this.textboxPlayerCoordinateCalculatedZ.Location = new System.Drawing.Point(298, 263);
            this.textboxPlayerCoordinateCalculatedZ.Name = "textboxPlayerCoordinateCalculatedZ";
            this.textboxPlayerCoordinateCalculatedZ.ReadOnly = true;
            this.textboxPlayerCoordinateCalculatedZ.Size = new System.Drawing.Size(133, 26);
            this.textboxPlayerCoordinateCalculatedZ.TabIndex = 13;
            this.textboxPlayerCoordinateCalculatedZ.TabStop = false;
            // 
            // textboxPlayerCoordinateCalculatedY
            // 
            this.textboxPlayerCoordinateCalculatedY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textboxPlayerCoordinateCalculatedY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxPlayerCoordinateCalculatedY.Font = new System.Drawing.Font("Roboto", 16F);
            this.textboxPlayerCoordinateCalculatedY.Location = new System.Drawing.Point(298, 229);
            this.textboxPlayerCoordinateCalculatedY.Name = "textboxPlayerCoordinateCalculatedY";
            this.textboxPlayerCoordinateCalculatedY.ReadOnly = true;
            this.textboxPlayerCoordinateCalculatedY.Size = new System.Drawing.Size(133, 26);
            this.textboxPlayerCoordinateCalculatedY.TabIndex = 12;
            this.textboxPlayerCoordinateCalculatedY.TabStop = false;
            // 
            // textboxPlayerCoordinateCalculatedX
            // 
            this.textboxPlayerCoordinateCalculatedX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textboxPlayerCoordinateCalculatedX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxPlayerCoordinateCalculatedX.Font = new System.Drawing.Font("Roboto", 16F);
            this.textboxPlayerCoordinateCalculatedX.Location = new System.Drawing.Point(298, 195);
            this.textboxPlayerCoordinateCalculatedX.Name = "textboxPlayerCoordinateCalculatedX";
            this.textboxPlayerCoordinateCalculatedX.ReadOnly = true;
            this.textboxPlayerCoordinateCalculatedX.Size = new System.Drawing.Size(133, 26);
            this.textboxPlayerCoordinateCalculatedX.TabIndex = 8;
            this.textboxPlayerCoordinateCalculatedX.TabStop = false;
            // 
            // labelPlayerCalculatedY
            // 
            this.labelPlayerCalculatedY.AutoSize = true;
            this.labelPlayerCalculatedY.Font = new System.Drawing.Font("Roboto", 16F);
            this.labelPlayerCalculatedY.Location = new System.Drawing.Point(259, 229);
            this.labelPlayerCalculatedY.Name = "labelPlayerCalculatedY";
            this.labelPlayerCalculatedY.Size = new System.Drawing.Size(25, 27);
            this.labelPlayerCalculatedY.TabIndex = 11;
            this.labelPlayerCalculatedY.Text = "Y";
            // 
            // labelPlayerCalculatedZ
            // 
            this.labelPlayerCalculatedZ.AutoSize = true;
            this.labelPlayerCalculatedZ.Font = new System.Drawing.Font("Roboto", 16F);
            this.labelPlayerCalculatedZ.Location = new System.Drawing.Point(259, 263);
            this.labelPlayerCalculatedZ.Name = "labelPlayerCalculatedZ";
            this.labelPlayerCalculatedZ.Size = new System.Drawing.Size(25, 27);
            this.labelPlayerCalculatedZ.TabIndex = 10;
            this.labelPlayerCalculatedZ.Text = "Z";
            // 
            // labelPlayerCalculatedX
            // 
            this.labelPlayerCalculatedX.AutoSize = true;
            this.labelPlayerCalculatedX.Font = new System.Drawing.Font("Roboto", 16F);
            this.labelPlayerCalculatedX.Location = new System.Drawing.Point(259, 195);
            this.labelPlayerCalculatedX.Name = "labelPlayerCalculatedX";
            this.labelPlayerCalculatedX.Size = new System.Drawing.Size(26, 27);
            this.labelPlayerCalculatedX.TabIndex = 9;
            this.labelPlayerCalculatedX.Text = "X";
            // 
            // labelDeveloped
            // 
            this.labelDeveloped.AutoSize = true;
            this.labelDeveloped.Font = new System.Drawing.Font("Roboto", 8F);
            this.labelDeveloped.Location = new System.Drawing.Point(16, 378);
            this.labelDeveloped.Name = "labelDeveloped";
            this.labelDeveloped.Size = new System.Drawing.Size(521, 13);
            this.labelDeveloped.TabIndex = 15;
            this.labelDeveloped.Text = "Developed by xXxProKill - GitHub repository can be found here: https://github.com" +
    "/Oliver2Goetz/AIUtils";
            // 
            // checkboxShowWindowOnTop
            // 
            this.checkboxShowWindowOnTop.AutoSize = true;
            this.checkboxShowWindowOnTop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkboxShowWindowOnTop.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkboxShowWindowOnTop.Location = new System.Drawing.Point(17, 317);
            this.checkboxShowWindowOnTop.Name = "checkboxShowWindowOnTop";
            this.checkboxShowWindowOnTop.Size = new System.Drawing.Size(154, 21);
            this.checkboxShowWindowOnTop.TabIndex = 0;
            this.checkboxShowWindowOnTop.TabStop = false;
            this.checkboxShowWindowOnTop.Text = "show window on top";
            this.checkboxShowWindowOnTop.UseVisualStyleBackColor = true;
            this.checkboxShowWindowOnTop.CheckedChanged += new System.EventHandler(this.checkboxShowWindowOnTop_CheckedChanged);
            // 
            // labelDivider2
            // 
            this.labelDivider2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDivider2.Font = new System.Drawing.Font("Roboto", 16F);
            this.labelDivider2.Location = new System.Drawing.Point(10, 360);
            this.labelDivider2.Name = "labelDivider2";
            this.labelDivider2.Size = new System.Drawing.Size(580, 2);
            this.labelDivider2.TabIndex = 17;
            // 
            // pictureboxExit
            // 
            this.pictureboxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureboxExit.Image = global::AIUtils.Properties.Resources.cross;
            this.pictureboxExit.Location = new System.Drawing.Point(548, 12);
            this.pictureboxExit.Name = "pictureboxExit";
            this.pictureboxExit.Size = new System.Drawing.Size(40, 40);
            this.pictureboxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxExit.TabIndex = 0;
            this.pictureboxExit.TabStop = false;
            this.pictureboxExit.Click += new System.EventHandler(this.pictureboxExit_Click);
            // 
            // pictureboxMinimize
            // 
            this.pictureboxMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureboxMinimize.Image = global::AIUtils.Properties.Resources.line;
            this.pictureboxMinimize.Location = new System.Drawing.Point(497, 12);
            this.pictureboxMinimize.Name = "pictureboxMinimize";
            this.pictureboxMinimize.Size = new System.Drawing.Size(40, 40);
            this.pictureboxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxMinimize.TabIndex = 18;
            this.pictureboxMinimize.TabStop = false;
            this.pictureboxMinimize.Click += new System.EventHandler(this.pictureboxMinimize_Click);
            // 
            // buttonRefreshBaseAddress
            // 
            this.buttonRefreshBaseAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRefreshBaseAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefreshBaseAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefreshBaseAddress.Location = new System.Drawing.Point(488, 75);
            this.buttonRefreshBaseAddress.Name = "buttonRefreshBaseAddress";
            this.buttonRefreshBaseAddress.Size = new System.Drawing.Size(100, 30);
            this.buttonRefreshBaseAddress.TabIndex = 0;
            this.buttonRefreshBaseAddress.TabStop = false;
            this.buttonRefreshBaseAddress.Text = "Refresh";
            this.buttonRefreshBaseAddress.UseVisualStyleBackColor = true;
            this.buttonRefreshBaseAddress.Click += new System.EventHandler(this.buttonRefreshBaseAddress_Click);
            // 
            // AIUtils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.ControlBox = false;
            this.Controls.Add(this.buttonRefreshBaseAddress);
            this.Controls.Add(this.pictureboxMinimize);
            this.Controls.Add(this.labelDivider2);
            this.Controls.Add(this.checkboxShowWindowOnTop);
            this.Controls.Add(this.labelDeveloped);
            this.Controls.Add(this.labelOpenCAGE);
            this.Controls.Add(this.textboxPlayerCoordinateCalculatedZ);
            this.Controls.Add(this.textboxPlayerCoordinateCalculatedY);
            this.Controls.Add(this.textboxPlayerCoordinateCalculatedX);
            this.Controls.Add(this.labelPlayerCalculatedY);
            this.Controls.Add(this.labelPlayerCalculatedZ);
            this.Controls.Add(this.labelPlayerCalculatedX);
            this.Controls.Add(this.labelDivider);
            this.Controls.Add(this.labelCheatTable);
            this.Controls.Add(this.labelSelectLevel);
            this.Controls.Add(this.textboxPlayerCoordinateZ);
            this.Controls.Add(this.textboxPlayerCoordinateY);
            this.Controls.Add(this.textboxPlayerCoordinateX);
            this.Controls.Add(this.labelPlayerY);
            this.Controls.Add(this.labelPlayerZ);
            this.Controls.Add(this.labelPlayerX);
            this.Controls.Add(this.comboboxLevels);
            this.Controls.Add(this.labelHeadline);
            this.Controls.Add(this.pictureboxExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AIUtils";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AIUtils";
            this.Load += new System.EventHandler(this.AIUtils_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AIUtils_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureboxExit;
        private System.Windows.Forms.Label labelHeadline;
        private System.Windows.Forms.ComboBox comboboxLevels;
        private System.Windows.Forms.Label labelPlayerX;
        private System.Windows.Forms.Label labelPlayerZ;
        private System.Windows.Forms.Label labelPlayerY;
        private System.Windows.Forms.TextBox textboxPlayerCoordinateX;
        private System.Windows.Forms.TextBox textboxPlayerCoordinateY;
        private System.Windows.Forms.TextBox textboxPlayerCoordinateZ;
        private System.Windows.Forms.Label labelSelectLevel;
        private System.Windows.Forms.Label labelCheatTable;
        private System.Windows.Forms.Label labelDivider;
        private System.Windows.Forms.Label labelOpenCAGE;
        private System.Windows.Forms.TextBox textboxPlayerCoordinateCalculatedZ;
        private System.Windows.Forms.TextBox textboxPlayerCoordinateCalculatedY;
        private System.Windows.Forms.TextBox textboxPlayerCoordinateCalculatedX;
        private System.Windows.Forms.Label labelPlayerCalculatedY;
        private System.Windows.Forms.Label labelPlayerCalculatedZ;
        private System.Windows.Forms.Label labelPlayerCalculatedX;
        private System.Windows.Forms.Label labelDeveloped;
        private System.Windows.Forms.CheckBox checkboxShowWindowOnTop;
        private System.Windows.Forms.Label labelDivider2;
        private System.Windows.Forms.PictureBox pictureboxMinimize;
        private System.Windows.Forms.Button buttonRefreshBaseAddress;
    }
}

