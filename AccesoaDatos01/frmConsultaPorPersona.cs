using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }
    }
}
