using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }
        
        private void btnValidar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuBLL = new UsuarioBLL();

            string usu=txtUsuario.Text;
            string contra=txtClave.Text;
            string conexion = lblcon.Text;

            string mensaje = null;

            mensaje = usuBLL.validarUsuario(usu, contra, conexion);

            if (mensaje != null)
            {

                Venta venta = new Venta();
                venta.lblUsuario.Text = mensaje;
                venta.lblconexion.Text = conexion;
                venta.Show();
            }
            else
            {
                MessageBox.Show("USUARIO NO ENCONTRADO");
            }
        }
    }
}
