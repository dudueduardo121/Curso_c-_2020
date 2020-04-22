using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxAula01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e) {
            lstNumeros.Items.Clear();
            foreach ( int i in lstNumeros.Items) {
                lstNumeros.Items.Add(i);
            }
            for(int i = 0; i <= 10; i++) {
                lstNumeros.Items.Add(i);
            }
        }

        private void btnWhile_Click(object sender, EventArgs e) {
            lstNumeros.Items.Clear();
            int i=0;
            while( i <= 10){
                lstNumeros.Items.Add(i);
                i++;
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e) {
            lstNumeros.Items.Clear();
            int i = 0;
            do {
                lstNumeros.Items.Add(i);
                i++;
            } while (i <= 10);
        }

        private void btnlimpar_Click(object sender, EventArgs e) {
            lstNumeros.Items.Clear();
        }
    }
}
