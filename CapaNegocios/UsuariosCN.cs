using CapaDeAccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class UsuariosCN
    {
        UsuariosDAL usuariosDAL = new UsuariosDAL();
        public DataTable cargarUsuarios()
        {
            return usuariosDAL.CargarUsuarios();
        }
        public void AltaUsuarios(string displey_name, string user_name, string pass)
        {
            usuariosDAL.AltaUsuario(displey_name, user_name, pass);
        }
        public void ModificarContraseña(int id, string pass)
        {
            usuariosDAL.ModificarContraseña(id, pass);
        }
        public void EliminarUsuarios(int id)
        {
            usuariosDAL.EliminarUsuarios(id);
        }
        public bool LoginUser(string user_name, string pass)
        {
            return usuariosDAL.Login(user_name, pass);
        }
    }
}