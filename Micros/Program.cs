using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Iniciando simulación de Micros ACME");

        // Creamos un micro con: 2 lugares sentados, 1 parado, y 130 m3 de volumen
        Micro miMicro = new Micro(2, 1, 130);
        
        // Creamos a los pasajeros
        Apurado juanApurado = new Apurado();
        Claustrofobico pedroClaustro = new Claustrofobico(); 
        Fiaca martaFiaca = new Fiaca();
        Moderado luisModerado = new Moderado(2); // Luis solo sube si quedan 2 o más lugares libres

        try
        {
            Console.WriteLine("Intentando subir a Juan (Apurado)...");
            miMicro.Subir(juanApurado);
            Console.WriteLine("Juan subio Lugares libres: " + miMicro.LugaresLibres());

            Console.WriteLine("\nIntentando subir a Pedro (Claustrofobico)...");
            // Pedro debería subir porque el volumen del micro (130) es mayor a 120
            miMicro.Subir(pedroClaustro);
            Console.WriteLine("Pedro subio Lugares libres: " + miMicro.LugaresLibres());

            Console.WriteLine("\nIntentando subir a Marta (Fiaca)...");
            // Marta va a intentar subir. Ya hay 2 personas arriba y el micro solo tiene 2 asientos.
            // Por lo tanto, HayLugarSentado() va a dar false, y debería tirar excepción.
            miMicro.Subir(martaFiaca);
            Console.WriteLine("Marta subio"); 
        }
        catch (Exception ex)
        {
            // Acá atrapamos el error que tira el throw new Exception() dentro de Subir()
            Console.WriteLine("ERROR AL SUBIR: " + ex.Message);
        }

        
    }
}