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
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                this.Close();
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
