using FigurasGeometricas.BLL;
using FigurasGeometricas.DAL.Models;

namespace GeometricShapesApp;

class Program
{
    static void Main(string[] args)
    {
        AdminFormas adminFormas = new AdminFormas();

        while (true)
        {
            Console.WriteLine("1. Círculo");
            Console.WriteLine("2. Rectángulo");
            Console.WriteLine("0. Salir");

            Console.WriteLine("Elija una figura geométrica:");
            string opcion = Console.ReadLine();

            try
            {
                switch (opcion)
                {
                    case "1":
                        Circulo circulo = new Circulo();
                        Console.Write("Ingrese el radio del círculo: ");
                        if (double.TryParse(Console.ReadLine(), out double radio))
                        {
                            circulo.Radio = radio;
                            Console.WriteLine($"Area: {adminFormas.CalcularArea(circulo)}");
                        }
                        else
                        {
                            Console.WriteLine("Dato invalido ingresado para el radio.");
                        }
                        break;

                    case "2":
                        Rectangulo rectangulo = new Rectangulo();
                        Console.Write("Ingrese la base del rectángulo: ");
                        if (double.TryParse(Console.ReadLine(), out double rectanguloBase))
                        {
                            rectangulo.Base = rectanguloBase;

                            Console.Write("Ingrese la altura del rectángulo: ");
                            if (double.TryParse(Console.ReadLine(), out double altura))
                            {
                                rectangulo.Altura = altura;
                                Console.WriteLine($"Area: {adminFormas.CalcularArea(rectangulo)}");
                            }
                            else
                            {
                                Console.WriteLine("Dato invalido ingresado para la altura.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Dato invalido ingresado para la base.");
                        }
                        break;

                    case "0":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Elección no válida. Intentar otra vez.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se ha producido una excepción: {ex.Message}");

            }
        }
    }
}
