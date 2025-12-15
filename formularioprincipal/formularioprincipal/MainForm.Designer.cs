/*
 * Creado por SharpDevelop.
 * Usuario: makir
 * Fecha: 10/12/2025
 * Hora: 02:07 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace formularioprincipal
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.aPLICACIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.factorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fibonnaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aREAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cuadradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rectánguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.triánguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pERIMETROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.circunferenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trapecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vOLUMENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.esferaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cuboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pirámideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cONVERSIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.longitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kilómetrosAMillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.masaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kilogramosALibrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.temperaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.celciusAFahrenheitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tiempoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.segundosAHorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bOLETAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pOSTRESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eMPLEADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aPLICACIONESToolStripMenuItem,
									this.aREAToolStripMenuItem,
									this.pERIMETROToolStripMenuItem,
									this.vOLUMENToolStripMenuItem,
									this.cONVERSIONESToolStripMenuItem,
									this.bOLETAToolStripMenuItem,
									this.pOSTRESToolStripMenuItem,
									this.eMPLEADOSToolStripMenuItem,
									this.sALIRToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(931, 28);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// aPLICACIONESToolStripMenuItem
			// 
			this.aPLICACIONESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.factorialToolStripMenuItem,
									this.fibonnaciToolStripMenuItem});
			this.aPLICACIONESToolStripMenuItem.Name = "aPLICACIONESToolStripMenuItem";
			this.aPLICACIONESToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
			this.aPLICACIONESToolStripMenuItem.Text = "APLICACIONES";
			// 
			// factorialToolStripMenuItem
			// 
			this.factorialToolStripMenuItem.Name = "factorialToolStripMenuItem";
			this.factorialToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
			this.factorialToolStripMenuItem.Text = "Factorial";
			this.factorialToolStripMenuItem.Click += new System.EventHandler(this.FactorialToolStripMenuItemClick);
			// 
			// fibonnaciToolStripMenuItem
			// 
			this.fibonnaciToolStripMenuItem.Name = "fibonnaciToolStripMenuItem";
			this.fibonnaciToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
			this.fibonnaciToolStripMenuItem.Text = "Fibonnaci";
			this.fibonnaciToolStripMenuItem.Click += new System.EventHandler(this.FibonnaciToolStripMenuItemClick);
			// 
			// aREAToolStripMenuItem
			// 
			this.aREAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cuadradoToolStripMenuItem,
									this.rectánguloToolStripMenuItem,
									this.triánguloToolStripMenuItem});
			this.aREAToolStripMenuItem.Name = "aREAToolStripMenuItem";
			this.aREAToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
			this.aREAToolStripMenuItem.Text = "AREA";
			// 
			// cuadradoToolStripMenuItem
			// 
			this.cuadradoToolStripMenuItem.Name = "cuadradoToolStripMenuItem";
			this.cuadradoToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
			this.cuadradoToolStripMenuItem.Text = "Cuadrado";
			this.cuadradoToolStripMenuItem.Click += new System.EventHandler(this.CuadradoToolStripMenuItemClick);
			// 
			// rectánguloToolStripMenuItem
			// 
			this.rectánguloToolStripMenuItem.Name = "rectánguloToolStripMenuItem";
			this.rectánguloToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
			this.rectánguloToolStripMenuItem.Text = "Rectángulo";
			this.rectánguloToolStripMenuItem.Click += new System.EventHandler(this.RectánguloToolStripMenuItemClick);
			// 
			// triánguloToolStripMenuItem
			// 
			this.triánguloToolStripMenuItem.Name = "triánguloToolStripMenuItem";
			this.triánguloToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
			this.triánguloToolStripMenuItem.Text = "Triángulo";
			this.triánguloToolStripMenuItem.Click += new System.EventHandler(this.TriánguloToolStripMenuItemClick);
			// 
			// pERIMETROToolStripMenuItem
			// 
			this.pERIMETROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.circunferenciaToolStripMenuItem,
									this.trapecioToolStripMenuItem});
			this.pERIMETROToolStripMenuItem.Name = "pERIMETROToolStripMenuItem";
			this.pERIMETROToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
			this.pERIMETROToolStripMenuItem.Text = "PERIMETRO";
			// 
			// circunferenciaToolStripMenuItem
			// 
			this.circunferenciaToolStripMenuItem.Name = "circunferenciaToolStripMenuItem";
			this.circunferenciaToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
			this.circunferenciaToolStripMenuItem.Text = "Circunferencia";
			// 
			// trapecioToolStripMenuItem
			// 
			this.trapecioToolStripMenuItem.Name = "trapecioToolStripMenuItem";
			this.trapecioToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
			this.trapecioToolStripMenuItem.Text = "Trapecio";
			// 
			// vOLUMENToolStripMenuItem
			// 
			this.vOLUMENToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.esferaToolStripMenuItem,
									this.cuboToolStripMenuItem,
									this.pirámideToolStripMenuItem});
			this.vOLUMENToolStripMenuItem.Name = "vOLUMENToolStripMenuItem";
			this.vOLUMENToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
			this.vOLUMENToolStripMenuItem.Text = "VOLUMEN";
			// 
			// esferaToolStripMenuItem
			// 
			this.esferaToolStripMenuItem.Name = "esferaToolStripMenuItem";
			this.esferaToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
			this.esferaToolStripMenuItem.Text = "Esfera";
			// 
			// cuboToolStripMenuItem
			// 
			this.cuboToolStripMenuItem.Name = "cuboToolStripMenuItem";
			this.cuboToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
			this.cuboToolStripMenuItem.Text = "Cubo";
			// 
			// pirámideToolStripMenuItem
			// 
			this.pirámideToolStripMenuItem.Name = "pirámideToolStripMenuItem";
			this.pirámideToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
			this.pirámideToolStripMenuItem.Text = "Pirámide";
			// 
			// cONVERSIONESToolStripMenuItem
			// 
			this.cONVERSIONESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.longitudToolStripMenuItem,
									this.masaToolStripMenuItem,
									this.temperaturaToolStripMenuItem,
									this.tiempoToolStripMenuItem});
			this.cONVERSIONESToolStripMenuItem.Name = "cONVERSIONESToolStripMenuItem";
			this.cONVERSIONESToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
			this.cONVERSIONESToolStripMenuItem.Text = "CONVERSIONES ";
			// 
			// longitudToolStripMenuItem
			// 
			this.longitudToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.kilómetrosAMillasToolStripMenuItem});
			this.longitudToolStripMenuItem.Name = "longitudToolStripMenuItem";
			this.longitudToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
			this.longitudToolStripMenuItem.Text = "Longitud";
			// 
			// kilómetrosAMillasToolStripMenuItem
			// 
			this.kilómetrosAMillasToolStripMenuItem.Name = "kilómetrosAMillasToolStripMenuItem";
			this.kilómetrosAMillasToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
			this.kilómetrosAMillasToolStripMenuItem.Text = "kilómetros a Millas";
			this.kilómetrosAMillasToolStripMenuItem.Click += new System.EventHandler(this.KilómetrosAMillasToolStripMenuItemClick);
			// 
			// masaToolStripMenuItem
			// 
			this.masaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.kilogramosALibrasToolStripMenuItem});
			this.masaToolStripMenuItem.Name = "masaToolStripMenuItem";
			this.masaToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
			this.masaToolStripMenuItem.Text = "Masa";
			// 
			// kilogramosALibrasToolStripMenuItem
			// 
			this.kilogramosALibrasToolStripMenuItem.Name = "kilogramosALibrasToolStripMenuItem";
			this.kilogramosALibrasToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
			this.kilogramosALibrasToolStripMenuItem.Text = "Kilogramos a Libras";
			this.kilogramosALibrasToolStripMenuItem.Click += new System.EventHandler(this.KilogramosALibrasToolStripMenuItemClick);
			// 
			// temperaturaToolStripMenuItem
			// 
			this.temperaturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.celciusAFahrenheitToolStripMenuItem});
			this.temperaturaToolStripMenuItem.Name = "temperaturaToolStripMenuItem";
			this.temperaturaToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
			this.temperaturaToolStripMenuItem.Text = "Temperatura";
			// 
			// celciusAFahrenheitToolStripMenuItem
			// 
			this.celciusAFahrenheitToolStripMenuItem.Name = "celciusAFahrenheitToolStripMenuItem";
			this.celciusAFahrenheitToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
			this.celciusAFahrenheitToolStripMenuItem.Text = "Celcius a Fahrenheit";
			this.celciusAFahrenheitToolStripMenuItem.Click += new System.EventHandler(this.CelciusAFahrenheitToolStripMenuItemClick);
			// 
			// tiempoToolStripMenuItem
			// 
			this.tiempoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.segundosAHorasToolStripMenuItem});
			this.tiempoToolStripMenuItem.Name = "tiempoToolStripMenuItem";
			this.tiempoToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
			this.tiempoToolStripMenuItem.Text = "Tiempo:";
			// 
			// segundosAHorasToolStripMenuItem
			// 
			this.segundosAHorasToolStripMenuItem.Name = "segundosAHorasToolStripMenuItem";
			this.segundosAHorasToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
			this.segundosAHorasToolStripMenuItem.Text = "Segundos a Horas";
			this.segundosAHorasToolStripMenuItem.Click += new System.EventHandler(this.SegundosAHorasToolStripMenuItemClick);
			// 
			// bOLETAToolStripMenuItem
			// 
			this.bOLETAToolStripMenuItem.Name = "bOLETAToolStripMenuItem";
			this.bOLETAToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
			this.bOLETAToolStripMenuItem.Text = "BOLETA";
			// 
			// pOSTRESToolStripMenuItem
			// 
			this.pOSTRESToolStripMenuItem.Name = "pOSTRESToolStripMenuItem";
			this.pOSTRESToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
			this.pOSTRESToolStripMenuItem.Text = "POSTRES";
			// 
			// eMPLEADOSToolStripMenuItem
			// 
			this.eMPLEADOSToolStripMenuItem.Name = "eMPLEADOSToolStripMenuItem";
			this.eMPLEADOSToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
			this.eMPLEADOSToolStripMenuItem.Text = "EMPLEADOS";
			// 
			// sALIRToolStripMenuItem
			// 
			this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
			this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
			this.sALIRToolStripMenuItem.Text = "SALIR";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(931, 365);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "formularioprincipal";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem eMPLEADOSToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pOSTRESToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bOLETAToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem segundosAHorasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tiempoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem celciusAFahrenheitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem temperaturaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kilogramosALibrasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem masaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kilómetrosAMillasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem longitudToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cONVERSIONESToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pirámideToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cuboToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem esferaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vOLUMENToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem trapecioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem circunferenciaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pERIMETROToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem triánguloToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rectánguloToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cuadradoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aREAToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fibonnaciToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem factorialToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aPLICACIONESToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
