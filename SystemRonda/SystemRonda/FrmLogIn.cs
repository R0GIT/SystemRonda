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
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool existe = true;
            //Valida las credenciales del usuario UserProcess.userLogin(textBox1.Text, textBox2.Text)
            if (existe == true)
            {
                FrmLogIn login = new FrmLogIn();
                FrmListadoProductos form = new FrmListadoProductos();

                login.Hide();
                login.Close();
                login.Dispose();
                form.Show();
                
            }
            else
            {
                MessageBox.Show("Usuario y contraseña incorrectos","",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
