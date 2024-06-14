using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.nrojlla.examenFinal.Dtos
{
    /// <summary>
    /// Datos del coche 
    /// <autor>nrojalla14062024</autor>
    /// </summary>
    internal class CochesDto
    {
        long id;
        string matricula = "aaaaa";
        DateTime fchaMfchMatriculacion = new DateTime(9999, 12, 31);
        string dni = "aaaaa";
        DateTime fchCompra = new DateTime(9999, 12, 31);

        override

        public string ToString()
        {
            string mensaje = $"Nuevo propietario: {Id} - {Dni}\r\n";
            return mensaje;
        }

        public CochesDto()
        {
        }

        public CochesDto(long id, string matricula, DateTime fchaMfchMatriculacion, string dni, DateTime fchCompra)
        {
            this.id = id;
            this.matricula = matricula;
            this.fchaMfchMatriculacion = fchaMfchMatriculacion;
            this.dni = dni;
            this.fchCompra = fchCompra;
        }

        public long Id { get => id; set => id = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public DateTime FchaMfchMatriculacion { get => fchaMfchMatriculacion; set => fchaMfchMatriculacion = value; }
        public string Dni { get => dni; set => dni = value; }
        public DateTime FchCompra { get => fchCompra; set => fchCompra = value; }
    }
}
