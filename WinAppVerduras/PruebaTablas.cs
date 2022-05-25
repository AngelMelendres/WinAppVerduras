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
    public partial class PruebaTablas : Form
    {
        public PruebaTablas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
            dataSet1.WriteXml("e:\\pruebaset.xml");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataSet1.Clear();
            dataSet1.ReadXml("e:\\pruebaset.xml");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IngCateg ca= new IngCateg();
            ca.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ingresarProd pr = new ingresarProd();
            pr.Show();
        }
    }
}
