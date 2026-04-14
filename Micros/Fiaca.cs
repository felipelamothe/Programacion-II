public class Fiaca : Persona
{
    public override bool AceptaSubir(Micro micro)
    {
        // Solo si entran sentados
        return micro.HayLugarSentado();
    }
}
    
