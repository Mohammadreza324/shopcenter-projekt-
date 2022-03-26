using System;
using System.Collections.Generic;
using System.Text;

namespace Shopcenter_projekt_
{
    class Store : gemensamm_egenskap
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        public static int AmountOfStores { get; set; } = 0;
        public int Area { get; set; }
        public string Item { get; set; }

        //skapandet av kunstruktör
        public Store( string aName, int aArea, string aItem)
        {
            AmountOfStores++;
            Id = AmountOfStores;
            Name = aName;
            Area = aArea;
            Item = aItem;
        }
        public ShopCenter shopcenter { get; set; } = new ShopCenter();


    }
}
