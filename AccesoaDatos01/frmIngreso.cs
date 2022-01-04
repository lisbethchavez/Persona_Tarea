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

            int res = Clases.Personas.insertar(this.txtCedula.Text, this.txtApellidos.Text, this.txtNombres.Text, Convert.ToDateTime(this.dateTimePicker1.Text),Convert.ToDouble(this.txtPeso.Text));


            MessageBox.Show("Filas insertadas: " + res.ToString());

            if (res > 0)
                MessageBox.Show("Registro Agregado con exito...");
            else
                MessageBox.Show("No se pudo insertar el registro....");

          

        }
    }
}
