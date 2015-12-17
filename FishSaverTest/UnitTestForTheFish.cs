using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Practices.Unity;
using KBFishSaver;
using System.Collections.Generic;
using System.IO;

namespace FishSaverTest
{
    [TestClass]
    public class UnitTestForTheFish
    {

        IUnityContainer container = new UnityContainer();



        [TestMethod]
        public void NewTankNoFish()
        {
            // Arrange
            container.RegisterType<IGoldFish, GoldFish>();

            var goldlFish = container.Resolve<IGoldFish>();

            List<IFish> FishList = new List<IFish>();
            Tank tank = new Tank(FishList);
            var outputCount = tank.FishCount;

            // Act
            var actualCount = 0;

            // Assert
            Assert.AreEqual(outputCount, actualCount);
        }

        [TestMethod]
        public void NewTankTwoFish()
        {
            // Arrange
            container.RegisterType<IGoldFish, GoldFish>();
            container.RegisterType<IAngelFish, AngelFish>();

            var goldlFish = container.Resolve<IGoldFish>();
            var angelFish = container.Resolve<IAngelFish>();

            List<IFish> FishList = new List<IFish>();
            FishList.Add(angelFish);
            FishList.Add(goldlFish);
            Tank tank = new Tank(FishList);
            var outputCount = tank.FishCount;

            // Act
            var actualCount = 2;

            // Assert
            Assert.AreEqual(outputCount, actualCount);
        }

        [TestMethod]
        public void NewTankTwoFishPlusNewFish()
        {
            // Arrange
            container.RegisterType<IGoldFish, GoldFish>();
            container.RegisterType<IAngelFish, AngelFish>();

            var goldlFish = container.Resolve<IGoldFish>();
            var angelFish = container.Resolve<IAngelFish>();

            List<IFish> FishList = new List<IFish>();
            FishList.Add(angelFish);
            FishList.Add(goldlFish);
            Tank tank = new Tank(FishList);

            container.RegisterType<IPiranhaFish, PiranhaFish>();
            var piranhaFish = container.Resolve<IPiranhaFish>();
            tank.AddFish(piranhaFish);

            var outputCount = tank.FishCount;

            // Act
            var actualCount = 3;

            // Assert
            Assert.AreEqual(outputCount, actualCount);
        }

        [TestMethod]
        public void ChangeName()
        {
            // Arrange
            container.RegisterType<IGoldFish, GoldFish>();

            var goldlFish = container.Resolve<IGoldFish>();

            var origName = goldlFish.Name;

            goldlFish.Name = "Goldy";

            // Act
            var actualName = goldlFish.Name;

            // Assert
            Assert.AreNotEqual(origName, actualName);
        }

        [TestMethod]
        public void CheckFeedTest()
        {

            // Add 4 gold fish, check total feed for them
            // Arrange
            container.RegisterType<IGoldFish, GoldFish>();
            var goldlFish = container.Resolve<IGoldFish>();

            List<IFish> FishList = new List<IFish>();
            FishList.Add(goldlFish);
            FishList.Add(goldlFish);
            FishList.Add(goldlFish);
            FishList.Add(goldlFish);
            Tank tank = new Tank(FishList);

            var feedTotal = tank.GetFeed();

            // Act
            var actualFeedTotal = Convert.ToDecimal(6.12 * 4);

            // Assert
            Assert.AreEqual(feedTotal, actualFeedTotal);
        }

        [TestMethod]
        public void XmlOutTest()
        {

            // Quick dump of xml, tidy up with read back of xml and compare original values with new when time.
            // Arrange
            container.RegisterType<IGoldFish, GoldFish>();
            var goldlFish = container.Resolve<IGoldFish>();

            container.RegisterType<IPiranhaFish, PiranhaFish>();
            var piranhaFish = container.Resolve<IPiranhaFish>();

            goldlFish.XmlOut(@"c:\Xml\goldlFish.xml");
            piranhaFish.XmlOut(@"c:\Xml\piranhaFish.xml");


            // Act

            // Assert
         
        }
    }

}
