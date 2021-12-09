using bts.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bts.Interface
{
    public interface Iperson
    {
        Task<PersonDto> GetById(string Id);
        Task<string[]> Insert(PersonDto person);
        Task<List<PersonDto>> ListPersons();
    }
}
