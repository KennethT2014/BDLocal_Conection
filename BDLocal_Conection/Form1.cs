using BDLocal_Conection.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Design;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDLocal_Conection
{
    public partial class Form1 : Form
    {
        ProductosEntities dataEntities = new ProductosEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Clases.DProducto objetoConexion = new Clases.DProducto();
            objetoConexion.EstablecerConexion();

            //string query = "Select * from Cliente";
            //SqlCommand comando = new SqlCommand(query);
            //SqlDataAdapter data = new SqlDataAdapter(comando);
            //DataTable tabla = new DataTable();
            //data.Fill(tabla);

            //dgvClientes.DataSource = tabla; 
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            var Productos = DProducto.MostrarProductos();
            this.dgvClientes.DataSource = Productos;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var query =
                from Producto in dataEntities.Productoes
                where Producto.estado == "Habilitado"
                orderby Producto.estado
                select new
                {
                    Producto.IdProducto,
                    Producto.IdCategoria,
                    Producto.NombreProducto,
                    Producto.CantidadExistente,
                    Producto.Precio,
                    Producto.estado
                };
            dgvClientes.ItemsSource = query.ToList();
        }
    }
}
