using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemRonda.Busines;
using SystemRonda.Models;
using SystemRonda.Utilities;

namespace SystemRonda
{
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }
                
        private void FrmProducto_Load(object sender, EventArgs e)
        {

            toolTip1.SetToolTip(button1,"Aceptar");

            try
            {
                Product product = new Product();

                if (ProductsProcess.GetProduct(AppConfig.codeProd, ref product))
                {
                    //Se asigna los valores obtienidos del objeto producto a las cajas de texto
                    textBox1.Text = product.idPlanta.ToString();
                    textBox2.Text = product.idTipoProducto.ToString();
                    textBox3.Text = product.divicion.ToString();
                    textBox4.Text = product.codigoProducto;
                    textBox5.Text = product.espesor.ToString();
                    textBox6.Text = product.anchor.ToString();
                    textBox12.Text = product.largo.ToString();
                    textBox11.Text = product.unidadMedida.ToString();
                    textBox9.Text = product.pesoTeorico.ToString();
                    textBox8.Text = product.unidadMedidaVenta.ToString();
                    textBox7.Text = product.descripcionCompletaProducto;
                    textBox15.Text = product.descripcionAbreviadaProducto;
                    textBox14.Text = product.piezasProducto.ToString();
                    textBox13.Text = product.cajasPorTarima.ToString();
                }
                else
                {
                    MessageBox.Show("No se encontraron registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Interno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
