internal class Program
{
    private static void Main(string[] args)
    {
        int opcion;

        Console.WriteLine("1. Ventas");
        Console.WriteLine("2. Recepción");
        Console.WriteLine("3. Dirección");
        Console.WriteLine("4. Compras");
        Console.WriteLine("Seleccione una opción:");
        opcion = int.Parse(Console.ReadLine());

        if (opcion == 1)
            Console.WriteLine("Ventas - Juan Pérez (juanP_P8@gmail.com)");
        else if (opcion == 2)
            Console.WriteLine("Recepción - María Gómez (mariag_g4@gmail.com)");
        else if (opcion == 3)
            Console.WriteLine("Dirección - Carlos Ruiz (carlit0z_1995@gmail.com)");
        else if (opcion == 4)
            Console.WriteLine("Compras - Ana López (4na_85@gmail.com)");
        else
            Console.WriteLine("Opción inválida");

    }
}