namespace Clase1.Ejercicio;
public abstract class BonoResultado 
{
    public abstract double Calcular (double neto, int porcentajeObjetivo);
}

public class BonoResultadoEstandar : BonoResultado
{
    public override double Calcular (double neto, int porcentajeObjetivo)
    {
        if (porcentajeObjetivo == 100)
        {
            return neto * 0.10; 
        } else if (porcentajeObjetivo >= 80) {
            return 800;
        } 
        return 0;
    }
}