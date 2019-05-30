using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using info.lundin.math;

namespace Trapecio_Múltiple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double i, x, suma;

            double b = double.Parse(superior.Text);
            double a = double.Parse(inferior.Text);
            double n = double.Parse(intervalos.Text);
            ExpressionParser parser = new ExpressionParser();


            double h = (b - a) / n;

            resultado.Text = resultado.Text + h;

            //********************Funcion********************
            string fx;
            fx = funcion.Text;
            fx = fx.Replace("x", "(" + a + ")");
            double fxresult = parser.Parse(fx);            
            suma = fxresult;            
            //*******************************************************************           
            //******************Calculando limites de en medio*******************
            //calcular los sigt limites de enmedio..... execepto el ultimo
              for (i=a+h; i<=b-1;i=i+h)
              {
                 fx = fx.Replace("x", "(" + i +")");
                 suma= suma + (parser.Parse(fx)*2); 

              }
            // calcular el ultimo intervalo!
            fx = funcion.Text;
            fx = fx.Replace("x", "(" + b +")");
            
            suma = fxresult+ suma + parser.Parse(fx);
            R.Text =R.Text + ((h / 2) * (suma)) + " u2";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
