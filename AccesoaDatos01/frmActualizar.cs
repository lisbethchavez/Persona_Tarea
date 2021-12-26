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

namespace AccesoaDatos01
{
    public partial class frmActualizar : Form
    {
        SqlConnection conexion = new SqlConnection(@"server=DESKTOP-83B08MV\SQLEXPRESS;database=TI2021; Integrated Security=true");
        public frmActualizar()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string cedula = txtCedula.Text;
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            string fechaNacimiento = dateTimePicker1.Text;
            string peso = txtPeso.Text;
            int cant;

            string cadena = "update personas set apellidos=@apellidos,nombres=@nombres,fechaNacimiento=@fechaNacimiento,peso=@peso where cedula=@cedula";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            cant = comando.ExecuteNonQuery(); 
            if(cant==1)
            {
                MessageBox.Show("Se actualizó correctamente el registro");
            }
            else
            {
                MessageBox.Show("Esta persona no se encuentra ingresada");
            }
            conexion.Close(); 

           
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del sistema?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
