using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KBFishSaver
{
    public class AngelFish: Fish, IAngelFish
    {
        public decimal Feed { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }

        public AngelFish()
        {
            this.Feed = 4.13m;
            this.Name = "Angel Fish";
        }


    }
}
