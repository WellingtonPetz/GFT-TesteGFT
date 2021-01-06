using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTecnico
{
    public class Negocio
    {
        public List<tradeCategories> ListaCategorias(List<ITrade> portifolio)
        {
            List<tradeCategories> categoriesList = new List<tradeCategories>();


            

            foreach (var item in portifolio)
            {
                switch (item.ClientSector)
                {
                    case "PUBLIC":
                        if (item.Value < 1000000)
                        {
                            categoriesList.Add(new tradeCategories("LOWRISK"));

                        }
                        else  if (item.Value > 1000000)
                        {
                            categoriesList.Add(new tradeCategories("MEDIUMRISK"));
                        }
                        break;

                    case "PRIVATE":
                        if (item.Value > 1000000)
                        {
                            categoriesList.Add(new tradeCategories("HIGHRISK"));
                        }
                        else
                        {
                            categoriesList.Add(new tradeCategories("NONE"));
                        }
                        break;

                    default:
                        break;
                }
                   
            }

            return categoriesList;
        }
    }
}
