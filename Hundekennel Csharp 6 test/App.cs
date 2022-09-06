using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundeKennel
{

    class App
    {

        public static class DataBase
        {
            public static List<Item> items { get; set; }

            static DataBase()
            {
                items = new List<Item>();
            }
        }
        public static class SavedDogChoice
        {
            public static List<Item> SpecificDog { get; set; }

            static SavedDogChoice()
            {
                SpecificDog = new List<Item>();
            }
        }
        public static void start()
        {

            Console.WriteLine("1 - Vis alle hunde");
            Console.WriteLine("2 - Tilføj hund");
            Console.WriteLine("0 - Afslut");
            Console.Write("Angiv dit valg: ");


        }
        public static void Text()
        {
            Console.Clear();
            Console.WriteLine("Our database contains {0} items", DataBase.items.Count);
            Console.WriteLine();
            Console.WriteLine("-----------------------");
            Console.WriteLine("ID      item name");
            Console.WriteLine("-----------------------");
            Console.WriteLine("-----------------------");
        }
        public static void NewItem()
        {
            TextWriter tsw = new StreamWriter(@"C:\Users\MIke\Desktop\HundeData.csv", true);

            //Writing text to the file.
            Console.WriteLine("");
            tsw.WriteLine(Console.ReadLine());

            //Close the file.
            tsw.Close();
        }

        public static void ReadItem()
        {

            string[] txt = File.ReadAllLines(@"C:\Users\MIke\Desktop\HundeData.csv");
            foreach (string line in txt)
            {

                var whatever = line.Split(';');
                Item item = new Item();
                item.Id = whatever[0];
                item.Stamebog = whatever[1];
                item.Tato = whatever[2];
                item.Name = whatever[3];
                item.Breeder = whatever[4];
                item.Dad = whatever[5];
                item.Mom = whatever[6];
                item.Title = whatever[7];
                item.DKKTitle = whatever[8];
                item.LastVisit = whatever[9];
                item.Count = whatever[10];
                item.Born = whatever[11];
                item.HD = whatever[12];
                item.AD = whatever[13];
                item.HZ = whatever[14];
                item.SP = whatever[15];
                item.IndexDate = whatever[16];
                item.HDIndex = whatever[17];
                item.Sex = whatever[18];
                item.Color = whatever[19];
                App.DataBase.items.Add(item);


            }


        }

        public static void MainMenu()
        {
            App.ReadItem();
            bool repeat = true;

            do
            {
                App.start();
                switch (Console.ReadLine())
                {
                    case "1":

                        App.Text();
                        Item.CheckItem();
                        Item.items();
                        break;
                    case "2":
                        App.NewItem();
                        break;
                    case "0":
                        repeat = false;
                        break;

                }

            }
            while (repeat);
        }

    }


}
