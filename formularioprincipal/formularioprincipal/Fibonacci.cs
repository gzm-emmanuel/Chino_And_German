/*
 * Creado por SharpDevelop.
 * Usuario: makir
 * Fecha: 15/12/2025
 * Hora: 02:30 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace formularioprincipal
{
	/// <summary>
	/// Description of Fibonacci.
	/// </summary>
	public partial class Fibonacci : Form
	{
		public Fibonacci()
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
			if(!int.TryParse(textBox1.Text, out n) || n<= 0)
			{
				MessageBox.Show("Ingresa un numero entero mayor a 0");
				return;
			}
			int a = 0, b = 1, c;
			string serie ="";
			for (int i = 1; i<=n; i++)
			{
				serie += a + " ";
				c = a + b;
				a = b;
				b = c;
			}
			label2.Text = "Resultado" + serie;
		} 
	}
}
