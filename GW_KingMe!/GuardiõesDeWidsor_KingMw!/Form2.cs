using KingMeServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuardiõesDeWidsor_KingMw_
{
    public partial class Form2 : Form
    {
        public string nomeDaPartida { get; set; }
        private string senhaDaPartida { get; set; }
        private string nomeDoGrupo { get; set; }


        public Form2()
        {
            InitializeComponent();           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            senhaDaPartida = textBox_SenhaDaPartidaCriada.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox_nomeCriado_TextChanged(object sender, EventArgs e)
        {
            nomeDaPartida = textBox_nomeCriado.Text;
        }

        private void textBox_NomeDoGrupo_TextChanged(object sender, EventArgs e)
        {
            nomeDoGrupo = textBox_NomeDoGrupo.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_CriacaoDaPartida_Click(object sender, EventArgs e)
        {
            textBox_idPartidaCriada.Text = Jogo.CriarPartida(nomeDaPartida, senhaDaPartida, nomeDoGrupo);
            string retorno = Jogo.ListarPartidas("T"); //Seleção de Partidas            
            retorno = retorno.Replace("\r", "");
            //retorno = retorno.Substring(0, retorno.Length - 1);
            string[] partidas = retorno.Split(new[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);

            listBox1.Items.Clear();
            foreach (string partida in partidas)
            {
                listBox1.Items.Add(partida);
            }
        }
    }
}
