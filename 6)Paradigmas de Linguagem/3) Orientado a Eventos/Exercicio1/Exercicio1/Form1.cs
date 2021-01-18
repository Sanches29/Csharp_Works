using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1
{
    public partial class Exercicio1 : Form
    {
        public Exercicio1()
        {
            InitializeComponent();
        }

        private void Exercicio1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCaixa.Text = "";
            lblLabel.Text = "";
        }

        private void txtCaixa_TextChanged(object sender, EventArgs e)
        {
            lblLabel.Text = txtCaixa.Text;
        }

        private void lblLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
