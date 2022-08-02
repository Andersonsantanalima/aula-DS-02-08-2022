using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_DS
{
    public partial class lbl : Form
    {
        public lbl()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnconf_Click(object sender, EventArgs e)
        {
            funcionario funcionario = new funcionario() ;

            funcionario.nome = txtnome.Text;
            funcionario.quanHora  = Convert.ToDouble (txthoras.Text);
            funcionario.valorHora = Convert.ToDouble (txtvalor.Text);

            
            
            
           

            lblfun.Text = funcionario.nome;
            lblquanHora.Text = funcionario.quanHora.ToString("C");
            lblvalor.Text = funcionario.valorHora.ToString("C");

            lblsalbruto.Text = funcionario.calcSalBruto().ToString("C");
            lblvalorInss.Text = funcionario.calcInss().ToString("C");
            lblvalorIr.Text = funcionario.calcIr().ToString("C");
            lblsalLiquid.Text = funcionario.calcSalLiquido().ToString("C");
            lblvalor.Text = funcionario.valorHora.ToString("C");

        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}
