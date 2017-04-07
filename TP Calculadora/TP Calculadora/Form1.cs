using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Agrego los operadores al combo box y le modifico el nombre por medio de propiedades.
            cmbOperacion.Items.Add("+");
            cmbOperacion.Items.Add("-");
            cmbOperacion.Items.Add("*");
            cmbOperacion.Items.Add("/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click_1(object sender, EventArgs e)
        {
            //Genero el numero 1 y 2 para que tomen los valores de los respectivos text box y luego utilizo mi metodo operar de la clase calculadora para realizar la operación deseada y mostrarlo por el label. 
            //El valor de resultado de del metodo operar es un double y lo transformo a String para poder mostrarlo. 
            Numero numero1 = new Numero(this.textBox1.Text);
            Numero numero2 = new Numero(this.textBox2.Text);
            this.lblResultado.Text = Calculadora.Operar(numero1, numero2, cmbOperacion.Text).ToString();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            //Dentro del evento del boton CC, utilizo clear para borrar los text box y asigno valor vacio al label
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.lblResultado.Text = "";
        }
    }
}
