using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        string query = "";
        public string conex1="";
        public string conex2;
        int opcion=0;
        public frmPermisos()
        {
            InitializeComponent();
        }

        private void frmPermisos_Load(object sender, EventArgs e)
        {
            txt_nombre.Text = conecta;
            query = "select * from tbl_programas order by programas";
            SqlConnection cnn = new SqlConnection(conex1);

            try
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cnn.Open();
                SqlDataReader leerProgram = cmd.ExecuteReader();
                while (leerProgram.Read())
                {
                    comboB_SelecSistema.Items.Add(leerProgram["programas"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }

        private void informacion()
        {
            checkList_modulos.Items.Clear();
            checkLis_Lectura.Items.Clear();
           // MessageBox.Show(conex1);
            query = "select OPCION AS MOD1 from tbl_progmod where  UPPER(MODULO)='" +comboB_modulos.Text.ToUpper() + "' and UPPER(programa)='"+comboB_SelecSistema.Text.ToUpper()+"'";
            SqlConnection cnn = new SqlConnection(conex1);
            try 
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cnn.Open();
                SqlDataReader leerProgram= cmd.ExecuteReader();
                while(leerProgram.Read())
                {
                    comboB_modulos.Items.Add(leerProgram["MOD1"]);
                }

                //MessageBox.Show("conexion");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }
       
        private void Usuarios()
        {
            query = "select * from tbl_usuarios where EMPRESA";
        }

        private void habiltarBotones(bool bandera)
        {
            btt_Nuevo.Visible = bandera;
            bttn_Editar.Visible = bandera;
            bttn_Eliminar.Visible = bandera;
            bttn_Cerrar.Visible = bandera;
            bttn_Grabar.Visible = !bandera;
            bttn_Cencelar.Visible = !bandera;
            comboB_SelecSistema.Enabled = bandera;
            comboB_Empresa.Enabled = bandera;
            checkLis_Lectura.Enabled = !bandera;
            checkList_modulos.Enabled = !bandera;
            comboB_modulos.Enabled = bandera;
            txt_nombre.Enabled = !bandera;
            txt_password.Enabled = !bandera;
            txt_usuario.Enabled = !bandera;
        }

        private void bttn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttn_Cencelar_Click(object sender, EventArgs e)
        {
            opcion = 0;
            habiltarBotones(true);
            txt_nombre.Text = "";
            txt_password.Text = "";
            txt_usuario.Text = "";
        }

        private void bttn_Grabar_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                switch (opcion)
                {
                    case 1:
                        query = "delete from tbl_permisos where PROGRAMA='" + comboB_SelecSistema.SelectedIndex + "' and NO_EMPRESA='"+comboB_Empresa.SelectedIndex+"' AND MODULOS='"+comboB_modulos.SelectedIndex+"' AND usuario='"+txt_usuario.Text+"'";
                        MessageBox.Show(query);
                        break;
                    case 2:
                        query = "";
                        break;

                }
            }
        }
        private bool validaciones()
        {
            return true;
        }

        private void comboB_SelecSistema_Click(object sender, EventArgs e)//cmbprogramas
        {
            //informacion();
            comboB_modulos.Items.Clear();
            checkList_modulos.Items.Clear();
            query = "select DISTINCT (MODULO)AS MOD1 from tbl_progmod where  UPPER(programa)= '" + comboB_SelecSistema.Text.ToUpper() + "'";
            SqlConnection cnn = new SqlConnection(conex1);
            try {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cnn.Open();
                SqlDataReader leerProgram = cmd.ExecuteReader();
                while (leerProgram.Read())
                {
                    comboB_modulos.Items.Add(leerProgram["MOD1"]);
                }
            }
            catch (Exception me)
            {
                MessageBox.Show(me.Message);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }

        private void comboB_Empresa_Click(object sender, EventArgs e)
        {
            informacion();
        }

        private void comboB_modulos_Click(object sender, EventArgs e)
        {
            informacion();
        }

        private void bttn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_permisos.RowCount > 0)
            {
                int fila = dgv_permisos.CurrentRow.Index;//obtiene la fila selecionada por el usuario
                string usuaSele = dgv_permisos.Rows[fila].Cells[0].Value.ToString();
                DialogResult dialog = MessageBox.Show("¿Esta seguro de continuar con este proceso?\n El usuario a eliminar es "+usuaSele+"", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    SqlConnection cnn = new SqlConnection(conex1);
                    SqlCommand cmd;
                    try
                    {
                        cnn.Open();
                        query = "delete from tbl_usuarios where usuario='"+usuaSele+"'";
                        cmd = new SqlCommand(query, cnn);
                        cmd.ExecuteNonQuery();
                        query = "delete from tbl_permisos where usuario='" + usuaSele + "'";
                        cmd = new SqlCommand(query, cnn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuario borrado");

                    }
                    catch (Exception me)
                    {
                        MessageBox.Show(me.Message);
                    }
                    finally
                    {
                        if (cnn.State == ConnectionState.Open)
                        {
                            cnn.Close();
                        }
                    }
                }//fin del if
                informacion();
            }
            
        }

        private void bttn_Editar_Click(object sender, EventArgs e)
        {
            opcion = 2;
            if (comboB_modulos.SelectedIndex> -1)
            {
                if (dgv_permisos.RowCount > 0)
                {
                    int fila = dgv_permisos.CurrentRow.Index;//obtiene la fila selecionada por el usuario
                    string usuaSele = dgv_permisos.Rows[fila].Cells[0].Value.ToString();
                    query=""
                }
            }
        }

        
    }
}
