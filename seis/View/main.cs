using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seis.View
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calculo();
        }

        private void Calculo()
        {
            decimal valor = 0;
            decimal porcento = 0;
            decimal valorfinal = 0;

            valor = Convert.ToDecimal(tbxValor.Text);
           //porcento = Convert.ToDecimal(tbxFrete.Text);


            switch (cbxUf.SelectedItem.ToString())
            {
                case "AM":
                    porcento = 0.6m;
                    break;
                case "MG":
                    porcento = 0.35m;
                    break;
                case "RJ":
                    porcento = 0.3m;
                    break;
                case "SP":
                    porcento = 0.20m;
                    break;
                default:
                    porcento = 0.75m;
                    break;

            }
            tbxFrete.Text = porcento.ToString();
            valorfinal = valor * (1 + porcento);

            lblResultado.Text = valorfinal.ToString();

        }

        private void cbxUf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
