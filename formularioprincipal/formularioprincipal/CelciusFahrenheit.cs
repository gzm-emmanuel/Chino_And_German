/*
 * Creado por SharpDevelop.
 * Usuario: makir
 * Fecha: 15/12/2025
 * Hora: 03:21 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace formularioprincipal
{
	/// <summary>
	/// Description of CelciusFahrenheit.
	/// </summary>
	public partial class CelciusFahrenheit : Form
	{
		public CelciusFahrenheit()
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
			double c;
			if(!double.TryParse(textBox1.Text, out c))
			{
				MessageBox.Show("Ingresa un valor valido");
				return;
			}
			double f = (c * 9.0 / 5.0) + 32;
			label2.Text = "Fahrenheit: " + f.ToString("0.00");
		}
	}
}
