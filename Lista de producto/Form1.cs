using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_producto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void insertar (string nombre)
        {
            List<string> listap = new List<string>();
            listap.Add(nombre);
            foreach(string ver in listap)
            {
                dataGridView1.Rows.Add(ver);
            }
            txtproducto.Text = "";
                
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            insertar(txtproducto.Text);
        }
    }
}
