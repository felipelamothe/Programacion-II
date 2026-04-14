namespace Clase1.Ejercicio;

public abstract class Empleados
{
    private double _sueldoNeto;
    public double SueldoNeto
    {
        get { return _sueldoNeto; }
        set { _sueldoNeto = value; }
    }

    private BonoPresentismo _miBonoPresentismo;
    public BonoPresentismo MiBonoPresentismo
    {
        get { return _miBonoPresentismo; }
        set { _miBonoPresentismo = value; }
    }

    private BonoResultado _miBonoResultado;
    public BonoResultado MiBonoResultado
    {
        get { return _miBonoResultado; }
        set { _miBonoResultado = value; }
    }
    public Empleados (double sueldoNeto, BonoPresentismo Bpresentismo, BonoResultado Bresultado)
    {
        SueldoNeto = sueldoNeto;
        MiBonoPresentismo = Bpresentismo;
        MiBonoResultado = Bresultado;
    }
    public double CalcularSueldoNeto(int faltas, int objetivo)
    {
        return SueldoNeto + MiBonoPresentismo.Calcular(faltas) + MiBonoResultado.Calcular(SueldoNeto, objetivo);
    }

}