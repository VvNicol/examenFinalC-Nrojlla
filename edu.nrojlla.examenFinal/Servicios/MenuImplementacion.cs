namespace edu.nrojlla.examenFinal.Servicios
{
    /// <summary>
    /// Detalle de los metodos de MenuInterface
    /// <autor>nrojalla14062024</autor>
    /// </summary>
    internal class MenuImplementacion : MenuInterface
    {
        public int MenuPrincipal()
        {
            try
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Menu principal");
                Console.WriteLine("0.Cerrar");
                Console.WriteLine("1.Número de históricos");
                Console.WriteLine("2.Alta nuevo propietario");
                Console.WriteLine("---------------------");
                int opcionElegida = Convert.ToInt32(Console.ReadLine());
                return opcionElegida;

            }
            catch (Exception) { throw; }
        }
    }
}