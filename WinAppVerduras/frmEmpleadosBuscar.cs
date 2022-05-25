using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppVerduras
{
    public partial class frmEmpleadosBuscar : Form
    {
        public frmEmpleadosBuscar()
        {
            InitializeComponent();
            gbxEmpleado.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gbxEmpleado.Visible = true;
        }
    }
}
