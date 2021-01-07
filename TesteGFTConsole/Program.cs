using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteTecnico;

namespace TesteGFTConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime validaDataReferencia = DateTime.MinValue;
            DateTime validaDataTrade = DateTime.MinValue;


            if (args.Length < 3)
            {
                Console.WriteLine("Argumentos Insuficientes");
            }
            else if (Convert.ToInt32(args[1].ToString()) == 0)
            {
                Console.WriteLine("Argumentos [1] não pode ser Igual a 0");
            }
            else if (Convert.ToInt32(args[1].ToString()) != (args.Length - 2))
            {
                Console.WriteLine("Argumentos Incoerentes");
            }
           
            else
            {

                if (!DateTime.TryParseExact(args[0].Trim(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out validaDataReferencia))
                {
                    Console.WriteLine("Data Inválida no Argumento [0]");
                }
                else
                {
                    Trades trades;
                    List<ITrade> Portifolio = new List<ITrade>();

                    List<tradeCategories> categoriesList = new List<tradeCategories>();
                    Negocio pesquisa = new Negocio();

                    for (int i = 0; i < Convert.ToInt32(args[1].ToString()); i++)
                    {
                        var linha = args[i + 2].ToString().Split(' ');

                        if (Convert.ToDouble(linha[0].ToString()) == 0)
                        {
                            Console.WriteLine("Argumento Inválido na Linha " + i.ToString());
                        } 
                        else if (linha[1].ToString() != "Private" && linha[1].ToString() != "Public")
                        {
                            Console.WriteLine("Argumento Inválido na Linha " + i.ToString());
                        }
                        else if (! DateTime.TryParseExact(linha[2].Trim(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out validaDataTrade))
                        {

                            Console.WriteLine("Argumento de Data Inválido na Linha " + i.ToString());
                        }
                        else
                        {
                            trades = new Trades();

                            //trades.AddTrade(Convert.ToDouble(linha[0].ToString()), linha[1].ToString(), validaDataTrade, (linha[3] == "true") );

                            trades.AddTrade(Convert.ToDouble(linha[0].ToString()), linha[1].ToString(), validaDataTrade);


                            Portifolio.Add(trades);
                        }
                       
                    }


                    categoriesList = pesquisa.ListaCategorias(Portifolio, validaDataReferencia);

                    Console.WriteLine("Output:");
                    foreach (var categorie in categoriesList)
                    {
                        Console.WriteLine(categorie.categorie.ToString());
                    }

                    Console.ReadLine();

                }


            }
        }
    }
}
