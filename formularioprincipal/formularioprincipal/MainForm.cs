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
		
		void FibonnaciToolStripMenuItemClick(object sender, EventArgs e)
		{
			Fibonacci f = new Fibonacci();
			f.MdiParent = this;
			f.Show();
		}
		
		void KilogramosALibrasToolStripMenuItemClick(object sender, EventArgs e)
		{
			KgLibras f = new KgLibras();
			f.MdiParent = this;
			f.Show();
		}
		
		void KilómetrosAMillasToolStripMenuItemClick(object sender, EventArgs e)
		{
			KmMillas f = new KmMillas();
			f.MdiParent = this;
			f.Show();
		}
		
		void SegundosAHorasToolStripMenuItemClick(object sender, EventArgs e)
		{
			SegHoras f = new SegHoras();
			f.MdiParent = this;
			f.Show();
		}
		
		void CelciusAFahrenheitToolStripMenuItemClick(object sender, EventArgs e)
		{
			CelciusFahrenheit f = new CelciusFahrenheit();
			f.MdiParent = this;
			f.Show();
		}
		
		void CircunferenciaToolStripMenuItemClick(object sender, EventArgs e)
		{
			Circumferencia f = new Circumferencia();
			f.MdiParent = this;
			f.Show();
		}
		
		void CuadradoToolStripMenuItemClick(object sender, EventArgs e)
		{
			AreaCuadrado f = new AreaCuadrado();
			f.MdiParent = this;
			f.Show();
		}
		
		void TrapecioToolStripMenuItemClick(object sender, EventArgs e)
		{
			Trapecio f = new Trapecio();
			f.MdiParent = this;
			f.Show();
		}
		
		void EsferaToolStripMenuItemClick(object sender, EventArgs e)
		{
			Esfera f = new Esfera();
			f.MdiParent = this;
			f.Show();
		}
		
		void CuboToolStripMenuItemClick(object sender, EventArgs e)
		{
			Cubo f = new Cubo();
			f.MdiParent = this;
			f.Show();
		}
		
		void PirámideToolStripMenuItemClick(object sender, EventArgs e)
		{
			Piramide f = new Piramide();
			f.MdiParent = this;
			f.Show();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
	}
}
