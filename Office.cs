using System;
using System.Collections.Generic;
using System.Text;

namespace Shopcenter_projekt_
{
    class Office
    {
        public int OfficeId { get; set; }
        public string OfficeName { get; set; }
        public int OfficeFloorNummber { get; set; }

        //public Office(int aId, string aName, int aFloorNummber)
        //{
        //    Id = aId;
        //    Name = aName;
        //    FloorNummber = aFloorNummber;
        //    
        //}

        public ShopCenter shopcenter { get; set; } = new ShopCenter();

        public List<Worker> Workers { get; set; } = new List<Worker>(); // En lista av worker i Office

        public void workerEntre(Worker workerObj)
        {
            Console.WriteLine($"The worker {workerObj.Name} with id-nummer {workerObj.Id} have entred the {OfficeName}.");
        }
    }
}
