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
    public partial class Conexion : Form
    {
        public Conexion()
        {
            InitializeComponent();
        }

        private void BTNSQL_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();

            venta.lblconexion.Text = "sql";
            Usuario usus = new Usuario();
            usus.lblcon.Text = "sql";
            usus.Show();



        }

        private void BTNMYSQL_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();

            venta.lblconexion.Text = "mysql";
            Usuario usus = new Usuario();
            usus.lblcon.Text = "mysql";
            usus.Show();


        }

        private void Conexion_Load(object sender, EventArgs e)
        {

        }
    }
}
