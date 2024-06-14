using edu.nrojlla.examenFinal.Controlador;
using edu.nrojlla.examenFinal.Dtos;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace edu.nrojlla.examenFinal.Servicios
{
    /// <summary>
    /// Detalle de los metodos de la operativa
    /// <autor>nrojalla14062024</autor>
    /// </summary>
    internal class OperativaImplementacion : OperativaInterface
    {
        public void AltaNuevoPropietario()
        {
            try
            {

                long nuevoId = Utils.Utils.generarId();
                string dniUsuario;
                bool esValidoDni = false;

                do
                {
                    CochesDto cochesDto = new CochesDto();
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Ingrese su dni (8 digitos)");
                    int dniDigitos = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrese la letra de su dni (ej: z)");
                    char letraDni = Convert.ToChar(Console.ReadLine().ToUpper());

                    int[] resto = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
                    char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

                    int divisor = 23;
                    int operacion = dniDigitos % divisor;

                    int posicionResto = resto[operacion];

                    if (letraDni == letras[posicionResto])
                    {

                        esValidoDni = true;
                        dniUsuario = $"{dniDigitos}{letraDni}";
                        cochesDto.Dni = dniUsuario;

                        var mensaje = Program.CochesLista.OrderBy(c => c.Id).ToList();
                        int numero = 0;
                        int num;

                        for (int i = 0; i < mensaje.Count(); i++)
                        {
                            numero += i;
                            num = numero;
                        }

                        Console.WriteLine($"Nuevo propietario: {numero} - {dniUsuario}");
                    }
                    else
                    {
                        esValidoDni = false;
                        Console.WriteLine("No es valido Intentelo otravez");
                    }

                    cochesDto.Id = nuevoId;

                    Program.CochesLista.Add(cochesDto);




                } while (!esValidoDni);


            }
            catch (Exception) { throw; }
        }

        public void NumeroHistorico()
        {
            try
            {
                DateTime date = new DateTime(2003, 01, 01);
                
                var historico = Program.CochesLista.Where(v => v.FchCompra > date).ToList();
                int numero = 0;
                int num = 0;

                for (int i = 0; i < historico.Count(); i++)
                {
                    numero += i;
                    num = numero;
                    
                }
                Console.WriteLine($"N. Históricos: {numero}");

            }
            catch (Exception) { throw; }
        }
    }
}