/*
 * Creado por SharpDevelop.
 * Usuario: makir
 * Fecha: 15/12/2025
 * Hora: 02:42 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace formularioprincipal
{
	/// <summary>
	/// Description of KgLibras.
	/// </summary>
	public partial class KgLibras : Form
	{
		public KgLibras()
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
			double kg;
			if(!double.TryParse(textBox1.Text, out kg) || kg <0)
			{
				MessageBox.Show("Ingresa un valor valido");
				return;
			}
			double libras = kg * 2.20;
			label2.Text = "Libras: " + libras.ToString("0.00");
		}
	}
}
