public class Obsecuente : Persona
{
    public override bool AceptaSubir(Micro micro)
    {
        // Validación básica por si no se le asignó jefe
        if (this.Jefe == null)
        {
            return false; 
        }

        // Delega la decisión en su jefe. 
        // Ojo: si dos obsecuentes son jefes mutuamente (A es jefe de B y B es jefe de A), 
        // esto va a generar un StackOverflowException por llamadas infinitas.
        return this.Jefe.AceptaSubir(micro);
    }
}
