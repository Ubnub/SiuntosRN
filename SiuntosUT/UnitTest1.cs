using System;
using SiuntosRN;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SiuntosUT
{
    [TestClass]
    public class Siunta_UT
    {

        //Realised midway that probably shouldn't have 2 methods for this...
        [TestMethod]
        public void SkaiciuotiDydi_DydisTarp0ir5Kai1Preke_DydisReturned1()
        {
            Preke testPreke = new Preke(1, 1, "testPreke", 5);
            List<Preke> testList = new List<Preke>();
            testList.Add(testPreke);
            Siunta testSiunta = new Siunta(testList);
            testSiunta.SkaiciuotiDydi();
            Assert.AreEqual(1, testSiunta.Dydis);
        }

        [TestMethod]
        public void SkaiciuotiDydi_DydisTarp6ir15Kai1Preke_DydisReturned2()
        {
            Preke testPreke = new Preke(1, 1, "testPreke", 10);
            List<Preke> testList = new List<Preke>();
            testList.Add(testPreke);
            Siunta testSiunta = new Siunta(testList);
            testSiunta.SkaiciuotiDydi();
            Assert.AreEqual(2, testSiunta.Dydis);
        }

        [TestMethod]
        public void SkaiciuotiDydi_DydisVirs15Kai1Preke_DydisReturned3()
        {
            Preke testPreke = new Preke(1, 1, "testPreke", 161);
            List<Preke> testList = new List<Preke>();
            testList.Add(testPreke);
            Siunta testSiunta = new Siunta(testList);
            testSiunta.SkaiciuotiDydi();
            Assert.AreEqual(3, testSiunta.Dydis);
        }

        [TestMethod]
        public void SkaiciuotiDydi_DydisTarp0ir5KaiKeliosPrekes_DydisReturned1()
        {
            List<Preke> testList = new List<Preke>();
            for (int i = 0; i < 4; i++)
            {
                Preke testPreke = new Preke(1, 1, "testPreke", 1);
                testList.Add(testPreke);
            }                     
            Siunta testSiunta = new Siunta(testList);
            testSiunta.SkaiciuotiDydi();
            Assert.AreEqual(1, testSiunta.Dydis);
        }
        [TestMethod]
        public void SkaiciuotiDydi_DydisTarp6ir15KaiKeliosPrekes_DydisReturned2()
        {
            List<Preke> testList = new List<Preke>();
            for (int i = 0; i < 4; i++)
            {
                Preke testPreke = new Preke(1, 1, "testPreke", 2);
                testList.Add(testPreke);
            }
            Siunta testSiunta = new Siunta(testList);
            testSiunta.SkaiciuotiDydi();
            Assert.AreEqual(2, testSiunta.Dydis);
        }
        [TestMethod]
        public void SkaiciuotiDydi_DydisTarpVirs16KaiKeliosPrekes_DydisReturned1()
        {
            List<Preke> testList = new List<Preke>();
            for (int i = 0; i < 4; i++)
            {
                Preke testPreke = new Preke(1, 1, "testPreke", 100);
                testList.Add(testPreke);
            }
            Siunta testSiunta = new Siunta(testList);
            testSiunta.SkaiciuotiDydi();
            Assert.AreEqual(3, testSiunta.Dydis);
        }

        [TestMethod]
        public void SkaiciuotiKaina_Dydis1_PrekesKainaPlius1()
        {
            Preke testPreke = new Preke(1, 15, "testPreke", 4);
            List<Preke> testList = new List<Preke>();
            testList.Add(testPreke);
            Siunta testSiunta = new Siunta(testList);
            testSiunta.SkaiciuotiDydi();
            testSiunta.SkaiciuotiKaina();
            Assert.AreEqual(testList[0].Kaina + 1, testSiunta.Kaina);
        }

        [TestMethod]
        public void SkaiciuotiKaina_Dydis2_PrekesKainaPlius2()
        {
            Preke testPreke = new Preke(1, 15, "testPreke", 8);
            List<Preke> testList = new List<Preke>();
            testList.Add(testPreke);
            Siunta testSiunta = new Siunta(testList);
            testSiunta.SkaiciuotiDydi();
            testSiunta.SkaiciuotiKaina();
            Assert.AreEqual(testList[0].Kaina + 2, testSiunta.Kaina);
        }

        [TestMethod]
        public void SkaiciuotiKaina_Dydis3_PrekesKainaPlius3()
        {
            Preke testPreke = new Preke(1, 15, "testPreke", 16);
            List<Preke> testList = new List<Preke>();
            testList.Add(testPreke);
            Siunta testSiunta = new Siunta(testList);
            testSiunta.SkaiciuotiDydi();
            testSiunta.SkaiciuotiKaina();
            Assert.AreEqual(testList[0].Kaina + 3, testSiunta.Kaina);
        }

        [TestMethod]
        public void SkaiciuotiKaina_Dydis1_PrekiuKainaPlius1()
        {
            Preke testPreke = new Preke(1, 15, "testPreke", 2);
            Preke testPreke2 = new Preke(1, 12, "testPreke", 2);
            List<Preke> testList = new List<Preke>();
            testList.Add(testPreke);
            testList.Add(testPreke2);
            Siunta testSiunta = new Siunta(testList);
            testSiunta.SkaiciuotiDydi();
            testSiunta.SkaiciuotiKaina();
            Assert.AreEqual(testList[0].Kaina+testList[1].Kaina + 1, testSiunta.Kaina);
        }

        [TestMethod]
        public void SkaiciuotiKaina_Dydis2_PrekiuKainaPlius2()
        {
            Preke testPreke = new Preke(1, 15, "testPreke", 4);
            Preke testPreke2 = new Preke(1, 12, "testPreke", 2);
            List<Preke> testList = new List<Preke>();
            testList.Add(testPreke);
            testList.Add(testPreke2);
            Siunta testSiunta = new Siunta(testList);
            testSiunta.SkaiciuotiDydi();
            testSiunta.SkaiciuotiKaina();
            Assert.AreEqual(testList[0].Kaina + testList[1].Kaina + 2, testSiunta.Kaina);
        }
        [TestMethod]
        public void SkaiciuotiKaina_Dydis3_PrekiuKainaPlius3()
        {
            Preke testPreke = new Preke(1, 15, "testPreke", 44);
            Preke testPreke2 = new Preke(1, 12, "testPreke", 42);
            List<Preke> testList = new List<Preke>();
            testList.Add(testPreke);
            testList.Add(testPreke2);
            Siunta testSiunta = new Siunta(testList);
            testSiunta.SkaiciuotiDydi();
            testSiunta.SkaiciuotiKaina();
            Assert.AreEqual(testList[0].Kaina + testList[1].Kaina + 3, testSiunta.Kaina);
        }
    }
}
