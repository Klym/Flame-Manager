﻿using System;
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
        public static List<Post> posts = new List<Post>();

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
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
            this.selectPosts();
            this.selectPlayers();
            this.showPlayerList();
            playersCountLabel.Text = players.Count().ToString();
        }

        private void selectPlayers() {
            MySqlConnection playersConnection = new MySqlConnection(db.ConnectionStr);
            playersConnection.Open();
            string query = "SELECT * FROM sostav ORDER BY scores DESC";
            MySqlCommand cmd = new MySqlCommand(query, playersConnection);
            MySqlDataReader playersReader = cmd.ExecuteReader();
            this.players = new List<Player>();
            int id;
            double scores;
            Rank rank;
            string login, name, skype;
            int[] postIdArr;
            Post[] postsArr;
            while (playersReader.Read()) {
                id = int.Parse(playersReader["id"].ToString());
                login = playersReader["name"].ToString();
                scores = double.Parse(playersReader["scores"].ToString());
                rank = ranks[int.Parse(playersReader["rang"].ToString()) - 1];
                name = playersReader["fullName"].ToString();
                skype = playersReader["skype"].ToString();
                this.selectPlayerPosts(id, out postIdArr);
                postsArr = new Post[3];
                for (int i = 0; i < 3; i++) {
                    postsArr[i] = posts.Find(post => post.Id == postIdArr[i]);
                }
                this.players.Add(new Player(id, login, rank, scores, postsArr, name, skype));
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

        private void selectPosts() {
            string query = "SELECT * FROM playerDol";
            MySqlConnection postCon = new MySqlConnection(db.ConnectionStr);
            postCon.Open();
            MySqlCommand getPost = new MySqlCommand(query, postCon);
            MySqlDataReader postReader = getPost.ExecuteReader();
            Post post;
            while(postReader.Read()) {
                post = new Post(int.Parse(postReader["did"].ToString()), postReader["dolName"].ToString(), int.Parse(postReader["bitFlag"].ToString()));
                posts.Add(post);
            }
            postCon.Close();
        }

        private void selectPlayerPosts(int id, out int[] postsArr) {
            string query = "SELECT * FROM playerPosts WHERE player = " + id;
            MySqlConnection postCon = new MySqlConnection(db.ConnectionStr);
            postCon.Open();
            MySqlCommand getPost = new MySqlCommand(query, postCon);
            MySqlDataReader postReader = getPost.ExecuteReader();
            postsArr = new int[3];
            int i = 0;
            while (postReader.Read()) {
                postsArr[i++] = int.Parse(postReader["did"].ToString());
            }
            postCon.Close();
        }

        private void showPlayerList() {
            for (int i = 0; i < this.players.Count; i++) {
                PlayerView.Items.Add(this.writePlayer(players[i]));
            }
        }

        private ListViewItem writePlayer(Player p) {
            ListViewItem player = new ListViewItem(p.Login);
            player.SubItems.Add(p.Scores.ToString());
            player.SubItems.Add(p.Rank.Name);
            player.SubItems.Add(p.Name);
            return player;
        }

        private void addButton_Click(object sender, EventArgs e) {
            Player newPlayer = new Player(0);
            Form addForm = new PlayerAddForm(db, newPlayer);
            addForm.ShowDialog();
            if (newPlayer.Id == 0) return;
            this.players.Add(newPlayer);
            PlayerView.Items.Add(this.writePlayer(newPlayer));
            playersCountLabel.Text = this.players.Count.ToString();
        }

        private void viewButton_Click(object sender, EventArgs e) {
            Process.Start("http://clan-flame.ru/sostav.php");
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e) {
            if (PlayerView.SelectedItems.Count > 0) {
                int index = PlayerView.SelectedItems[0].Index;
                Form editForm = new PlayerEditForm(db, players[index]);
                editForm.ShowDialog();
                // Обновляем в списке изменившуюся информацию
                PlayerView.Items[index] = this.writePlayer(players[index]);
            } else {
                MessageBox.Show("Вы не выбрали игрока.");
            }
        }
    }
}
