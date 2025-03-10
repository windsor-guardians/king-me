﻿namespace kingme
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
            this.lblCardsContent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lstCards = new System.Windows.Forms.ListBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.txtPlayerId = new System.Windows.Forms.TextBox();
            this.txtPlayerPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerID = new System.Windows.Forms.Label();
            this.btnUpdatePlayerList = new System.Windows.Forms.Button();
            this.lblPlayerPassword = new System.Windows.Forms.Label();
            this.lblListPlayers = new System.Windows.Forms.Label();
            this.lstMatchPlayers = new System.Windows.Forms.ListBox();
            this.btnInitializeMatch = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstFavorites
            // 
            this.lstFavorites.FormattingEnabled = true;
            this.lstFavorites.Location = new System.Drawing.Point(731, 72);
            this.lstFavorites.Name = "lstFavorites";
            this.lstFavorites.Size = new System.Drawing.Size(283, 264);
            this.lstFavorites.TabIndex = 41;
            // 
            // lblCardsTitle
            // 
            this.lblCardsTitle.AutoSize = true;
            this.lblCardsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCardsTitle.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblCardsTitle.Location = new System.Drawing.Point(726, 344);
            this.lblCardsTitle.Name = "lblCardsTitle";
            this.lblCardsTitle.Size = new System.Drawing.Size(127, 26);
            this.lblCardsTitle.TabIndex = 42;
            this.lblCardsTitle.Text = "Suas cartas:";
            // 
            // btnListCards
            // 
            this.btnListCards.BackColor = System.Drawing.Color.Black;
            this.btnListCards.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListCards.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnListCards.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListCards.Location = new System.Drawing.Point(783, 474);
            this.btnListCards.Name = "btnListCards";
            this.btnListCards.Size = new System.Drawing.Size(169, 35);
            this.btnListCards.TabIndex = 43;
            this.btnListCards.Text = "Listar cartas";
            this.btnListCards.UseVisualStyleBackColor = false;
            this.btnListCards.Click += new System.EventHandler(this.btnListCards_Click);
            // 
            // lblCardsContent
            // 
            this.lblCardsContent.AutoSize = true;
            this.lblCardsContent.Location = new System.Drawing.Point(855, 349);
            this.lblCardsContent.Name = "lblCardsContent";
            this.lblCardsContent.Size = new System.Drawing.Size(0, 13);
            this.lblCardsContent.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(726, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 26);
            this.label2.TabIndex = 48;
            this.label2.Text = "Personagens";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(535, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Versão:";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.BackColor = System.Drawing.Color.Transparent;
            this.lblTeam.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam.ForeColor = System.Drawing.Color.Black;
            this.lblTeam.Location = new System.Drawing.Point(359, 43);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(128, 20);
            this.lblTeam.TabIndex = 49;
            this.lblTeam.Text = "Windsor Guardians";
            // 
            // lstCards
            // 
            this.lstCards.FormattingEnabled = true;
            this.lstCards.Location = new System.Drawing.Point(727, 373);
            this.lstCards.Name = "lstCards";
            this.lstCards.Size = new System.Drawing.Size(283, 95);
            this.lstCards.TabIndex = 51;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(607, 48);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(0, 13);
            this.lblVersion.TabIndex = 52;
            // 
            // txtPlayerId
            // 
            this.txtPlayerId.Location = new System.Drawing.Point(38, 77);
            this.txtPlayerId.Name = "txtPlayerId";
            this.txtPlayerId.ReadOnly = true;
            this.txtPlayerId.Size = new System.Drawing.Size(172, 20);
            this.txtPlayerId.TabIndex = 45;
            // 
            // txtPlayerPassword
            // 
            this.txtPlayerPassword.Location = new System.Drawing.Point(37, 126);
            this.txtPlayerPassword.Name = "txtPlayerPassword";
            this.txtPlayerPassword.ReadOnly = true;
            this.txtPlayerPassword.Size = new System.Drawing.Size(172, 20);
            this.txtPlayerPassword.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 26);
            this.label1.TabIndex = 47;
            this.label1.Text = "Info";
            // 
            // lblPlayerID
            // 
            this.lblPlayerID.AutoSize = true;
            this.lblPlayerID.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerID.ForeColor = System.Drawing.Color.Black;
            this.lblPlayerID.Location = new System.Drawing.Point(37, 59);
            this.lblPlayerID.Name = "lblPlayerID";
            this.lblPlayerID.Size = new System.Drawing.Size(91, 13);
            this.lblPlayerID.TabIndex = 32;
            this.lblPlayerID.Text = "ID do Jogador:";
            // 
            // btnUpdatePlayerList
            // 
            this.btnUpdatePlayerList.BackColor = System.Drawing.Color.Black;
            this.btnUpdatePlayerList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdatePlayerList.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdatePlayerList.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePlayerList.Location = new System.Drawing.Point(37, 452);
            this.btnUpdatePlayerList.Name = "btnUpdatePlayerList";
            this.btnUpdatePlayerList.Size = new System.Drawing.Size(172, 35);
            this.btnUpdatePlayerList.TabIndex = 40;
            this.btnUpdatePlayerList.Text = "Atualizar";
            this.btnUpdatePlayerList.UseVisualStyleBackColor = false;
            this.btnUpdatePlayerList.Click += new System.EventHandler(this.btnUpdatePlayerList_Click);
            // 
            // lblPlayerPassword
            // 
            this.lblPlayerPassword.AutoSize = true;
            this.lblPlayerPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPlayerPassword.Location = new System.Drawing.Point(37, 110);
            this.lblPlayerPassword.Name = "lblPlayerPassword";
            this.lblPlayerPassword.Size = new System.Drawing.Size(114, 13);
            this.lblPlayerPassword.TabIndex = 34;
            this.lblPlayerPassword.Text = "Senha do Jogador:";
            // 
            // lblListPlayers
            // 
            this.lblListPlayers.AutoSize = true;
            this.lblListPlayers.BackColor = System.Drawing.Color.Transparent;
            this.lblListPlayers.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblListPlayers.ForeColor = System.Drawing.Color.Black;
            this.lblListPlayers.Location = new System.Drawing.Point(32, 218);
            this.lblListPlayers.Name = "lblListPlayers";
            this.lblListPlayers.Size = new System.Drawing.Size(177, 26);
            this.lblListPlayers.TabIndex = 37;
            this.lblListPlayers.Text = "Lista de jogadores";
            // 
            // lstMatchPlayers
            // 
            this.lstMatchPlayers.FormattingEnabled = true;
            this.lstMatchPlayers.Location = new System.Drawing.Point(36, 247);
            this.lstMatchPlayers.Name = "lstMatchPlayers";
            this.lstMatchPlayers.Size = new System.Drawing.Size(173, 199);
            this.lstMatchPlayers.TabIndex = 36;
            this.lstMatchPlayers.SelectedIndexChanged += new System.EventHandler(this.lstMatchPlayers_SelectedIndexChanged);
            // 
            // btnInitializeMatch
            // 
            this.btnInitializeMatch.BackColor = System.Drawing.Color.Black;
            this.btnInitializeMatch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInitializeMatch.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnInitializeMatch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInitializeMatch.Location = new System.Drawing.Point(37, 152);
            this.btnInitializeMatch.Name = "btnInitializeMatch";
            this.btnInitializeMatch.Size = new System.Drawing.Size(172, 35);
            this.btnInitializeMatch.TabIndex = 31;
            this.btnInitializeMatch.Text = "Iniciar partida";
            this.btnInitializeMatch.UseVisualStyleBackColor = false;
            this.btnInitializeMatch.Click += new System.EventHandler(this.btnInitializeMatch_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.BackColor = System.Drawing.Color.Red;
            this.btnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeave.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnLeave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLeave.Location = new System.Drawing.Point(40, 494);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(169, 34);
            this.btnLeave.TabIndex = 48;
            this.btnLeave.Text = "Sair";
            this.btnLeave.UseVisualStyleBackColor = false;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kingme.Properties.Resources.texture1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 549);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnInitializeMatch);
            this.Controls.Add(this.lstCards);
            this.Controls.Add(this.lstMatchPlayers);
            this.Controls.Add(this.lblListPlayers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPlayerPassword);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.btnUpdatePlayerList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlayerID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCardsContent);
            this.Controls.Add(this.txtPlayerPassword);
            this.Controls.Add(this.btnListCards);
            this.Controls.Add(this.txtPlayerId);
            this.Controls.Add(this.lblCardsTitle);
            this.Controls.Add(this.lstFavorites);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstFavorites;
        private System.Windows.Forms.Label lblCardsTitle;
        private System.Windows.Forms.Button btnListCards;
        private System.Windows.Forms.Label lblCardsContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.ListBox lstCards;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TextBox txtPlayerId;
        private System.Windows.Forms.TextBox txtPlayerPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerID;
        private System.Windows.Forms.Button btnUpdatePlayerList;
        private System.Windows.Forms.Label lblPlayerPassword;
        private System.Windows.Forms.Label lblListPlayers;
        private System.Windows.Forms.ListBox lstMatchPlayers;
        private System.Windows.Forms.Button btnInitializeMatch;
        private System.Windows.Forms.Button btnLeave;
    }
}