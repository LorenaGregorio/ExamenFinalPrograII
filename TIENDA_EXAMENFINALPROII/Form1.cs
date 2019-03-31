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
            txtprom.Clear();

        }


        public void AgregarValorInicial(string valor)
        {
           
        }

        
        public void agregarValorFinal(string valor)
        {
            
        }


        private void ReiniciarValores()
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int cal=0;
                

            if ((comboBox1.SelectedItem.Equals("0")
                && comboBox2.SelectedItem.Equals("0"))
                && comboBox3.SelectedItem.Equals("0")
                 && comboBox4.SelectedItem.Equals("0")
                   && comboBox5.SelectedItem.Equals("0"))
            {
                MessageBox.Show("Debe selecionar un Producto");
            }

            if (comboBox1.SelectedItem.Equals("1")) 
            {
                cal = cal + 1;
            }

            if (comboBox2.SelectedItem.Equals("1"))
            {
                cal = cal + 5;
            }
            if (comboBox3.SelectedItem.Equals("1"))
            {
                cal = cal + 10;
            }
            if (comboBox4.SelectedItem.Equals("1"))
            {
                cal = cal + 2;
            }
            if (comboBox5.SelectedItem.Equals("1"))
            {
                cal = cal + 3;
            }
            txtprom.Text = cal.ToString() + " Mins." ;

           

        }

        private void button8_Click(object sender, EventArgs e)
        {
           
           
        }
    }
}
