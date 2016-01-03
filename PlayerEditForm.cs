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
    public partial class PlayerEditForm : Form {
        private Db db;
        private Player player;

        public PlayerEditForm(Db db, Player player) {
            InitializeComponent();
            this.db = db;
            this.player = player;
            this.Text += this.player.Login;
            this.fillTextBoxes();
        }

        private void fillTextBoxes() {
            nickName.Text = this.player.Login;
            scores.Text = this.player.Scores.ToString();
            // Заполняем comboBox званиями и выбираем текущий
            rank.Items.Clear();
            for (int i = 0; i < MainForm.ranks.Count - 1; i++) {
                rank.Items.Add(MainForm.ranks[i].Name);
                if (MainForm.ranks[i].Name == this.player.Rank.Name) {
                    rank.SelectedItem = this.player.Rank.Name;
                }
            }
            // Запонляем должности
            this.fillPost(post1, 0);
            this.fillPost(post2, 1);
            this.fillPost(post3, 2);

            name.Text = this.player.Name;
            skype.Text = this.player.Skype;
            // Подгружаем изображение нашивки с сайта
            this.setImageOfStripe(this.player.Rank.Id);
        }

        private void fillPost(ComboBox post, int pnum) {
            post.Items.Clear();
            post.Items.Add("");
            for (int i = 0; i < MainForm.posts.Count; i++) {
                post.Items.Add(MainForm.posts[i].Name);
                if (this.player.Posts[pnum] != null && this.player.Posts[pnum].Name == MainForm.posts[i].Name) {
                    post.SelectedItem = this.player.Posts[pnum].Name;
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e) {
            this.player.Login = nickName.Text;
            this.player.Rank = MainForm.ranks.Find(prank => prank.Name == rank.SelectedItem.ToString());
            this.player.Scores = double.Parse(scores.Text);
            this.player.Posts[0] = (post1.SelectedItem != null) ? MainForm.posts.Find(ppost => ppost.Name == post1.SelectedItem.ToString()) : null;
            this.player.Posts[1] = (post2.SelectedItem != null) ? MainForm.posts.Find(ppost => ppost.Name == post2.SelectedItem.ToString()) : null;
            this.player.Posts[2] = (post3.SelectedItem != null) ? MainForm.posts.Find(ppost => ppost.Name == post3.SelectedItem.ToString()) : null;
            this.player.Name = name.Text;
            this.player.Skype = skype.Text;
        }

        private void updatePlayer() {
            MySqlConnection updateConnection = new MySqlConnection(db.ConnectionStr);
            updateConnection.Open();
            string vals = this.player.Login + "," + this.player.Scores + "," + this.player.Rank.Id + "," + this.player.countPostBits() + "," + this.player.Name + "," + this.player.Skype;
            string query = "UPDATE sostav (name,scores,rang,dol,fullName,skype) VALUES ( " + vals + " ) WHERE id = " + this.player.Id;
            MySqlCommand cmd = new MySqlCommand(query, updateConnection);
        }

        private void addScoresButton_Click(object sender, EventArgs e) {
            if (String.Empty == scores.Text) return;
            scores.Text = (double.Parse(scores.Text) + double.Parse(scoresToAdd.Text)).ToString();
        }

        private void subScoresButton_Click(object sender, EventArgs e) {
            if (String.Empty == scores.Text) return;
            scores.Text = (double.Parse(scores.Text) - double.Parse(scoresToAdd.Text)).ToString();
        }

        private void kills_TextChanged(object sender, EventArgs e) {
            double newScores = 0;
            if (kills.Text == String.Empty || deathes.Text == String.Empty) return;
            newScores = (double.Parse(kills.Text) - double.Parse(deathes.Text)) * 0.2;
            scoresToAdd.Text = newScores.ToString();
        }

        private void kills_KeyPress(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar < 48 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;
        }

        private void resetButton_Click(object sender, EventArgs e) {
            this.fillTextBoxes();
        }

        private void viewPlayerButton_Click(object sender, EventArgs e) {
            Process.Start("http://clan-flame.ru/sostav.php?id=" + player.Id);
        }

        private void rank_SelectionChangeCommitted(object sender, EventArgs e) {
            for (int i = 0; i < MainForm.ranks.Count - 1; i++) {
                if (MainForm.ranks[i].Name == this.rank.SelectedItem.ToString()) {
                    scores.Text = MainForm.ranks[i].MinScores.ToString();
                    this.setImageOfStripe(MainForm.ranks[i].Id);
                }
            }
        }

        private void scores_TextChanged(object sender, EventArgs e) {
            if (String.Empty == scores.Text) return;
            if (int.Parse(scores.Text) > 500000) {
                scores.Text = "480000";
            }
            for (int i = 0; i < MainForm.ranks.Count - 1; i++) {
                if (double.Parse(scores.Text) >= MainForm.ranks[i].MinScores && double.Parse(scores.Text) <= MainForm.ranks[i].MaxScores) {
                    rank.SelectedItem = MainForm.ranks[i].Name;
                    this.setImageOfStripe(MainForm.ranks[i].Id);
                }
            }
        }

        private void setImageOfStripe(int stripeNum) {
            if (stripeNum < 45) {
                stripe.Location = new Point(36, 19);
            } else {
                stripe.Location = new Point(24, 19);
            }
            stripe.Image = Image.FromFile(@"rangs/" + stripeNum + ".png");
        }

        private void post1_SelectionChangeCommitted(object sender, EventArgs e) {
            if (String.Empty == post1.SelectedItem.ToString()) return;
            if (post2.SelectedItem != null && post1.SelectedItem.ToString() == post2.SelectedItem.ToString()) {
                post2.SelectedItem = "";
            }
            if (post3.SelectedItem != null && post1.SelectedItem.ToString() == post3.SelectedItem.ToString()) {
                post3.SelectedItem = "";
            }
        }

        private void post2_SelectionChangeCommitted(object sender, EventArgs e) {
            if (String.Empty == post2.SelectedItem.ToString()) return;
            if (post1.SelectedItem != null && post2.SelectedItem.ToString() == post1.SelectedItem.ToString()) {
                post1.SelectedItem = "";
            }
            if (post3.SelectedItem != null && post2.SelectedItem.ToString() == post3.SelectedItem.ToString()) {
                post3.SelectedItem = "";
            }
        }

        private void post3_SelectionChangeCommitted(object sender, EventArgs e) {
            if (String.Empty == post3.SelectedItem.ToString()) return;
            if (post1.SelectedItem != null && post3.SelectedItem.ToString() == post1.SelectedItem.ToString()) {
                post1.SelectedItem = "";
            }
            if (post2.SelectedItem != null && post3.SelectedItem.ToString() == post2.SelectedItem.ToString()) {
                post2.SelectedItem = "";
            }
        }
    }
}
