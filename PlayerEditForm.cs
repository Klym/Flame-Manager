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

namespace Flame_Manager {
    public partial class PlayerEditForm : Form {
        private Player player;

        public PlayerEditForm(Player player) {
            InitializeComponent();
            this.player = player;
            this.fillTextBoxes();
        }

        private void fillTextBoxes() {
            nickName.Text = this.player.Login;
            scores.Text = this.player.Scores.ToString();
            // Заполняем comboBox званиями и выбираем текущий
            for (int i = 0; i < MainForm.ranks.Count - 1; i++) {
                rank.Items.Add(MainForm.ranks[i].Name);
                if (MainForm.ranks[i].Name == this.player.Rank.Name) {
                    rank.SelectedItem = this.player.Rank.Name;
                }
            }
            name.Text = this.player.Name;
            skype.Text = this.player.Skype;
            // Подгружаем изображение нашивки с сайта
            this.setImageOfStripe(this.player.Rank.Id);
        }

        private void updateButton_Click(object sender, EventArgs e) {

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
    }
}
