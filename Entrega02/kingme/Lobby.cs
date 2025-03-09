using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingMeServer;

namespace kingme
{
    public partial class Lobby: Form
    {
        public Lobby()
        {
            InitializeComponent();
            listMatches();
            lblVersionListRoom.Text = Jogo.versao;
        }

        private void listMatches()
        {
            string matchList = Jogo.ListarPartidas("T");
            matchList = matchList.Replace("\r", "");
            matchList = matchList.Substring(0, matchList.Length - 1);
            string[] matchListSanitized = matchList.Split('\n');
            lstMatches.Items.Clear();
            for (int i = 0; i < matchListSanitized.Length; i++)
            {
                lstMatches.Items.Add(matchListSanitized[i]);
            }
        }

        private void btnListMatches_Click(object sender, EventArgs e)
        {
            string matchList = Jogo.ListarPartidas("T");
            matchList = matchList.Replace("\r", "");
            matchList = matchList.Substring(0, matchList.Length - 1);
            string[] matchListSanitized = matchList.Split('\n');
            lstMatches.Items.Clear();
            for (int i = 0; i < matchListSanitized.Length; i++)
            {
                lstMatches.Items.Add(matchListSanitized[i]);
            }
        }

        private void lstMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMatch = lstMatches.SelectedItem.ToString();

            string[] matchData = selectedMatch.Split(',');

            int matchID = Convert.ToInt32(matchData[0]);

            string matchPlayers = Jogo.ListarJogadores(matchID);
            string[] matchPlayersSanitized = matchPlayers.Split('\n');

        }
        
              
        public bool createMatchValidation(string newMatchName, string matchPassword, string matchGroupName)
        {
            var validations = new[]
            {
                new Tuple<string, string>(newMatchName, "O nome da partida não pode ser vazio"),
                new Tuple<string, string>(matchPassword, "A senha não pode ser vazia"),
                new Tuple<string, string>(matchGroupName, "O nome do grupo não pode ser vazio"),
            };

            foreach (var entry in validations)
            {
                if (string.IsNullOrWhiteSpace(entry.Item1))
                {
                    MessageBox.Show(entry.Item2, "Bad Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                
            }
            return true;
        }


        private void lobby_Load(object sender, EventArgs e)
        {

        }
        private void lstMatchesTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblVersionListRoom_Click(object sender, EventArgs e)
        {

        }
    }
}
