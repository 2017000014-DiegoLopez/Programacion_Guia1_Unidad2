internal class Program
{
    private static void Main(string[] args)
    {
        int a1, a2, a3;

        Console.WriteLine("Ingrese el ángulo 1:");
        a1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el ángulo 2:");
        a2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el ángulo 3:");
        a3 = int.Parse(Console.ReadLine());

        if (a1 == a2 && a2 == a3)
            Console.WriteLine("es Triángulo Equilátero");
        else if (a1 == a2 || a2 == a3 || a1 == a3)
            Console.WriteLine("es Triángulo Isósceles");
        else
            Console.WriteLine("es Triángulo Escaleno");    
    }
}