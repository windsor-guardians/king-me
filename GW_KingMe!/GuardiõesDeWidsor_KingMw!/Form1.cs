using System;
using System.Web;
using KingMeServer;

namespace GuardiõesDeWidsor_KingMw_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl_Versão.Text = Jogo.versao;
        }

        private void btnListaDePartidas_Click(object sender, EventArgs e)
        {
            //Caixa de Saida das Partidas
            /*
             * T = Todas as partidas.
             * J = Jogando.
             */
            /*Criar uma classe para nao misturar logica e interface*/
            string retorno = Jogo.ListarPartidas("T"); //Seleção de Partidas            
            retorno = retorno.Replace("\r", "");
            //retorno = retorno.Substring(0, retorno.Length - 1);
            string[] partidas = retorno.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            listBox_Partidas.Items.Clear();
            //for (int i = 0; i < partidas.Length - 1; i++)
            //{
            //    listBox_Partidas.Items.Add(partidas[i]);
            //}
            foreach(string partida in partidas)
            {
                listBox_Partidas.Items.Add(partida);
            }

        }

        private void listBox_Partidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seleçao das partidas
            string partida = listBox_Partidas.SelectedItem.ToString();
            string[] info_Partidas = partida.Split(','); // Separa as informações
            //informações da partida
            int idPartida = Convert.ToInt32(info_Partidas[0]);
            string nomeDaSala_Partida = info_Partidas[1];
            string data_partida = info_Partidas[2];

            lbl_IdPartida.Text = idPartida.ToString();
            lbl_NomePartida.Text = nomeDaSala_Partida;
            lbl_DataSala.Text = data_partida;
            //impressão dos jogadores na partida
            string telaDeInfo = Jogo.ListarJogadores(idPartida);
            if (string.IsNullOrEmpty(telaDeInfo) || telaDeInfo.StartsWith("ERRO"))
            {
                MessageBox.Show("Houve um Erro\n" + info_Partidas);
                return;
            }
            else
            {
                telaDeInfo = telaDeInfo.Replace("\r", "");
                string[] jogadores = telaDeInfo.Split('\n');

                listBox_Jogadores.Items.Clear();
                for (int i = 0; i < jogadores.Length - 1; i++)
                {
                    listBox_Jogadores.Items.Add(jogadores[i]);
                }
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Jogador
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //idpartida
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //data
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //proxima tela btn
        }

        private void btn_criarPartida_Click(object sender, EventArgs e)
        {
            Form2 tela2 = new Form2();
            tela2.Show();
        }
    }
}
