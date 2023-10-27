using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTUoW.Repository.DbContext;
using TESTUoW.Repository.Interfaces;

namespace TESTUoW.Repository.Implementations
{
    public class UoW : IUoW
    {
        private readonly DatabaseContext _databaseContext;
        private IDbConnection _dbConnection;
        private IDbTransaction _dbTransaction;
        private IPersonRepository _personRepository;
        public UoW(DatabaseContext databaseContext) 
        {
            _databaseContext = databaseContext;
            _dbConnection =  databaseContext.CreateConnection();
            _dbConnection.Open();
            _dbTransaction = _dbConnection.BeginTransaction();
        }

        public IPersonRepository PersonRepository => _personRepository;

        public void Begin()
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void RollBack()
        {
            throw new NotImplementedException();
        }
    }
}
