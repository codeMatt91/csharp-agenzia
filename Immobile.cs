using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_agenzia
{
    internal class Immobile
    {
        private string codice;
        public string Codice { get => codice; set => codice = value; }
        private string indirizzo;
        public string Indirizzo { get => indirizzo; set => indirizzo = value; }
        private string cap;
        public string Cap { get => cap; set => cap = value; }
        private string citta;
        public string Citta { get => citta; set => citta = value;}
        private int mq;
        public int Mq { get => mq; set => mq = value; }


        public Immobile(string codice, string indirizzo, string cap, string citta, int mq)
        { 
            this.Codice = codice;
            this.Indirizzo = indirizzo;
            this.Cap = cap;
            this.Citta = citta;
            this.mq = mq;
        }


        public override string ToString()
        {
            return string.Format("Immobile:{0}", Write());
        }

        protected virtual string Write()
        {
            return string.Format("codice: {0}\n indirizzo: {1}\n cap: {2}\n citta:{3}\n mq: {4}", 
                this.Codice,this.Indirizzo,this.Cap,this.Citta,this.Mq);
        }

        public virtual bool Contains(string key)
        {

            if (this.Codice.Contains(key)) return true;
            else if (this.Indirizzo.Contains(key)) return true;
            else if (this.Cap.Contains(key)) return true;
            else if (this.Citta.Contains(key)) return true;
            else if (this.Mq.ToString().Contains(key)) return true;
            else return false;
        }

    }
}
