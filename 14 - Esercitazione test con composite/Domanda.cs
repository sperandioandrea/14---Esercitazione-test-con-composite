using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___Esercitazione_test_con_composite
{
    public class Domanda : IComposite
    {
        private List<IComposite> risposte = new List<IComposite>();

        public override void Aggiunta(IComposite componente)
        {
            risposte.Add(componente);
        }

        public override void Cancellazione(IComposite componente)
        {
            risposte.Remove(componente);
        }

        public override IComposite GetChild(int index)
        {
            return risposte[index];
        }

        public override int Punteggio()
        {
            int punteggioTotale = 0;
            foreach (var risposta in risposte)
            {
                punteggioTotale += risposta.Punteggio();
            }
            return punteggioTotale;
        }
    }
}
