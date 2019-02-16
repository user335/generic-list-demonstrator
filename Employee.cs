using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee<T> : Person, IQuittable
    {
        public int ID { set; get; }
        public List<T> things;

        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
        public void Quit()
        {
            Console.WriteLine("\r\nGoodbye");
            Console.ReadKey();
        }
        public override void PrintYourThings()
        {
            foreach (var item in things)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
