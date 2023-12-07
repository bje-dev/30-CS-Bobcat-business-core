using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.DAL.Contracts
{
    //Usando tipos genéricos -> T
    internal interface IEntityAdapter<T>
    {
        T Adapt(object[] values);
    }
}
