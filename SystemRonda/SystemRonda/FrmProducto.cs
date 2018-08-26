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

            ProductsProcess product = new ProductsProcess();



        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1,"Aceptar");
        }
    }
}
