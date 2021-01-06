using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTecnico
{
    public class tradeCategories
    {
        private string _categorie;

        public tradeCategories(string strCategorie) 
        {
            this.categorie = strCategorie;
        }

        public string categorie
        {
            get { return _categorie; }
            set { _categorie = value; }
        }
    }
}
