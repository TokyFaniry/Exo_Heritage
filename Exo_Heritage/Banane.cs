using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Heritage
{
    internal class Banane:Fruit
    {
        public override void SetNomAliment()
        {
            base.SetNomAliment();
            this.NomAliment = "Banane";
        }
        public Banane() 
        { 
            SetNomAliment();
        }
    }
}
