using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTUoW.Repository.Entity;

namespace TESTUoW.Repository.Interfaces
{
    public interface IPersonRepository
    {
        Task<List<Person>> GetAllAsync();
    }
}
