/*
 * Creado por SharpDevelop.
 * Usuario: makir
 * Fecha: 11/12/2025
 * Hora: 02:06 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace boleta
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class c1 : Form
	{
		public c1()
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
			 float suma = 
                float.Parse(textBox1.Text) + float.Parse(c2.Text) + float.Parse(c3.Text) +
                float.Parse(c4.Text) + float.Parse(c5.Text) + float.Parse(c6.Text) +
                float.Parse(c7.Text);

            float prom = suma / 7;
            txtPromedio.Text = prom.ToString();
		}
	}
}
