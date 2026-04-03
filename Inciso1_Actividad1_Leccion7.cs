internal class Program
{
    private static void Main(string[] args)
    {
        int n1;
        Console.WriteLine("Ingresa la primer nota:");
        n1 = Convert.ToInt32(Console.ReadLine());
        int n2;
        Console.WriteLine("Ingresa la segunda nota:");
        n2 = Convert.ToInt32(Console.ReadLine());
        int n3;
        Console.WriteLine("Ingresa la tercera nota:");
        n3 = Convert.ToInt32(Console.ReadLine());
        int n4;
        Console.WriteLine("Ingresa la cuarta nota:");
        n4 = Convert.ToInt32(Console.ReadLine());
        int n5;
        Console.WriteLine("Ingresa la quinta nota:");
        n5 = Convert.ToInt32(Console.ReadLine());
        int suma;
        suma = n1 + n2 + n3 + n4 + n5;
        double Resultado;
        Resultado = suma / 5;
        if (Resultado >= 70)
        {
            Console.WriteLine("Usted a ganado la clase");
        }
        else
        {
            Console.WriteLine("Usted a perdido la clase");
        }



    }
}