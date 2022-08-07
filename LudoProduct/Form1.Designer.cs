namespace LudoProduct
{
    partial class Ludo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameboardpanel = new System.Windows.Forms.Panel();
            this.NotiPanel = new System.Windows.Forms.Panel();
            this.NotiLabel = new System.Windows.Forms.Label();
            this.player1panel = new System.Windows.Forms.Panel();
            this.player1name = new System.Windows.Forms.Label();
            this.player1avatar = new System.Windows.Forms.PictureBox();
            this.player3panel = new System.Windows.Forms.Panel();
            this.player3name = new System.Windows.Forms.Label();
            this.player3avatar = new System.Windows.Forms.PictureBox();
            this.player2panel = new System.Windows.Forms.Panel();
            this.player2name = new System.Windows.Forms.Label();
            this.player2avatar = new System.Windows.Forms.PictureBox();
            this.player0panel = new System.Windows.Forms.Panel();
            this.player0name = new System.Windows.Forms.Label();
            this.player0avatar = new System.Windows.Forms.PictureBox();
            this.dicePanel = new System.Windows.Forms.Panel();
            this.NotiPanel.SuspendLayout();
            this.player1panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player1avatar)).BeginInit();
            this.player3panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player3avatar)).BeginInit();
            this.player2panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2avatar)).BeginInit();
            this.player0panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player0avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // gameboardpanel
            // 
            this.gameboardpanel.BackgroundImage = global::LudoProduct.Properties.Resources._900background1;
            this.gameboardpanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gameboardpanel.Location = new System.Drawing.Point(271, 88);
            this.gameboardpanel.MinimumSize = new System.Drawing.Size(900, 900);
            this.gameboardpanel.Name = "gameboardpanel";
            this.gameboardpanel.Size = new System.Drawing.Size(900, 900);
            this.gameboardpanel.TabIndex = 0;
            // 
            // NotiPanel
            // 
            this.NotiPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NotiPanel.BackgroundImage = global::LudoProduct.Properties.Resources.notibar2;
            this.NotiPanel.Controls.Add(this.NotiLabel);
            this.NotiPanel.Location = new System.Drawing.Point(271, 12);
            this.NotiPanel.Name = "NotiPanel";
            this.NotiPanel.Size = new System.Drawing.Size(900, 70);
            this.NotiPanel.TabIndex = 1;
            // 
            // NotiLabel
            // 
            this.NotiLabel.BackColor = System.Drawing.Color.Transparent;
            this.NotiLabel.Location = new System.Drawing.Point(20, 13);
            this.NotiLabel.Name = "NotiLabel";
            this.NotiLabel.Size = new System.Drawing.Size(852, 43);
            this.NotiLabel.TabIndex = 0;
            this.NotiLabel.Text = "Status:   ";
            this.NotiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // player1panel
            // 
            this.player1panel.Controls.Add(this.player1name);
            this.player1panel.Controls.Add(this.player1avatar);
            this.player1panel.Location = new System.Drawing.Point(1177, 88);
            this.player1panel.Name = "player1panel";
            this.player1panel.Size = new System.Drawing.Size(160, 206);
            this.player1panel.TabIndex = 2;
            // 
            // player1name
            // 
            this.player1name.Image = global::LudoProduct.Properties.Resources.output_onlinepngtools__2_;
            this.player1name.Location = new System.Drawing.Point(0, 163);
            this.player1name.Margin = new System.Windows.Forms.Padding(3);
            this.player1name.Name = "player1name";
            this.player1name.Size = new System.Drawing.Size(160, 40);
            this.player1name.TabIndex = 3;
            this.player1name.Text = "  Player 2";
            this.player1name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // player1avatar
            // 
            this.player1avatar.BackgroundImage = global::LudoProduct.Properties.Resources.green;
            this.player1avatar.Location = new System.Drawing.Point(0, 0);
            this.player1avatar.Margin = new System.Windows.Forms.Padding(0);
            this.player1avatar.Name = "player1avatar";
            this.player1avatar.Size = new System.Drawing.Size(160, 160);
            this.player1avatar.TabIndex = 0;
            this.player1avatar.TabStop = false;
            // 
            // player3panel
            // 
            this.player3panel.Controls.Add(this.player3name);
            this.player3panel.Controls.Add(this.player3avatar);
            this.player3panel.Location = new System.Drawing.Point(1177, 782);
            this.player3panel.Name = "player3panel";
            this.player3panel.Size = new System.Drawing.Size(160, 206);
            this.player3panel.TabIndex = 4;
            // 
            // player3name
            // 
            this.player3name.Image = global::LudoProduct.Properties.Resources.bluename;
            this.player3name.Location = new System.Drawing.Point(0, 163);
            this.player3name.Margin = new System.Windows.Forms.Padding(3);
            this.player3name.Name = "player3name";
            this.player3name.Size = new System.Drawing.Size(160, 40);
            this.player3name.TabIndex = 3;
            this.player3name.Text = "  Player 3";
            this.player3name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // player3avatar
            // 
            this.player3avatar.BackgroundImage = global::LudoProduct.Properties.Resources.blue;
            this.player3avatar.Location = new System.Drawing.Point(0, 0);
            this.player3avatar.Margin = new System.Windows.Forms.Padding(0);
            this.player3avatar.Name = "player3avatar";
            this.player3avatar.Size = new System.Drawing.Size(160, 160);
            this.player3avatar.TabIndex = 0;
            this.player3avatar.TabStop = false;
            // 
            // player2panel
            // 
            this.player2panel.Controls.Add(this.player2name);
            this.player2panel.Controls.Add(this.player2avatar);
            this.player2panel.Location = new System.Drawing.Point(105, 782);
            this.player2panel.Name = "player2panel";
            this.player2panel.Size = new System.Drawing.Size(160, 206);
            this.player2panel.TabIndex = 5;
            // 
            // player2name
            // 
            this.player2name.Image = global::LudoProduct.Properties.Resources.playeryellow;
            this.player2name.Location = new System.Drawing.Point(0, 163);
            this.player2name.Margin = new System.Windows.Forms.Padding(3);
            this.player2name.Name = "player2name";
            this.player2name.Size = new System.Drawing.Size(160, 40);
            this.player2name.TabIndex = 3;
            this.player2name.Text = "  Player 4";
            this.player2name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // player2avatar
            // 
            this.player2avatar.BackgroundImage = global::LudoProduct.Properties.Resources.yellow;
            this.player2avatar.Location = new System.Drawing.Point(0, 0);
            this.player2avatar.Margin = new System.Windows.Forms.Padding(0);
            this.player2avatar.Name = "player2avatar";
            this.player2avatar.Size = new System.Drawing.Size(160, 160);
            this.player2avatar.TabIndex = 0;
            this.player2avatar.TabStop = false;
            // 
            // player0panel
            // 
            this.player0panel.Controls.Add(this.player0name);
            this.player0panel.Controls.Add(this.player0avatar);
            this.player0panel.Location = new System.Drawing.Point(105, 85);
            this.player0panel.Name = "player0panel";
            this.player0panel.Size = new System.Drawing.Size(160, 206);
            this.player0panel.TabIndex = 6;
            // 
            // player0name
            // 
            this.player0name.Image = global::LudoProduct.Properties.Resources.playerred;
            this.player0name.Location = new System.Drawing.Point(0, 163);
            this.player0name.Margin = new System.Windows.Forms.Padding(3);
            this.player0name.Name = "player0name";
            this.player0name.Size = new System.Drawing.Size(160, 40);
            this.player0name.TabIndex = 3;
            this.player0name.Text = "  Player 1";
            this.player0name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // player0avatar
            // 
            this.player0avatar.BackgroundImage = global::LudoProduct.Properties.Resources.red;
            this.player0avatar.Location = new System.Drawing.Point(0, 0);
            this.player0avatar.Margin = new System.Windows.Forms.Padding(0);
            this.player0avatar.Name = "player0avatar";
            this.player0avatar.Size = new System.Drawing.Size(160, 160);
            this.player0avatar.TabIndex = 0;
            this.player0avatar.TabStop = false;
            // 
            // dicePanel
            // 
            this.dicePanel.Location = new System.Drawing.Point(1222, 446);
            this.dicePanel.Name = "dicePanel";
            this.dicePanel.Size = new System.Drawing.Size(170, 170);
            this.dicePanel.TabIndex = 7;
            // 
            // Ludo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1422, 1033);
            this.Controls.Add(this.dicePanel);
            this.Controls.Add(this.player0panel);
            this.Controls.Add(this.player2panel);
            this.Controls.Add(this.player3panel);
            this.Controls.Add(this.player1panel);
            this.Controls.Add(this.NotiPanel);
            this.Controls.Add(this.gameboardpanel);
            this.MinimumSize = new System.Drawing.Size(1440, 1040);
            this.Name = "Ludo";
            this.Text = "Ludo Game";
            this.NotiPanel.ResumeLayout(false);
            this.player1panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player1avatar)).EndInit();
            this.player3panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player3avatar)).EndInit();
            this.player2panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player2avatar)).EndInit();
            this.player0panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player0avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label Player1;
        private Label Player3;
        private Label Player2;
        private Label Player0;
        private Panel gameboardpanel;
        private Panel NotiPanel;
        private Panel player1panel;
        private Label player1name;
        private PictureBox player1avatar;
        private Panel player3panel;
        private Label player3name;
        private PictureBox player3avatar;
        private Panel player2panel;
        private Label player2name;
        private PictureBox player2avatar;
        private Panel player0panel;
        private Label player0name;
        private PictureBox player0avatar;
        private Label NotiLabel;
        private Panel dicePanel;
    }
}