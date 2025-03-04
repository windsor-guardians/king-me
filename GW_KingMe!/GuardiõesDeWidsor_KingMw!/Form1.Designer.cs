namespace GuardiõesDeWidsor_KingMw_
{
    partial class Form1
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
            btnListaDePartidas = new Button();
            listBox_Partidas = new ListBox();
            lbl_IdPartida = new Label();
            lbl_NomePartida = new Label();
            lbl_DataSala = new Label();
            listBox_Jogadores = new ListBox();
            lbl_Versão = new Label();
            button1 = new Button();
            btn_criarPartida = new Button();
            SuspendLayout();
            // 
            // btnListaDePartidas
            // 
            btnListaDePartidas.Location = new Point(82, 264);
            btnListaDePartidas.Name = "btnListaDePartidas";
            btnListaDePartidas.Size = new Size(180, 68);
            btnListaDePartidas.TabIndex = 0;
            btnListaDePartidas.Text = "Partidas";
            btnListaDePartidas.UseVisualStyleBackColor = true;
            btnListaDePartidas.Click += btnListaDePartidas_Click;
            // 
            // listBox_Partidas
            // 
            listBox_Partidas.FormattingEnabled = true;
            listBox_Partidas.Location = new Point(12, 54);
            listBox_Partidas.Name = "listBox_Partidas";
            listBox_Partidas.Size = new Size(329, 204);
            listBox_Partidas.TabIndex = 2;
            listBox_Partidas.SelectedIndexChanged += listBox_Partidas_SelectedIndexChanged;
            // 
            // lbl_IdPartida
            // 
            lbl_IdPartida.AutoSize = true;
            lbl_IdPartida.Location = new Point(372, 76);
            lbl_IdPartida.Name = "lbl_IdPartida";
            lbl_IdPartida.Size = new Size(37, 20);
            lbl_IdPartida.TabIndex = 3;
            lbl_IdPartida.Text = "Sala";
            lbl_IdPartida.Click += label1_Click;
            // 
            // lbl_NomePartida
            // 
            lbl_NomePartida.AutoSize = true;
            lbl_NomePartida.Location = new Point(372, 134);
            lbl_NomePartida.Name = "lbl_NomePartida";
            lbl_NomePartida.Size = new Size(103, 20);
            lbl_NomePartida.TabIndex = 4;
            lbl_NomePartida.Text = "Nome da Sala";
            lbl_NomePartida.Click += label2_Click;
            // 
            // lbl_DataSala
            // 
            lbl_DataSala.AutoSize = true;
            lbl_DataSala.Location = new Point(372, 191);
            lbl_DataSala.Name = "lbl_DataSala";
            lbl_DataSala.Size = new Size(41, 20);
            lbl_DataSala.TabIndex = 5;
            lbl_DataSala.Text = "Data";
            lbl_DataSala.Click += label3_Click;
            // 
            // listBox_Jogadores
            // 
            listBox_Jogadores.FormattingEnabled = true;
            listBox_Jogadores.Location = new Point(530, 67);
            listBox_Jogadores.Name = "listBox_Jogadores";
            listBox_Jogadores.Size = new Size(227, 144);
            listBox_Jogadores.TabIndex = 6;
            // 
            // lbl_Versão
            // 
            lbl_Versão.AutoSize = true;
            lbl_Versão.Location = new Point(738, 421);
            lbl_Versão.Name = "lbl_Versão";
            lbl_Versão.Size = new Size(56, 20);
            lbl_Versão.TabIndex = 7;
            lbl_Versão.Text = "version";
            // 
            // button1
            // 
            button1.Location = new Point(581, 217);
            button1.Name = "button1";
            button1.Size = new Size(129, 43);
            button1.TabIndex = 8;
            button1.Text = "Proxima Tela";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_criarPartida
            // 
            btn_criarPartida.Location = new Point(12, 406);
            btn_criarPartida.Name = "btn_criarPartida";
            btn_criarPartida.Size = new Size(147, 32);
            btn_criarPartida.TabIndex = 9;
            btn_criarPartida.Text = "Criar Partida";
            btn_criarPartida.UseVisualStyleBackColor = true;
            btn_criarPartida.Click += btn_criarPartida_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_criarPartida);
            Controls.Add(button1);
            Controls.Add(lbl_Versão);
            Controls.Add(listBox_Jogadores);
            Controls.Add(lbl_DataSala);
            Controls.Add(lbl_NomePartida);
            Controls.Add(lbl_IdPartida);
            Controls.Add(listBox_Partidas);
            Controls.Add(btnListaDePartidas);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KingMe!";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListaDePartidas;
        private ListBox listBox_Partidas;
        private Label lbl_IdPartida;
        private Label lbl_NomePartida;
        private Label lbl_DataSala;
        private ListBox listBox_Jogadores;
        private Label lbl_Versão;
        private Button button1;
        private Button btn_criarPartida;
    }
}
