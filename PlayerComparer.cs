using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flame_Manager {
    public class PlayerComparer : IComparer<Player> {
        public int Compare(Player p1, Player p2) {
            if (p1.Scores < p2.Scores) {
                return 1;
            } else if (p1.Scores > p2.Scores) {
                return -1;
            } else {
                return 0;
            }
        }
    }
}
