using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class UsuarioBLL
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        Usuario usuario = new Usuario();
        public Usuario buscarUsuario(int id,string tipo)
        {
            usuario = usuarioDAO.BuscarUsuario(id,tipo);
            return usuario;
        }
        public string validarUsuario(string usua , string clave, string tipo)
        {
            string usuario;
            usuario = usuarioDAO.VALIDARUsuario(usua,clave,tipo);
            return usuario;
        }
        

    }
}
