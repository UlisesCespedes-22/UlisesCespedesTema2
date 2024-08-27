namespace ConsoleApp1_consigna_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese el radio del cilindro");
                var radio = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese altura del cilindro");
                var altura = int.Parse(Console.ReadLine());

                var volumen = Math.PI * Math.Pow(radio, 2) * altura;

                var superficie = Math.PI * 2 * Math.Pow(radio, 2) * altura;

                Console.WriteLine($"El volumen es: {volumen:N2}");
                Console.WriteLine($"La superficie es: {superficie:N2}");
            }
            catch (Exception)
            {

                
            }

        }
    }
}
