/*
 * Creado por SharpDevelop.
 * Usuario: makir
 * Fecha: 10/12/2025
 * Hora: 06:24 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace formularioprincipal
{
	/// <summary>
	/// Description of AreaRectangulo1.
	/// </summary>
	public partial class AreaRectangulo1 : Form
	{
		public AreaRectangulo1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			}
			public partial class AreaRectangulo : Form
			{
        /*    
		
		void Button1Click(object sender, EventArgs e)
		{
			   double B, H;
			   
			if(!double.TryParse(txtBase.Text, out B) ||
               !double.TryParse(txtAltura.Text, out H))
			{
				MessageBox.Show("Ingresa un numer valido.");
				return;
			}
			double area = B*H;
			lblResultado.Text = "area: " + area;
		}*/
	}
		
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			   double B, H;
			   
			if(!double.TryParse(txtBase.Text, out B) ||
               !double.TryParse(txtAltura.Text, out H))
			{
				MessageBox.Show("Ingresa un numer valido.");
				return;
			}
			double area = B*H;
			lblResultado.Text = "area: " + area;
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
}
}