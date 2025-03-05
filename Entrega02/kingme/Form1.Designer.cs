namespace kingme
{
    partial class lobby
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListMatches = new System.Windows.Forms.Button();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.lblVersionTitle = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lstMatches = new System.Windows.Forms.ListBox();
            this.lstMatchPlayers = new System.Windows.Forms.ListBox();
            this.lstMatchesTitle = new System.Windows.Forms.Label();
            this.lblNameMatch = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.txtMatchName = new System.Windows.Forms.TextBox();
            this.lblPasswordMatch = new System.Windows.Forms.Label();
            this.txtPasswordMatch = new System.Windows.Forms.TextBox();
            this.lblGroupNameMatch = new System.Windows.Forms.Label();
            this.txtGroupNameMatch = new System.Windows.Forms.TextBox();
            this.btnCreateNewMatch = new System.Windows.Forms.Button();
            this.lblCreateMatch = new System.Windows.Forms.Label();
            this.lblListPlayers = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.txtIdMatch = new System.Windows.Forms.TextBox();
            this.txtPasswordCurrentMatch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMatchStart = new System.Windows.Forms.Button();
            this.btnInitializeMatch = new System.Windows.Forms.Button();
            this.lblPlayerID = new System.Windows.Forms.Label();
            this.txtPlayerId = new System.Windows.Forms.TextBox();
            this.lblPlayerPassword = new System.Windows.Forms.Label();
            this.txtPlayerPassword = new System.Windows.Forms.TextBox();
            this.lstCharacters = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnListMatches
            // 
            this.btnListMatches.BackColor = System.Drawing.Color.Black;
            this.btnListMatches.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListMatches.ForeColor = System.Drawing.Color.White;
            this.btnListMatches.Location = new System.Drawing.Point(97, 26);
            this.btnListMatches.Name = "btnListMatches";
            this.btnListMatches.Size = new System.Drawing.Size(210, 35);
            this.btnListMatches.TabIndex = 0;
            this.btnListMatches.Text = "Listar partidas";
            this.btnListMatches.UseVisualStyleBackColor = false;
            this.btnListMatches.Click += new System.EventHandler(this.btnListMatches_Click);
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.BackColor = System.Drawing.Color.Transparent;
            this.lblGroupName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupName.ForeColor = System.Drawing.Color.White;
            this.lblGroupName.Location = new System.Drawing.Point(1444, 566);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(148, 16);
            this.lblGroupName.TabIndex = 1;
            this.lblGroupName.Text = "Guardiões de Windsor";
            // 
            // lblVersionTitle
            // 
            this.lblVersionTitle.AutoSize = true;
            this.lblVersionTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblVersionTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersionTitle.ForeColor = System.Drawing.Color.White;
            this.lblVersionTitle.Location = new System.Drawing.Point(1615, 566);
            this.lblVersionTitle.Name = "lblVersionTitle";
            this.lblVersionTitle.Size = new System.Drawing.Size(54, 16);
            this.lblVersionTitle.TabIndex = 2;
            this.lblVersionTitle.Text = "Versão:";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(1675, 566);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(0, 16);
            this.lblVersion.TabIndex = 3;
            // 
            // lstMatches
            // 
            this.lstMatches.FormattingEnabled = true;
            this.lstMatches.Location = new System.Drawing.Point(97, 126);
            this.lstMatches.Name = "lstMatches";
            this.lstMatches.Size = new System.Drawing.Size(283, 316);
            this.lstMatches.TabIndex = 4;
            this.lstMatches.SelectedIndexChanged += new System.EventHandler(this.lstMatches_SelectedIndexChanged);
            // 
            // lstMatchPlayers
            // 
            this.lstMatchPlayers.FormattingEnabled = true;
            this.lstMatchPlayers.Location = new System.Drawing.Point(787, 432);
            this.lstMatchPlayers.Name = "lstMatchPlayers";
            this.lstMatchPlayers.Size = new System.Drawing.Size(283, 121);
            this.lstMatchPlayers.TabIndex = 5;
            this.lstMatchPlayers.SelectedIndexChanged += new System.EventHandler(this.lstMatchPlayers_SelectedIndexChanged);
            // 
            // lstMatchesTitle
            // 
            this.lstMatchesTitle.AutoSize = true;
            this.lstMatchesTitle.BackColor = System.Drawing.Color.Transparent;
            this.lstMatchesTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMatchesTitle.ForeColor = System.Drawing.Color.White;
            this.lstMatchesTitle.Location = new System.Drawing.Point(94, 94);
            this.lstMatchesTitle.Name = "lstMatchesTitle";
            this.lstMatchesTitle.Size = new System.Drawing.Size(178, 24);
            this.lstMatchesTitle.TabIndex = 7;
            this.lstMatchesTitle.Text = "Lista de partidas";
            // 
            // lblNameMatch
            // 
            this.lblNameMatch.AutoSize = true;
            this.lblNameMatch.BackColor = System.Drawing.Color.Transparent;
            this.lblNameMatch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameMatch.ForeColor = System.Drawing.Color.White;
            this.lblNameMatch.Location = new System.Drawing.Point(449, 150);
            this.lblNameMatch.Name = "lblNameMatch";
            this.lblNameMatch.Padding = new System.Windows.Forms.Padding(0, 0, 91, 0);
            this.lblNameMatch.Size = new System.Drawing.Size(208, 16);
            this.lblNameMatch.TabIndex = 8;
            this.lblNameMatch.Text = "Nome da partida:";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(843, 119);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(0, 13);
            this.lblPlayerName.TabIndex = 9;
            // 
            // txtMatchName
            // 
            this.txtMatchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatchName.Location = new System.Drawing.Point(452, 168);
            this.txtMatchName.Name = "txtMatchName";
            this.txtMatchName.Size = new System.Drawing.Size(210, 20);
            this.txtMatchName.TabIndex = 10;
            this.txtMatchName.TextChanged += new System.EventHandler(this.txtMatchName_TextChanged);
            // 
            // lblPasswordMatch
            // 
            this.lblPasswordMatch.AutoSize = true;
            this.lblPasswordMatch.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordMatch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordMatch.ForeColor = System.Drawing.Color.White;
            this.lblPasswordMatch.Location = new System.Drawing.Point(449, 197);
            this.lblPasswordMatch.Name = "lblPasswordMatch";
            this.lblPasswordMatch.Size = new System.Drawing.Size(52, 16);
            this.lblPasswordMatch.TabIndex = 11;
            this.lblPasswordMatch.Text = "Senha:";
            // 
            // txtPasswordMatch
            // 
            this.txtPasswordMatch.Location = new System.Drawing.Point(452, 216);
            this.txtPasswordMatch.Name = "txtPasswordMatch";
            this.txtPasswordMatch.PasswordChar = '*';
            this.txtPasswordMatch.Size = new System.Drawing.Size(210, 20);
            this.txtPasswordMatch.TabIndex = 12;
            // 
            // lblGroupNameMatch
            // 
            this.lblGroupNameMatch.AutoSize = true;
            this.lblGroupNameMatch.BackColor = System.Drawing.Color.Transparent;
            this.lblGroupNameMatch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupNameMatch.ForeColor = System.Drawing.Color.White;
            this.lblGroupNameMatch.Location = new System.Drawing.Point(449, 249);
            this.lblGroupNameMatch.Name = "lblGroupNameMatch";
            this.lblGroupNameMatch.Size = new System.Drawing.Size(109, 16);
            this.lblGroupNameMatch.TabIndex = 13;
            this.lblGroupNameMatch.Text = "Nome do grupo:";
            // 
            // txtGroupNameMatch
            // 
            this.txtGroupNameMatch.Location = new System.Drawing.Point(452, 268);
            this.txtGroupNameMatch.Name = "txtGroupNameMatch";
            this.txtGroupNameMatch.Size = new System.Drawing.Size(210, 20);
            this.txtGroupNameMatch.TabIndex = 14;
            // 
            // btnCreateNewMatch
            // 
            this.btnCreateNewMatch.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateNewMatch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewMatch.Location = new System.Drawing.Point(452, 315);
            this.btnCreateNewMatch.Name = "btnCreateNewMatch";
            this.btnCreateNewMatch.Size = new System.Drawing.Size(210, 35);
            this.btnCreateNewMatch.TabIndex = 15;
            this.btnCreateNewMatch.Text = "Criar partida";
            this.btnCreateNewMatch.UseVisualStyleBackColor = false;
            this.btnCreateNewMatch.Click += new System.EventHandler(this.btnCreateNewMatch_Click);
            // 
            // lblCreateMatch
            // 
            this.lblCreateMatch.AutoSize = true;
            this.lblCreateMatch.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateMatch.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateMatch.ForeColor = System.Drawing.Color.White;
            this.lblCreateMatch.Location = new System.Drawing.Point(448, 110);
            this.lblCreateMatch.Name = "lblCreateMatch";
            this.lblCreateMatch.Size = new System.Drawing.Size(134, 24);
            this.lblCreateMatch.TabIndex = 16;
            this.lblCreateMatch.Text = "Criar partida";
            // 
            // lblListPlayers
            // 
            this.lblListPlayers.AutoSize = true;
            this.lblListPlayers.BackColor = System.Drawing.Color.Transparent;
            this.lblListPlayers.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListPlayers.ForeColor = System.Drawing.Color.White;
            this.lblListPlayers.Location = new System.Drawing.Point(783, 405);
            this.lblListPlayers.Name = "lblListPlayers";
            this.lblListPlayers.Size = new System.Drawing.Size(197, 24);
            this.lblListPlayers.TabIndex = 17;
            this.lblListPlayers.Text = "Lista de jogadores";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(787, 153);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(91, 13);
            this.lblPlayer.TabIndex = 18;
            this.lblPlayer.Text = "Nome do jogador:";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(787, 169);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(210, 20);
            this.txtPlayerName.TabIndex = 19;
            // 
            // txtIdMatch
            // 
            this.txtIdMatch.Location = new System.Drawing.Point(787, 216);
            this.txtIdMatch.Name = "txtIdMatch";
            this.txtIdMatch.Size = new System.Drawing.Size(210, 20);
            this.txtIdMatch.TabIndex = 20;
            // 
            // txtPasswordCurrentMatch
            // 
            this.txtPasswordCurrentMatch.Location = new System.Drawing.Point(787, 268);
            this.txtPasswordCurrentMatch.Name = "txtPasswordCurrentMatch";
            this.txtPasswordCurrentMatch.Size = new System.Drawing.Size(210, 20);
            this.txtPasswordCurrentMatch.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(787, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Id da partida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(787, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Senha da partida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(783, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Entrar na partida";
            // 
            // btnMatchStart
            // 
            this.btnMatchStart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMatchStart.Location = new System.Drawing.Point(787, 315);
            this.btnMatchStart.Name = "btnMatchStart";
            this.btnMatchStart.Size = new System.Drawing.Size(172, 35);
            this.btnMatchStart.TabIndex = 25;
            this.btnMatchStart.Text = "Entrar na partida";
            this.btnMatchStart.UseVisualStyleBackColor = true;
            this.btnMatchStart.Click += new System.EventHandler(this.btnMatchStart_Click);
            // 
            // btnInitializeMatch
            // 
            this.btnInitializeMatch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnInitializeMatch.Location = new System.Drawing.Point(1070, 252);
            this.btnInitializeMatch.Name = "btnInitializeMatch";
            this.btnInitializeMatch.Size = new System.Drawing.Size(172, 35);
            this.btnInitializeMatch.TabIndex = 26;
            this.btnInitializeMatch.Text = "Iniciar partida";
            this.btnInitializeMatch.UseVisualStyleBackColor = true;
            this.btnInitializeMatch.Click += new System.EventHandler(this.btnInitializeMatch_Click);
            // 
            // lblPlayerID
            // 
            this.lblPlayerID.AutoSize = true;
            this.lblPlayerID.Location = new System.Drawing.Point(1070, 151);
            this.lblPlayerID.Name = "lblPlayerID";
            this.lblPlayerID.Size = new System.Drawing.Size(77, 13);
            this.lblPlayerID.TabIndex = 27;
            this.lblPlayerID.Text = "ID do Jogador:";
            // 
            // txtPlayerId
            // 
            this.txtPlayerId.Location = new System.Drawing.Point(1070, 167);
            this.txtPlayerId.Name = "txtPlayerId";
            this.txtPlayerId.Size = new System.Drawing.Size(210, 20);
            this.txtPlayerId.TabIndex = 28;
            // 
            // lblPlayerPassword
            // 
            this.lblPlayerPassword.AutoSize = true;
            this.lblPlayerPassword.Location = new System.Drawing.Point(1070, 199);
            this.lblPlayerPassword.Name = "lblPlayerPassword";
            this.lblPlayerPassword.Size = new System.Drawing.Size(97, 13);
            this.lblPlayerPassword.TabIndex = 29;
            this.lblPlayerPassword.Text = "Senha do Jogador:";
            // 
            // txtPlayerPassword
            // 
            this.txtPlayerPassword.Location = new System.Drawing.Point(1070, 216);
            this.txtPlayerPassword.Name = "txtPlayerPassword";
            this.txtPlayerPassword.Size = new System.Drawing.Size(210, 20);
            this.txtPlayerPassword.TabIndex = 30;
            // 
            // lstCharacters
            // 
            this.lstCharacters.FormattingEnabled = true;
            this.lstCharacters.Location = new System.Drawing.Point(1384, 150);
            this.lstCharacters.Name = "lstCharacters";
            this.lstCharacters.Size = new System.Drawing.Size(262, 316);
            this.lstCharacters.TabIndex = 31;
            // 
            // lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kingme.Properties.Resources.medieval1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1713, 608);
            this.Controls.Add(this.lstCharacters);
            this.Controls.Add(this.txtPlayerPassword);
            this.Controls.Add(this.lblPlayerPassword);
            this.Controls.Add(this.txtPlayerId);
            this.Controls.Add(this.lblPlayerID);
            this.Controls.Add(this.btnInitializeMatch);
            this.Controls.Add(this.btnMatchStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPasswordCurrentMatch);
            this.Controls.Add(this.txtIdMatch);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblListPlayers);
            this.Controls.Add(this.lblCreateMatch);
            this.Controls.Add(this.btnCreateNewMatch);
            this.Controls.Add(this.txtGroupNameMatch);
            this.Controls.Add(this.lblGroupNameMatch);
            this.Controls.Add(this.txtPasswordMatch);
            this.Controls.Add(this.lblPasswordMatch);
            this.Controls.Add(this.txtMatchName);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.lblNameMatch);
            this.Controls.Add(this.lstMatchesTitle);
            this.Controls.Add(this.lstMatchPlayers);
            this.Controls.Add(this.lstMatches);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblVersionTitle);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.btnListMatches);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(1072, 593);
            this.Name = "lobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lobby King Me";
            this.Load += new System.EventHandler(this.lobby_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListMatches;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.Label lblVersionTitle;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.ListBox lstMatches;
        private System.Windows.Forms.ListBox lstMatchPlayers;
        private System.Windows.Forms.Label lstMatchesTitle;
        private System.Windows.Forms.Label lblNameMatch;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.TextBox txtMatchName;
        private System.Windows.Forms.Label lblPasswordMatch;
        private System.Windows.Forms.TextBox txtPasswordMatch;
        private System.Windows.Forms.Label lblGroupNameMatch;
        private System.Windows.Forms.TextBox txtGroupNameMatch;
        private System.Windows.Forms.Button btnCreateNewMatch;
        private System.Windows.Forms.Label lblCreateMatch;
        private System.Windows.Forms.Label lblListPlayers;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.TextBox txtIdMatch;
        private System.Windows.Forms.TextBox txtPasswordCurrentMatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMatchStart;
        private System.Windows.Forms.Button btnInitializeMatch;
        private System.Windows.Forms.Label lblPlayerID;
        private System.Windows.Forms.TextBox txtPlayerId;
        private System.Windows.Forms.Label lblPlayerPassword;
        private System.Windows.Forms.TextBox txtPlayerPassword;
        private System.Windows.Forms.ListBox lstCharacters;
    }
}

