using Lab01.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person person = new Person();

            person.Id = 1;
            person.Name = "Juan";
            person.LastName = "Perez";

            ILogger logger = person;

            System.Console.WriteLine("Person");

            string personString = string.Format("Id:{0},Name:{1},LastName:{2}", person.Id, person.Name, person.LastName);

            

            System.Console.WriteLine(personString);

            logger.Log("Hello World");

            System.Console.ReadKey();
            
        }
    }
}
