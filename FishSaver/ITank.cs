using KBFishSaver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishSaver
{
    public interface ITank
    {
        decimal GetFeed();
        void AddFish(IFish fish);
    }
}
