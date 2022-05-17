using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_agenzia
{
    internal class Box : Immobile
    {
        private int numPostiAuto;
        public int PostiAuto { get => numPostiAuto; set => numPostiAuto = value; }
        public Box(string codice, string indirizzo, string cap, string citta, int mq, int postiAuto) : base(codice, indirizzo, cap, citta, mq)
        {
            this.numPostiAuto = postiAuto;
        }


        public override string ToString()
        {
            return string.Format("Box: {0}", this.Write());
        }

        protected override string Write()
        {
            return string.Format("{0}\n PostiAuto: {1}", base.Write(), this.PostiAuto);
        }

        public override bool Contains(string key)
        {
            if (base.Contains(key)) return true;
            else if (this.PostiAuto.ToString().Contains(key)) return true;
            else return false;
        }

    }

}
