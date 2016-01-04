﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flame_Manager {
    public partial class PlayerAddForm : Form {
        private Player player;

        public PlayerAddForm(Player player) {
            InitializeComponent();
            this.fillRanks();
            this.fillPosts();
            this.player = player;
        }

        private void fillRanks() {
            // Заполняем comboBox званиями и выбираем текущий
            for (int i = 0; i < MainForm.ranks.Count - 1; i++) {
                rank.Items.Add(MainForm.ranks[i].Name);
            }
        }

        private void fillPosts() {
            for (int i = 0; i < MainForm.posts.Count; i++) {
                post1.Items.Add(MainForm.posts[i].Name);
                post2.Items.Add(MainForm.posts[i].Name);
                post3.Items.Add(MainForm.posts[i].Name);
            }
        }

        private void insertButton_Click(object sender, EventArgs e) {
            this.player.Login = nickName.Text;
            this.player.Rank = (rank.SelectedItem != null) ? MainForm.ranks.Find(prank => prank.Name == rank.SelectedItem.ToString()) : null;
            this.player.Scores = (scores.Text != String.Empty) ? double.Parse(scores.Text) : 0;
            this.player.Posts[0] = (post1.SelectedItem != null) ? MainForm.posts.Find(ppost => ppost.Name == post1.SelectedItem.ToString()) : null;
            this.player.Posts[1] = (post2.SelectedItem != null) ? MainForm.posts.Find(ppost => ppost.Name == post2.SelectedItem.ToString()) : null;
            this.player.Posts[2] = (post3.SelectedItem != null) ? MainForm.posts.Find(ppost => ppost.Name == post3.SelectedItem.ToString()) : null;
            this.player.Name = name.Text;
            this.player.Skype = skype.Text;
            try {
                this.player.isValid();
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, "Ошибка");
                return;
            }
            this.Close();
        }

        private void skipButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void rank_SelectionChangeCommitted(object sender, EventArgs e) {
            for (int i = 0; i < MainForm.ranks.Count - 1; i++) {
                if (MainForm.ranks[i].Name == this.rank.SelectedItem.ToString()) {
                    scores.Text = MainForm.ranks[i].MinScores.ToString();
                }
            }
        }

        private void scores_TextChanged(object sender, EventArgs e) {
            if (String.Empty == scores.Text) return;
            for (int i = 0; i < MainForm.ranks.Count - 1; i++) {
                if (double.Parse(scores.Text) >= MainForm.ranks[i].MinScores && double.Parse(scores.Text) <= MainForm.ranks[i].MaxScores) {
                    rank.SelectedItem = MainForm.ranks[i].Name;
                }
            }
        }

        private void scores_KeyPress(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar < 48 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;
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
