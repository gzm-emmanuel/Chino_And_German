/*
 * Creado por SharpDevelop.
 * Usuario: makir
 * Fecha: 10/12/2025
 * Hora: 02:48 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace formularioprincipal
{
	/// <summary>
	/// Description of Usuario__contraseña.
	/// </summary>
	public partial class Usuario__contraseña : Form
	{
		int inten=0;
		public Usuario__contraseña()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnEntrarClick(object sender, EventArgs e)
		{
			string user = "admin";       

            string pass = "1234";         



            if (txtUsuario.Text == user && txtPassword.Text == pass)

            {

                MainForm f = new MainForm();

                f.Show();

                this.Hide();

            }

            else

            {

                inten++;



                if (inten >= 3)

                {

                    MessageBox.Show("Has agotado los 3 intentos.\nEl programa se cerrara.");

                    Application.Exit();

                }

                else

                {

                    MessageBox.Show("Usuario o contraseña incorrectos.\nIntentos restantes: " + (3 - inten));

                }

            }
		}
	}
}
