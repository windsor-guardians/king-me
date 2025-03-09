namespace kingme
{
    partial class Game
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
            this.lstFavorites = new System.Windows.Forms.ListBox();
            this.lblCardsTitle = new System.Windows.Forms.Label();
            this.btnListCards = new System.Windows.Forms.Button();
            this.btnInitializeMatch = new System.Windows.Forms.Button();
            this.btnUpdatePlayerList = new System.Windows.Forms.Button();
            this.lblListPlayers = new System.Windows.Forms.Label();
            this.lstMatchPlayers = new System.Windows.Forms.ListBox();
            this.lblPlayerPassword = new System.Windows.Forms.Label();
            this.lblPlayerID = new System.Windows.Forms.Label();
            this.txtPlayerPassword = new System.Windows.Forms.TextBox();
            this.txtPlayerId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lstCards = new System.Windows.Forms.ListBox();
            this.lblVersionGame = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstFavorites
            // 
            this.lstFavorites.FormattingEnabled = true;
            this.lstFavorites.ItemHeight = 16;
            this.lstFavorites.Location = new System.Drawing.Point(969, 65);
            this.lstFavorites.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstFavorites.Name = "lstFavorites";
            this.lstFavorites.Size = new System.Drawing.Size(376, 324);
            this.lstFavorites.TabIndex = 41;
            this.lstFavorites.SelectedIndexChanged += new System.EventHandler(this.lstFavorites_SelectedIndexChanged);
            // 
            // lblCardsTitle
            // 
            this.lblCardsTitle.AutoSize = true;
            this.lblCardsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblCardsTitle.Location = new System.Drawing.Point(963, 415);
            this.lblCardsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardsTitle.Name = "lblCardsTitle";
            this.lblCardsTitle.Size = new System.Drawing.Size(178, 31);
            this.lblCardsTitle.TabIndex = 42;
            this.lblCardsTitle.Text = "Suas cartas:";
            this.lblCardsTitle.Click += new System.EventHandler(this.lblCardsTitle_Click);
            // 
            // btnListCards
            // 
            this.btnListCards.BackColor = System.Drawing.Color.Black;
            this.btnListCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnListCards.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListCards.Location = new System.Drawing.Point(969, 583);
            this.btnListCards.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListCards.Name = "btnListCards";
            this.btnListCards.Size = new System.Drawing.Size(225, 43);
            this.btnListCards.TabIndex = 43;
            this.btnListCards.Text = "Listar cartas";
            this.btnListCards.UseVisualStyleBackColor = false;
            this.btnListCards.Click += new System.EventHandler(this.btnListCards_Click);
            // 
            // btnInitializeMatch
            // 
            this.btnInitializeMatch.BackColor = System.Drawing.Color.Black;
            this.btnInitializeMatch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInitializeMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnInitializeMatch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInitializeMatch.Location = new System.Drawing.Point(21, 177);
            this.btnInitializeMatch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInitializeMatch.Name = "btnInitializeMatch";
            this.btnInitializeMatch.Size = new System.Drawing.Size(229, 43);
            this.btnInitializeMatch.TabIndex = 31;
            this.btnInitializeMatch.Text = "Iniciar partida";
            this.btnInitializeMatch.UseVisualStyleBackColor = false;
            this.btnInitializeMatch.Click += new System.EventHandler(this.btnInitializeMatch_Click);
            // 
            // btnUpdatePlayerList
            // 
            this.btnUpdatePlayerList.BackColor = System.Drawing.Color.Black;
            this.btnUpdatePlayerList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdatePlayerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdatePlayerList.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePlayerList.Location = new System.Drawing.Point(21, 546);
            this.btnUpdatePlayerList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdatePlayerList.Name = "btnUpdatePlayerList";
            this.btnUpdatePlayerList.Size = new System.Drawing.Size(229, 43);
            this.btnUpdatePlayerList.TabIndex = 40;
            this.btnUpdatePlayerList.Text = "Atualizar";
            this.btnUpdatePlayerList.UseVisualStyleBackColor = false;
            this.btnUpdatePlayerList.Click += new System.EventHandler(this.btnUpdatePlayerList_Click);
            // 
            // lblListPlayers
            // 
            this.lblListPlayers.AutoSize = true;
            this.lblListPlayers.BackColor = System.Drawing.Color.Transparent;
            this.lblListPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblListPlayers.ForeColor = System.Drawing.Color.White;
            this.lblListPlayers.Location = new System.Drawing.Point(15, 258);
            this.lblListPlayers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListPlayers.Name = "lblListPlayers";
            this.lblListPlayers.Size = new System.Drawing.Size(253, 31);
            this.lblListPlayers.TabIndex = 37;
            this.lblListPlayers.Text = "Lista de jogadores";
            // 
            // lstMatchPlayers
            // 
            this.lstMatchPlayers.FormattingEnabled = true;
            this.lstMatchPlayers.ItemHeight = 16;
            this.lstMatchPlayers.Location = new System.Drawing.Point(20, 294);
            this.lstMatchPlayers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstMatchPlayers.Name = "lstMatchPlayers";
            this.lstMatchPlayers.Size = new System.Drawing.Size(229, 244);
            this.lstMatchPlayers.TabIndex = 36;
            this.lstMatchPlayers.SelectedIndexChanged += new System.EventHandler(this.lstMatchPlayers_SelectedIndexChanged);
            // 
            // lblPlayerPassword
            // 
            this.lblPlayerPassword.AutoSize = true;
            this.lblPlayerPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerPassword.ForeColor = System.Drawing.Color.White;
            this.lblPlayerPassword.Location = new System.Drawing.Point(21, 126);
            this.lblPlayerPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerPassword.Name = "lblPlayerPassword";
            this.lblPlayerPassword.Size = new System.Drawing.Size(122, 16);
            this.lblPlayerPassword.TabIndex = 34;
            this.lblPlayerPassword.Text = "Senha do Jogador:";
            // 
            // lblPlayerID
            // 
            this.lblPlayerID.AutoSize = true;
            this.lblPlayerID.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerID.ForeColor = System.Drawing.Color.White;
            this.lblPlayerID.Location = new System.Drawing.Point(21, 63);
            this.lblPlayerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerID.Name = "lblPlayerID";
            this.lblPlayerID.Size = new System.Drawing.Size(96, 16);
            this.lblPlayerID.TabIndex = 32;
            this.lblPlayerID.Text = "ID do Jogador:";
            // 
            // txtPlayerPassword
            // 
            this.txtPlayerPassword.Location = new System.Drawing.Point(21, 145);
            this.txtPlayerPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlayerPassword.Name = "txtPlayerPassword";
            this.txtPlayerPassword.ReadOnly = true;
            this.txtPlayerPassword.Size = new System.Drawing.Size(228, 22);
            this.txtPlayerPassword.TabIndex = 46;
            // 
            // txtPlayerId
            // 
            this.txtPlayerId.Location = new System.Drawing.Point(23, 85);
            this.txtPlayerId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlayerId.Name = "txtPlayerId";
            this.txtPlayerId.ReadOnly = true;
            this.txtPlayerId.Size = new System.Drawing.Size(228, 22);
            this.txtPlayerId.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 31);
            this.label1.TabIndex = 47;
            this.label1.Text = "Info";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::kingme.Properties.Resources.wood;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnInitializeMatch);
            this.panel1.Controls.Add(this.lstMatchPlayers);
            this.panel1.Controls.Add(this.lblListPlayers);
            this.panel1.Controls.Add(this.lblPlayerPassword);
            this.panel1.Controls.Add(this.btnUpdatePlayerList);
            this.panel1.Controls.Add(this.lblPlayerID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPlayerPassword);
            this.panel1.Controls.Add(this.txtPlayerId);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 652);
            this.panel1.TabIndex = 48;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(25, 598);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 42);
            this.button1.TabIndex = 48;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(963, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 31);
            this.label2.TabIndex = 48;
            this.label2.Text = "Personagens";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.Black;
            this.lblVersion.Location = new System.Drawing.Point(1199, 642);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(88, 25);
            this.lblVersion.TabIndex = 50;
            this.lblVersion.Text = "Versão:";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.BackColor = System.Drawing.Color.Transparent;
            this.lblTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam.ForeColor = System.Drawing.Color.Black;
            this.lblTeam.Location = new System.Drawing.Point(969, 642);
            this.lblTeam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(197, 25);
            this.lblTeam.TabIndex = 49;
            this.lblTeam.Text = "Windsor Guardians";
            // 
            // lstCards
            // 
            this.lstCards.FormattingEnabled = true;
            this.lstCards.ItemHeight = 16;
            this.lstCards.Location = new System.Drawing.Point(969, 459);
            this.lstCards.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCards.Name = "lstCards";
            this.lstCards.Size = new System.Drawing.Size(376, 116);
            this.lstCards.TabIndex = 51;
            this.lstCards.SelectedIndexChanged += new System.EventHandler(this.lstCards_SelectedIndexChanged);
            // 
            // lblVersionGame
            // 
            this.lblVersionGame.AutoSize = true;
            this.lblVersionGame.Location = new System.Drawing.Point(1294, 649);
            this.lblVersionGame.Name = "lblVersionGame";
            this.lblVersionGame.Size = new System.Drawing.Size(44, 16);
            this.lblVersionGame.TabIndex = 52;
            this.lblVersionGame.Text = "label3";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 676);
            this.Controls.Add(this.lblVersionGame);
            this.Controls.Add(this.lstCards);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnListCards);
            this.Controls.Add(this.lblCardsTitle);
            this.Controls.Add(this.lstFavorites);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstFavorites;
        private System.Windows.Forms.Label lblCardsTitle;
        private System.Windows.Forms.Button btnListCards;
        private System.Windows.Forms.Button btnInitializeMatch;
        private System.Windows.Forms.Button btnUpdatePlayerList;
        private System.Windows.Forms.Label lblListPlayers;
        private System.Windows.Forms.ListBox lstMatchPlayers;
        private System.Windows.Forms.Label lblPlayerPassword;
        private System.Windows.Forms.Label lblPlayerID;
        private System.Windows.Forms.TextBox txtPlayerPassword;
        private System.Windows.Forms.TextBox txtPlayerId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstCards;
        private System.Windows.Forms.Label lblVersionGame;
    }
}