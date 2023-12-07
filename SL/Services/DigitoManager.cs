using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Services
{
    internal sealed class DigitoManager
    {
        static char GenerarDigitoVerificador(string dato)
        {
            // Algoritmo de suma ponderada
            int sumaPonderada = 0;
            int multiplicador = 2;

            // Itera sobre los dígitos del número de cuenta en orden inverso
            for (int i = dato.Length - 1; i >= 0; i--)
            {
                int digito = int.Parse(dato[i].ToString());
                sumaPonderada += digito * multiplicador;

                multiplicador = (multiplicador == 2) ? 1 : 2; // Alterna entre 1 y 2
            }

            // Calcula el residuo de la suma ponderada dividido por 10
            int residuo = sumaPonderada % 10;

            // Calcula el dígito verificador restando el residuo de 10
            int digitoVerificador = (residuo == 0) ? 0 : 10 - residuo;

            // Convierte el dígito verificador a un carácter
            return char.Parse(digitoVerificador.ToString());
        }

      
            
    }
}
