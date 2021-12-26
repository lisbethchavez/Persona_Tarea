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
        SqlConnection conexion = new SqlConnection(@"server=DESKTOP-83B08MV\SQLEXPRESS;database=TI2021; Integrated Security=true");
        public frmEliminar()
        {
            InitializeComponent();
        }

        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            int cant = 0;
            string cadena = "Delete from personas where cedula=@cedula " + txtCedula.Text;
            SqlCommand comando = new SqlCommand(cadena,conexion);
            cant = comando.ExecuteNonQuery();

            if(cant==1)
            {
                MessageBox.Show("¿Está segur@ de eliminar este registro?");
            }
            else
            {
                MessageBox.Show("Esta persona no se encuentra ingresada en la base de datos");
            }
            conexion.Close();
            txtCedula.Text = "";
           
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
