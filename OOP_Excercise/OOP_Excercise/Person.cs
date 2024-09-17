using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercise
{
    public class Person
    {

        string Name { get; set; }
        string LastName { get; set; }
        int Age { get; set; }

        public Person(string name, string lastname, int age)
        {
            Name = name;
            LastName = lastname;
            Age = age;



        }
        public void BeskrivningPerson()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Lastname: {LastName}");
            Console.WriteLine($"Age: {Age}");
        }
    }
}
