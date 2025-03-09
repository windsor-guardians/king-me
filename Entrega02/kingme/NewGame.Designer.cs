namespace kingme
{
    partial class NewGame
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
            this.btnCreateNewMatch = new System.Windows.Forms.Button();
            this.txtGroupNameMatch = new System.Windows.Forms.TextBox();
            this.lblGroupNameMatch = new System.Windows.Forms.Label();
            this.txtPasswordMatch = new System.Windows.Forms.TextBox();
            this.lblPasswordMatch = new System.Windows.Forms.Label();
            this.txtMatchName = new System.Windows.Forms.TextBox();
            this.lblNameMatch = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateNewMatch
            // 
            this.btnCreateNewMatch.BackColor = System.Drawing.Color.Black;
            this.btnCreateNewMatch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateNewMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCreateNewMatch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreateNewMatch.Location = new System.Drawing.Point(579, 425);
            this.btnCreateNewMatch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateNewMatch.Name = "btnCreateNewMatch";
            this.btnCreateNewMatch.Size = new System.Drawing.Size(280, 43);
            this.btnCreateNewMatch.TabIndex = 23;
            this.btnCreateNewMatch.Text = "Criar partida";
            this.btnCreateNewMatch.UseVisualStyleBackColor = false;
            this.btnCreateNewMatch.Click += new System.EventHandler(this.btnCreateNewMatch_Click);
            // 
            // txtGroupNameMatch
            // 
            this.txtGroupNameMatch.Location = new System.Drawing.Point(579, 367);
            this.txtGroupNameMatch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGroupNameMatch.Name = "txtGroupNameMatch";
            this.txtGroupNameMatch.Size = new System.Drawing.Size(279, 22);
            this.txtGroupNameMatch.TabIndex = 22;
            // 
            // lblGroupNameMatch
            // 
            this.lblGroupNameMatch.AutoSize = true;
            this.lblGroupNameMatch.BackColor = System.Drawing.Color.Transparent;
            this.lblGroupNameMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupNameMatch.ForeColor = System.Drawing.Color.White;
            this.lblGroupNameMatch.Location = new System.Drawing.Point(575, 343);
            this.lblGroupNameMatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupNameMatch.Name = "lblGroupNameMatch";
            this.lblGroupNameMatch.Size = new System.Drawing.Size(149, 24);
            this.lblGroupNameMatch.TabIndex = 21;
            this.lblGroupNameMatch.Text = "Nome do grupo:";
            // 
            // txtPasswordMatch
            // 
            this.txtPasswordMatch.Location = new System.Drawing.Point(579, 303);
            this.txtPasswordMatch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPasswordMatch.Name = "txtPasswordMatch";
            this.txtPasswordMatch.PasswordChar = '*';
            this.txtPasswordMatch.Size = new System.Drawing.Size(279, 22);
            this.txtPasswordMatch.TabIndex = 20;
            // 
            // lblPasswordMatch
            // 
            this.lblPasswordMatch.AutoSize = true;
            this.lblPasswordMatch.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordMatch.ForeColor = System.Drawing.Color.White;
            this.lblPasswordMatch.Location = new System.Drawing.Point(575, 279);
            this.lblPasswordMatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordMatch.Name = "lblPasswordMatch";
            this.lblPasswordMatch.Size = new System.Drawing.Size(70, 24);
            this.lblPasswordMatch.TabIndex = 19;
            this.lblPasswordMatch.Text = "Senha:";
            // 
            // txtMatchName
            // 
            this.txtMatchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatchName.Location = new System.Drawing.Point(579, 244);
            this.txtMatchName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatchName.Name = "txtMatchName";
            this.txtMatchName.Size = new System.Drawing.Size(279, 22);
            this.txtMatchName.TabIndex = 18;
            // 
            // lblNameMatch
            // 
            this.lblNameMatch.AutoSize = true;
            this.lblNameMatch.BackColor = System.Drawing.Color.Transparent;
            this.lblNameMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameMatch.ForeColor = System.Drawing.Color.White;
            this.lblNameMatch.Location = new System.Drawing.Point(575, 222);
            this.lblNameMatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameMatch.Name = "lblNameMatch";
            this.lblNameMatch.Padding = new System.Windows.Forms.Padding(0, 0, 121, 0);
            this.lblNameMatch.Size = new System.Drawing.Size(275, 24);
            this.lblNameMatch.TabIndex = 17;
            this.lblNameMatch.Text = "Nome da partida:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::kingme.Properties.Resources.wood;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::kingme.Properties.Resources.king;
            this.pictureBox1.Location = new System.Drawing.Point(119, 87);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 491);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(993, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(57, 39);
            this.btnBack.TabIndex = 26;
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
            this.label5.Location = new System.Drawing.Point(373, 627);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 31);
            this.label5.TabIndex = 38;
            this.label5.Text = "Versão:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.BackColor = System.Drawing.Color.Transparent;
            this.lblTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam.ForeColor = System.Drawing.Color.White;
            this.lblTeam.Location = new System.Drawing.Point(90, 627);
            this.lblTeam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(262, 31);
            this.lblTeam.TabIndex = 37;
            this.lblTeam.Text = "Windsor Guardians";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(495, 639);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 39;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kingme.Properties.Resources.wood;
            this.ClientSize = new System.Drawing.Size(1067, 667);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCreateNewMatch);
            this.Controls.Add(this.txtGroupNameMatch);
            this.Controls.Add(this.lblGroupNameMatch);
            this.Controls.Add(this.txtPasswordMatch);
            this.Controls.Add(this.lblPasswordMatch);
            this.Controls.Add(this.txtMatchName);
            this.Controls.Add(this.lblNameMatch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1088, 667);
            this.Name = "NewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewGame";
            this.Load += new System.EventHandler(this.NewGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreateNewMatch;
        private System.Windows.Forms.TextBox txtGroupNameMatch;
        private System.Windows.Forms.Label lblGroupNameMatch;
        private System.Windows.Forms.TextBox txtPasswordMatch;
        private System.Windows.Forms.Label lblPasswordMatch;
        private System.Windows.Forms.TextBox txtMatchName;
        private System.Windows.Forms.Label lblNameMatch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label label1;
    }
}