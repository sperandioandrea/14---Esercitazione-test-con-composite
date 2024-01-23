using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___Esercitazione_test_con_composite
{
    public abstract class Test : IComposite
    {
        private List<IComposite> componenti = new List<IComposite>();

        //Funzione Punteggio
        public override int Punteggio()
        {
            int punteggioTotale = 0;
            foreach (var componente in componenti)
            {
                punteggioTotale += componente.Punteggio();
            }
            return punteggioTotale;
        }

        //Aggiunta
        public override void Aggiunta(IComposite componente)
        {
            componenti.Add(componente);
        }
        //Cancellazione
        public override void Cancellazione(IComposite componente)
        {
            componenti.Remove(componente);
        }
        //GetChild
        public override IComposite GetChild(int index)
        {
            return componenti[index];
        }

        //ToString
        public override string ToString()
        {
            string result = "Test:\n";
            foreach (var componente in componenti)
            {
                result += " - " + componente.ToString() + "\n";
            }
            return result;
        }
        //Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Test other = (Test)obj;

            if (base.Equals(other) && componenti == other.componenti)
            {
                return true;
            }

            return false;
        }
    }
}
