using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flame_Manager {
    public class Post {
        public int Id { get; }
        public string Name { get; }
        public int bitFlag { get; }

        public Post(int id, string name, int bitFlag) {
            this.Id = id;
            this.Name = name;
            this.bitFlag = bitFlag;
        }
    }
}
