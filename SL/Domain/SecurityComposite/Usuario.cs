using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.SecurityComposite
{
    public class Usuario
    {
        public string CulturaCodigo { get; set; }

        public string Nombre { get; set; }

        public string Contraseña { get; set; }

        public List<PatenteFamilia> Permisos { get; set; } = new List<PatenteFamilia>();

        public List<Patente> PermisosMenu
        {
            get
            {
                List<Patente> listadoAux = new List<Patente>();
                ObtenerListadoPatentes(Permisos, listadoAux);
                return listadoAux;
            }
        }

        public List<Familia> Roles
        {
            get
            {
                //Devolver los roles a los que pertenece el usuario
                List<Familia> listadoAux = new List<Familia>();
                ObtenerListadoFamilias(Permisos, listadoAux);
                return listadoAux;
            }
        }

        /// <summary>
        /// DESAFÍO -> ARMAR EL LIST DE PATENTES CON ESTE MÉTODO...
        /// </summary>
        /// <param name="lstPermisosPorGrupo"></param>
        private void ObtenerListadoPatentes(List<PatenteFamilia> lstPermisosPorGrupo, List<Patente> listadoAux)
        {
            foreach (var permisoItem in lstPermisosPorGrupo)
            {
                if (permisoItem.CantidadHijos == 0)
                {
                    //Console.WriteLine("Patente: " + permisoItem.Nombre);
                    listadoAux.Add(permisoItem as Patente);
                }
                if (permisoItem.CantidadHijos > 0)
                {
                    ObtenerListadoPatentes((permisoItem as Familia).ListadoHijos, listadoAux);
                }
            }
        }

        private void ObtenerListadoFamilias(List<PatenteFamilia> lstPermisosPorGrupo, List<Familia> listadoAux)
        {
            foreach (var permisoItem in lstPermisosPorGrupo)
            {
                if (permisoItem.CantidadHijos > 0)
                {
                    //YO SÉ QUE ESTOY EN UNA FAMILIA...
                    listadoAux.Add(permisoItem as Familia);
                    ObtenerListadoFamilias((permisoItem as Familia).ListadoHijos, listadoAux);
                }
                //else...Si soy patente no hago nada...
            }
        }
    }
}
