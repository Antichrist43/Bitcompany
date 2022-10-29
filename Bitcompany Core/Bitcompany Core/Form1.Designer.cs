namespace Bitcompany_Core
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPorfolioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myPortfolioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendBitcompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiveBitcompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionV0001ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitcompanyChainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFriendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFriendToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inviteAFriendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.friendRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mitLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.networkToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(999, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPorfolioToolStripMenuItem,
            this.myPortfolioToolStripMenuItem,
            this.sendBitcompanyToolStripMenuItem,
            this.receiveBitcompanyToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createPorfolioToolStripMenuItem
            // 
            this.createPorfolioToolStripMenuItem.Name = "createPorfolioToolStripMenuItem";
            this.createPorfolioToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.createPorfolioToolStripMenuItem.Text = "Create Bitcompany Portfolio";
            this.createPorfolioToolStripMenuItem.Click += new System.EventHandler(this.createPorfolioToolStripMenuItem_Click);
            // 
            // myPortfolioToolStripMenuItem
            // 
            this.myPortfolioToolStripMenuItem.Name = "myPortfolioToolStripMenuItem";
            this.myPortfolioToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.myPortfolioToolStripMenuItem.Text = "My Bitcompany Portfolio";
            this.myPortfolioToolStripMenuItem.Click += new System.EventHandler(this.myPortfolioToolStripMenuItem_Click);
            // 
            // sendBitcompanyToolStripMenuItem
            // 
            this.sendBitcompanyToolStripMenuItem.Name = "sendBitcompanyToolStripMenuItem";
            this.sendBitcompanyToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.sendBitcompanyToolStripMenuItem.Text = "Send a Bitcompany | TO:";
            this.sendBitcompanyToolStripMenuItem.Click += new System.EventHandler(this.sendBitcompanyToolStripMenuItem_Click);
            // 
            // receiveBitcompanyToolStripMenuItem
            // 
            this.receiveBitcompanyToolStripMenuItem.Name = "receiveBitcompanyToolStripMenuItem";
            this.receiveBitcompanyToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.receiveBitcompanyToolStripMenuItem.Text = "Request a Bitcompany | FROM:";
            this.receiveBitcompanyToolStripMenuItem.Click += new System.EventHandler(this.receiveBitcompanyToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(237, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.versionV0001ToolStripMenuItem,
            this.fAQToolStripMenuItem,
            this.mitLicenseToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // versionV0001ToolStripMenuItem
            // 
            this.versionV0001ToolStripMenuItem.Name = "versionV0001ToolStripMenuItem";
            this.versionV0001ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.versionV0001ToolStripMenuItem.Text = "Version v.0.0.0.1";
            this.versionV0001ToolStripMenuItem.Click += new System.EventHandler(this.versionV0001ToolStripMenuItem_Click);
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fAQToolStripMenuItem.Text = "FAQ";
            this.fAQToolStripMenuItem.Click += new System.EventHandler(this.fAQToolStripMenuItem_Click);
            // 
            // networkToolStripMenuItem
            // 
            this.networkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitcompanyChainToolStripMenuItem,
            this.addFriendToolStripMenuItem,
            this.addFriendToolStripMenuItem1,
            this.inviteAFriendToolStripMenuItem,
            this.friendRequestToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.statsToolStripMenuItem});
            this.networkToolStripMenuItem.Name = "networkToolStripMenuItem";
            this.networkToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.networkToolStripMenuItem.Text = "Network";
            // 
            // bitcompanyChainToolStripMenuItem
            // 
            this.bitcompanyChainToolStripMenuItem.Name = "bitcompanyChainToolStripMenuItem";
            this.bitcompanyChainToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.bitcompanyChainToolStripMenuItem.Text = "Network Chain";
            this.bitcompanyChainToolStripMenuItem.Click += new System.EventHandler(this.bitcompanyChainToolStripMenuItem_Click);
            // 
            // addFriendToolStripMenuItem
            // 
            this.addFriendToolStripMenuItem.Name = "addFriendToolStripMenuItem";
            this.addFriendToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addFriendToolStripMenuItem.Text = "Invite a Friend ";
            // 
            // addFriendToolStripMenuItem1
            // 
            this.addFriendToolStripMenuItem1.Name = "addFriendToolStripMenuItem1";
            this.addFriendToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.addFriendToolStripMenuItem1.Text = "Find Friend ";
            // 
            // inviteAFriendToolStripMenuItem
            // 
            this.inviteAFriendToolStripMenuItem.Name = "inviteAFriendToolStripMenuItem";
            this.inviteAFriendToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.inviteAFriendToolStripMenuItem.Text = "Friend Requests ";
            // 
            // friendRequestToolStripMenuItem
            // 
            this.friendRequestToolStripMenuItem.Name = "friendRequestToolStripMenuItem";
            this.friendRequestToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.friendRequestToolStripMenuItem.Text = "Friends ";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // statsToolStripMenuItem
            // 
            this.statsToolStripMenuItem.Name = "statsToolStripMenuItem";
            this.statsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.statsToolStripMenuItem.Text = "Stats";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1 Bitcompany: $1.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Earned: $0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 524);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Network: Online";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(45, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Friends: 0";
            // 
            // mitLicenseToolStripMenuItem
            // 
            this.mitLicenseToolStripMenuItem.Name = "mitLicenseToolStripMenuItem";
            this.mitLicenseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mitLicenseToolStripMenuItem.Text = "Mit License";
            this.mitLicenseToolStripMenuItem.Click += new System.EventHandler(this.mitLicenseToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(999, 625);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Bitcompany Core";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPorfolioToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem myPortfolioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionV0001ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendBitcompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiveBitcompanyToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem networkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitcompanyChainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFriendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFriendToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inviteAFriendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem friendRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statsToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem mitLicenseToolStripMenuItem;
    }
}

