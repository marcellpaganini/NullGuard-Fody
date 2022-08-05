using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullGuard
{
    public class Person
    {
        private static Person[] people = new Person[]
        {
            new Person(1, "Mike Wilson"),
            new Person(2, "Arya Stark"),
            new Person(3, "Vladimir Khorikov")
        };
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static Person? GetById(int id) 
        { 
            return people.Single(p => p.Id == id) ?? null;
        }
    }
}
