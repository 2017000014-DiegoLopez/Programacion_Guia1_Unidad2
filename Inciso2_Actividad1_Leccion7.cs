internal class Program
{
    private static void Main(string[] args)
    {
        int edad;
        Console.WriteLine("Ingrese su edad:");
        edad = Convert.ToInt32(Console.ReadLine());
        if (edad >= 18)
        {
            Console.WriteLine("Usted es mayor de edad");
        }
        else
        {
            Console.WriteLine("Usted es menor de edad");
        }
    }
}