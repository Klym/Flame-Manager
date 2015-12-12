using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Flame_Manager {
    public partial class MainForm : Form {
        private Db db;
        private List<Player> players;
        public static List<Rank> ranks = new List<Rank>();

        public MainForm() {
            InitializeComponent();
            try {
                this.db = new Db();
            } catch (System.ComponentModel.Win32Exception) {
                MessageBox.Show("Ошибка. Не удается открыть plink.exe");
                this.Close();
                return;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                this.Close();
                return;
            }
            this.selectRanks();
            this.selectPlayers();
            this.showPlayerList();
        }

        private void selectPlayers() {
            MySqlConnection playersConnection = new MySqlConnection(db.ConnectionStr);
            playersConnection.Open();
            string query = "SELECT * FROM sostav ORDER BY scores DESC";
            MySqlCommand cmd = new MySqlCommand(query, playersConnection);
            MySqlDataReader playersReader = cmd.ExecuteReader();
            this.players = new List<Player>();
            int id, post;
            double scores;
            Rank rank;
            string login, name, skype;
            while (playersReader.Read()) {
                id = int.Parse(playersReader["id"].ToString());
                login = playersReader["name"].ToString();
                scores = double.Parse(playersReader["scores"].ToString());
                rank = ranks[int.Parse(playersReader["rang"].ToString()) - 1];
                post = int.Parse(playersReader["dol"].ToString());
                name = playersReader["fullName"].ToString();
                skype = playersReader["skype"].ToString();

                this.players.Add(new Player(id, login, rank, scores, post, name, skype));
            }
            playersConnection.Close();
        }

        private void selectRanks() {
            string query = "SELECT * FROM playerRangs";
            MySqlConnection rankCon = new MySqlConnection(db.ConnectionStr);
            rankCon.Open();
            MySqlCommand getRank = new MySqlCommand(query, rankCon);
            MySqlDataReader rankReader = getRank.ExecuteReader();
            Rank rank;
            while (rankReader.Read()) {
                rank = new Rank(int.Parse(rankReader["rid"].ToString()), rankReader["rangName"].ToString(), double.Parse(rankReader["minScores"].ToString()), double.Parse(rankReader["maxScores"].ToString()));
                ranks.Add(rank);
            }
            rankCon.Close();
        }

        private void showPlayerList() {
            ListViewItem player;
            for (int i = 0; i < this.players.Count; i++) {
                player = new ListViewItem(players[i].Login);
                player.SubItems.Add(this.players[i].Scores.ToString());
                player.SubItems.Add(this.players[i].Rank.Name);
                player.SubItems.Add(this.players[i].Name);
                PlayerView.Items.Add(player);
            }
        }

        private void addButton_Click(object sender, EventArgs e) {
            Form addForm = new PlayerAddForm();
            addForm.ShowDialog();
        }

        private void viewButton_Click(object sender, EventArgs e) {
            Process.Start("http://clan-flame.ru/sostav.php");
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e) {
            if (PlayerView.SelectedItems.Count > 0) {
                Form editForm = new PlayerEditForm(players[PlayerView.SelectedItems[0].Index]);
                editForm.Show();
            } else {
                MessageBox.Show("Вы не выбрали игрока.");
            }
        }
    }
}
