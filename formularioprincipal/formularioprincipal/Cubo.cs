/*
 * Creado por SharpDevelop.
 * Usuario: makir
 * Fecha: 15/12/2025
 * Hora: 06:10 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace formularioprincipal
{
	/// <summary>
	/// Description of Cubo.
	/// </summary>
	public partial class Cubo : Form
	{
		public Cubo()
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
			double label1;
			if(!double.TryParse(textBox1.Text, out label1))
			{
				MessageBox.Show("Ingresa un valor valido");
				return;
			}
			double volumen = Math.Pow(label1, 3);
			label2.Text ="Volumen: " + volumen.ToString("0.00");
		}
	}
}
