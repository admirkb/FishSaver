using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBFishSaver
{
    public class PiranhaFish : Fish, IPiranhaFish
    {
        public decimal Feed { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }

        public PiranhaFish()
        {
            this.Feed = 199.13m;
            this.Name = "Piranha Fish";
        }
    }
}
