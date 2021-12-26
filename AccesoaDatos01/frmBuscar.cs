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
    public partial class frmBuscar : Form
    {
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            DataTable dt = getPersona();
            this.cmbPersona.DataSource = dt;
            this.cmbPersona.DisplayMember = "nombre completo";
            this.cmbPersona.ValueMember = "cedula";
        }

        /// <summary>
        /// Obtiene un listado de todas las personas 
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        private DataTable getPersona(string cedula = "")
        {
            SqlConnection conexion = new SqlConnection(@"server=L-ELR-029\SQLEXPRESS01;database=TI2021; Integrated Security=true");

            string sql = "";
            if (cedula == "") //si no hay cedula
            {
                sql = "select cedula, upper(apellidos+' '+ nombres) as nombreCompleto, fechNacimiento, peso";
                sql += "from personas order by apellidos, nombres";
            }
            else
            {
                sql = "select cedula, upper(apellidos+' '+ nombres) as nombreCompleto, fechNacimiento, peso";
                sql += "from personas where cedula=@cedula order by apellidos, nombres";
            }

            SqlCommand comando = new SqlCommand(sql, conexion);
            if (cedula != "")
            {
                comando.Parameters.Add(new SqlParameter("@cedula", cedula));
            }



            SqlDataAdapter ad1 = new SqlDataAdapter(comando);

            //Nota: pasar los datos desde el adaptador a un datatable
            DataTable dt = new DataTable();
            ad1.Fill(dt);


            return dt;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DataTable dt = getPersona(this.cmbPersona.SelectedValue.ToString());

            //mostrar la informacion en los cuadro de texto
            foreach (DataRow row in dt.Rows)
            {
                this.txtCedula.Text = row["cedula"].ToString();
                this.txtApellidos.Text = row["apellidos"].ToString();
                this.txtNombres.Text = row["nombres"].ToString();
                this.dateTimePicker1.Text = row["fechaNacimiento"].ToString();
                this.txtPeso.Text = row["peso"].ToString();


            }
        }
    }
}
