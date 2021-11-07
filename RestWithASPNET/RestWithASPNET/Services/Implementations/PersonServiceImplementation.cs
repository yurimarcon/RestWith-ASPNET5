using System.Threading;
using System;
using System.Collections.Generic;
using RestWithASPNET.Model;
using RestWithASPNET.Services;

namespace RestWithASPNET.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public Person FindByID(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                Name = "Yuri",
                LastName = "Marcon",
                Adress = "São Bernardo do Campo - SP",
                Gender = "Male"
            };
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for(int i = 0; i < 8; i++)
            {
                Person person = MockPerson();
                persons.Add(person);
            }
            return persons;
        }

        public Person Update(Person person)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                Name = "Yuri",
                LastName = "Marcon",
                Adress = "São Bernardo do Campo - SP",
                Gender = "Male"
            };
        }
        
        private Person MockPerson()
        {
            return new Person
            {
                Id = IncrementAndGet(),
                Name = "Person Name",
                LastName = "Person LastName",
                Adress = "Some Address",
                Gender = "Male"
            };
        }
        private long IncrementAndGet() => Interlocked.Increment(ref count);

    }
}