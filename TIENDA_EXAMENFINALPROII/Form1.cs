using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIENDA_EXAMENFINALPROII
{
    public partial class Form1 : Form
    {

        public string valorInicial = "";
        public string valorFinal = "";
        public string signoActual = "";
        public int contadorCalculos = 0;
        public double promedio = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReiniciarValores();
            txtprom.Text = "";

        }


        public void AgregarValorInicial(string valor)
        {
            valorInicial += valor;
            txtprom.Text = valorInicial.ToString();
        }

        
        public void agregarValorFinal(string valor)
        {
            valorFinal += valor;
            txtprom.Text = valorFinal.ToString();
        }


        private void ReiniciarValores()
        {
            signoActual = "";
            valorInicial = "";
            valorFinal = "";
            contadorCalculos = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((signoActual != "") && (contadorCalculos == 0))
            {
                AgregarValorInicial("1");
            }
            else
            {
                agregarValorFinal("1");
            }
            //    btnigual.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((signoActual != "") && (contadorCalculos == 0))
            {
                AgregarValorInicial("5");
            }
            else
            {
                agregarValorFinal("5");
            }
            //btnigual.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((signoActual != "") && (contadorCalculos == 0))
            {
                AgregarValorInicial("2");
            }
            else
            {
                agregarValorFinal("2");
            }
            //btnigual.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((signoActual != "") && (contadorCalculos == 0))
            {
                AgregarValorInicial("10");
            }
            else
            {
                agregarValorFinal("10");
            }
            //btnigual.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((signoActual != "") && (contadorCalculos == 0))
            {
                AgregarValorInicial("3");
            }
            else
            {
                agregarValorFinal("3");
            }
            //btnigual.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double promedio = 0;
            switch (signoActual)
            {
                case "PROMEDIO":
                    promedio = (Convert.ToDouble(valorInicial) + Convert.ToDouble(valorFinal));
                    txtprom.Text = promedio.ToString();
                    //    btnigual.Focus();
                    break;
                   
            }
            valorInicial = promedio.ToString();
            signoActual = "";
            valorFinal = "";
            contadorCalculos += 1;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            signoActual = "+";
            txtprom.Text = "";
        }
    }
}
