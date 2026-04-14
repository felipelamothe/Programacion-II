using System.Collections.Generic;

namespace clases
{
    public class Deposito
    {
        private List<Locomotora> _locomotoras;
        public List<Locomotora> Locomotoras
        {
            get { return _locomotoras; }
            set { _locomotoras = value; }
        }

        private List<Formacion> _formaciones;
        public List<Formacion> Formaciones
        {
            get { return _formaciones; }
            set { _formaciones = value; }
        }

        public Deposito()
        {
            _locomotoras = new List<Locomotora>();
            _formaciones = new List<Formacion>();
        }

        public void AgregarLocomotoraEnFormacion(Locomotora pLocomotora, Formacion pFormacion)
        {
            if (pFormacion.EstaEnMovimiento == false)
            {
                pFormacion.Locomotoras.Add(pLocomotora);
            }
        }

        public bool NecesitaConductorExperimentado()
        {
            foreach (Formacion f in Formaciones)
            {
                int total = f.Vagones.Count + f.Locomotoras.Count;

                double peso = 0;

                foreach (Vagon v in f.Vagones)
                {
                    peso += v.PesoMaximo();
                }

                foreach (Locomotora l in f.Locomotoras)
                {
                    peso += l.Peso;
                }

                if (total > 20 || peso > 10000)
                {
                    return true;
                }
            }

            return false;
        }
    }
}

