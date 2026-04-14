using System;
using System.Collections.Generic;

public class Micro
{
    private int _sentados;
    private int _parados;
    private int _volumen;
    private List<Persona> _pasajeros;

    public int Sentados
    {
        get { return _sentados; }
        set { _sentados = value; }
    }

    public int Parados
    {
        get { return _parados; }
        set { _parados = value; }
    }

    public int Volumen
    {
        get { return _volumen; }
        set { _volumen = value; }
    }

    public List<Persona> Pasajeros
    {
        get { return _pasajeros; }
        set { _pasajeros = value; }
    }

    // Constructor
    public Micro(int sentados, int parados, int volumen)
    {
        this.Sentados = sentados;
        this.Parados = parados;
        this.Volumen = volumen;
        this.Pasajeros = new List<Persona>(); // Inicializamos la lista
    }

    // Métodos
    public bool PuedeSubir(Persona pasajero)
    {
        return this.HayLugar() && pasajero.AceptaSubir(this);
    }

    public bool HayLugar()
    {
        return (this.Sentados + this.Parados) > this.Pasajeros.Count;
    }

    public bool HayLugarSentado()
    {
        return this.Sentados > this.Pasajeros.Count;
    }

    public int LugaresLibres()
    {
        return (this.Sentados + this.Parados) - this.Pasajeros.Count;
    }

    public void Subir(Persona pasajero)
    {
        if (!this.PuedeSubir(pasajero))
        {
            throw new Exception("No puede subir."); // Acá va tu NoPuedeSubirException
        }
        this.Pasajeros.Add(pasajero);
    }

    public void Bajar(Persona pasajero)
    {
        if (this.Pasajeros.Count == 0)
        {
            throw new Exception("Micro vacío."); // Acá va tu MicroVacioException
        }
        this.Pasajeros.Remove(pasajero);
    }

    public Persona PrimerPasajero()
    {
        if (this.Pasajeros.Count == 0)
        {
            return null;
        }
        return this.Pasajeros[0];
    }
}