using System.Threading;
using System;
using System.Collections.Generic;
using RestWithASPNET.Model;
using RestWithASPNET.Services;
using RestWithASPNET.Model.Context;
using System.Linq;

namespace RestWithASPNET.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private MySqlContext _context;

        public PersonServiceImplementation(MySqlContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            return person;
        }

        public Person FindByID(long id)
        {
            return new Person
            {
                Id = 1,
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
            return _context.Persons.ToList();
        }

        public Person Update(Person person)
        {
            return new Person
            {
                Id = 1,
                Name = "Yuri",
                LastName = "Marcon",
                Adress = "São Bernardo do Campo - SP",
                Gender = "Male"
            };
        }
    }
}