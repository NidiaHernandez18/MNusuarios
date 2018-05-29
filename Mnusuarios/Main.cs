using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mnusuarios
{
    public class Main
    {
        string cadenaConexion = "";

        public void abrirConexion(string cadena)
        {
            this.cadenaConexion = cadena;
        }

        public void UsuariosDerechos()
        {
            frmPermisos objPer = new frmPermisos();
            objPer.conecta = cadenaConexion;
            objPer.ShowDialog();
        }

    }
}
