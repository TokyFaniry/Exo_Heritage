namespace Exo_Heritage
{
    internal class Aliment
    {   
        public int ApportEnegetique;
        public string NomAliment;

        public int GetApportEnergetique()
        {
            return this.ApportEnegetique;
        }

        public virtual void SetApportEnergetique()
        {
            this.ApportEnegetique = 0;
        }
        public virtual void SetNomAliment()
        {
            this.NomAliment = "Just aliment";
        }


    }
 }
