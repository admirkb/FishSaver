using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBFishSaver
{
    public class GoldFish : Fish, IGoldFish
    {
        public decimal Feed { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public GoldFish()
        {
            this.Feed = 6.12m;
            this.Name = "Gold Fish";
        }
    }
}
