namespace Spotify_OBS_Player.Forms
{
    partial class Playback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playback));
            this.Thumbnail = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.Artist = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // Thumbnail
            // 
            this.Thumbnail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Thumbnail.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Thumbnail.ErrorImage")));
            this.Thumbnail.Image = ((System.Drawing.Image)(resources.GetObject("Thumbnail.Image")));
            this.Thumbnail.Location = new System.Drawing.Point(12, 12);
            this.Thumbnail.Name = "Thumbnail";
            this.Thumbnail.Size = new System.Drawing.Size(103, 101);
            this.Thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Thumbnail.TabIndex = 0;
            this.Thumbnail.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title.Location = new System.Drawing.Point(121, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(58, 13);
            this.Title.TabIndex = 1;
            this.Title.Text = "Track Title";
            // 
            // Artist
            // 
            this.Artist.AutoSize = true;
            this.Artist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Artist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Artist.Location = new System.Drawing.Point(121, 36);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(30, 13);
            this.Artist.TabIndex = 2;
            this.Artist.Text = "Artist";
            this.Artist.Click += new System.EventHandler(this.Artist_Click);
            // 
            // Playback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(505, 125);
            this.Controls.Add(this.Artist);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Thumbnail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Playback";
            this.Text = "Playback";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Playback_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Playback_FormClosed);
            this.Load += new System.EventHandler(this.Playback_Load);
            this.Shown += new System.EventHandler(this.Playback_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Thumbnail;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Artist;
    }
}