using System;
using clases;

class Program
{
    static void Main(string[] args)
    {
        DePasajeros vp = new DePasajeros();
        vp.Largo = 10;
        vp.AnchoUtil = 2;

        DeCarga vc = new DeCarga();
        vc.CargaMaxima = 2000;

        Locomotora l = new Locomotora();
        l.Peso = 1000;
        l.arrastrePesoUtil = 12000;
        l.VelocidadMaxima = 80;

        Formacion f = new Formacion();
        f.Vagones.Add(vp);
        f.Vagones.Add(vc);
        f.Locomotoras.Add(l);

        Console.WriteLine("");
        Console.WriteLine("Pasajeros: " + f.TotalPasajeros());
        Console.WriteLine("Livianos: " + f.VagonesLivianos());
        Console.WriteLine("Velocidad: " + f.VelocidadMaxima());
        Console.WriteLine("Puede moverse: " + f.PuedeMoverse());
        Console.WriteLine("Faltan kg: " + f.KilosFaltantes());
        Console.WriteLine("");
    }
}


