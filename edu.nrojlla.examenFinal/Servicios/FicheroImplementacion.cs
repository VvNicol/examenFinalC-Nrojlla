using edu.nrojlla.examenFinal.Controlador;
using edu.nrojlla.examenFinal.Dtos;

namespace edu.nrojlla.examenFinal.Servicios
{
    /// <summary>
    /// Detallede los metodos de FicheroInterface
    /// <autor>nrojalla14062024</autor>
    /// </summary>
    internal class FicheroImplementacion : FicheroInterface
    {
        public void CargaDatos()
        {
            try
            {
                if (!File.Exists(Program.datosIniciales))
                {
                    using (StreamWriter st = new StreamWriter(Program.datosIniciales))
                    {
                        st.WriteLine("1234ATT:12-12-2019:12345678A:12-12-2019");
                        st.WriteLine("9876WWW:10-11-2021:23456789P:21-12-2023");
                        st.WriteLine("4567UOP:20-10-1998:98765432R:20-10-1999");
                        st.WriteLine("4567UPO:20-10-1996:34567891I:20-10-2003");

                    }
                }
                else
                {
                    using (StreamReader sr = new StreamReader(Program.datosIniciales))
                    {
                        string linea;
                        while ((linea = sr.ReadLine()) != null)
                        {
                            string[] partes = linea.Split(':');

                            
                            long id = Utils.Utils.generarId();
                            string matricula = partes[0];
                            DateTime fchaMfchMatriculacion = DateTime.Parse(partes[1]);
                            string dni = partes[2];
                            DateTime fchCompra = DateTime.Parse(partes[3]);
                            
                            CochesDto carga = new CochesDto(id,matricula,fchaMfchMatriculacion,dni,fchCompra);
                            Program.CochesLista.Add(carga);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar los ficheros: " + ex.Message);
            }

        }
    }
}