using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flame_Manager {
    public class Player {
        public int Id { get; }
        public string Login { get; }
        public Rank Rank { get; }
        public double Scores { get; }
        public int Post { get; }
        public string Name { get; }
        public string Skype { get; }

        public Player(int id, string login, Rank rank, double scores, int post, string name, string skype) {
            this.Id = id;
            this.Login = login;
            this.Rank = rank;
            this.Scores = scores;
            this.Post = post;
            this.Name = name;
            this.Skype = skype;
        }
    }
}
