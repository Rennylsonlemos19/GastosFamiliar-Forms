using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
           
            double rendafamiliar = double.Parse(txtrendafamiliar.Text);

            double energia = double.Parse(txtenergia.Text);
            double agua = double.Parse(txtagua.Text);
            double internet = double.Parse(txtinternet.Text);
            double alimentacao = double.Parse(txtalimentacao.Text);
            double outros = double.Parse(txtoutrosgasto.Text);

            //processamneto

             double resultado = outros + energia + agua + internet + alimentacao;    
             double saldo = rendafamiliar - resultado;


            lblresultado.Text = resultado.ToString("C");
            lblsaldo.Text = saldo.ToString("C");

           
           
           
        }
       

        private void btn3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtrendafamiliar.Clear();
            txtenergia.Clear();
            txtagua.Clear();
            txtinternet.Clear();
            txtalimentacao.Clear();
            txtoutrosgasto.Clear();

            lblresultado.Text = "0";
            lblsaldo.Text = "0";
        }
    }
}
