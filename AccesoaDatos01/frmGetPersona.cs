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
    public partial class frmGetPersona : Form
    {
        public frmGetPersona()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            this.cargaPersona();

        }

        private void cargaPersona()
        {
            this.dgPersonas.DataSource = Clases.Personas.getPersona();
        }

        

        private void dgPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgPersonas.Columns[e.ColumnIndex].Name == "linkSeleccionar")
                {
                    //MessageBox.Show("Clic en Seleccionar");
                    string cedula = this.dgPersonas["Cédula", e.RowIndex].Value.ToString();
                    frmConsultaPorPersona frm1 = new frmConsultaPorPersona(cedula);
                    frm1.ShowDialog();


                } else if (this.dgPersonas.Columns[e.ColumnIndex].Name == "linkEliminar")
                {
                    //MessageBox.Show("Clic en Eliminar");
                    string cedula = this.dgPersonas["Cédula", e.RowIndex].Value.ToString();
                    //MessageBox.Show("La cédula es: " + cedula);

                    DialogResult dialog = MessageBox.Show("Estas seguro de eliminar", "Advertencia", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                        return; // abandonar 

                    int respuesta = Clases.Personas.borrar(cedula);
                    if (respuesta > 0)
                    {
                        this.cargaPersona();
                        MessageBox.Show("Registro Borrado con éxito...");
                    }
                    else
                        MessageBox.Show("No se pudo borrar el registro.....");                  
                }                      
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString()); 
            }
        }
    }
}
