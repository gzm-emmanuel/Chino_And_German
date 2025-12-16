/*
 * Creado por SharpDevelop.
 * Usuario: makir
 * Fecha: 15/12/2025
 * Hora: 05:37 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace formularioprincipal
{
	/// <summary>
	/// Description of Circumferencia.
	/// </summary>
	public partial class Circumferencia : Form
	{
		public Circumferencia()
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
			if(!double.TryParse(textBox1.Text, out r))
			{
				MessageBox.Show("Ingresa un valor valido");
				return;
			}
			double perimetro = 2 * Math.PI * r;
			label2.Text = "Perimetro:"  + perimetro.ToString("0.00");
		}
	}
}
