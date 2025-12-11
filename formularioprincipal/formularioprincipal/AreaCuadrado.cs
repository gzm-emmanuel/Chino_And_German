/*
 * Creado por SharpDevelop.
 * Usuario: makir
 * Fecha: 10/12/2025
 * Hora: 02:22 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace formularioprincipal
{
	/// <summary>
	/// Description of AreaCuadrado.
	/// </summary>
	public partial class AreaCuadrado : Form
	{
		public AreaCuadrado()
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
			double lado;
			if(!double.TryParse(textBox1.Text, out lado))
			{
				MessageBox.Show("Ingresa un numero valido.");
				return;
			}
			double area = lado * lado;
			label3.Text = "area: " + area;
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			
		}
		
		void AreaCuadradoLoad(object sender, EventArgs e)
		{
			
		}
	}
}
