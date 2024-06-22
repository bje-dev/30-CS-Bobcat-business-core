using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Usuario
    {
        private string alias { get; set; }
        private string contraseña { get; set; }
        private List<Familia> Familia { get; set; }

    }
}
