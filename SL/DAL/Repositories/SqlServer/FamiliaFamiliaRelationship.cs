using SL.DAL.Contracts;
using SL.Domain.SecurityComposite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.DAL.Repositories.SqlServer
{

    internal class FamiliaFamiliaRelationship : IGenericRelationship<Familia, Familia>
    {
        public List<Familia> Get(Familia obj)
        {
            return new List<Familia>();
        }

        public void Join(Familia obj1, Familia obj2)
        {
            throw new NotImplementedException();
        }
    }
}
