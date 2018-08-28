using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemRonda
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            btnModulo1.Location = new Point(0, 56);
            btnModulo2.Location = new Point(0, 93);
            panel1.Hide();
            panel2.Hide();
        }
        
        private void btnModulo1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }

            btnModulo1.Location = new Point(0, 56);
            panel1.Location = new Point(127, 56);
            btnModulo2.Location = new Point(0, 93);
            panel2.Hide();

            if (!panel1.Visible)
            {
                btnModulo1.Location = new Point(0, 56);
                btnModulo2.Location = new Point(0, 93);
            }
        }

        private void btnModulo2_Click(object sender, EventArgs e)
        {
            if (panel2.Visible)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
            }

            btnModulo1.Location = new Point(0, 56);
            btnModulo2.Location = new Point(0, 93);
            panel2.Location = new Point(127, 93);
            panel1.Hide();

            if (!panel2.Visible)
            {
                btnModulo1.Location = new Point(0, 56);
                btnModulo2.Location = new Point(0, 93);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmLogIn login = new FrmLogIn();
            login.Show();
            this.Hide();
        }

        private void btnSubmodulo21_Click(object sender, EventArgs e)
        {
            FrmListadoProductos pantallaProductos = new FrmListadoProductos();
            pantallaProductos.Show();
            this.Hide();
        }
    }
}
