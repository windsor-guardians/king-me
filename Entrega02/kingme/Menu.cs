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

namespace kingme
{
    public partial class Menu: Form
    {
        public string playerId { get; set; }
        public string playerPass { get; set; }
        public Menu()
        {
            InitializeComponent();
            lblVersion.Text = Jogo.versao;
        }

        private void menu_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMatches_Click(object sender, EventArgs e)
        {
            Lobby lobby = new Lobby();
            lobby.ShowDialog();
        }

        private void btnNewGame_Click_1(object sender, EventArgs e)
        {
            NewGame game = new NewGame();
            game.ShowDialog();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string matchId = txtIdMatch.Text;
            string playerName = txtPlayerName.Text;
            string passCurrentMatch = txtPasswordCurrentMatch.Text;

            if (!startMatchValidation(matchId, playerName, passCurrentMatch))
            {
                clearFields();
                return;
            }

            string credentials = Jogo.Entrar(Convert.ToInt32(matchId), playerName, passCurrentMatch);

            if (credentials.Substring(0, 4).ToLower() == "erro")
            {
                MessageBox.Show(credentials.Substring(5), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearFields();
                return;
            }

            credentials = credentials.Replace("\r", "");
            credentials = credentials.Substring(0, credentials.Length);
            string[] matchListSanitized = credentials.Split(',');

            this.playerId = matchListSanitized[0];
            this.playerPass = matchListSanitized[1];

            Game game = new Game();
            game.playerId = this.playerId;
            game.playerPass = this.playerPass;
            game.matchId = txtIdMatch.Text;

            game.updateGameContent();
            game.ShowDialog();
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
                
                if (!int.TryParse(matchId, out int result))
                {
                    MessageBox.Show("O ID só pode conter números", "Bad Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }

            return true;
        }

        private void clearFields()
        {
            txtIdMatch.Clear();
            txtPasswordCurrentMatch.Clear();
            txtPlayerName.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
