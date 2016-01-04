using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flame_Manager {
    public class Player {
        public int Id { get; set; }
        public string Login { get; set; }
        public Rank Rank { get; set; }
        public double Scores { get; set; }
        public Post[] Posts { get; set; }
        public string Name { get; set; }
        public string Skype { get; set; }

        public Player(int id) {
            this.Id = id;
            this.Posts = new Post[3];
        }

        public Player(int id, string login, Rank rank, double scores, Post[] posts, string name, string skype) {
            this.Id = id;
            this.Login = login;
            this.Rank = rank;
            this.Scores = scores;
            this.Posts = posts;
            this.Name = name;
            this.Skype = skype;
        }

        public int countPostBits() {
            int bitFlag = 0;
            for (int i = 0; i < 3; i++) {
                bitFlag += (this.Posts[i] != null) ? this.Posts[i].bitFlag : 0;
            }
            return bitFlag;
        }

        public bool isValid() {
            if (this.Login == String.Empty) {
                throw new Exception("Вы не ввели позывной.");
            }
            if (this.Rank == null) {
                throw new Exception("Вы не выбрали ранг.");
            }
            if (this.Posts[0] == null && this.Posts[1] == null && this.Posts[2] == null) {
                throw new Exception("Игрок должен иметь хотя бы одну должность.");
            }
            if (this.Name == String.Empty) {
                throw new Exception("Вы не ввели имя.");
            }
            if (this.Skype == String.Empty) {
                throw new Exception("Вы не ввели скайп.");
            }
            return true;
        }
    }
}
