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
    public partial class IngCateg : Form
    {
        public IngCateg()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dataSet11.ReadXml("e:\\pruebaset.xml");

            object[] vec = new object[3];
            vec[0] =textBoxId.Text;
            vec[1] =textBoxNombre.Text;
            vec[2]= textBoxDesc.Text;

            dataSet11.Categorias.Rows.Add(vec);

            dataSet11.WriteXml("e:\\pruebaset.xml");
        }
    }
}
