using KBFishSaver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FishSaver
{
    public class Tank:ITank
    {
        private List<IFish> FishList = new List<IFish>();

        public Tank()
        {

        }
        public Tank(List<IFish> fishList)
        {
            this.FishList = new List<IFish>(fishList);
        }

        public void GetFishData()
        {

            foreach (var f in FishList)
            {
                MessageBox.Show(f.Name);
            }
        }
        public decimal GetFeed()
        {
            var feedTot = 0m;
            foreach (var f in this.FishList)
            {
                feedTot += f.Feed;
            }

            return feedTot;
        }

        public void AddFish(IFish fish)
        {
            FishList.Add(fish);



        }
    }
}
