using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.SecurityComposite
{
    /// <summary>
    /// This class (a) defines behaviour for components having children, (b) stores
    /// child components, and (c) implements child-related operations in the Component
    /// interface.
    /// </summary>
    public class Familia : PatenteFamilia
    {

        private List<PatenteFamilia> patenteFamilias = new List<PatenteFamilia>();

        //Retorno el listado de mis elementos hijos...
        public List<PatenteFamilia> ListadoHijos => patenteFamilias;

        public override int CantidadHijos => patenteFamilias.Count;

        public Guid IdFamilia { get; set; }

        public Familia()
        {
        }

        public Familia(PatenteFamilia patenteFamilia)
        {
            patenteFamilias.Add(patenteFamilia);
        }

        /// 
        /// <param name="component"></param>
        public override void Add(PatenteFamilia component)
        {
            patenteFamilias.Add(component);
        }

        /// 
        /// <param name="component"></param>
        public override void Remove(PatenteFamilia component)
        {
            patenteFamilias.Remove(component);
            //Verificar restricción de eliminación, al menos una patente/familia debería de existir
        }

    }//end Familia
}
