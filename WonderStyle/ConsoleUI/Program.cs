using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            DressTest();

            Console.ReadLine();

        }

        private static void DressTest()
        {
            DressManager dressManager = new DressManager(new EfDressDal());

            foreach (var dress in dressManager.GetDressDetail())
            {
                Console.WriteLine("Name: " + dress.DressName +"/ Size: "+ dress.SizeName + "/ Style: " + dress.StyleName + "/ Price: " + dress.UnitPrice);
            }
        }
    }
}
