using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIralynok
{
    internal class Helyek
    {
        private int sor;

        public int Sor
        {
            get { return sor; }
            set { sor = value; }
        }
        private int oszlop;

        public int Oszlop
        {
            get { return oszlop; }
            set { oszlop = value; }
        }

        public Helyek(int i, int k)
        {
            Oszlop = i;
            Sor = k;
        }
    }
}
