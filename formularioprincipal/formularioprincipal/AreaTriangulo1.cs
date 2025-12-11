/*
 * Creado por SharpDevelop.
 * Usuario: makir
 * Fecha: 11/12/2025
 * Hora: 12:51 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace formularioprincipal
{
	/// <summary>
	/// Description of AreaTriangulo1.
	/// </summary>
	public partial class AreaTriangulo1 : Form
	{
		public AreaTriangulo1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			double b, h;
			
			if(!double.TryParse(textBox1.Text, out b) ||
			   !double.TryParse(textBox2.Text, out h))
			{
				MessageBox.Show("Ingresa valores validos");
				return;
			}
			double area = (b * h) / 2;
			label1.Text = "Area: " + area;
		} 
	}
}
