using edu.nrojlla.examenFinal.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.nrojlla.examenFinal.Utils
{
    /// <summary>
    /// Clase utilidades frecuentes
    /// <autor>nrojalla14062024</autor>
    /// </summary>
    internal class Utils
    {
        public static long generarId()
        {
            long idCalcular;
            int tamanio = Program.CochesLista.Count();
            if (tamanio > 0)
            {
                idCalcular = Program.CochesLista.Count() + 1;
            }
            else
            {
                idCalcular = 1;
            }
            return idCalcular;
        }
    }
}
