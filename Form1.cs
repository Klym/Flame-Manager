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
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e) {
            Form addForm = new PlayerAddForm();
            addForm.ShowDialog();
        }

        private void viewButton_Click(object sender, EventArgs e) {
            Process.Start("http://clan-flame.ru/sostav.php");
        }
    }
}
