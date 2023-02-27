using System;

namespace WSUniversalLib
{
    public static class Calculation
    {
        public static int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            float coefProductType = 0;
            float coefMaterialType = 0;
            switch (productType)
            {
                case 1:
                    coefProductType = (float)1.1;
                    break;
                case 2:
                    coefProductType = (float)2.5;
                    break;
                case 3:
                    coefProductType = (float)8.43;
                    break;
            }
            switch (materialType)
            {
                case 1:
                    coefMaterialType = (float)1.03;
                    break;
                case 2:
                    coefMaterialType = (float)1.12;
                    break;
                
            }
            float afloat = width * length * coefProductType  * coefMaterialType * count;
            int a = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(afloat)));
            if (a <= 0) a = -1;
            return a;
        }
    }
}
