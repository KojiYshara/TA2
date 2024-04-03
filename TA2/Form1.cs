using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TA2.Controllers;
using TA2.Entities;

namespace TA2
{
    public partial class Form1 : Form
    {
        private ProductoCon ProductoCon = new ProductoCon();
        public Form1()
        {
            InitializeComponent();
        }
        private void MostrarDataGrid(Entities.Producto[] productos)
        {
            dgProd.DataSource = null;
            dgProd.DataSource = productos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("Ingrese todos los campos");
                    return;
                }

                Producto producto = new Producto()
                {
                    Codigo = textBox1.Text,
                    Nombre = textBox2.Text,
                    Descripcion = textBox3.Text,
                    Precio = double.Parse(textBox4.Text),
                    Cantidad = int.Parse(textBox5.Text)
                };

            ProductoCon.Registrar(producto);

            MostrarDataGrid(ProductoCon.ListarTodo());
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (dgProd.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a eliminar");
                return;
            }

            String codigo = dgProd.SelectedRows[0].Cells[0].Value.ToString();

            ProductoCon.Eliminar(codigo);

            MostrarDataGrid(ProductoCon.ListarTodo());
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }


    }
}
