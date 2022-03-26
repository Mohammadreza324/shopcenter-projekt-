using System;
using System.Linq;

namespace Shopcenter_projekt_
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopCenter Femman = new ShopCenter(); // skapar new shopcenter
            Femman.Id = 1;
            Femman.Name = "Femman";
            Femman.Area = 10000;


            //Använder mig av kontruktör
            Console.WriteLine("mata in namn till store 1:");
            string Store1Name = Console.ReadLine();
            Console.WriteLine("mata in area till store 1:");
            int Store1Area = int.Parse(Console.ReadLine());
            Console.WriteLine("vad för typ av store är store 1:");
            string Store1Item = Console.ReadLine();
            Store Store1 = new Store( Store1Name, Store1Area, Store1Item); // skapar new store
            
            Console.WriteLine("mata in namn till store 2:");
            string Store2Name = Console.ReadLine();
            Console.WriteLine("mata in area till store 2:");
            int Store2Area = int.Parse(Console.ReadLine());
            Console.WriteLine("vad för typ av store är store 2:");
            string Store2Item = Console.ReadLine();
            Store Store2 = new Store(Store2Name, Store2Area, Store2Item);


            Store Store3 = new Store( "H&M", 200, "Clothes Store");
            Store Store4 = new Store( "Jack & Jones", 100, "Clothes Store");

            Store1.shopcenter = Femman; //Märkerar vilken shopcenter tillhör store
            Store2.shopcenter = Femman;
            Store3.shopcenter = Femman;
            Store4.shopcenter = Femman;

            Femman.Stores.Add(Store1);
            Femman.Stores.Add(Store2);
            Femman.Stores.Add(Store3);
            Femman.Stores.Add(Store4);

            Office Office1 = new Office();
            Office1.OfficeId = 1;
            Office1.OfficeName = "Hemköp Office";
            Office1.OfficeFloorNummber = 3;

            Office Office2 = new Office();
            Office2.OfficeId = 2;
            Office2.OfficeName = "Clas Ohlson Office";
            Office2.OfficeFloorNummber = 1;

            Office Office3 = new Office();
            Office3.OfficeId = 3;
            Office3.OfficeName = "H&M Office";
            Office3.OfficeFloorNummber = 3;

            Office Office4 = new Office();
            Office4.OfficeId = 4;
            Office4.OfficeName = "Jack & Jones Office";
            Office4.OfficeFloorNummber = 2;

            Office1.shopcenter = Femman;
            Office2.shopcenter = Femman;
            Office3.shopcenter = Femman;
            Office4.shopcenter = Femman;

            Worker Worker1 = new Worker(1, "John", "Bakom Dator", 5);
            Worker Worker2 = new Worker(2, "Ali", "Avdelnings Chef", 8);
            Worker Worker3 = new Worker(3, "Nils", "Marknadsföring", 3);
            Worker Worker4 = new Worker(4, "Reza", "Bakom Dator", 2);
            
            Worker1.office = Office1;
            Worker2.office = Office1;
            Worker3.office = Office1;
            Worker4.office = Office1;

            Console.WriteLine("---------------\n");
            Console.WriteLine("Namn och typ av butik for store 1");
            Console.WriteLine(Store1Name);
            Console.WriteLine(Store1Item);
            Console.WriteLine("Namn och typ av butik for store 2");
            Console.WriteLine(Store2Name);
            Console.WriteLine(Store2Item);

            Console.WriteLine("---------------\n");
            Worker1.workerEntreTheBuilding(Office1); //En metod där Worker1 som är John går in genom dörren till Office 1
            Worker2.workerEntreTheBuilding(Office3);
            
            Console.WriteLine("---------------\n");
            Console.WriteLine("antal store som finns i Femman:");
            foreach (var butik in Femman.Stores)//här gåt jag genom store listan som jag har skapat i shopcenter femman.
            {
                Console.WriteLine(butik.Name);
            }
            Console.WriteLine("---------------\n");
            Console.WriteLine("store som har arean 100 m^2:");
            var searching = Femman.Stores.Where(store => store.Area == 100).ToList();// Använder linq för söka genom min lista av store och filtera ut det jag söker efter
            
            foreach (var variabel in searching)
            {
                Console.WriteLine(variabel.Name);

            }

        }
    }
}
