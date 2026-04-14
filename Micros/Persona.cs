using System;
using System.Collections.Generic;

public abstract class Persona
{
    public bool EsJefe { get; set; }
    public Persona Jefe { get; set; }

    public abstract bool AceptaSubir(Micro micro);
}