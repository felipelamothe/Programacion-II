namespace Clase1.Ejercicio;
public abstract class BonoPresentismo
{
 public abstract double Calcular(int faltas);
}

//BONO A
public class BonoA : BonoPresentismo
{
    public override double Calcular(int faltas)
    {
        if (faltas == 0) return 1000;
        if (faltas == 1) return 450;

        return 0;
    }
}

//BONO B
public class BonoB : BonoPresentismo
{
    public override double Calcular(int faltas)
    {
        return 500; //Siempre retorna cero, sin importar las faltas
    }
}