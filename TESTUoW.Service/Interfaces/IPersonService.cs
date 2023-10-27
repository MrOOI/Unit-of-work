using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTUoW.Service.Models;

namespace TESTUoW.Service.Interfaces
{
    public interface IPersonService
    {
        IList<PersonGetAllModel> GetAll();
    }
}
