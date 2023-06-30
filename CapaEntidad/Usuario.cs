using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario

    {
        public int idusuario { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }

        public Usuario(int idusuario, string usuario, string clave)
        {
            this.idusuario = idusuario;
            this.usuario = usuario;
            this.clave = clave;
        }

        public Usuario()
        {
        }
    }

}
