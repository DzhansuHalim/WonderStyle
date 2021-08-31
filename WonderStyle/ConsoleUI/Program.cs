using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            DressManager dressManager = new DressManager( new InMemoryDressDal());

            foreach (var dress in dressManager.GetAll())
            {
                Console.WriteLine(dress.DressName);
            }

            Console.ReadLine();

        }
    }
}
