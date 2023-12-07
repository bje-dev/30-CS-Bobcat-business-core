using SL.DAL.Factories;
using SL.Domain.SecurityComposite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Services.Security
{
    //PATRÓN FACADE...
    public sealed class ServicesUser
    {
        #region Singleton
        private readonly static ServicesUser _instance = new ServicesUser();

        public static ServicesUser Current
        {
            get
            {
                return _instance;
            }
        }

        private ServicesUser()
        {
            //Implement here the initialization code
        }
        #endregion

        #region USUARIOS
        public bool Login(Usuario usuario)
        {
            //Hacemos lo pertinente...

            return false;
        }

        public void AgregarUsuario(Usuario usuario)
        {
            //Verificar que debería ir a la BLL, pero voy a la DAL directo ahora...
            Factory.Current.UsuarioRepository.Insert(usuario);
        }

        public void ObtenerUsuario(Guid idUsuario)
        {
            //Verificar que debería ir a la BLL, pero voy a la DAL directo ahora...
            Factory.Current.UsuarioRepository.GetOne(idUsuario);
        }
        #endregion

        #region PATENTES
        public void AgregarPatente(Patente patente)
        {
            //Verificar que debería ir a la BLL, pero voy a la DAL directo ahora...
            Factory.Current.PatenteRepository.Insert(patente);
        }

        public Patente ObtenerPatente(Guid idPatente)
        {
            //Verificar que debería ir a la BLL, pero voy a la DAL directo ahora...
            return Factory.Current.PatenteRepository.GetOne(idPatente);
        }

        #endregion

        #region FAMILIAS

        public Familia ObtenerFamilia(Guid idFamilia)
        {
            //Recordar que debería ir a las reglas de negocio de este proyecto...
            return Factory.Current.FamiliaRepository.GetOne(idFamilia);
        }

        #endregion

    }
}
