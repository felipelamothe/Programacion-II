public class Claustrofobico : Persona
{
    private const int VOLUMEN_MINIMO = 120;

    public override bool AceptaSubir(Micro micro)
    {
        return micro.Volumen > VOLUMEN_MINIMO;
    }
}