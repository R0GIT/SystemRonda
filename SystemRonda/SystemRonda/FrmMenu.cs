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
            btnModulo1.Location = new Point(0, 127);
            btnModulo2.Location = new Point(0, 164);
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

            btnModulo1.Location = new Point(0, 126);
            panel1.Location = new Point(0, 160);
            btnModulo2.Location = new Point(0, 233);
            panel2.Hide();

            if (!panel1.Visible)
            {
                btnModulo1.Location = new Point(0, 127);
                btnModulo2.Location = new Point(0, 164);
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

            btnModulo1.Location = new Point(0, 127);
            btnModulo2.Location = new Point(0, 164);
            panel2.Location = new Point(0, 200);
            panel1.Hide();

            if (!panel2.Visible)
            {
                btnModulo1.Location = new Point(0, 127);
                btnModulo2.Location = new Point(0, 164);
            }
        }
    }
}
