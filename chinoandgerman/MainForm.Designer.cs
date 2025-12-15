/*
 * Creado por SharpDevelop.
 * Usuario: CC1_PC50
 * Fecha: 08/12/2025
 * Hora: 03:08 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace detallesdecliente
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
			this.components = new System.ComponentModel.Container();
			this.lblCodigo = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblPuesto = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.lblSexo = new System.Windows.Forms.Label();
			this.lblEstado = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.cmbPuesto = new System.Windows.Forms.ComboBox();
			this.rbRegular = new System.Windows.Forms.RadioButton();
			this.rbContrato = new System.Windows.Forms.RadioButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnActualizarFoto = new System.Windows.Forms.Button();
			this.btnQuitar = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.cmbSexo = new System.Windows.Forms.ComboBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.dtFecha = new System.Windows.Forms.DateTimePicker();
			this.errperror = new System.Windows.Forms.ErrorProvider(this.components);
			this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errperror)).BeginInit();
			this.SuspendLayout();
			// 
			// lblCodigo
			// 
			this.lblCodigo.BackColor = System.Drawing.Color.White;
			this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblCodigo.Location = new System.Drawing.Point(226, 9);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(181, 20);
			this.lblCodigo.TabIndex = 0;
			this.lblCodigo.Text = "codigo del empleado";
			// 
			// lblNombre
			// 
			this.lblNombre.BackColor = System.Drawing.Color.White;
			this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblNombre.Location = new System.Drawing.Point(226, 35);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(120, 23);
			this.lblNombre.TabIndex = 1;
			this.lblNombre.Text = "Nombre del empleado";
			// 
			// lblPuesto
			// 
			this.lblPuesto.BackColor = System.Drawing.Color.White;
			this.lblPuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblPuesto.Location = new System.Drawing.Point(227, 64);
			this.lblPuesto.Name = "lblPuesto";
			this.lblPuesto.Size = new System.Drawing.Size(43, 23);
			this.lblPuesto.TabIndex = 2;
			this.lblPuesto.Text = "Puesto";
			// 
			// lblFecha
			// 
			this.lblFecha.BackColor = System.Drawing.Color.White;
			this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblFecha.Location = new System.Drawing.Point(226, 91);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(120, 23);
			this.lblFecha.TabIndex = 3;
			this.lblFecha.Text = "fecha de nacimiento";
			// 
			// lblSexo
			// 
			this.lblSexo.BackColor = System.Drawing.Color.White;
			this.lblSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblSexo.Location = new System.Drawing.Point(227, 121);
			this.lblSexo.Name = "lblSexo";
			this.lblSexo.Size = new System.Drawing.Size(43, 23);
			this.lblSexo.TabIndex = 4;
			this.lblSexo.Text = "sexo";
			// 
			// lblEstado
			// 
			this.lblEstado.BackColor = System.Drawing.Color.White;
			this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblEstado.Location = new System.Drawing.Point(413, 138);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(43, 23);
			this.lblEstado.TabIndex = 5;
			this.lblEstado.Text = "estado";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(413, 9);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(100, 20);
			this.txtCodigo.TabIndex = 6;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(354, 38);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(146, 20);
			this.txtNombre.TabIndex = 8;
			// 
			// cmbPuesto
			// 
			this.cmbPuesto.FormattingEnabled = true;
			this.cmbPuesto.Items.AddRange(new object[] {
									"Pasteleros principales",
									"Ayudantes de pastelería",
									"Decoradores de pasteles",
									"Personal de atención al cliente",
									"Encargado de producción",
									"Personal de limpieza",
									"Administrador"});
			this.cmbPuesto.Location = new System.Drawing.Point(286, 66);
			this.cmbPuesto.Name = "cmbPuesto";
			this.cmbPuesto.Size = new System.Drawing.Size(121, 21);
			this.cmbPuesto.TabIndex = 9;
			// 
			// rbRegular
			// 
			this.rbRegular.BackColor = System.Drawing.Color.Thistle;
			this.rbRegular.Location = new System.Drawing.Point(465, 123);
			this.rbRegular.Name = "rbRegular";
			this.rbRegular.Size = new System.Drawing.Size(59, 24);
			this.rbRegular.TabIndex = 11;
			this.rbRegular.TabStop = true;
			this.rbRegular.Text = "regular";
			this.rbRegular.UseVisualStyleBackColor = false;
			// 
			// rbContrato
			// 
			this.rbContrato.BackColor = System.Drawing.Color.Thistle;
			this.rbContrato.Location = new System.Drawing.Point(465, 153);
			this.rbContrato.Name = "rbContrato";
			this.rbContrato.Size = new System.Drawing.Size(66, 24);
			this.rbContrato.TabIndex = 12;
			this.rbContrato.TabStop = true;
			this.rbContrato.Text = "contrato";
			this.rbContrato.UseVisualStyleBackColor = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.pictureBox1.Location = new System.Drawing.Point(12, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(111, 105);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			// 
			// btnActualizarFoto
			// 
			this.btnActualizarFoto.BackColor = System.Drawing.Color.Thistle;
			this.btnActualizarFoto.Location = new System.Drawing.Point(32, 118);
			this.btnActualizarFoto.Name = "btnActualizarFoto";
			this.btnActualizarFoto.Size = new System.Drawing.Size(75, 23);
			this.btnActualizarFoto.TabIndex = 14;
			this.btnActualizarFoto.Text = "actualizar foto";
			this.btnActualizarFoto.UseVisualStyleBackColor = false;
			this.btnActualizarFoto.Click += new System.EventHandler(this.BtnActualizarFotoClick);
			// 
			// btnQuitar
			// 
			this.btnQuitar.BackColor = System.Drawing.Color.Thistle;
			this.btnQuitar.Location = new System.Drawing.Point(32, 147);
			this.btnQuitar.Name = "btnQuitar";
			this.btnQuitar.Size = new System.Drawing.Size(75, 23);
			this.btnQuitar.TabIndex = 15;
			this.btnQuitar.Text = "quitar";
			this.btnQuitar.UseVisualStyleBackColor = false;
			this.btnQuitar.Click += new System.EventHandler(this.BtnQuitarClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Codigo,
									this.Nombre,
									this.Puesto,
									this.fecha,
									this.sexo});
			this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dataGridView1.Location = new System.Drawing.Point(23, 183);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(544, 150);
			this.dataGridView1.TabIndex = 16;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// cmbSexo
			// 
			this.cmbSexo.FormattingEnabled = true;
			this.cmbSexo.Items.AddRange(new object[] {
									"Femenino",
									"Masculino "});
			this.cmbSexo.Location = new System.Drawing.Point(286, 123);
			this.cmbSexo.Margin = new System.Windows.Forms.Padding(2);
			this.cmbSexo.Name = "cmbSexo";
			this.cmbSexo.Size = new System.Drawing.Size(92, 21);
			this.cmbSexo.TabIndex = 17;
			
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(12, 377);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(58, 34);
			this.btnGuardar.TabIndex = 18;
			this.btnGuardar.Text = "Guardar ";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(214, 377);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(56, 34);
			this.btnEliminar.TabIndex = 19;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(434, 377);
			this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(59, 34);
			this.btnLimpiar.TabIndex = 20;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// dtFecha
			// 
			this.dtFecha.CalendarForeColor = System.Drawing.Color.LightBlue;
			this.dtFecha.CalendarMonthBackground = System.Drawing.Color.Khaki;
			this.dtFecha.Location = new System.Drawing.Point(354, 94);
			this.dtFecha.Name = "dtFecha";
			this.dtFecha.Size = new System.Drawing.Size(170, 20);
			this.dtFecha.TabIndex = 21;
			// 
			// errperror
			// 
			this.errperror.ContainerControl = this;
			// 
			// Codigo
			// 
			this.Codigo.HeaderText = "Codigo";
			this.Codigo.Name = "Codigo";
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			// 
			// Puesto
			// 
			this.Puesto.HeaderText = "Puesto";
			this.Puesto.Name = "Puesto";
			// 
			// fecha
			// 
			this.fecha.HeaderText = "Fecha";
			this.fecha.Name = "fecha";
			// 
			// sexo
			// 
			this.sexo.HeaderText = "Sexo";
			this.sexo.Name = "sexo";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(595, 437);
			this.Controls.Add(this.dtFecha);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.cmbSexo);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnQuitar);
			this.Controls.Add(this.btnActualizarFoto);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.rbContrato);
			this.Controls.Add(this.rbRegular);
			this.Controls.Add(this.cmbPuesto);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.lblEstado);
			this.Controls.Add(this.lblSexo);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.lblPuesto);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.lblCodigo);
			this.Name = "MainForm";
			this.Text = "detallesdecliente";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errperror)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ErrorProvider errperror;
		private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
		private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
		private System.Windows.Forms.DateTimePicker dtFecha;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.ComboBox cmbSexo;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnQuitar;
		private System.Windows.Forms.Button btnActualizarFoto;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.RadioButton rbContrato;
		private System.Windows.Forms.RadioButton rbRegular;
		private System.Windows.Forms.ComboBox cmbPuesto;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label lblEstado;
		private System.Windows.Forms.Label lblSexo;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.Label lblPuesto;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblCodigo;
	}
}
