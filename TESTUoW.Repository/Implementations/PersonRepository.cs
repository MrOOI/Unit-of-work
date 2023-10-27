using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTUoW.Repository.Entity;
using TESTUoW.Repository.Interfaces;

namespace TESTUoW.Repository.Implementations
{
    public class PersonRepository : IPersonRepository
    {
        public Task<List<Person>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
