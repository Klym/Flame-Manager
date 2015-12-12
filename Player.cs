using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flame_Manager {
    public class Player {
        private int id;
        private string login;
        private string rank;
        private double scores;
        private int post;
        private string name;
        private string skype;

        public int Id {
            get {
                return id;
            }
        }
        
        public string Login {
            get {
                return login;
            }
        }
        
        public string Rank {
            get {
                return rank;
            }
        }
        
        public double Scores {
            get {
                return scores;
            }
        }
       
        public int Post {
            get {
                return post;
            }
        }
       
        public string Name {
            get {
                return name;
            }
        }
       
        public string Skype {
            get {
                return skype;
            }
        }

        public Player(int id, string login, string rank, double scores, int post, string name, string skype) {
            this.id = id;
            this.login = login;
            this.rank = rank;
            this.scores = scores;
            this.post = post;
            this.name = name;
            this.skype = skype;
        }
    }
}
