using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTecnico
{
    public class Negocio
    {
        public List<tradeCategories> ListaCategorias(List<ITrade> portifolio, DateTime referenceDate)
        {
            List<tradeCategories> categoriesList = new List<tradeCategories>();


            foreach (var item in portifolio)
            {
                TimeSpan diferenca = referenceDate- item.NextPaymentDate;

                int dias = diferenca.Days;

                //if (item.IsPoliticallyExposed)
                //{
                //    categoriesList.Add(new tradeCategories("PEP"));

                //}
                //else 
                if (dias > 30)
                {
                    categoriesList.Add(new tradeCategories("DEFAULTED"));
                }
                else if (item.Value > 1000000 && item.ClientSector.ToString().ToUpper() == "PRIVATE")
                {
                    categoriesList.Add(new tradeCategories("HIGHRISK"));

                }
                else if (item.Value > 1000000 && item.ClientSector.ToString().ToUpper() == "PUBLIC")
                {
                    categoriesList.Add(new tradeCategories("MEDIUMRISK"));

                }
                else
                {
                    categoriesList.Add(new tradeCategories("UNDEFINED"));
                }
            }

            return categoriesList;
        }
    }
}
