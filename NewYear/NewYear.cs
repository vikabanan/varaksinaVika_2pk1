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
        public void MakeAWish()
        {
            Console.WriteLine("Под бой курантов загадайте желание!Запишите его на бумажке и сожгите ее, чтобы оно обязательно сбылось!");
        }
        public void GreetNewYear()
        {
            Console.WriteLine("Поздравляю всех с Новым годом!");
        }
    }
}
