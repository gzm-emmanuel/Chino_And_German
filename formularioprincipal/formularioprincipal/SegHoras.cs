/*
 * Creado por SharpDevelop.
 * Usuario: makir
 * Fecha: 15/12/2025
 * Hora: 03:00 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace formularioprincipal
{
	/// <summary>
	/// Description of SegHoras.
	/// </summary>
	public partial class SegHoras : Form
	{
		public SegHoras()
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
			double seg;
			if(!double.TryParse(textBox1.Text, out seg) || seg <0)
			{
				MessageBox.Show("Ingresa un valor valido");
				return;
			}
			double horas = seg / 3600.0;
			label2.Text = "Horas: " + horas.ToString("0.00");
		}
	}
}
