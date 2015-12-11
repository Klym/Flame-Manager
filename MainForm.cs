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
            this.showPlayerList();
        }

        private List<Player> selectPlayers() {
            string query = "SELECT * FROM sostav ORDER BY scores DESC";
            MySqlCommand cmd = new MySqlCommand(query, db.Connection);
            MySqlDataReader playersReader = cmd.ExecuteReader();
            List<Player> players = new List<Player>();
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

                players.Add(new Player(id, login, rank, scores, post, name, skype));
            }
            return players;
        }

        private void showPlayerList() {
            List<Player> players = this.selectPlayers();
            ListViewItem player;
            for (int i = 0; i < players.Count; i++) {
                player = new ListViewItem(players[i].Login);
                player.SubItems.Add(players[i].Scores.ToString());
                player.SubItems.Add(players[i].Rank.ToString());
                player.SubItems.Add(players[i].Name.ToString());
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
            Form editForm = new PlayerEditForm();
            editForm.Show();
        }
    }
}
