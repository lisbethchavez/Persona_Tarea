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
    public partial class frmEliminar : Form
    {
        public frmEliminar()
        {
            InitializeComponent();
        }

        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
            string sql = "delete from personas where cedula=@cedula";
            sql += "values (@cedula,@apellidos,@nombres,@fechaNacimiento,@peso)"; 

            

            /*
            conexion.Open();
            string cod = txtCedula.Text;
            string cadena = "delete from personas where cedula=@cedula" + cod;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                label4.Text = "";
                label5.Text = "";
                MessageBox.Show("¿Está segur@ de eliminar este registro?");
            }
            else
            {
                MessageBox.Show("Esa persona no se encuentra ingresada");
                conexion.Close();
                btnEliminar.Enabled = false;
            }
            */


        }
    }
}
