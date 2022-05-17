using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_agenzia
{
    internal class Appartamento : Immobile
    {
        private int numStanze;
        public int nStanze { get => numStanze; set => numStanze = value; }

        private int numBagni;
        public int nBagni { get => numBagni; set => numBagni = value; }
        public Appartamento(string codice, string indirizzo, string cap, string citta, int mq, int stanze, int bagni) : base(codice, indirizzo, cap, citta, mq)
        {
            this.numStanze = stanze;
            this.numBagni = bagni;
        }


        public override string ToString()
        {
            return string.Format("Appartamento: {0}", this.Write());
        }

        protected override string Write()
        {
            return string.Format("{0}\n Stanze: {1}\n Bagni: {2}", base.Write(), this.nStanze, this.nBagni);
        }


        public override bool Contains(string key)
        {
            if (base.Contains(key)) return true;
            else if (this.nStanze.ToString().Contains(key)) return true;
            else if (this.nBagni.ToString().Contains(key)) return true;
            else return false;
        }


        }
    }
