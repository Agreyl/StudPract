using NUnit.Framework;
using WSUniversalLib;

namespace TestProject_WSUniverslLib_Kadan
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_GetQuantityForProduct_CorrectData_Basic()
        {
            int pt = 1;
            int mt = 1;
            int count = 1;
            float wid = (float)1.22;
            float len = (float)1.33;
            int a = Calculation.GetQuantityForProduct(pt, mt, count, wid, len);
            Assert.AreEqual((int)2, a);
        }
        [Test]
        public void Test_GetQuantityForProduct_CorrectData_C2()
        {
            int pt = 1;
            int mt = 1;
            int count = 2;
            float wid = (float)1.22;
            float len = (float)1.33;
            int a = Calculation.GetQuantityForProduct(pt, mt, count, wid, len);
            Assert.AreEqual((int)4, a);
        }
        [Test]
        public void Test_GetQuantityForProduct_CorrectData_C10()
        {
            int pt = 1;
            int mt = 1;
            int count = 10;
            float wid = (float)1.22;
            float len = (float)1.33;
            int a = Calculation.GetQuantityForProduct(pt, mt, count, wid, len);
            Assert.AreEqual((int)19, a);
        }
        [Test]
        public void Test_GetQuantityForProduct_CorrectData_PT2()
        {
            int pt = 2;
            int mt = 1;
            int count = 1;
            float wid = (float)1.22;
            float len = (float)1.33;
            int a = Calculation.GetQuantityForProduct(pt, mt, count, wid, len);
            Assert.AreEqual((int)5, a);
        }
        [Test]
        public void Test_GetQuantityForProduct_CorrectData_PT3()
        {
            int pt = 3;
            int mt = 1;
            int count = 1;
            float wid = (float)1.22;
            float len = (float)1.33;
            int a = Calculation.GetQuantityForProduct(pt, mt, count, wid, len);
            Assert.AreEqual((int)15, a);
        }
        [Test]
        public void Test_GetQuantityForProduct_CorrectData_MT2()
        {
            int pt = 1;
            int mt = 2;
            int count = 1;
            float wid = (float)1.22;
            float len = (float)1.33;
            int a = Calculation.GetQuantityForProduct(pt, mt, count, wid, len);
            Assert.AreEqual((int)2, a);
        }
        [Test]
        public void Test_GetQuantityForProduct_CorrectData_SmlSizes()
        {
            int pt = 1;
            int mt = 1;
            int count = 1;
            float wid = (float)0.00002;
            float len = (float)0.000063;
            int a = Calculation.GetQuantityForProduct(pt, mt, count, wid, len);
            Assert.AreEqual((int)1, a);
        }
        [Test]
        public void Test_GetQuantityForProduct_CorrectData_HugeSizes()
        {
            int pt = 1;
            int mt = 1;
            int count = 1;
            float wid = (float)5461442348344887455;
            float len = (float)8843341873348983354;
            int a = Calculation.GetQuantityForProduct(pt, mt, count, wid, len);
            Assert.AreEqual((int)-1, a);
        }
        [Test]
        public void Test_GetQuantityForProduct_InCorrectData_WrongPT()
        {
            int pt = 10;
            int mt = 1;
            int count = 1;
            float wid = (float)1.22;
            float len = (float)1.33;
            int a = Calculation.GetQuantityForProduct(pt, mt, count, wid, len);
            Assert.AreEqual((int)-1, a);
        }
        [Test]
        public void Test_GetQuantityForProduct_InCorrectData_WrongMT()
        {
            int pt = 1;
            int mt = 10;
            int count = 1;
            float wid = (float)1.22;
            float len = (float)1.33;
            int a = Calculation.GetQuantityForProduct(pt, mt, count, wid, len);
            Assert.AreEqual((int)-1, a);
        }
        [Test]
        public void Test_GetQuantityForProduct_InCorrectData_ZeroCount()
        {
            int pt = 1;
            int mt = 1;
            int count = 0;
            float wid = (float)1.22;
            float len = (float)1.33;
            int a = Calculation.GetQuantityForProduct(pt, mt, count, wid, len);
            Assert.AreEqual((int)-1, a);
        }
        [Test]
        public void Test_GetQuantityForProduct_InCorrectData_NegCount()
        {
            int pt = 1;
            int mt = 1;
            int count = -10;
            float wid = (float)1.22;
            float len = (float)1.33;
            int a = Calculation.GetQuantityForProduct(pt, mt, count, wid, len);
            Assert.AreEqual((int)-1, a);
        }
        [Test]
        public void Test_GetQuantityForProduct_InCorrectData_NegWid()
        {
            int pt = 1;
            int mt = 1;
            int count = 1;
            float wid = (float)-1.22;
            float len = (float)1.33;
            int a = Calculation.GetQuantityForProduct(pt, mt, count, wid, len);
            Assert.AreEqual((int)-1, a);
        }
        [Test]
        public void Test_GetQuantityForProduct_InCorrectData_NegLen()
        {
            int pt = 1;
            int mt = 1;
            int count = 1;
            float wid = (float)1.22;
            float len = (float)-1.33;
            int a = Calculation.GetQuantityForProduct(pt, mt, count, wid, len);
            Assert.AreEqual((int)-1, a);
        }
        [Test]
        public void Test_GetQuantityForProduct_InCorrectData_NegSize()
        {
            int pt = 1;
            int mt = 1;
            int count = 1;
            float wid = (float)-1.22;
            float len = (float)-1.33;
            int a = Calculation.GetQuantityForProduct(pt, mt, count, wid, len);
            Assert.AreEqual((int)-1, a);
        }
        [Test]
        public void Test_GetQuantityForProduct_InCorrectData_ZeroSize()
        {
            int pt = 1;
            int mt = 1;
            int count = 1;
            float wid = (float)0;
            float len = (float)-0;
            int a = Calculation.GetQuantityForProduct(pt, mt, count, wid, len);
            Assert.AreEqual((int)-1, a);
        }

    }
}