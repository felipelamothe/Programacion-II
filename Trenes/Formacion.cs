namespace clases
{
    public class Formacion
    {
        private List<Locomotora> _locomotoras;
        private List<Vagon> _vagones;
        private bool _estaEnMovimiento;

        // Constructor
        public Formacion()
        {
            // Inicializamos las listas para que no den error al intentar agregar elementos
            _locomotoras = new List<Locomotora>();
            _vagones = new List<Vagon>();
            _estaEnMovimiento = false;
        }

        public List<Locomotora> Locomotoras
        {
            get { return _locomotoras; }
            set { _locomotoras = value; }
        }

        public List<Vagon> Vagones
        {
            get { return _vagones; }
            set { _vagones = value; }
        }

        public bool EstaEnMovimiento
        {
            get { return _estaEnMovimiento; }
            set { _estaEnMovimiento = value; }
        }

        public int TotalPasajeros()
        {
            int total = 0;

            foreach (Vagon v in Vagones)
            {
                if (v is DePasajeros)
                {
                    DePasajeros vp = (DePasajeros)v;
                    total += vp.CantidadDePasajeros();
                }
            }

            return total;
        }

        public int VagonesLivianos()
        {
            int contador = 0;

            foreach (Vagon v in Vagones)
            {
                if (v.PesoMaximo() < 2500)
                {
                    contador++;
                }
            }

            return contador;
        }

        public double VelocidadMaxima()
        {
            double min = Locomotoras[0].VelocidadMaxima;

            foreach (Locomotora l in Locomotoras)
            {
                if (l.VelocidadMaxima < min)
                {
                    min = l.VelocidadMaxima;
                }
            }

            return min;
        }

        public bool PuedeMoverse()
        {
            double pesoVagones = 0;
            double arrastre = 0;

            foreach (Vagon v in Vagones)
            {
                pesoVagones += v.PesoMaximo();
            }

            foreach (Locomotora l in Locomotoras)
            {
                arrastre += l.ArrastreUtil();
            }

            return arrastre >= pesoVagones;
        }

        public double KilosFaltantes()
        {
            double pesoVagones = 0;
            double arrastre = 0;

            foreach (Vagon v in Vagones)
            {
                pesoVagones += v.PesoMaximo();
            }

            foreach (Locomotora l in Locomotoras)
            {
                arrastre += l.ArrastreUtil();
            }

            if (arrastre >= pesoVagones)
            {
                return 0;
            }
            else
            {
                return pesoVagones - arrastre;
            }
        }

    }

}
