namespace clases
{
public class DePasajeros : Vagon
{
    public int CantidadDePasajeros()
    {
        if (this.AnchoUtil <= 2.5)
        {
            return (int)(8 * this.Largo);
        }
        else
        {
            return (int)(10 * this.Largo);
        }
    }

    public override double PesoMaximo()
    {
        // Cada pasajero pesa 80 kg
        return this.CantidadDePasajeros() * 80; 
    }
}

}