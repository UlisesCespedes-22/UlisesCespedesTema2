namespace Consigna_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Ingrese el radio del cilindro");
                var radio = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese altura del cilindro");
                var altura = int.Parse(Console.ReadLine());

                var volumen = Math.PI * Math.Pow(radio, 2) * altura;

                var superficie = Math.PI * 2 * Math.Pow(radio, 2) * altura;

                Console.WriteLine($"El volumen es: {volumen:N2}");
                Console.WriteLine($"La superficie es: {superficie:N2}");

                Console.WriteLine("desea agregar un nuevo cilindro?");
                Console.WriteLine("S: CONTUNIAR");
                Console.WriteLine("N: FINALIZAR");

                char opcion = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (opcion)
                {
                    case 'S':
                        Console.WriteLine("CONTINUE");
                        break;
                    case 'N':
                        Console.WriteLine("FIN");
                        var FIN = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                } 
            } while (true);
        }
    }
}
