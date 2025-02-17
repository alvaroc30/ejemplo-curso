using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploControles
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
                if (item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya existe esta ventana abierta, termine de trabajar alli...");
                        return;
                }

            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show();
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void tsbPerfilPersona_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.ShowDialog();
        }
    }
}
