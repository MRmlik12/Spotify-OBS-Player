namespace Spotify_OBS_Player
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Start = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.UpdateTimeField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.FontColorTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ColorDialogButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.PlayerColorTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.TitleTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.ArtistsTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.AutoSize = true;
            this.Start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Start.Depth = 0;
            this.Start.Location = new System.Drawing.Point(16, 344);
            this.Start.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Start.MouseState = MaterialSkin.MouseState.HOVER;
            this.Start.Name = "Start";
            this.Start.Primary = false;
            this.Start.Size = new System.Drawing.Size(55, 36);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(207, 344);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(57, 36);
            this.materialFlatButton2.TabIndex = 4;
            this.materialFlatButton2.Text = "About";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.MaterialFlatButton2_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 80);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(181, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Update Time (in seconds)";
            // 
            // UpdateTimeField
            // 
            this.UpdateTimeField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateTimeField.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpdateTimeField.Depth = 0;
            this.UpdateTimeField.Hint = "";
            this.UpdateTimeField.Location = new System.Drawing.Point(199, 80);
            this.UpdateTimeField.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateTimeField.Name = "UpdateTimeField";
            this.UpdateTimeField.PasswordChar = '\0';
            this.UpdateTimeField.SelectedText = "";
            this.UpdateTimeField.SelectionLength = 0;
            this.UpdateTimeField.SelectionStart = 0;
            this.UpdateTimeField.Size = new System.Drawing.Size(188, 23);
            this.UpdateTimeField.TabIndex = 6;
            this.UpdateTimeField.Text = "10";
            this.UpdateTimeField.UseSystemPasswordChar = false;
            this.UpdateTimeField.Click += new System.EventHandler(this.UpdateTimeField_Click);
            this.UpdateTimeField.TextChanged += new System.EventHandler(this.UpdateTimeField_TextChanged);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(79, 344);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(120, 36);
            this.materialFlatButton1.TabIndex = 7;
            this.materialFlatButton1.Text = "Check Updates";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.MaterialFlatButton1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 154);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(80, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Font Color";
            // 
            // FontColorTextBox
            // 
            this.FontColorTextBox.Depth = 0;
            this.FontColorTextBox.Hint = "";
            this.FontColorTextBox.Location = new System.Drawing.Point(89, 150);
            this.FontColorTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.FontColorTextBox.Name = "FontColorTextBox";
            this.FontColorTextBox.PasswordChar = '\0';
            this.FontColorTextBox.SelectedText = "";
            this.FontColorTextBox.SelectionLength = 0;
            this.FontColorTextBox.SelectionStart = 0;
            this.FontColorTextBox.Size = new System.Drawing.Size(188, 23);
            this.FontColorTextBox.TabIndex = 9;
            this.FontColorTextBox.UseSystemPasswordChar = false;
            this.FontColorTextBox.TextChanged += new System.EventHandler(this.FontColorTextBox_TextChanged);
            // 
            // ColorDialogButton
            // 
            this.ColorDialogButton.Depth = 0;
            this.ColorDialogButton.Location = new System.Drawing.Point(283, 150);
            this.ColorDialogButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ColorDialogButton.Name = "ColorDialogButton";
            this.ColorDialogButton.Primary = true;
            this.ColorDialogButton.Size = new System.Drawing.Size(28, 23);
            this.ColorDialogButton.TabIndex = 10;
            this.ColorDialogButton.Text = "...";
            this.ColorDialogButton.UseVisualStyleBackColor = true;
            this.ColorDialogButton.Click += new System.EventHandler(this.ColorDialogButton_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 192);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(129, 19);
            this.materialLabel3.TabIndex = 11;
            this.materialLabel3.Text = "Background Color";
            // 
            // PlayerColorTextBox
            // 
            this.PlayerColorTextBox.Depth = 0;
            this.PlayerColorTextBox.Hint = "";
            this.PlayerColorTextBox.Location = new System.Drawing.Point(147, 188);
            this.PlayerColorTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.PlayerColorTextBox.Name = "PlayerColorTextBox";
            this.PlayerColorTextBox.PasswordChar = '\0';
            this.PlayerColorTextBox.SelectedText = "";
            this.PlayerColorTextBox.SelectionLength = 0;
            this.PlayerColorTextBox.SelectionStart = 0;
            this.PlayerColorTextBox.Size = new System.Drawing.Size(155, 23);
            this.PlayerColorTextBox.TabIndex = 12;
            this.PlayerColorTextBox.UseSystemPasswordChar = false;
            this.PlayerColorTextBox.TextChanged += new System.EventHandler(this.PlayerColorTextBox_TextChanged);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(308, 188);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(28, 23);
            this.materialRaisedButton1.TabIndex = 13;
            this.materialRaisedButton1.Text = "...";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.ColorDialogButton_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 117);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(105, 19);
            this.materialLabel4.TabIndex = 14;
            this.materialLabel4.Text = "Font Size Title";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Depth = 0;
            this.TitleTextBox.Hint = "";
            this.TitleTextBox.Location = new System.Drawing.Point(123, 113);
            this.TitleTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.PasswordChar = '\0';
            this.TitleTextBox.SelectedText = "";
            this.TitleTextBox.SelectionLength = 0;
            this.TitleTextBox.SelectionStart = 0;
            this.TitleTextBox.Size = new System.Drawing.Size(35, 23);
            this.TitleTextBox.TabIndex = 15;
            this.TitleTextBox.UseSystemPasswordChar = false;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(164, 117);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(120, 19);
            this.materialLabel5.TabIndex = 16;
            this.materialLabel5.Text = "Font Size Artists";
            // 
            // ArtistsTextBox
            // 
            this.ArtistsTextBox.Depth = 0;
            this.ArtistsTextBox.Hint = "";
            this.ArtistsTextBox.Location = new System.Drawing.Point(290, 113);
            this.ArtistsTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ArtistsTextBox.Name = "ArtistsTextBox";
            this.ArtistsTextBox.PasswordChar = '\0';
            this.ArtistsTextBox.SelectedText = "";
            this.ArtistsTextBox.SelectionLength = 0;
            this.ArtistsTextBox.SelectionStart = 0;
            this.ArtistsTextBox.Size = new System.Drawing.Size(35, 23);
            this.ArtistsTextBox.TabIndex = 17;
            this.ArtistsTextBox.UseSystemPasswordChar = false;
            this.ArtistsTextBox.TextChanged += new System.EventHandler(this.ArtistsTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 395);
            this.Controls.Add(this.ArtistsTextBox);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.PlayerColorTextBox);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.ColorDialogButton);
            this.Controls.Add(this.FontColorTextBox);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.UpdateTimeField);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.Start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Spotify OBS Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton Start;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField UpdateTimeField;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField FontColorTextBox;
        private MaterialSkin.Controls.MaterialRaisedButton ColorDialogButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField PlayerColorTextBox;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField TitleTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField ArtistsTextBox;
    }
}

