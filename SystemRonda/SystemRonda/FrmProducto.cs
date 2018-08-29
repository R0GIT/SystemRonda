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

            toolTip1.SetToolTip(button1,"Guardar");

            if (AppConfig.codeProd != null)
            {
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

        private void button1_Click_1(object sender, EventArgs e)
        {

            //
            try
            {
                Product product = new Product();


                    //Se asigna los valores obtienidos del objeto producto a las cajas de texto
                    product.idPlanta = Convert.ToInt32(textBox1.Text);
                    product.idTipoProducto = Convert.ToInt32(textBox2.Text);
                    product.divicion = Convert.ToChar(textBox3.Text);
                    product.codigoProducto = textBox4.Text;
                    product.espesor = Convert.ToDouble(textBox5.Text);
                    product.anchor = Convert.ToDouble(textBox6.Text);
                    product.largo = Convert.ToDouble(textBox12.Text);
                    product.unidadMedida = Convert.ToInt32(textBox11.Text);
                    product.pesoTeorico = Convert.ToDouble(textBox9.Text);
                    product.unidadMedidaVenta = Convert.ToInt32(textBox8.Text);
                    product.descripcionCompletaProducto = textBox7.Text;
                    product.descripcionAbreviadaProducto = textBox15.Text;
                    product.piezasProducto = Convert.ToInt32(textBox14.Text);
                    product.cajasPorTarima = Convert.ToInt32(textBox13.Text);

                if (ProductsProcess.InsertProduct(product))
                {
                    MessageBox.Show("Registro Guardado", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Interno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
