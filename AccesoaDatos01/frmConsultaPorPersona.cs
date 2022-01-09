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
    public partial class frmConsultaPorPersona : Form
    {
        SqlConnection conexion = new SqlConnection(@"server=DESKTOP-83B08MV\SQLEXPRESS ; database=TI2021 ; integrated security = true");
        private string mCedula;
        public frmConsultaPorPersona(string cedula)
        {
            InitializeComponent();
            this.mCedula = cedula;

            
        }

        private void frmConsultaPorPersona_Load(object sender, EventArgs e)
        {
            MessageBox.Show("La cédula es: " + mCedula);

            string cadena = "select nombres,apellidos,fechNacimiento,peso from personas where cedula=@cedula";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtCedula.Text = registro["cedula"].ToString();
                txtNombres.Text = registro["nombres"].ToString();
                txtPeso.Text = registro["peso"].ToString();
                dateTimePicker1.Text = registro["fechaNacimiento"].ToString();

            }
            else
                MessageBox.Show("Persona no encontrada");
            conexion.Close();


        }
    }
}
