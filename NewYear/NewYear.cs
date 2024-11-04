using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYear
{
    internal class NewYear
    {
        public int year { get; set; }
        public string namePet { get; set; }
        public string santa { get; set; }
        public void GiveHappyPeople()
        {
            Console.WriteLine($"С новым {year} годом!");
        }
    }
}
