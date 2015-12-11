using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Flame_Manager {
    class Db {
        private MySqlConnection connection;
        private Process plink;
        private string mysqlHost;
        private string ftpHost;
        private string database;
        private string pass;

        public MySqlConnection Connection {
            get {
                return connection;
            }
        }

        public Db() {
            // Чтение хостов и паролей из файла
            this.deserializeSettings();

            // Открытие SSH туннеля
            this.openSSHTunnel();

            // Соединение с базой данных
            try {
                this.connect();
            } catch (Exception) {
                this.plink.Kill();
                throw new Exception("Не удается установить соединение с базой.");
            }
        }

        private void deserializeSettings() {
            FileStream fs = new FileStream(@"pass.txt", FileMode.Open);
            StreamReader file = new StreamReader(fs);
            this.mysqlHost = file.ReadLine();
            this.ftpHost = file.ReadLine();
            this.database = file.ReadLine();
            this.pass = file.ReadLine();
            file.Close();
            fs.Close();
        }

        private void openSSHTunnel() {
            this.plink = new Process();
            this.plink.StartInfo.FileName = @"plink.exe";
            this.plink.StartInfo.Arguments = "-L localhost:3306:" + mysqlHost + ":3306 -pw " + pass + " " + ftpHost;
            this.plink.StartInfo.CreateNoWindow = true;
            this.plink.StartInfo.UseShellExecute = false;
            this.plink.Start();
        }

        private void connect() {
            this.connection = new MySqlConnection("SERVER=127.0.0.1; Port=3306; DATABASE=" + database + "; UID=" + database + "; PASSWORD=" + pass + ";");
            this.connection.Open();
        }

        ~Db() {
            this.connection.Close();
            this.plink.Kill();
        }
    }
}
