namespace clases
{
public abstract class Vagon
{
    private double _largo;

     public double Largo
    {
        get { return _largo; }
        set { _largo = value; }
    }
    private double _anchoUtil;
    public double AnchoUtil
    {
        get { return _anchoUtil; }
        set { _anchoUtil = value; }
    }
    
    // La clase base solo define que todo vagón debe saber calcular su peso
    public abstract double PesoMaximo();
}
}

