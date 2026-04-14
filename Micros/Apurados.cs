public class Apurado : Persona
{
    public override bool AceptaSubir(Micro micro)
    {
        // Los apurados se suben siempre
        return true; 
    }
}

