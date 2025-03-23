using KingMeServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kingme
{
    public partial class Game : Form
    {
        public string playerId { get; set; }
        public string playerPass { get; set; }
        public string matchId { get; set; }
        private string[] matchPlayersList { get; set; }
        private string[] characterList { get; set; }

        Player player = new Player();
        public Game()
        {
            InitializeComponent();
            lblVersion.Text = Jogo.versao;
        }

        public void updateGameContent()
        {
            txtPlayerId.Text = playerId;
            txtPlayerPassword.Text = playerPass;
        }

        private void Game_Load(object sender, EventArgs e)
        {
        }

        private void btnInitializeMatch_Click(object sender, EventArgs e)
        {
            int playerId = Convert.ToInt32(this.playerId);
            string playerPassword = playerPass;

            if (!initializeMatchValidations(playerId.ToString(), playerPassword)) 
            {
                return;
            }

            string inicio = Jogo.Iniciar(playerId, playerPassword);

            if (errorPopUpGenerate(inicio))
            {
                return;
            }

            MessageBox.Show("A partida foi iniciada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void lstMatchPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void getListOfPlayers()
        {
            string matchPlayersContent = Jogo.ListarJogadores(Convert.ToInt32(this.matchId));

            matchPlayersContent = matchPlayersContent.Replace("\r", "");
            this.matchPlayersList = matchPlayersContent.Split('\n');  
        }

        private void updatePlayerList()
        {
            getListOfPlayers();
            lstMatchPlayers.Items.Clear();

            if (this.matchPlayersList[0] == "")
            {
                MessageBox.Show("Sem jogadores na partida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < matchPlayersList.Length; i++)
            {
                string player = matchPlayersList[i];
                lstMatchPlayers.Items.Add(matchPlayersList[i]);
            }
        }

        private void btnUpdatePlayerList_Click(object sender, EventArgs e)
        {
            updatePlayerList();
        }

        private void btnListCards_Click(object sender, EventArgs e)
        {
            string playerCards = listPlayerCards();
            if (playerCards.Contains("Error"))
            {
                return;
            }
        }

        public bool errorPopUpGenerate(string content)
        {
            if (content.Contains("ERRO"))
            {
                string errorMessage = content.Substring(5);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }


        private void btnLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string listPlayerCards()
        {
            string playerCards = Jogo.ListarCartas(Convert.ToInt32(txtPlayerId.Text), txtPlayerPassword.Text);

            if (errorPopUpGenerate(playerCards))
            {
                return "Error";
            }

            char[] listPlayerCards = playerCards.ToCharArray();

            for (int i = 0; i < listPlayerCards.Length - 1; i++)
            {
                char cardPrefix = listPlayerCards[i];
                foreach (string character in this.characterList)
                {
                    if (character.StartsWith(cardPrefix.ToString()))
                    {
                        lstCards.Items.Add(character);
                    }
                }
            }

            return "Cartas listadas";
        }

        private void btnSetCharacter_Click(object sender, EventArgs e)
        {
            if (getCharacter() == "null" || lstSections.SelectedItem == null)
            {
                MessageBox.Show("Você deve selecionar um personagem e um setor", "Erro", MessageBoxButtons.OK);
                return;
            }

            string character = getCharacter();
            string section = (string)lstSections.SelectedItem;
            string characterInitialLetter = character.Substring(0, 1).ToUpper();

            string setCharacter = Jogo.ColocarPersonagem(Convert.ToInt32(this.playerId), this.playerPass, Convert.ToInt32(section), characterInitialLetter);

            if (errorPopUpGenerate(setCharacter))
            {
                return;
            }
        }

        private void btnVerifyTurn_Click(object sender, EventArgs e)
        {
            string turn = Jogo.VerificarVez(Convert.ToInt32(this.matchId));
            if (errorPopUpGenerate(turn))
            {
                return;
            } 
            turn = turn.Replace("\r", "");
            string[] turnStateList = turn.Split('\n');

            string currentTurnPlayer = turnStateList[0];
            string[] currentTurnPlayerContent = currentTurnPlayer.Split(',');
            getListOfPlayers();

            for (int i = 0; i < turnStateList.Length; i++)
            {
                string currentTurn = turnStateList[i];
            }

            for (int i = 0; i < this.matchPlayersList.Length - 1; i++)
            {
                string player = this.matchPlayersList[i];
                string[] playerContent = player.Split(',');
 
                if (playerContent[0] == currentTurnPlayerContent[0])
                {
                    lblPlayerIdValue.Text = currentTurnPlayerContent[0];
                    lblPlayerNameValue.Text = playerContent[1];
                }
            }
            if (turnStateList.Length > 2)
            {
               setCharacterInSector(turnStateList);
            }
        }

        public string getCharacter()
        {
            var characters = new[]
            {
             new Tuple<RadioButton, string>(rdoBeatriz, "Beatriz Paiva"),
             new Tuple<RadioButton, string>(rdoAdilson, "Adilson Konrad"),
             new Tuple<RadioButton, string>(rdoMario, "Mario Toledo"),
             new Tuple<RadioButton, string>(rdoDouglas, "Douglas Baquiao"),
             new Tuple<RadioButton, string>(rdoHeredia, "Heredia"),
             new Tuple<RadioButton, string>(rdoClaro, "Claro"),
             new Tuple<RadioButton, string>(rdoEduardo, "Eduardo Takeo"),
             new Tuple<RadioButton, string>(rdoGuilherme, "Guilherme Rey"),
             new Tuple<RadioButton, string>(rdoKelly, "Kelly Kiyumi"),
             new Tuple<RadioButton, string>(rdoLeonardo, "Leonardo Takuno"),
             new Tuple<RadioButton, string>(rdoToshio, "Toshio"),
             new Tuple<RadioButton, string>(rdoQuintas, "Quintas"),
             new Tuple<RadioButton, string>(rdoRanulfo, "Ranulfo"),
            };

            foreach (var character in characters)
            {
                if (character.Item1.Checked)
                {
                    return character.Item2;
                }
            }
            return "null";
        }

        public void setCharacterInSector(string[] gameState)
        {
            clearSectors();
            var sectors = new[]
            {
              new Tuple<int, PictureBox>(0, pboSetorZero),
              new Tuple<int, PictureBox>(1, pboSetorUm),
              new Tuple<int, PictureBox>(2, pboSetorDois),
              new Tuple<int, PictureBox>(3, pboSetorTres),
              new Tuple<int, PictureBox>(4, pboSetorQuatro),
              new Tuple<int, PictureBox>(5, pboSetorCinco),
              new Tuple<int, PictureBox>(10, pboSetorDez),
           };

           for (int i = 1; i < gameState.Length - 1; i++)
            {
                string[] characterDetails = gameState[i].Split(',');
                int characterSector = Convert.ToInt32(characterDetails[0]);
                string characterInitial = characterDetails[1];

                foreach (var sector in sectors)
                {
                    if (sector.Item1 == characterSector)
                    {
                        Button clonedButton = cloneButton(getCharacterButton(characterInitial));
                        AddButtonSmart(sector.Item2, clonedButton);
                    }
                }
            }
        }
        
        public Button getCharacterButton(string initialLetter)
        {
            var characterButtons = new[]
            {
              new Tuple<string, Button>("A", btnAdilson),
              new Tuple<string, Button>("B", btnBeatrizPaiva),
              new Tuple<string, Button>("C", btnClaro),
              new Tuple<string, Button>("D", btnDouglas),
              new Tuple<string, Button>("E", btnEduardo),
              new Tuple<string, Button>("G", btnGuilherme),
              new Tuple<string, Button>("H", btnHeredia),
              new Tuple<string, Button>("K", btnKelly),
              new Tuple<string, Button>("L", btnLeonardo),
              new Tuple<string, Button>("M", btnMario),
              new Tuple<string, Button>("Q", btnQuintas),
              new Tuple<string, Button>("R", btnRanulfo),
              new Tuple<string, Button>("T", btnToshio),
           };

            foreach (var characterButton in characterButtons)
            {
                if (characterButton.Item1 == initialLetter)
                {
                    return characterButton.Item2;
                }
            }

            return new Button();
        }
        public bool AddButtonSmart(PictureBox pictureBox, Button button)
        {
            Point originalPos = button.Location;

            if (!IsOverlapping(pictureBox, button))
            {
                pictureBox.Controls.Add(button);
                button.BringToFront();
                return true;
            }

            int maxX = pictureBox.ClientSize.Width - button.Width;
            int maxY = pictureBox.ClientSize.Height - button.Height;

            int gridSpacing = 10;

            for (int y = 0; y <= maxY; y += gridSpacing)
            {
                for (int x = 0; x <= maxX; x += gridSpacing)
                {
                    button.Location = new Point(x, y);

                    if (!IsOverlapping(pictureBox, button))
                    {
                        pictureBox.Controls.Add(button);
                        button.BringToFront();
                        return true;
                    }
                }
            }

            gridSpacing = 5;

            for (int y = 0; y <= maxY; y += gridSpacing)
            {
                for (int x = 0; x <= maxX; x += gridSpacing)
                {
                    button.Location = new Point(x, y);

                    if (!IsOverlapping(pictureBox, button))
                    {
                        pictureBox.Controls.Add(button);
                        button.BringToFront();
                        return true;
                    }
                }
            }

            button.Location = originalPos;

            pictureBox.Controls.Add(button);
            button.BringToFront();

            return false;
        }

        /// <summary>
        /// Checks if a button overlaps with any existing buttons in the PictureBox
        /// </summary>
        private bool IsOverlapping(PictureBox pictureBox, Button button)
        {
            foreach (Control control in pictureBox.Controls)
            {
                if (!(control is Button) || control == button)
                    continue;

                if (button.Bounds.IntersectsWith(control.Bounds))
                {
                    return true;
                }
            }

            return false;
        }

        public Button cloneButton(Button button)
        {
            Button characterBtn = new Button();

            characterBtn.Size = button.Size;
            characterBtn.FlatStyle = button.FlatStyle;
            characterBtn.BackgroundImage = button.BackgroundImage;
            characterBtn.Name = button.Name;
            characterBtn.BackColor = button.BackColor;
            characterBtn.ForeColor = button.ForeColor;
            characterBtn.FlatAppearance.BorderSize = button.FlatAppearance.BorderSize;
            return characterBtn;
        }

        public void clearSectors()
        {
            pboSetorZero.Controls.Clear();
            pboSetorUm.Controls.Clear();
            pboSetorDois.Controls.Clear();
            pboSetorTres.Controls.Clear();
            pboSetorQuatro.Controls.Clear();
            pboSetorDez.Controls.Clear();
        }
    }
}
