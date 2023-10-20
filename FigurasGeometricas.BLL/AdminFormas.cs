using FigurasGeometricas.DAL.Models;

namespace FigurasGeometricas.BLL;

public class AdminFormas
{
    public double CalcularArea(Formas formas)
    {
        return formas.CalcularArea();
    }
}
