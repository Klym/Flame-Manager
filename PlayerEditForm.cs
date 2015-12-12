using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            name.Text = this.player.Name;
            skype.Text = this.player.Skype;
        }

        private void updateButton_Click(object sender, EventArgs e) {

        }

        private void addScoresButton_Click(object sender, EventArgs e) {
            scores.Text = (double.Parse(scores.Text) + double.Parse(scoresToAdd.Text)).ToString();
        }

        private void subScoresButton_Click(object sender, EventArgs e) {
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
    }
}
