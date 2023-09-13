using FordelingsHatten.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FordelingsHatten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortingHat sortingHat = new SortingHat();
            Random getFaction = new Random();

            Console.WriteLine(sortingHat.GetFaction((byte)getFaction.Next(1, 5)));
        }
    }
}
