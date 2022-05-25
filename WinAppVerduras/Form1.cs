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
    public partial class btnBuscar : Form
    {
        public btnBuscar()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            PruebaTablas o = new PruebaTablas();
            o.Show();

        private Form formularioActivo = null;
        private void AbrirFormulariosHijos(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(formularioHijo);
            pnlContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new frmEmpleadosBuscar());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new frmEmpleadosEditar());
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new frmEmpleadosEliminar());

        }

  
       
    }
}
