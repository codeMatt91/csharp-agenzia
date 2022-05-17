using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_agenzia
{
    internal class Villa : Appartamento
    {
        private int mqGiardino;
        public int MqGiardino { get => mqGiardino; set => mqGiardino = value; }

        public Villa(string codice, string indirizzo, string cap, string citta, int mq, int stanze, int bagni, int mqGiardino) : base(codice, indirizzo, cap, citta, mq, stanze, bagni)
        {
            this.MqGiardino = mqGiardino;
        }

        public override string ToString()
        {
            return string.Format("Villa: {0}", this.Write());
        }

        protected override string Write()
        {
            return string.Format("{0}\n Giardino(mq): {1}}", base.Write(), this.MqGiardino);
        }


        public override bool Contains(string key)
        {
            if (base.Contains(key)) return true;
            else if (this.MqGiardino.ToString().Contains(key)) return true;
            else return false;
        }

    }
}
