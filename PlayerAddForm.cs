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
        }

        private void skipButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}