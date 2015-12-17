using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBFishSaver
{
    public interface IFish
    {
        decimal Feed { get; set; }
        string Type { get; set; }
        string Name { get; set; }
        void XmlOut(string filePath);
    }
}
