/*
 * Creado por SharpDevelop.
 * Usuario: makir
 * Fecha: 11/12/2025
 * Hora: 01:03 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace formularioprincipal
{
	/// <summary>
	/// Description of Factorial.
	/// </summary>
	public partial class Factorial : Form
	{
		public Factorial()
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
			int n;
			long resultado = 1;
			if(!int.TryParse(textBox1.Text, out n)|| n < 0)
			{
				MessageBox.Show("Ingresa un numero valido.");
				return;
			}
			for (int i = 1; i <= n; i++)
			{
				resultado *= i;
			}
			label2.Text = "Resultado: " + resultado;
		}
	}
}
