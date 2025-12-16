/*
 * Creado por SharpDevelop.
 * Usuario: makir
 * Fecha: 15/12/2025
 * Hora: 05:53 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace formularioprincipal
{
	/// <summary>
	/// Description of Trapecio.
	/// </summary>
	public partial class Trapecio : Form
	{
		public Trapecio()
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
			double label1, label2, label3, label4;
			 if(!double.TryParse(textBox1.Text, out label1) ||
				!double.TryParse(textBox2.Text, out label2) ||
				!double.TryParse(textBox3.Text, out label3) ||
				!double.TryParse(textBox4.Text, out label4)) 
			{
				MessageBox.Show("Ingresa un valor valido");
				return;
			}
			double perimetro = label1 + label2 + label3 + label4;
			lblResultado.Text = "Perimetro:" + perimetro;
		}
	}
}
