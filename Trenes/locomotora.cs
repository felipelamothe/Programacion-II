namespace clases
{public class Locomotora
{
    private double _peso;
    private int _arrastrePesoUtil;
    private double _velocidadMaxima;

    public double Peso
    {
        get { return _peso; }
        set { _peso = value; }
    }

    public int arrastrePesoUtil
    {
        get { return _arrastrePesoUtil; }
        set { _arrastrePesoUtil = value; }
    }

    public double VelocidadMaxima
    {
        get { return _velocidadMaxima; }
        set { _velocidadMaxima = value; }
    }
    public double ArrastreUtil()
    {
        // Se calcula restando el peso propio al peso máximo que puede arrastrar
        return this.arrastrePesoUtil - this.Peso;
    }
}
}