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

        public MySqlConnection Connection {
            get {
                return connection;
            }
        }

        public Db() {
            // Чтение хостов и паролей из файла
            FileStream fs = new FileStream(@"pass.txt", FileMode.Open);
            StreamReader file = new StreamReader(fs);
            string mysqlHost = file.ReadLine();
            string ftpHost = file.ReadLine();
            string database = file.ReadLine();
            string pass = file.ReadLine();
            file.Close();
            fs.Close();

            // Открытие SSH туннеля
            this.plink = new Process();
            this.plink.StartInfo.FileName = @"plink.exe";
            this.plink.StartInfo.Arguments = "-L localhost:3306:" + mysqlHost + ":3306 -pw " + pass + " " + ftpHost;
            this.plink.StartInfo.CreateNoWindow = true;
            this.plink.StartInfo.UseShellExecute = false;
            this.plink.Start();

            // Соединение с базой данных
            try {
                this.connection = new MySqlConnection("SERVER=127.0.0.1; Port=3306; DATABASE=" + database + "; UID=" + database + "; PASSWORD=" + pass + ";");
                this.connection.Open();
            } catch (Exception) {
                this.plink.Kill();
                throw new Exception("Не удается установить соединение с базой.");
            }
        }

        ~Db() {
            this.connection.Close();
            this.plink.Kill();
        }
    }
}
