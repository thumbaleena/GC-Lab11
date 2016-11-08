using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClasses
{
    class Program
    {
        public static object HashTable { get; private set; }
        static void Main(string[] args)
        {
            Student stu1 = new Student("Bart Simpson", "742 Evergreen Terrace, Springfield", "Bachelors in Finance", 2018, 4000.00);
            Staff sta1 = new Staff("Edna Krabappel", "123 Imaginary Lane, Springfield", "Springfield Elementary", 50000.00);

            List<Person> personList = new List<Person>();

            personList.Add(stu1);
            personList.Add(sta1);
            personList.Add(new Staff("Seymour Skinner", "555 Somewhere Street, Springfield", "Springfield Elementary", 65000.00));

            for (int i = 0; i < personList.Count; i++)
            {
                Console.WriteLine(personList[i]);
            }
        }
    }
}
