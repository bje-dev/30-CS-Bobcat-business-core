using SL.Domain.SecurityComposite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.DAL.Repositories.SqlServer.Adapters
{
    internal sealed class PatenteAdapter
    {
        #region Singleton
        private readonly static PatenteAdapter _instance = new PatenteAdapter();

        public static PatenteAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private PatenteAdapter()
        {
            //Implement here the initialization code
        }
        #endregion

        public Patente Adapt(object[] values)
        {
            return new Patente()
            {
                IdPatente = Guid.Parse(values[0].ToString()),
                Nombre = values[1].ToString(),
                Vista = values[2].ToString()
            };
        }
    }
}
