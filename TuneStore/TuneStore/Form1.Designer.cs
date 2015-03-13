namespace TuneStore
{
    partial class TuneStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TuneStore));
            this.label1 = new System.Windows.Forms.Label();
            this.rtbMusic = new System.Windows.Forms.RichTextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSongName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbArtist = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAlbum = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miTuneStore = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miClose = new System.Windows.Forms.ToolStripMenuItem();
            this.miInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.sfdMusic = new System.Windows.Forms.SaveFileDialog();
            this.ofdMusic = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Music;";
            // 
            // rtbMusic
            // 
            this.rtbMusic.Location = new System.Drawing.Point(281, 38);
            this.rtbMusic.Name = "rtbMusic";
            this.rtbMusic.Size = new System.Drawing.Size(326, 158);
            this.rtbMusic.TabIndex = 1;
            this.rtbMusic.Text = "";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(12, 31);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Song Name;";
            // 
            // tbSongName
            // 
            this.tbSongName.Location = new System.Drawing.Point(93, 82);
            this.tbSongName.Name = "tbSongName";
            this.tbSongName.Size = new System.Drawing.Size(100, 20);
            this.tbSongName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Artist;";
            // 
            // tbArtist
            // 
            this.tbArtist.Location = new System.Drawing.Point(93, 116);
            this.tbArtist.Name = "tbArtist";
            this.tbArtist.Size = new System.Drawing.Size(100, 20);
            this.tbArtist.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Album;";
            // 
            // tbAlbum
            // 
            this.tbAlbum.Location = new System.Drawing.Point(93, 148);
            this.tbAlbum.Name = "tbAlbum";
            this.tbAlbum.Size = new System.Drawing.Size(100, 20);
            this.tbAlbum.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 215);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miTuneStore,
            this.miInformation});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(619, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miTuneStore
            // 
            this.miTuneStore.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSaveAs,
            this.miOpen,
            this.miClose});
            this.miTuneStore.Name = "miTuneStore";
            this.miTuneStore.Size = new System.Drawing.Size(73, 20);
            this.miTuneStore.Text = "TuneStore";
            // 
            // miSaveAs
            // 
            this.miSaveAs.Name = "miSaveAs";
            this.miSaveAs.Size = new System.Drawing.Size(118, 22);
            this.miSaveAs.Text = "Save as..";
            this.miSaveAs.Click += new System.EventHandler(this.miSaveAs_Click);
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(118, 22);
            this.miOpen.Text = "Open..";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miClose
            // 
            this.miClose.Name = "miClose";
            this.miClose.Size = new System.Drawing.Size(118, 22);
            this.miClose.Text = "Close";
            this.miClose.Click += new System.EventHandler(this.miClose_Click);
            // 
            // miInformation
            // 
            this.miInformation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAbout});
            this.miInformation.Name = "miInformation";
            this.miInformation.Size = new System.Drawing.Size(82, 20);
            this.miInformation.Text = "Information";
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(113, 22);
            this.miAbout.Text = "About..";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "File Location;";
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(93, 176);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(100, 20);
            this.tbLocation.TabIndex = 14;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(118, 215);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 15;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // ofdMusic
            // 
            this.ofdMusic.FileName = "openFileDialog1";
            // 
            // TuneStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 250);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbAlbum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbArtist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSongName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.rtbMusic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TuneStore";
            this.Text = "Tune Store";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbMusic;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSongName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbArtist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAlbum;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miTuneStore;
        private System.Windows.Forms.ToolStripMenuItem miSaveAs;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.SaveFileDialog sfdMusic;
        private System.Windows.Forms.OpenFileDialog ofdMusic;
        private System.Windows.Forms.ToolStripMenuItem miClose;
        private System.Windows.Forms.ToolStripMenuItem miInformation;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
    }
}

