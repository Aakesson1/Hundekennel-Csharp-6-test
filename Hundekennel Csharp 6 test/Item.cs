using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundeKennel
{
    public class Item
    {

        public string Stamebog { get; set; }
        public string Id { get; set; }
        public string Tato { get; set; }
        public string Name { get; set; }
        public string Breeder { get; set; }
        public string Dad { get; set; }
        public string Mom { get; set; }
        public string DKKTitle { get; set; }
        public string Title { get; set; }
        public string LastVisit { get; set; }
        public string Count { get; set; }
        public string Born { get; set; }
        public string HD { get; set; }
        public string AD { get; set; }
        public string HZ { get; set; }
        public string SP { get; set; }
        public string IndexDate { get; set; }
        public string HDIndex { get; set; }
        public string Sex { get; set; }
        public string Color { get; set; }

        public static void items()
        {
            Console.WriteLine("Select ID");
            string q = "";
            string DogChoice = Console.ReadLine();
            for (int i = 0; i < 1; i++)
            {
                
                foreach (Item all in App.DataBase.items)
                {
                    
                    if (all.Id == DogChoice)
                        
                        Console.WriteLine("{0}) Stambog: {1} Tattoo: {2} Name: {3} Breeder: {4}  Dad: {5} Mom: {6} " +
                        "\n Titles :{7} DKKTitles: {8} Last visit: {9} " +
                        "\n Count: {10}  Born: {11} HD: {12} AD: {13} HZ: {14}" +
                        "\n SP: {15} Idenxdate: {16} HD Index: {17} Sex: {18} " +
                        " Color: {19}"
                        , all.Id, all.Stamebog, all.Tato, all.Name, all.Breeder, all.Dad, all.Mom, all.Title, all.DKKTitle,
                        all.LastVisit, all.Count, all.Born, all.HD, all.AD, all.HZ, all.SP, all.IndexDate, all.HDIndex, all.Sex,
                        all.Color);
                }
            }
            Console.WriteLine();
            //Saving choice to x
            int x = int.Parse(Console.ReadLine()) - 1;
            App.SavedDogChoice.SpecificDog.Add(App.DataBase.items[x]);

            Console.WriteLine("");
        }
        public static void CheckItem()
        {
            string q = "";
            string p = "Ukendt";
            for (int i = 0; i < App.DataBase.items.Count; i++)
            {
                foreach (Item item in App.DataBase.items)
                {
                    if (item.Id == q)
                    {
                        item.Id = p;
                    }
                    if (item.Name == q)
                    {
                        item.Name = p;
                    }
                    if (item.Tato == q)
                    {
                        item.Tato = p;
                    }
                    if (item.Stamebog == q)
                    {
                        item.Stamebog = p;
                    }
                    if (item.Breeder == q)
                    {
                        item.Breeder = p;
                    }
                    if (item.HZ == q)
                    {
                        item.HZ = p;
                    }
                    if (item.Count == q)
                    {
                        item.Count = p;
                    }
                    if (item.LastVisit == q)
                    {
                        item.LastVisit = p;
                    }
                    if (item.Born == q)
                    {
                        item.Born = p;
                    }
                    if (item.HD == q)
                    {
                        item.HD = p;
                    }
                    if (item.AD == q)
                    {
                        item.AD = p;
                    }
                    if (item.SP == q)
                    {
                        item.SP = p;
                    }
                    if (item.HDIndex == q)
                    {
                        item.HDIndex = p;
                    }
                    if (item.Title == q)
                    {
                        item.Title = p;
                    }
                    if (item.DKKTitle == q)
                    {
                        item.DKKTitle = p;
                    }
                    if (item.Sex == q)
                    {
                        item.Sex = p;
                    }
                    if (item.Color == q)
                    {
                        item.Color = p;
                    }
                    if (item.IndexDate == q)
                    {
                        item.IndexDate = p;
                    }
                    if (item.Dad == q)
                    {
                        item.Dad = p;
                    }
                    if (item.Mom == q)
                    {
                        item.Mom = p;
                    }
                }
            }
        }
       

    }
}