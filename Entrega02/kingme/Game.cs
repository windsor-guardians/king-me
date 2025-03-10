﻿using KingMeServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kingme
{
    public partial class Game: Form
    {
        public string playerId { get; set; }
        public string playerPass { get; set; }
        public string matchId { get; set; }
        private string[] matchPlayersList { get; set; }
        private string[] characterList { get; set; }
        public Game()
        {
            InitializeComponent();
            listCharacters();
            lblVersion.Text = Jogo.versao;
        }

        public void updateGameContent()
        {
            txtPlayerId.Text = this.playerId;
            txtPlayerPassword.Text = this.playerPass;
        }

        private void Game_Load(object sender, EventArgs e)
        {
        }

        private void btnInitializeMatch_Click(object sender, EventArgs e)
        {
            string playerId = this.playerId;
            string playerPassword = this.playerPass;

            if (!initializeMatchValidations(playerId.ToString(), playerPassword))
            {
                return;
            }

            string inicio = Jogo.Iniciar(Convert.ToInt32(txtPlayerId.Text), txtPlayerPassword.Text);

            if (errorPopUpGenerate(inicio))
            {
                return;
            }

            MessageBox.Show("A partida foi iniciada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnInitializeMatch.Enabled = false;
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

        private void updatePlayerList()
        {
            string matchPlayersContent = Jogo.ListarJogadores(Convert.ToInt32(this.matchId));
            this.matchPlayersList = matchPlayersContent.Split('\n');
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

        private void listCharacters()
        {
            string characters = Jogo.ListarPersonagens();
            this.characterList = characters.Split('\n');
            
            for (int i = 0; i < this.characterList.Length - 1; i++)
            {
                string character = this.characterList[i];
                lstFavorites.Items.Add(character);
            }
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
    }
}
