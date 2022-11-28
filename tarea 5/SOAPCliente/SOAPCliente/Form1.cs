using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOAPCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtbNum.Text);
            int operacion=0;
            ServicioWebSoap.WSOServerSoapClient op = new ServicioWebSoap.WSOServerSoapClient();

            switch (cboxOperaciones.SelectedIndex)
            {
                case 0:
                    operacion = op.sumatoria(num);
                    break;
                case 1:
                    operacion = op.factorial(num);
                    break;
                case 2:
                    operacion = op.fibonacci(num);
                    break;
                default: lbResultado.Text = "tiene que anotar un numero";
                    break;
                    
            }

            lbResultado.Text = "Resultado :" +operacion.ToString();
        }
    }
}
