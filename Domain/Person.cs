using bts.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bts.Domain
{
    public class PersonDto
    {
        //private List<PersonDto> people;

        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Id { get; set; }


        //private void Person(string Name, int Age, DateTime DateOfBirth, string Id)
        //{
        //    people.Add(new PersonDto {  Name = Name, Age = Age, DateOfBirth = DateOfBirth, Id = Id });
        //}
    }
}
/*
 * Name
Age
DateOfBirth 
Id

 */