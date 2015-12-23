using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBFishSaver
{
    public class Cat : ICat
    {
        public int FishCount { get; set; }
        public int CatFullCount { get; set; }
        private List<IFish> FishList = new List<IFish>();

        public Cat()
        {
            CatFullCount = 3;
        }

        public void EatFish(IFish fish)
        {
            FishList.Add(fish);
            FishCount = this.FishList.Count();

            // Cats got too full so emits each fish as xml
            if (CatFullCount == FishCount)
            {

                foreach (var fishy in this.FishList)
                {
                    fishy.XmlOut(@"c:\Xml\" + fishy.Name + ".xml");
                }
            }

        }
    }
}
