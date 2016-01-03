using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Flame_Manager {
    public class Db {
        private Process plink;
        private string connectionStr;
        private string mysqlHost;
        private string ftpHost;
        private string database;
        private string pass;

        public string ConnectionStr {
            get {
                return connectionStr;
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
            this.plink.StartInfo.RedirectStandardOutput = true;
            this.plink.StartInfo.UseShellExecute = false;
            this.plink.Start();
            // Ожидание открытия SSH (приложение при успешном открытии выведет 3 строки)
            int i = 0;
            while (i++ < 2) {
                this.plink.StandardOutput.ReadLine();
            }
        }

        private void connect() {
            this.connectionStr = "SERVER=127.0.0.1; Port=3306; DATABASE=" + database + "; UID=" + database + "; PASSWORD=" + pass + "; CHARSET=utf8;";
        }

        ~Db() {
            this.plink.Kill();
        }
    }
}
