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
        public PlayerAddForm() {
            InitializeComponent();
            this.fillRanks();
        }

        private void fillRanks() {
            // Заполняем comboBox званиями и выбираем текущий
            for (int i = 0; i < MainForm.ranks.Count - 1; i++) {
                rank.Items.Add(MainForm.ranks[i].Name);
            }
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
    }
}
