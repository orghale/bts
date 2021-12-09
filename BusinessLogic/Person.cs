using bts.Domain;
using bts.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bts.BusinessLogic
{
    public class Person : Iperson
    {
        private List<PersonDto> people = new List<PersonDto>();

        public Person()
        {

        }

        public Task<PersonDto> GetById(string Id)
        {
            var result = new PersonDto();
            try
            {
                result = people.FirstOrDefault(x => x.Id == Id);
            }
            catch
            {
                result = null;
                throw;
            }
            return Task.FromResult(result);
        }

        public Task<string[]> Insert(PersonDto person)
        {

            try
            {
                AddPerson(person.Name, person.Age, person.DateOfBirth, person.Id);
                return Task.FromResult(new[] { "Person successfully added" });
            }
            catch (Exception e)
            {
                return Task.FromResult(new[] { "Error creating person", e.Message });
            }
        }

        public Task<List<PersonDto>> ListPersons()
        {
            var result = new List<PersonDto>();
            try
            {
                result = people;
                return Task.FromResult(result);
            }
            catch
            {
                throw;
            }
        }

        private void AddPerson(string Name, int Age, DateTime DateOfBirth, string Id)
        {
            people.Add(new PersonDto { Name = Name, Age = Age, DateOfBirth = DateOfBirth, Id = Id });
        }

    }
}
