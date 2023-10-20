using FigurasGeometricas.BLL;
using FigurasGeometricas.DAL.Models;
using Xunit;

public class FigurasGeometricasTests
{
    [Fact]
    public void CircleAreaCalculation()
    {
        Circulo circulo = new Circulo { Radio = 5 };
        AdminFormas adminFormas = new AdminFormas();

        double areaEsperada = Math.PI * Math.Pow(5, 2);
        double areaActual = adminFormas.CalcularArea(circulo);

        Assert.Equal(areaEsperada, areaActual);
    }

    [Fact]
    public void RectangleAreaCalculation()
    {
        Rectangulo rectangulo = new Rectangulo { Base = 4, Altura = 6 };
        AdminFormas adminFormas = new AdminFormas();

        double areaEsperada = 4 * 6;
        double areaActual = adminFormas.CalcularArea(rectangulo);

        Assert.Equal(areaEsperada, areaActual);
    }
}
