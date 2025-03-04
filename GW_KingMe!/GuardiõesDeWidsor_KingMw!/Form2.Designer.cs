namespace GuardiõesDeWidsor_KingMw_
{
    partial class Form2
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
            textBox_nomeCriado = new TextBox();
            textBox_SenhaDaPartidaCriada = new TextBox();
            textBox_NomeDoGrupo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox_idPartidaCriada = new TextBox();
            btn_CriacaoDaPartida = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // textBox_nomeCriado
            // 
            textBox_nomeCriado.Location = new Point(108, 146);
            textBox_nomeCriado.Name = "textBox_nomeCriado";
            textBox_nomeCriado.Size = new Size(185, 27);
            textBox_nomeCriado.TabIndex = 1;
            textBox_nomeCriado.TextChanged += textBox_nomeCriado_TextChanged;
            // 
            // textBox_SenhaDaPartidaCriada
            // 
            textBox_SenhaDaPartidaCriada.Location = new Point(108, 183);
            textBox_SenhaDaPartidaCriada.Name = "textBox_SenhaDaPartidaCriada";
            textBox_SenhaDaPartidaCriada.Size = new Size(185, 27);
            textBox_SenhaDaPartidaCriada.TabIndex = 3;
            textBox_SenhaDaPartidaCriada.TextChanged += textBox1_TextChanged;
            // 
            // textBox_NomeDoGrupo
            // 
            textBox_NomeDoGrupo.Location = new Point(142, 220);
            textBox_NomeDoGrupo.Name = "textBox_NomeDoGrupo";
            textBox_NomeDoGrupo.Size = new Size(151, 27);
            textBox_NomeDoGrupo.TabIndex = 5;
            textBox_NomeDoGrupo.TextChanged += textBox_NomeDoGrupo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 149);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 6;
            label1.Text = "Criar Nome:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 223);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 7;
            label2.Text = "Nome do Grupo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 186);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 8;
            label3.Text = "Criar Senha:";
            // 
            // textBox_idPartidaCriada
            // 
            textBox_idPartidaCriada.Location = new Point(481, 149);
            textBox_idPartidaCriada.Name = "textBox_idPartidaCriada";
            textBox_idPartidaCriada.Size = new Size(118, 27);
            textBox_idPartidaCriada.TabIndex = 9;
            textBox_idPartidaCriada.TextChanged += textBox2_TextChanged;
            // 
            // btn_CriacaoDaPartida
            // 
            btn_CriacaoDaPartida.Location = new Point(108, 253);
            btn_CriacaoDaPartida.Name = "btn_CriacaoDaPartida";
            btn_CriacaoDaPartida.Size = new Size(106, 41);
            btn_CriacaoDaPartida.TabIndex = 10;
            btn_CriacaoDaPartida.Text = "Criar Partida";
            btn_CriacaoDaPartida.UseVisualStyleBackColor = true;
            btn_CriacaoDaPartida.Click += btn_CriacaoDaPartida_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(356, 152);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 11;
            label4.Text = "Numero da Sala:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(122, 123);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 12;
            label5.Text = "Criar partida";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(432, 123);
            label6.Name = "label6";
            label6.Size = new Size(157, 20);
            label6.TabIndex = 13;
            label6.Text = "info Da partida Criada";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(356, 186);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(245, 164);
            listBox1.TabIndex = 14;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btn_CriacaoDaPartida);
            Controls.Add(textBox_idPartidaCriada);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_NomeDoGrupo);
            Controls.Add(textBox_SenhaDaPartidaCriada);
            Controls.Add(textBox_nomeCriado);
            Name = "Form2";
            Text = "info Da partida Criada";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox_nomeCriado;
        private TextBox textBox_SenhaDaPartidaCriada;
        private TextBox textBox_NomeDoGrupo;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_idPartidaCriada;
        private Button btn_CriacaoDaPartida;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox listBox1;
    }
}