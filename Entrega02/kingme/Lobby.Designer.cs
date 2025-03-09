namespace kingme
{
    partial class Lobby
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
            this.lstMatches = new System.Windows.Forms.ListBox();
            this.lstMatchesTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblVersionListRoom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListMatches
            // 
            this.btnListMatches.BackColor = System.Drawing.Color.Black;
            this.btnListMatches.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListMatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListMatches.ForeColor = System.Drawing.Color.White;
            this.btnListMatches.Location = new System.Drawing.Point(267, 562);
            this.btnListMatches.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListMatches.Name = "btnListMatches";
            this.btnListMatches.Size = new System.Drawing.Size(280, 43);
            this.btnListMatches.TabIndex = 0;
            this.btnListMatches.Text = "Atualizar";
            this.btnListMatches.UseVisualStyleBackColor = false;
            this.btnListMatches.Click += new System.EventHandler(this.btnListMatches_Click);
            // 
            // lstMatches
            // 
            this.lstMatches.BackColor = System.Drawing.Color.White;
            this.lstMatches.FormattingEnabled = true;
            this.lstMatches.ItemHeight = 16;
            this.lstMatches.Location = new System.Drawing.Point(223, 154);
            this.lstMatches.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstMatches.Name = "lstMatches";
            this.lstMatches.Size = new System.Drawing.Size(376, 388);
            this.lstMatches.TabIndex = 4;
            this.lstMatches.SelectedIndexChanged += new System.EventHandler(this.lstMatches_SelectedIndexChanged);
            // 
            // lstMatchesTitle
            // 
            this.lstMatchesTitle.AutoSize = true;
            this.lstMatchesTitle.BackColor = System.Drawing.Color.Transparent;
            this.lstMatchesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMatchesTitle.ForeColor = System.Drawing.Color.White;
            this.lstMatchesTitle.Location = new System.Drawing.Point(271, 81);
            this.lstMatchesTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lstMatchesTitle.Name = "lstMatchesTitle";
            this.lstMatchesTitle.Size = new System.Drawing.Size(283, 39);
            this.lstMatchesTitle.TabIndex = 7;
            this.lstMatchesTitle.Text = "Lista de partidas";
            this.lstMatchesTitle.Click += new System.EventHandler(this.lstMatchesTitle_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(743, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(57, 39);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "X";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(497, 631);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 31);
            this.label5.TabIndex = 40;
            this.label5.Text = "Versão:";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.BackColor = System.Drawing.Color.Transparent;
            this.lblTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam.ForeColor = System.Drawing.Color.White;
            this.lblTeam.Location = new System.Drawing.Point(216, 631);
            this.lblTeam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(262, 31);
            this.lblTeam.TabIndex = 39;
            this.lblTeam.Text = "Windsor Guardians";
            // 
            // lblVersionListRoom
            // 
            this.lblVersionListRoom.AutoSize = true;
            this.lblVersionListRoom.BackColor = System.Drawing.Color.Transparent;
            this.lblVersionListRoom.Location = new System.Drawing.Point(619, 643);
            this.lblVersionListRoom.Name = "lblVersionListRoom";
            this.lblVersionListRoom.Size = new System.Drawing.Size(44, 16);
            this.lblVersionListRoom.TabIndex = 41;
            this.lblVersionListRoom.Text = "label1";
            this.lblVersionListRoom.Click += new System.EventHandler(this.lblVersionListRoom_Click);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kingme.Properties.Resources.wood;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 673);
            this.Controls.Add(this.lblVersionListRoom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lstMatchesTitle);
            this.Controls.Add(this.lstMatches);
            this.Controls.Add(this.btnListMatches);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(816, 673);
            this.Name = "Lobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lobby King Me";
            this.Load += new System.EventHandler(this.lobby_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListMatches;
        private System.Windows.Forms.ListBox lstMatches;
        private System.Windows.Forms.Label lstMatchesTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblVersionListRoom;
    }
}

