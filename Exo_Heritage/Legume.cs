using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Heritage
{
    internal class Legume:Aliment
    {
        public override void SetApportEnergetique()
        {
            base.SetApportEnergetique();
            this.ApportEnegetique = 10;
        }
        public Legume()
        {
            this.SetApportEnergetique();
        }
    }
}
