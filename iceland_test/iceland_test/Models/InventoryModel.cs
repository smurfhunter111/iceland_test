using System.Collections.Generic;

namespace iceland_test.Models
{
    #region - Operation Handling Class
    public class InventoryModel
    {
        //constants
        public static string ERROR_MESSAGE_ITEM_INVALID = "NO SUCH ITEM";

        #region Data - Test Input
        public static List<InventoryItem> GetInventoryTest()
        {
            var inv = new List<InventoryItem>();

            inv.Add(new InventoryItem()
            {
                Name = "Aged Brie",
                SellIn = 1,
                Quality = 1,
                Status = 1
            });

            inv.Add(new InventoryItem()
            {
                Name = "Backstage passes",
                SellIn = -1,
                Quality = 2,
                Status = 3
            });

            inv.Add(new InventoryItem()
            {
                Name = "Backstage passes",
                SellIn = 9,
                Quality = 2,
                Status = 3
            });

            inv.Add(new InventoryItem()
            {
                Name = "Sulfuras",
                SellIn = 2,
                Quality = 2,
                Status = 2
            });

            inv.Add(new InventoryItem()
            {
                Name = "Normal Item",
                SellIn = -1,
                Quality = 55
            });

            inv.Add(new InventoryItem()
            {
                Name = "Normal Item",
                SellIn = 2,
                Quality = 2
            });

            inv.Add(new InventoryItem()
            {
                Name = "INVALID ITEM",
                SellIn = 2,
                Quality = 2,
                Status = 5
            });

            inv.Add(new InventoryItem()
            {
                Name = "Conjured",
                SellIn = 2,
                Quality = 2,
                Status = 4
            });

            inv.Add(new InventoryItem()
            {
                Name = "Conjured",
                SellIn = -1,
                Quality = 5,
                Status = 4
            });

            return inv;
        }
        #endregion

        #region Data - Process Inventory
        //process whole item
        public static List<InventoryItem> ProcessInventory(int dayIncrement, int concert, List<InventoryItem> inv)
        {
            var newList = new List<InventoryItem>();

            for (int i = 0; i < inv.Count; i++)
            {
                newList.Add(ProcessItem(dayIncrement, concert, inv[i]));
            }

            return newList;
        }

        //process single item 
        public static InventoryItem ProcessItem(int dayIncrement, int concert, InventoryItem ii)
        {
            //extract variables
            var sellIn = ii.SellIn;
            var quality = ii.Quality;
            var status = ii.Status;

            //add multiplier of quality adjustment
            var adjustment = 1;
            if (sellIn < 0)
            {
                adjustment = 2;
            }

            switch (status)
            {
                case 0: //normal
                    quality = quality - dayIncrement * adjustment;
                    break;

                case 1: //cheese
                    quality = quality + dayIncrement;
                    break;

                case 2: //legendary
                    //nothing ever happens with legendary
                    break;

                case 3: //backstage
                    if (concert > -1)
                    {
                        quality = 0;
                    }
                    else
                    {
                        if (sellIn < 6)
                        {
                            quality = quality + 3 * dayIncrement;
                        }
                        else if (sellIn < 11)
                        {
                            quality = quality + 2 * dayIncrement;
                        }
                        else
                        {
                            quality = quality + dayIncrement;
                        }
                    }
                    break;

                case 4: //conjured
                    quality = quality - 2 * dayIncrement * adjustment;
                    break;

                case 5: //invalid
                    ii.Name = ERROR_MESSAGE_ITEM_INVALID;
                    quality = null;
                    sellIn = null;
                    break;
            }

            if (status != 2)
            {
                //decrease sell in
                sellIn = sellIn - dayIncrement;
            }

            //quality never more than 50
            if (quality > 50)
            {
                quality = 50;
            }
            else if (quality < 0)
            {
                quality = 0;
            }

            //reassign variables
            ii.Quality = quality;
            ii.SellIn = sellIn;

            return ii;
        }
        #endregion

        #region GET - Result Colouring Class
        public static string ResultColouringClass(int? value)
        {
            var className = string.Empty;
            if (value < 0)
            {
                className = "text-danger";
            }
            else if (value > 0)
            {
                className = "text-success";
            }

            return className;
        }
        #endregion
    }
    #endregion

    #region CLASS - Inventory Page Model
    public class InventoryPageModel
    {
        public InventoryPageSettings Settings { get; set; }
        public List<InventoryItem> Inventory { get; set; }

        public static InventoryPageModel New()
        {
            return new InventoryPageModel()
            {
                Settings = InventoryPageSettings.New(),
                Inventory = InventoryModel.GetInventoryTest()
            };
        }
    }
    #endregion

    #region CLASS - Inventory Page Settings
    public class InventoryPageSettings
    {
        public int DayIncrement { get; set; }
        public int Day { get; set; }
        public int Concert { get; set; }

        public static InventoryPageSettings New()
        {
            return new InventoryPageSettings()
            {
                DayIncrement = 0,
                Day = 0,
                Concert = -1
            };
        }
    }
    #endregion

    #region CLASS - Inventory Item
    public class InventoryItem
    {
        public string Name { get; set; }
        public int? SellIn { get; set; }
        public int? Quality { get; set; }

        //0 = Normal
        //1 = Cheese
        //2 = Legendary
        //3 = Backstage
        //4 = Conjured
        //5 = Invalid
        public int Status { get; set; }
    }
    #endregion

    #region CLASS - Inventory Page Post Model
    public class InventoryPagePostModel
    {
        public IEnumerable<InventoryPageSettings> Settings { get; set; }
        public IEnumerable<InventoryItem> Inventory { get; set; }
    }
    #endregion
}
