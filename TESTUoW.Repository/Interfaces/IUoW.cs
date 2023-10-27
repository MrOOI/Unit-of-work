using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTUoW.Repository.Interfaces
{
    public interface IUoW : IDisposable
    {
        IPersonRepository PersonRepository { get; }
        void Begin();
        void Commit();
        void RollBack();
    }
}
