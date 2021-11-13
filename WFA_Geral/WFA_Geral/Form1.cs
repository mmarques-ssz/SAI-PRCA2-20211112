using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFA_Geral
{
    public partial class frmSoma : Form
    {
        public frmSoma()
        {
            InitializeComponent();
        }

        private void btnPipoca_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            int resultado;

            n1 = int.Parse(txtN1.Text);
            n2 = int.Parse(txtN2.Text);
            resultado = n1 + n2;

            lblResultado.Text = resultado.ToString();
        }

        private void txtPipoca_MouseHover(object sender, EventArgs e)
        {
            lblMensagem.Text = "Digite aqui o 1º número";
        }

        private void txtPipoca_MouseLeave(object sender, EventArgs e)
        {
            lblMensagem.Text = "";
        }

        private void txtN2_MouseHover(object sender, EventArgs e)
        {
            lblMensagem.Text = "Digite aqui o 2º número";
        }
    }
}
