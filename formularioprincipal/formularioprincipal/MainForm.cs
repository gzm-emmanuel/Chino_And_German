/*
 * Creado por SharpDevelop.
 * Usuario: makir
 * Fecha: 10/12/2025
 * Hora: 02:07 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace formularioprincipal
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void CuadradoToolStripMenuItemClick(object sender, EventArgs e)
		{
			AreaCuadrado f = new AreaCuadrado();
			f.MdiParent = this;
			f.Show();
		}
		
		void RectánguloToolStripMenuItemClick(object sender, EventArgs e)
		{
			AreaRectangulo1 f = new AreaRectangulo1();
			f.MdiParent = this;
			f.Show();
		}
		
		void TriánguloToolStripMenuItemClick(object sender, EventArgs e)
		{
			AreaTriangulo1 f = new AreaTriangulo1();
			f.MdiParent = this;
			f.Show();
		}
		
		void FactorialToolStripMenuItemClick(object sender, EventArgs e)
		{
			Factorial f = new Factorial();
			f.MdiParent = this;
			f.Show();
		}
	}
}
