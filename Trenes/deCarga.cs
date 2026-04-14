namespace clases
{
public class DeCarga : Vagon
{
    private double _cargaMaxima;
    public double CargaMaxima
    {
        get { return _cargaMaxima; }
        set { _cargaMaxima = value; }
    }
    public override double PesoMaximo()
    {
        // Carga máxima + 160 kg (dos guardas de 80 kg cada uno)
        return this.CargaMaxima + 160; 
    }
}
}