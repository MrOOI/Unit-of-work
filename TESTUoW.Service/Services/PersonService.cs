using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTUoW.Repository.Interfaces;
using TESTUoW.Service.Interfaces;
using TESTUoW.Service.Models;

namespace TESTUoW.Service.Services
{
    public class PersonService : BaseService, IPersonService
    {
        protected IUoW UoW { get; }
        public PersonService(IUoW uoW):base(uoW)
        {
            UoW = uoW;
        }
        public IList<PersonGetAllModel> GetAll()
        {
            UoW.PersonRepository.GetAllAsync();

            return new List<PersonGetAllModel>();
        }
    }
}
