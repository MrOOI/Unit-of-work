using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTUoW.Repository.Interfaces;

namespace TESTUoW.Service.Services
{
    public abstract class BaseService
    {
        protected IUoW UoW { get; }
        protected BaseService(IUoW uoW) 
        {
            UoW = uoW;
        }
    }
}
