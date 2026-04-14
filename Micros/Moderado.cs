public class Moderado : Persona
{
    private int lugaresLibresRequeridos;

    public Moderado(int lugaresMinimos)
    {
        this.lugaresLibresRequeridos = lugaresMinimos;
    }

    public override bool AceptaSubir(Micro micro)
    {
        return micro.LugaresLibres() >= lugaresLibresRequeridos;
    }
}
