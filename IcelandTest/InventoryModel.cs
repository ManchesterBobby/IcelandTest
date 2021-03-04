using System;
using System.Collections.Generic;
using System.Text;

namespace IcelandTest
{
    public enum ProductType
    {
        Fresh = 1,
        Frozen = 2,
        Seasonal = 3,
        NonAging = 4,
        Aged = 5,
        Invalid = 6
    }
    public class InventoryModel
    {
        public string ProductName { get; set; }

        public int SellIn { get; set; }

        public int QualityRating { get; set; }

        public ProductType Type { get; set; }

        public Boolean InValid { get; set; }
    }
}
