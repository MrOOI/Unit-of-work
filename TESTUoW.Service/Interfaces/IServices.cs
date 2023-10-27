using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTUoW.Service.Interfaces
{
    public interface IServices: IDisposable
    {
        IPersonService PersonService { get; }
        DbTransaction BeginTransaction { get; }
    }
}
