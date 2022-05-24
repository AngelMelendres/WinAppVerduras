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
    public partial class frmEmpleadosEditar : Form
    {
        public frmEmpleadosEditar()
        {
            InitializeComponent();
            gbxEmpleado.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gbxEmpleado.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
