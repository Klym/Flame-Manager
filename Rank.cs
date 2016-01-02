using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flame_Manager {
    public class Rank {
        public int Id { get; }
        public string Name { get; }
        public double MinScores { get; }
        public double MaxScores { get; }

        public Rank(int id, string name, double minScores, double maxScores) {
            this.Id = id;
            this.Name = name;
            this.MinScores = minScores;
            this.MaxScores = maxScores;
        }
    }
}
