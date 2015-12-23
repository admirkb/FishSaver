using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KBFishSaver
{
    public class Tank : ITank
    {
        public int FishCount { get; set; }
        private List<IFish> FishList = new List<IFish>();

        public Tank()
        {

        }
        public Tank(List<IFish> fishList)
        {
            this.FishList = new List<IFish>(fishList);
            FishCount = this.FishList.Count();
        }

        //public void GetFishData()
        //{

        //    foreach (var f in FishList)
        //    {
        //        MessageBox.Show(f.Name);
        //    }
        //}
        public decimal GetFeed()
        {

            return this.FishList.Sum(i => i.Feed);
            //return (from i in this.FishList select i.Feed).Sum();
        }

        public void AddFish(IFish fish)
        {
            FishList.Add(fish);
            FishCount = this.FishList.Count();
        }
        public void RemFish(IFish fish)
        {
            FishList.Remove(fish);
            FishCount = this.FishList.Count();
        }
    }
}
