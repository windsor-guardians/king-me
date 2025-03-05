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
    public partial class lobby: Form
    {
        public lobby()
        {
            InitializeComponent();
            lblVersion.Text = Jogo.versao;
            listCharacters();
        }

        private void listCharacters()
        {
            string characters = Jogo.ListarPersonagens();
            characters = characters.Replace("\r", "");
            characters = characters.Substring(0, characters.Length - 1);
            string[] charactersListSanitized = characters.Split('\n');

            lstCharacters.Items.Clear();
            for (int i = 0; i < charactersListSanitized.Length; i++)
            {
                lstCharacters.Items.Add(charactersListSanitized[i]);
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
            lstMatchPlayers.Items.Clear();

            if (matchPlayersSanitized[0] == "")
            {
                MessageBox.Show("Sem jogadores na partida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < matchPlayersSanitized.Length; i++)
            {
                string player = matchPlayersSanitized[i];
                lstMatchPlayers.Items.Add(matchPlayersSanitized[i]);
            }

        }
        

        private void lstMatchPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateNewMatch_Click(object sender, EventArgs e)
        {
            string newMatchName = txtMatchName.Text.Trim();
            string matchPassword = txtPasswordMatch.Text.Trim();
            string matchGroupName = txtGroupNameMatch.Text.Trim();

            if (!createMatchValidation(newMatchName, matchPassword, matchGroupName))
            {
                return;
            }

            string id = Jogo.CriarPartida(newMatchName, matchPassword, matchGroupName);

            if (id.Contains("ERRO"))
            {
                string errorMessage = id.Substring(5);
                MessageBox.Show(errorMessage, "Bad Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string matchCreatedMessage = "A partida de id " + id + " foi criada com sucesso!";
                MessageBox.Show(matchCreatedMessage, "Partida criada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleanFields();
            } 
           
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

        private void cleanFields()
        {
            txtGroupNameMatch.Clear();
            txtMatchName.Clear();
            txtPasswordMatch.Clear();
        }

        private void lobby_Load(object sender, EventArgs e)
        {

        }

        private void txtMatchName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMatchStart_Click(object sender, EventArgs e)
        {

            string matchId = txtIdMatch.Text;
            string playerName = txtPlayerName.Text;
            string passCurrentMatch = txtPasswordCurrentMatch.Text;
            
            if (!startMatchValidation(matchId, playerName, passCurrentMatch))
            {
                return;
            }

            string credentials = Jogo.Entrar(Convert.ToInt32(matchId), playerName, passCurrentMatch);

            credentials = credentials.Replace("\r", "");
            credentials = credentials.Substring(0, credentials.Length - 1);
            string[] matchListSanitized = credentials.Split(',');

            txtPlayerId.Text = matchListSanitized[0];
            txtPlayerPassword.Text = matchListSanitized[1];
        }

        public bool startMatchValidation(string matchId, string playerName, string passCurrentMatch)
        {
            var validations = new[]
            {
                new Tuple<string, string>(matchId, "O id da partida não pode ser vazio"),
                new Tuple<string, string>(playerName, "O nome do jogador não pode ser vazio"),
                new Tuple<string, string>(passCurrentMatch, "A senha da partida não pode ser vazia"),
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

        private void btnInitializeMatch_Click(object sender, EventArgs e)
        {
            string playerId = txtPlayerId.Text;
            string playerPassword = txtPlayerPassword.Text;
            
            if (!initializeMatchValidations(playerId.ToString(), playerPassword)) {
                return;
            } 

            Jogo.Iniciar(Convert.ToInt32(playerId), playerPassword);
        }

        public bool initializeMatchValidations(string playerId, string playerPassword)
        {
            var validations = new[]
            {
                new Tuple<string, string>(playerId, "O id do jogador não pode ser vazio"),
                new Tuple<string, string>(playerPassword, "A senha do jogador não pode ser vazia"),
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

    }
}
