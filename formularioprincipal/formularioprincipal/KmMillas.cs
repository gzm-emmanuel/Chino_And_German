/*
 * Creado por SharpDevelop.
 * Usuario: makir
 * Fecha: 15/12/2025
 * Hora: 02:53 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace formularioprincipal
{
	/// <summary>
	/// Description of KmMillas.
	/// </summary>
	public partial class KmMillas : Form
	{
		public KmMillas()
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
			double km;
			if(!double.TryParse(textBox1.Text, out km) || km <0)
			{
				MessageBox.Show("Ingresa un valor valido");
				return;
			}
			double millas = km * 0.6213;
			label2.Text = "Millas: " +millas.ToString("0.00");
		}
	}
}
