using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private MySQLContext _context;

        public PersonServiceImplementation(MySQLContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
           return person;
        }

        public void Delete(long id)
        {
           
        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }       

        public Person FindById(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Abner",
                LastName = "Jóia",
                Address = "Rua da Silva, 65",
                Gender = "Male",
            };
        }

        public Person Update(Person person)
        {
            return person;
        }            
    } 
}
