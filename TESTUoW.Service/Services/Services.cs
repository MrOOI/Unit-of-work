using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTUoW.Repository.DbContext;
using TESTUoW.Repository.Implementations;
using TESTUoW.Repository.Interfaces;
using TESTUoW.Service.Interfaces;

namespace TESTUoW.Service.Services
{
    public class Services : IServices
    {
        private readonly DatabaseContext _databaseContext;
        private readonly DatabaseSettings _databaseSettings;
        private IUoW _uoW;

        private IPersonService _personService;
        public Services() 
        {
            _uoW = new UoW(_databaseContext??(_databaseContext = new DatabaseContext(_databaseSettings??(_databaseSettings = new DatabaseSettings()))));
        }
        public IPersonService PersonService => _personService??(_personService = new PersonService(_uoW));

        public DbTransaction BeginTransaction => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
