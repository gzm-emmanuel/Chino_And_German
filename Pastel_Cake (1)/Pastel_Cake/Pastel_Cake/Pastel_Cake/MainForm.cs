/*
 * Creado por SharpDevelop.
 * Usuario: zamud
 * Fecha: 10/12/2025
 * Hora: 01:35 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Pastel_Cake
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		decimal subtotal = 0;
        decimal descuento = 0;
        decimal total = 0;
        decimal pagado = 0;
         decimal cambio = 0;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			dgvProductos.Columns.Add("Producto", "Producto");
            dgvProductos.Columns.Add("Precio", "Precio");
            dgvProductos.Columns.Add("Cantidad", "Cantidad");
            dgvProductos.Columns.Add("Total", "Total");

            CargarProductos();
		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			if (cmbSeleccionar.Text == "" || txtPrecio.Text == "" || txtCantidad.Text == ""|| txtTotal.Text == "")
             {
        MessageBox.Show("Completa todos los campos");
        return;
            }

         decimal precio = Convert.ToDecimal(txtPrecio.Text);
         int cantidad = Convert.ToInt32(txtCantidad.Text);
         decimal totalProd = precio * cantidad;

         dgvProductos.Rows.Add(cmbSeleccionar.Text, precio, cantidad, totalProd);
         CalcularTotales();
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			 if (dgvProductos.SelectedRows.Count > 0)
                {
        dgvProductos.Rows.RemoveAt(dgvProductos.SelectedRows[0].Index);
        CalcularTotales();
                }
             else
              {
        MessageBox.Show("Seleccione una fila para eliminar.");
             }
		  }
		
		void TxtPagadoTextChanged(object sender, EventArgs e)
		{
			if (txtPagado.Text != "")
                {
        pagado = Convert.ToDecimal(txtPagado.Text);
        cambio = pagado - total;
        txtCambio.Text = cambio.ToString("0.00");
                }
		}
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			int idVenta = GuardarVenta();
    GuardarDetalle(idVenta);

    MessageBox.Show("Venta guardada en MySQL correctamente");
		}
		
		void BtnBorrarClick(object sender, EventArgs e)
		{
			txtPrecio.Text = "";
            txtCantidad.Text = "";
            txtSub.Text = "";
            txtDes.Text = "";
            txtNeto.Text = "";
            txtPagado.Text = "";
            txtCambio.Text = "";
            cmbSeleccionar.Text = "";
            dgvProductos.Rows.Clear();
		 }
		void CalcularTotales()
         {
    subtotal = 0;
    foreach (DataGridViewRow row in dgvProductos.Rows)
            {
        if (row.Cells["Total"].Value != null)
            subtotal += Convert.ToDecimal(row.Cells["Total"].Value);
             }

          txtSub.Text = subtotal.ToString("0.00");
          descuento = (txtDes.Text == "") ? 0 : Convert.ToDecimal(txtDes.Text);
          total = subtotal - descuento;
         txtNeto.Text = total.ToString("0.00");
        }
		
		void CmbSeleccionarSelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbSeleccionar.SelectedIndex == -1)
        return;

          using (MySqlConnection cn = Conexion.Conectar())
         {
        cn.Open();
        string sql = "SELECT precio FROM productos WHERE nombre = @n LIMIT 1";
        MySqlCommand cmd = new MySqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@n", cmbSeleccionar.Text);

        object precio = cmd.ExecuteScalar();

        if (precio != null)
            txtPrecio.Text = precio.ToString();
        else
            txtPrecio.Text = "0";
		}
		}
		void CargarProductos()
        {
         using (MySqlConnection cn = Conexion.Conectar())
        {
        cn.Open();
        string sql = "SELECT nombre FROM productos";
        MySqlCommand cmd = new MySqlCommand(sql, cn);
        MySqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
               {
            cmbSeleccionar.Items.Add(dr["nombre"].ToString());
               }
            }
         }
		int GuardarVenta()
         {
    using (MySqlConnection cn = Conexion.Conectar())
            {
        cn.Open();
        string sql = @"INSERT INTO ventas(subtotal, descuento, total, pagado, cambio, fecha)
                       VALUES(@s, @d, @t, @p, @c, NOW())";

        MySqlCommand cmd = new MySqlCommand(sql, cn);

        cmd.Parameters.AddWithValue("@s", txtSub.Text);
        cmd.Parameters.AddWithValue("@d", txtDes.Text);
        cmd.Parameters.AddWithValue("@t", txtNeto.Text);
        cmd.Parameters.AddWithValue("@p", txtPagado.Text);
        cmd.Parameters.AddWithValue("@c", txtCambio.Text);

        cmd.ExecuteNonQuery();
        return (int)cmd.LastInsertedId; // ID de la venta
            }
         }
		void GuardarDetalle(int idVenta)
{
    using (MySqlConnection cn = Conexion.Conectar())
    {
        cn.Open();

        foreach (DataGridViewRow row in dgvProductos.Rows)
        {
            string sql = @"INSERT INTO venta_detalle(id_venta, producto, precio, cantidad, total)
                           VALUES(@id, @p, @pre, @c, @t)";

            MySqlCommand cmd = new MySqlCommand(sql, cn);

            cmd.Parameters.AddWithValue("@id", idVenta);
            cmd.Parameters.AddWithValue("@p", row.Cells[0].Value);
            cmd.Parameters.AddWithValue("@pre", row.Cells[1].Value);
            cmd.Parameters.AddWithValue("@c", row.Cells[2].Value);
            cmd.Parameters.AddWithValue("@t", row.Cells[3].Value);

            cmd.ExecuteNonQuery();
                  }
               }
		}
                
           public class Conexion
             {
           public static MySqlConnection Conectar()
             {
           string cadena = "server=localhost; database=psteleria; user=root; password=;";
           MySqlConnection cn = new MySqlConnection(cadena);
           return cn;
                 }
              }
           }
	    }
	

