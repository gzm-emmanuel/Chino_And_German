/*
 * Creado por SharpDevelop.
 * Usuario: makir
 * Fecha: 15/12/2025
 * Hora: 06:16 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace formularioprincipal
{
	/// <summary>
	/// Description of Esfera.
	/// </summary>
	public partial class Esfera : Form
	{
		public Esfera()
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
			double r;
			if(!double.TryParse(textBox1.Text, out r) || r <= 0)
			{
				MessageBox.Show("Ingresa un valor valido");
				return;
			}
			double volumen = (4.0 / 3.0) * Math.Pow(r, 3);
			label2.Text = "Volumen: " + volumen.ToString("0.00");
		}
	}
}
