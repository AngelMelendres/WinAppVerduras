using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WinAppVerduras
{
    public partial class ingresarProd : Form
    {
        public ingresarProd()
        {
            InitializeComponent();
            listarCategorias();
        }
        
        void listarCategorias()
        {
            //Create the XmlDocument.
            XmlDocument doc = new XmlDocument();
            doc.Load("e:\\pruebaset.xml");

            //Display all the book titles.
            XmlNodeList elemList = doc.GetElementsByTagName("title");
            for (int i = 0; i < elemList.Count; i++)
            {
                comboBoxCate.Items.Add(elemList[i].InnerText);
       
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dataSet11.ReadXml("e:\\pruebaset.xml");

            object[] vec = new object[9];
            vec[0] = textBoxId.Text;
            vec[1] = textBoxNombre.Text;
            vec[2] = "aa";
            vec[3] = "aa";
            vec[4] = "aa";
            vec[5] = "aa";
            vec[6] = "aa";
            vec[7] = "aa";
            vec[8] = comboBoxCate.Text;

            dataSet11.Productos.Rows.Add(vec);

            dataSet11.WriteXml("e:\\pruebaset.xml");
        }

        private void ingresarProd_Load(object sender, EventArgs e)
        {
            listarCategorias();
        }
    }
}
