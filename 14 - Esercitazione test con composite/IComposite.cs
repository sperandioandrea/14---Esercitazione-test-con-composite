using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___Esercitazione_test_con_composite
{
    public abstract class IComposite
    {
        public abstract int Punteggio();
        public abstract void Aggiunta(IComposite componente);
        public abstract void Cancellazione(IComposite componente);
        public abstract IComposite GetChild(int index);
    }
}
