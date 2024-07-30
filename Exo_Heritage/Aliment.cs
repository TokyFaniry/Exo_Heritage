using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Heritage
{
    internal  class  Aliment
    {
      public  int ApportEnegetique;
       
      public int GetApportEnergetique()
        {
            return this.ApportEnegetique;
        }
      
      public virtual void SetApportEnergetique()
        {
            this.ApportEnegetique=0;
        }
      
      
    }
}
