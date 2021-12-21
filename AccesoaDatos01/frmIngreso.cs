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
    public partial class frmIngreso : Form
    {
        public frmIngreso()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //1. Crear la conexión
            //SqlConnection conexion = new SqlConnection(@"server=L-ELR-029;database=TI2021; user id=sa; password=isa");


            SqlConnection conexion = new SqlConnection(@"server=DESKTOP-83B08MV\SQLEXPRESS;database=TI2021; Integrated Security=true");

            //2. Definir una operacion 
            string sql = "insert into personas(cedula,apellidos,nombres,fechaNacimiento,peso) ";
            sql += "values (@cedula,@apellidos,@nombres,@fechaNacimiento,@peso)";

            //3. Ejecutar la operacion 
            SqlCommand comando = new SqlCommand(sql, conexion);

            //3.1 configurar los parametros:@cedula,@apellidos,@nombres,@fechaNacimiento,@peso

            comando.Parameters.Add(new SqlParameter("@cedula", this.txtCedula.Text));
            comando.Parameters.Add(new SqlParameter("@apellidos", this.txtApellidos.Text));
            comando.Parameters.Add(new SqlParameter("@nombres", this.txtNombres.Text));
            comando.Parameters.Add(new SqlParameter("@fechaNacimiento", this.dateTimePicker1.Value));
            comando.Parameters.Add(new SqlParameter("@peso", this.txtPeso.Text));

            //3.2 Abrir conexion 

            conexion.Open();

            //3.3 Insertar el registro en la base de datos BDD

            int res = comando.ExecuteNonQuery();

            //4. Cerrar la conexion 
            conexion.Close();

            MessageBox.Show("Filas insertadas: " + res.ToString());

            try
            {
                MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE", "DATOS GUARDADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
            finally
            {
                this.label2.Text = "DEBES CORREGIR EL ERROR";
            }

        }
    }
}
