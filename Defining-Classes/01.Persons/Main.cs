using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Persons
{
    class Program
    {
        public static void Main()
        {
            var gosho = new Person("gosho",2);
            var pesho = new Person("pesho", 3, "pesho@Maniaka.bs");
            Console.WriteLine(gosho);
            Console.WriteLine(pesho);
        }
    }
}
