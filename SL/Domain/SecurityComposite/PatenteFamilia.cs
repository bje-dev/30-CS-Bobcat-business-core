using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.SecurityComposite
{
    /// <summary>
	/// This class (a) declares the interface for objects in the composition, (b)
	/// implements default behaviour for the interface common to all classes, as
	/// appropriate, (c) declares an interface for accessing and managing its child
	/// components, and (d) optionally defines an interface for accessing a component's
	/// parent in the recursive structure and implements it if that's appropriate.
	/// </summary>
	public abstract class PatenteFamilia
    {

        public string Nombre { get; set; }

        public PatenteFamilia()
        {

        }

        /// 
        /// <param name="component"></param>
        public abstract void Add(PatenteFamilia component);

        /// 
        /// <param name="component"></param>
        public abstract void Remove(PatenteFamilia component);

        public abstract int CantidadHijos { get; }

    }//end PatenteFamilia
}
