using edu.nrojlla.examenFinal.Dtos;
using edu.nrojlla.examenFinal.Servicios;
using System.Security.Cryptography;

namespace edu.nrojlla.examenFinal.Controlador
{
    /// <summary>
    /// Clase principal program
    /// <autor>nrojalla14062024</autor>
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Aplicaion principal 
        /// <autor>nrojalla14062024</autor>
        /// </summary>
        /// 
        public static List<CochesDto>CochesLista = new List<CochesDto>();
        public static string ficheroLog = $"log {DateTime.Now.ToString("ddMMyyyy")} .txt";
        public static string datosIniciales = "datosIniciales.txt";

        static void Main(string[] args)
        {

            MenuInterface mi = new MenuImplementacion();
            OperativaInterface oi = new OperativaImplementacion();
            FicheroInterface fi = new FicheroImplementacion();

            try
            {
                fi.CargaDatos();

                int opcionSeleccionada;
                bool esCerrado = false;
                do
                {
                    opcionSeleccionada = mi.MenuPrincipal();
                    string mensaje = $"{DateTime.Now.ToString("dd/MM/yyy HH:mm:ss")} - Menu Inicial, opcion : {opcionSeleccionada} ";
                    switch (opcionSeleccionada)
                    {
                        case 0:
                            mensaje += "Cerrado";
                            esCerrado = true;
                            Console.WriteLine("Aplicacion cerrada");
                            break;
                        case 1:
                            mensaje += "Numero de historicos";
                            oi.NumeroHistorico();
                            break;

                        case 2:
                            mensaje += "Alta nuevo propietario";
                            oi.AltaNuevoPropietario();
                            break;

                        default:
                            mensaje += "No valida";
                            Console.WriteLine("La opcion seleccionada no es valida");
                            break;
                    }
                    ficheroLogger(mensaje);

                } while (!esCerrado);

            }
            catch (Exception e) { Console.WriteLine($"No se ha podido leer/escribit ".Concat(e.ToString())); }

        }
        /// <summary>
        /// Fichero log
        /// </summary>
        /// <param name="mensaje"></param>
        private static void ficheroLogger(string mensaje)
        {
            try
            {
                using (StreamWriter log = new StreamWriter(ficheroLog, true))
                {
                    log.WriteLine(mensaje);
                }

            }
            catch (Exception e) { Console.WriteLine("No se ha podido escribir en el fichero".Concat(e.ToString())); }
        }
    }
}

