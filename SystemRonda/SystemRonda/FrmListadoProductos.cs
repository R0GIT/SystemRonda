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
    public partial class FrmListadoProductos : Form
    {
        public FrmListadoProductos()
        {
            InitializeComponent();
        }

        private void FrmListadoProductos_Load(object sender, EventArgs e)
        {
            //Asigna el control y el texto de tooltip
            toolTip1.SetToolTip(button1,"Buscar");
            toolTip1.SetToolTip(button2, "Buscar");
            toolTip1.SetToolTip(button8, "Nuevo");
            toolTip1.SetToolTip(button3, "Regresar");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ProductList> productList = new List<ProductList>();

            try
            {
                //Valida si hay o no productos de esa planta
                if (ProductsProcess.GetProductsLits(Convert.ToInt32(textBox1.Text), ref productList) == true)
                {
                    //Llena el grid con los datos de la lista
                    dataGridView1.DataSource = productList;
                    dataGridView1.AutoSize = true;
                }
                else
                {
                    MessageBox.Show("No se encontraron productos en la planta", "Warning", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("el formato de los parametros es incorrecto", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AppConfig.codeProd = textBox2.Text;
            FrmProducto product = new FrmProducto();
            product.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AppConfig.codeProd = null;
            FrmProducto product = new FrmProducto();
            product.Show();
        }

    }
}
