/*
 * Creado por SharpDevelop.
 * Usuario: makir
 * Fecha: 15/12/2025
 * Hora: 06:21 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace formularioprincipal
{
	/// <summary>
	/// Description of Piramide.
	/// </summary>
	public partial class Piramide : Form
	{
		public Piramide()
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
			double areaBase, altura;
				if(!double.TryParse(textBox1.Text, out areaBase) ||
				   !double.TryParse(textBox2.Text, out altura) ||
				   areaBase <= 0 || altura <= 0)
			{
				MessageBox.Show("Ingresa un valor valido");
				return;
			}
			double volumen = (areaBase * altura) / 3.0;
			label3.Text = "Volumen: " + volumen.ToString("0.00");
		}
	}
}
