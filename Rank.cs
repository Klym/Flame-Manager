using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flame_Manager {
    public class Rank {
        private int id;
        private string name;
        private double minScores;
        private double maxScores;

        public int Id {
            get {
                return id;
            }
        }

        public string Name {
            get {
                return name;
            }
        }

        public Rank(int id, string name, double minScores, double maxScores) {
            this.id = id;
            this.name = name;
            this.minScores = minScores;
            this.maxScores = maxScores;
        }
    }
}
