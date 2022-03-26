using System;
using System.Collections.Generic;
using System.Text;

namespace Shopcenter_projekt_
{
    class Worker : gemensamm_egenskap
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        public string ArbetsRoll { get; set; }
        public int ÅrsErfarenhet { get; set; }

        public Worker(int aId, string aName, string aArbetsRoll, int aÅrsErfarenhet)
        {
            Id = aId;
            Name = aName;
            ArbetsRoll = aArbetsRoll;
            ÅrsErfarenhet = aÅrsErfarenhet;
        }

        public Office office { get; set; } = new Office();

        public void workerEntreTheBuilding(Office OfficeObj)
        {
            OfficeObj.workerEntre(this);
        }

    }
}
