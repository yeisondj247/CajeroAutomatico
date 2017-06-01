using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ReClientes : Form
    {
        public ReClientes()
        {
            InitializeComponent();
        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            try
            {
                 Properties.Settings.Default.Nombre = txtNombre.Text;
            Properties.Settings.Default.Apellido = txtApellido.Text;
            Properties.Settings.Default.Contraseña = txtContraseña.Text;
            Properties.Settings.Default.Monto = txtMonto.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Registro Realizadoo"); 
            }
            catch (Exception)
            {
             throw;
            }

        }

        private void ReClientes_Load(object sender, EventArgs e)
        {
            txtNombre.Text = Properties.Settings.Default.Nombre;
            txtApellido.Text = Properties.Settings.Default.Apellido;
            txtContraseña.Text = Properties.Settings.Default.Contraseña;
            txtMonto.Text = Properties.Settings.Default.Monto; 
        }
    }
}
