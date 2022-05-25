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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PruebaTablas o = new PruebaTablas();
            o.Show();
        }
<<<<<<< Updated upstream
=======

        private void btnEAlternativas_Click(object sender, EventArgs e)
        {

        }

        private void btnOtros_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new Clientes());
        }
>>>>>>> Stashed changes
    }
}
