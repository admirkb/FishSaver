using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBFishSaver
{
    public class BabelFish : Fish, IBabelFish
    {
        public decimal Feed { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }

        public BabelFish()
        {
            this.Feed = 8.0m;
            this.Name = "Babel Fish";
        }
    }
}
