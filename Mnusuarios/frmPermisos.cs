using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mnusuarios
{
    public partial class frmPermisos : Form
    {
        public string conecta = "";
        Array arregloSistemas;
        Neg_Consultas objConsul = new Neg_Consultas();
        public frmPermisos()
        {
            InitializeComponent();
        }

        private void frmPermisos_Load(object sender, EventArgs e)
        {
            txt_nombre.Text = conecta;
            habilitarBotones(true);
            CargaSistemas();
        }

        private void CargaSistemas()
        {
           arregloSistemas= objConsul.sistemas();
             
          comboB_Programa.DataSource = objConsul.sistemas();
              
            foreach (int index in arregloSistemas)
            {
               // comboB_Programa.Items.Add(arregloSistemas[index]);
            }


        }

        private void habilitarBotones(bool bandera)
        {
            btt_Nuevo.Visible = bandera;
            bttn_Editar.Visible = bandera;
            bttn_Eliminar.Visible = bandera;
            bttn_Cerrar.Visible = bandera;
            bttn_Grabar.Visible = !bandera;
            bttn_Cencelar.Visible = !bandera;
            comboB_Programa.Enabled = bandera;
            comboB_Empresa.Enabled = bandera;
            checkList_modulos.Enabled = !bandera;
            checkLis_Lectura.Enabled = !bandera;
            comboB_modulos.Enabled = bandera;

            txt_nombre.Enabled =! bandera;
            txt_usuario.Enabled=! bandera;
            txt_password.Enabled =! bandera;
            
        }

        private void btt_Nuevo_Click(object sender, EventArgs e)
        {
            habilitarBotones(false);
        }

        private void bttn_Editar_Click(object sender, EventArgs e)
        {
            habilitarBotones(false);
        }

        private void bttn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void bttn_Cencelar_Click(object sender, EventArgs e)
        {
            habilitarBotones(true);
        }

        private void bttn_Grabar_Click(object sender, EventArgs e)
        {
            habilitarBotones(true);
        }
    }
}
