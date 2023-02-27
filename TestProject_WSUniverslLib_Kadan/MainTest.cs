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
            //Проверка работы метода при корректных данных
            //Все дальнейшие тесты основаны на этих данных с соответствующими тесту изменениями
            //Тип товара = 1
            //Тип материала = 1
            //Количестов товара = 1
            //Ширина товара = 1.22
            //Длина товара = 1.33
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
            //Проверка работы метода при корректных данных
            //Количество товара = 2
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
            //Проверка работы метода при корректных данных
            //Количество товара = 10
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
            //Проверка работы метода при корректных данных
            //Тип товара = 2
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
            //Проверка работы метода при корректных данных
            //Тип товара = 3
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
            //Проверка работы метода при корректных данных
            //Тип материала = 2
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
            //Проверка работы метода при корректных данных
            //Сверхмалые размеры товара
            int pt = 1;
            int mt = 1;
            int count = 1;
            float wid = (float)0.00000000000000000000000002;
            float len = (float)0.0000000000000000000000000000063;
            int a = Calculation.GetQuantityForProduct(pt, mt, count, wid, len);
            Assert.AreEqual((int)1, a);
        }
        [Test]
        public void Test_GetQuantityForProduct_CorrectData_HugeSizes()
        {
            //Проверка работы метода при корректных данных
            //Сверхбольшие размеры товара
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
            //Проверка работы метода при НЕкорректных данных
            //Несуществующий тип товара
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
            //Проверка работы метода при НЕкорректных данных
            //Несуществующий тип материала
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
            //Проверка работы метода при НЕкорректных данных
            //Количество товара = 0
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
            //Проверка работы метода при НЕкорректных данных
            //Количество товара менее 0
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
            //Проверка работы метода при НЕкорректных данных
            //Отрицательная ширина товара
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
            //Проверка работы метода при НЕкорректных данных
            //Отрицательная длина товара
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
            //Проверка работы метода при НЕкорректных данных
            //Отрицательные оба размера товара
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
            //Проверка работы метода при НЕкорректных данных
            //Нулевые размеры товара
            int pt = 1;
            int mt = 1;
            int count = 1;
            float wid = (float)0;
            float len = (float)0;
            int a = Calculation.GetQuantityForProduct(pt, mt, count, wid, len);
            Assert.AreEqual((int)-1, a);
        }

    }
}