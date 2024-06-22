using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        private string nombre {  get; set; }
        private string dni {  get; set; }
        private string direccion { get; set; }
        private string email { get; set; }
        private string telefono { get; set; }
        private Usuario Usuario { get; set; }
        
    }
}
