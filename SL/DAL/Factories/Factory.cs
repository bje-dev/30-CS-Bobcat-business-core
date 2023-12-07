using SL.DAL.Contracts;
using SL.DAL.Repositories.SqlServer;
using SL.Domain.SecurityComposite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.DAL.Factories
{
    internal sealed class Factory
    {
        #region Singleton
        private readonly static Factory _instance = new Factory();

        public static Factory Current
        {
            get
            {
                return _instance;
            }
        }

        private Factory()
        {
            string backend = ConfigurationManager.AppSettings["backendSL"];

            if (backend == "SL.DAL.Repositories.SqlServer")
            {
                //Instanciar todos los repositorios...
                PatenteRepository = new PatenteRepository();
                FamiliaRepository = new FamiliaRepository();
            }

        }
        #endregion

        public IGenericRepository<Patente> PatenteRepository { get; set; }

        public IGenericRepository<Familia> FamiliaRepository { get; set; }

        public IGenericRepository<Usuario> UsuarioRepository { get; set; }

    }
}
