namespace FigurasGeometricas.DAL.Models;

public class Rectangulo: Formas
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public override double CalcularArea()
    {
        return Base * Altura;
    }
}
