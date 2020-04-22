using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestandoCheckBox {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void btnFecharConta_Click(object sender, EventArgs e) {
            var qtdShop = Convert.ToDouble(txtQtdshop.Text);
            var qtdPetisco = Convert.ToDouble(txtQtdPetisco.Text);
            var qtdRefeicao = Convert.ToDouble(txtqtdRefeicao.Text);
            var numMesa = Convert.ToInt32(txtNummesa.Text);

            double result_1 = 0;
            double result_2 = 0;
            double result_3 = 0;

            if(chkShop.Checked == true) {
                result_1 = qtdShop * 4.50;
            }
            if (chkPetisco.Checked == true) {
                result_1 = qtdPetisco * 7.90;
            }
            if (chkRefeicao.Checked == true) {
                result_1 = qtdRefeicao * 15.90;
            }

            double totalparcial = result_1 + result_2 + result_3;
            txtTotalParcial.Text = Convert.ToString(totalparcial);

            double taxaServico = totalparcial * 0.08;
            txtTotalServico.Text = Convert.ToString(taxaServico);

            double totalFinal = totalparcial + taxaServico;
            txtTotalPagar.Text = Convert.ToString(totalFinal);

        }

        private void label8_Click(object sender, EventArgs e) {

        }
    }
}
