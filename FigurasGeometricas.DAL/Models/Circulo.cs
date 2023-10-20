namespace FigurasGeometricas.DAL.Models;

public class Circulo: Formas
{
    public double Radio { get; set; }

    public override double CalcularArea()
    {
        return Math.PI * Math.Pow(Radio, 2);
    }
}
