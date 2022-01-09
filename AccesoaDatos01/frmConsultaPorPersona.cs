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
        
        private string mCedula;
        public frmConsultaPorPersona(string cedula)
        {
            InitializeComponent();
            this.mCedula = cedula;       
        }

        private void frmConsultaPorPersona_Load(object sender, EventArgs e)
        {
            MessageBox.Show("La cédula es: " + mCedula);

            Datatable dt= Clases.Personas.seleccionar(mCedula);

            foreach(DataRow row in dt.Rows)
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
