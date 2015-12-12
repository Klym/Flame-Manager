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
            this.selectPlayers();
            this.showPlayerList();
        }

        private void selectPlayers() {
            string query = "SELECT * FROM sostav ORDER BY scores DESC";
            MySqlCommand cmd = new MySqlCommand(query, db.Connection);
            MySqlDataReader playersReader = cmd.ExecuteReader();
            this.players = new List<Player>();
            int id, post;
            double scores;
            string rank, login, name, skype;
            while (playersReader.Read()) {
                id = int.Parse(playersReader["id"].ToString());
                login = playersReader["name"].ToString();
                scores = double.Parse(playersReader["scores"].ToString());
                rank = playersReader["rang"].ToString();
                post = int.Parse(playersReader["dol"].ToString());
                name = playersReader["fullName"].ToString();
                skype = playersReader["skype"].ToString();

                this.players.Add(new Player(id, login, rank, scores, post, name, skype));
            }
        }

        private void showPlayerList() {
            ListViewItem player;
            for (int i = 0; i < this.players.Count; i++) {
                player = new ListViewItem(players[i].Login);
                player.SubItems.Add(this.players[i].Scores.ToString());
                player.SubItems.Add(this.players[i].Rank.ToString());
                player.SubItems.Add(this.players[i].Name.ToString());
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
