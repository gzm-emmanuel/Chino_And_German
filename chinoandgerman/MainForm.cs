/*
 * Creado por SharpDevelop.
 * Usuario: Cesar
 * Fecha: 08/12/2025
 * Hora: 06:01 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace detallesdecliente
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string rutaImagen = "";

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
	
		void BtnActualizarFotoClick(object sender, EventArgs e)
		{
	OpenFileDialog abrir = new OpenFileDialog();
    abrir.Filter = "Imágenes|*.jpg;*.png;*.jpeg;*.bmp";

    if (abrir.ShowDialog() == DialogResult.OK)
    {
        rutaImagen = abrir.FileName;
        pictureBox1.Image = Image.FromFile(rutaImagen);
    }			
		}
		
		void BtnQuitarClick(object sender, EventArgs e)
		{
			pictureBox1.Image = null;
    rutaImagen = "";
		}
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
	{
	bool valido = true;
	errperror.Clear();
	if(txtCodigo.Text.Trim() == "")
	{
		errperror.SetError(txtCodigo, "Ingrese el codigo del empleado");
		valido = false;
	}
	if(txtNombre.Text.Trim() == "")
	{
		errperror.SetError(txtNombre, "Ingrese el nombre del empleado");
		valido = false;
	}
	if(cmbPuesto.SelectedIndex == -1)
	{
		errperror.SetError(cmbPuesto, "Selecciona un puesto");
		valido = false;
	}
	if(cmbSexo.SelectedIndex == -1)
	{
		errperror.SetError(cmbSexo, "Selecciona un sexo");
		valido = false;
	}
	if(!rbRegular.Checked && !rbContrato.Checked)
	{
		errperror.SetError(rbContrato, "Selecciona el estado del empleado");
		valido = false;
	}
	if(!valido)
		return;
	string estado = rbRegular.Checked ? "REGULAR" : "CONTRTO";
			
			dataGridView1.Rows.Add(
				txtCodigo.Text,
				txtNombre.Text,
				cmbPuesto.Text,
				dtFecha.Value.ToShortDateString(),
				cmbSexo.Text,
				lblEstado
			);
		}

	}
		void BtnEliminarClick(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count == 0)
    {
        MessageBox.Show("Seleccione un registro para eliminar.");
        return;
    }

    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
    MessageBox.Show("Registro eliminado.");
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			 txtCodigo.Clear();
			 
    txtNombre.Clear();
    cmbPuesto.SelectedIndex = -1;
    cmbSexo.SelectedIndex = -1;
    rbRegular.Checked = false;
    rbContrato.Checked = false;
    dtFecha.Value = DateTime.Today;

    pictureBox1.Image = null;
    rutaImagen = "";
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
   		 {
        DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

        txtCodigo.Text = fila.Cells[0].Value.ToString();
        txtNombre.Text = fila.Cells[1].Value.ToString();
        cmbPuesto.Text = fila.Cells[2].Value.ToString();
        dtFecha.Text = fila.Cells[3].Value.ToString();
        cmbSexo.Text = fila.Cells[4].Value.ToString();

        if (fila.Cells[5].Value.ToString() == "Regular")
            rbRegular.Checked = true;
        else
            rbContrato.Checked = true;

        string img = fila.Cells[6].Value.ToString();
        if (System.IO.File.Exists(img))
            pictureBox1.Image = Image.FromFile(img);
			}
		}
		
		
		
		
	}
}



