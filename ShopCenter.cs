using System;
using System.Collections.Generic;
using System.Text;

namespace Shopcenter_projekt_
{
    class ShopCenter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Area { get; set; }

        //public ShopCenter(int aId, string aName, int aArea)
        //{
        //    this.Id = aId;
        //    this.Name = aName;
        //    this.Area = aArea;
        //}
        public List<Store> Stores { get; set; } = new List<Store>();
        public List<Office> Offices { get; set; } = new List<Office>();
    }
}
