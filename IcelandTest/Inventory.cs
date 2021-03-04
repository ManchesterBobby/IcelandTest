using System;
using System.Collections.Generic;
using System.Text;

namespace IcelandTest
{
    public class Inventory
    {
        public List<InventoryModel> InventoryList { get; set; }

        public Inventory()
        {
            InventoryList = new List<InventoryModel>();

            var product = new InventoryModel
            {
                ProductName = "Aged Brie",
                SellIn = 1,
                QualityRating = 1,
                Type = ProductType.Aged
            };
            InventoryList.Add(product);

            product = new InventoryModel
            {
                ProductName = "Christmas Crackers",
                SellIn = -1,
                QualityRating = 2,
                Type = ProductType.Seasonal
            };
            InventoryList.Add(product);

            product = new InventoryModel
            {
                ProductName = "Christmas Crackers",
                SellIn = 9,
                QualityRating = 2,
                Type = ProductType.Seasonal
            };
            InventoryList.Add(product);

            product = new InventoryModel
            {
                ProductName = "Soap",
                SellIn = 2,
                QualityRating = 2,
                Type = ProductType.NonAging
            };
            InventoryList.Add(product);

            product = new InventoryModel
            {
                ProductName = "Frozen Item",
                SellIn = -1,
                QualityRating = 55,
                Type = ProductType.Frozen
            };
            InventoryList.Add(product);

            product = new InventoryModel
            {
                ProductName = "Frozen Item",
                SellIn = 2,
                QualityRating = 2,
                Type = ProductType.Frozen
            };
            InventoryList.Add(product);

            product = new InventoryModel
            {
                ProductName = "Invalid Item",
                SellIn = 2,
                QualityRating = 2,
                Type = ProductType.Invalid,
                InValid = true
            };
            InventoryList.Add(product);

            product = new InventoryModel
            {
                ProductName = "Fresh Item",
                SellIn = 2,
                QualityRating = 2,
                Type = ProductType.Fresh
            };
            InventoryList.Add(product);

            product = new InventoryModel
            {
                ProductName = "Fresh Item",
                SellIn = -1,
                QualityRating = 5,
                Type = ProductType.Fresh
            };
            InventoryList.Add(product);

        }

        public List<InventoryModel> UpdateInventory()
        {
            var updatedList = new List<InventoryModel>();

            foreach (var product in InventoryList)
            {
                var newProduct = new InventoryModel();
                newProduct.ProductName = product.ProductName;
                newProduct.SellIn = product.SellIn - 1;
                switch (product.Type)
                {
                    case ProductType.Fresh:
                        if (newProduct.SellIn < 0)
                        {
                            newProduct.QualityRating = product.QualityRating > 4 ? product.QualityRating - 4 : 0;
                        }
                        else
                        {
                            newProduct.QualityRating = product.QualityRating > 2 ? product.QualityRating - 2 : 0;
                        }
                        break;
                    case ProductType.Frozen:
                        if (newProduct.SellIn < 0)
                        {
                            newProduct.QualityRating = product.QualityRating > 2 ? product.QualityRating - 2 : 0;
                        }
                        else
                        {
                            newProduct.QualityRating = product.QualityRating > 0 ? product.QualityRating - 1 : 0;
                        }
                        break;
                    case ProductType.Aged:
                        newProduct.QualityRating = product.QualityRating < 50 ? product.QualityRating + 1 : product.QualityRating;
                        break;
                    case ProductType.NonAging:
                        newProduct = product;
                        break;
                    case ProductType.Seasonal:
                        if (newProduct.SellIn > 10)
                        {
                            newProduct.QualityRating = product.QualityRating > 0 ? product.QualityRating - 1 : 0;
                        }
                        else
                        {
                            if (newProduct.SellIn > 3)
                            {
                                newProduct.QualityRating = product.QualityRating < 49 ? product.QualityRating + 2 : product.QualityRating;
                            }
                            else
                            {
                                if (newProduct.SellIn > 0)
                                {
                                    newProduct.QualityRating = product.QualityRating < 48 ? product.QualityRating + 3 : product.QualityRating;
                                }
                                else
                                {
                                    newProduct.QualityRating = 0;
                                }
                            }
                        }
                        break;
                    default:
                        newProduct.ProductName = "NO SUCH ITEM";
                        newProduct.SellIn = 0;
                        newProduct.QualityRating = 0;
                        newProduct.InValid = true;
                        break;
                }
                updatedList.Add(newProduct);
            }

            return updatedList;
        }
    }
}
