using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteTecnico
{
    public partial class frmTeste : Form
    {
        public frmTeste()
        {
            InitializeComponent();
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            if (lstInput.SelectedIndex > -1)
            {
                lstInput.Items.RemoveAt(lstInput.SelectedIndex);
            }
        }

        private void cmdResult_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();

            Trades trades; ;
            List<ITrade> Portifolio = new List<ITrade>();

            List<tradeCategories> categoriesList = new List<tradeCategories>();
            Negocio pesquisa = new Negocio();

            foreach (string item in lstInput.Items)
            {
                trades = new Trades();

                trades.AddTrade(Convert.ToDouble(item.ToString().Split(";")[0]), item.ToString().Split(";")[1]);

                Portifolio.Add(trades);
            }

            categoriesList = pesquisa.ListaCategorias(Portifolio);


            foreach (var categorie in categoriesList)
            {
            lstOutput.Items.Add(categorie.categorie.ToString());
            }


        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (txtValue.Text.Trim() != "" && cmbSector.SelectedIndex > -1)
            {
                string Item = "";

                Item = txtValue.Text.ToString().Trim() + ";" + cmbSector.Text.ToString().Trim();

                lstInput.Items.Add(Item);

                txtValue.Text = "";
                cmbSector.SelectedIndex = -1;
            }
            
        }
    }
}
