/*
 * Creado por SharpDevelop.
 * Usuario: zamud
 * Fecha: 10/12/2025
 * Hora: 01:35 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Pastel_Cake
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.rdbSalado = new System.Windows.Forms.RadioButton();
			this.rdbDulce = new System.Windows.Forms.RadioButton();
			this.lblSeleccionar = new System.Windows.Forms.Label();
			this.cmbSeleccionar = new System.Windows.Forms.ComboBox();
			this.lblPrecio = new System.Windows.Forms.Label();
			this.lblCantidad = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.dgvProductos = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblSub = new System.Windows.Forms.Label();
			this.lblDescuento = new System.Windows.Forms.Label();
			this.lblCambio = new System.Windows.Forms.Label();
			this.lblPagado = new System.Windows.Forms.Label();
			this.lblNeto = new System.Windows.Forms.Label();
			this.txtDes = new System.Windows.Forms.TextBox();
			this.txtSub = new System.Windows.Forms.TextBox();
			this.txtCambio = new System.Windows.Forms.TextBox();
			this.txtPagado = new System.Windows.Forms.TextBox();
			this.txtNeto = new System.Windows.Forms.TextBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnBorrar = new System.Windows.Forms.Button();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(1, -1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(92, 65);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// rdbSalado
			// 
			this.rdbSalado.Location = new System.Drawing.Point(111, 70);
			this.rdbSalado.Name = "rdbSalado";
			this.rdbSalado.Size = new System.Drawing.Size(104, 24);
			this.rdbSalado.TabIndex = 1;
			this.rdbSalado.TabStop = true;
			this.rdbSalado.Text = "Salado";
			this.rdbSalado.UseVisualStyleBackColor = true;
			// 
			// rdbDulce
			// 
			this.rdbDulce.Location = new System.Drawing.Point(1, 70);
			this.rdbDulce.Name = "rdbDulce";
			this.rdbDulce.Size = new System.Drawing.Size(104, 24);
			this.rdbDulce.TabIndex = 2;
			this.rdbDulce.TabStop = true;
			this.rdbDulce.Text = "Dulce";
			this.rdbDulce.UseVisualStyleBackColor = true;
			// 
			// lblSeleccionar
			// 
			this.lblSeleccionar.Location = new System.Drawing.Point(1, 106);
			this.lblSeleccionar.Name = "lblSeleccionar";
			this.lblSeleccionar.Size = new System.Drawing.Size(136, 23);
			this.lblSeleccionar.TabIndex = 3;
			this.lblSeleccionar.Text = "Seleccionar Producto:";
			// 
			// cmbSeleccionar
			// 
			this.cmbSeleccionar.FormattingEnabled = true;
			this.cmbSeleccionar.Items.AddRange(new object[] {
									"Galletas",
									"Pastel",
									"CupCake",
									"CakePops",
									"Charcuteria",
									"Barra de quesos"});
			this.cmbSeleccionar.Location = new System.Drawing.Point(111, 103);
			this.cmbSeleccionar.Name = "cmbSeleccionar";
			this.cmbSeleccionar.Size = new System.Drawing.Size(121, 21);
			this.cmbSeleccionar.TabIndex = 4;
			this.cmbSeleccionar.SelectedIndexChanged += new System.EventHandler(this.CmbSeleccionarSelectedIndexChanged);
			// 
			// lblPrecio
			// 
			this.lblPrecio.Location = new System.Drawing.Point(5, 138);
			this.lblPrecio.Name = "lblPrecio";
			this.lblPrecio.Size = new System.Drawing.Size(100, 23);
			this.lblPrecio.TabIndex = 5;
			this.lblPrecio.Text = "Precio";
			// 
			// lblCantidad
			// 
			this.lblCantidad.Location = new System.Drawing.Point(132, 138);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(100, 23);
			this.lblCantidad.TabIndex = 6;
			this.lblCantidad.Text = "Cantidad";
			// 
			// lblTotal
			// 
			this.lblTotal.Location = new System.Drawing.Point(267, 138);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(100, 23);
			this.lblTotal.TabIndex = 7;
			this.lblTotal.Text = "Total";
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(5, 164);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(100, 20);
			this.txtPrecio.TabIndex = 8;
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(132, 164);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(100, 20);
			this.txtCantidad.TabIndex = 9;
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(267, 164);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(100, 20);
			this.txtTotal.TabIndex = 10;
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.Color.Thistle;
			this.btnAgregar.Location = new System.Drawing.Point(361, 82);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(111, 23);
			this.btnAgregar.TabIndex = 11;
			this.btnAgregar.Text = "Agregar Producto";
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.Thistle;
			this.btnEliminar.Location = new System.Drawing.Point(361, 112);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(111, 23);
			this.btnEliminar.TabIndex = 12;
			this.btnEliminar.Text = "Eliminar Producto";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// dgvProductos
			// 
			this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2,
									this.Column3,
									this.Column4});
			this.dgvProductos.Location = new System.Drawing.Point(5, 190);
			this.dgvProductos.Name = "dgvProductos";
			this.dgvProductos.Size = new System.Drawing.Size(433, 74);
			this.dgvProductos.TabIndex = 14;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Producto";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Precio";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Cantidad";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Total";
			this.Column4.Name = "Column4";
			// 
			// lblSub
			// 
			this.lblSub.Location = new System.Drawing.Point(13, 293);
			this.lblSub.Name = "lblSub";
			this.lblSub.Size = new System.Drawing.Size(100, 23);
			this.lblSub.TabIndex = 15;
			this.lblSub.Text = "Subtotal:";
			// 
			// lblDescuento
			// 
			this.lblDescuento.Location = new System.Drawing.Point(13, 326);
			this.lblDescuento.Name = "lblDescuento";
			this.lblDescuento.Size = new System.Drawing.Size(100, 23);
			this.lblDescuento.TabIndex = 16;
			this.lblDescuento.Text = "Descuento:";
			// 
			// lblCambio
			// 
			this.lblCambio.Location = new System.Drawing.Point(238, 332);
			this.lblCambio.Name = "lblCambio";
			this.lblCambio.Size = new System.Drawing.Size(100, 23);
			this.lblCambio.TabIndex = 17;
			this.lblCambio.Text = "Cambio:";
			// 
			// lblPagado
			// 
			this.lblPagado.Location = new System.Drawing.Point(221, 296);
			this.lblPagado.Name = "lblPagado";
			this.lblPagado.Size = new System.Drawing.Size(100, 23);
			this.lblPagado.TabIndex = 18;
			this.lblPagado.Text = "Importe Pagado:";
			// 
			// lblNeto
			// 
			this.lblNeto.Location = new System.Drawing.Point(221, 270);
			this.lblNeto.Name = "lblNeto";
			this.lblNeto.Size = new System.Drawing.Size(100, 23);
			this.lblNeto.TabIndex = 19;
			this.lblNeto.Text = "Importe Neto:";
			// 
			// txtDes
			// 
			this.txtDes.Location = new System.Drawing.Point(82, 329);
			this.txtDes.Name = "txtDes";
			this.txtDes.Size = new System.Drawing.Size(100, 20);
			this.txtDes.TabIndex = 20;
			// 
			// txtSub
			// 
			this.txtSub.Location = new System.Drawing.Point(82, 293);
			this.txtSub.Name = "txtSub";
			this.txtSub.Size = new System.Drawing.Size(100, 20);
			this.txtSub.TabIndex = 21;
			// 
			// txtCambio
			// 
			this.txtCambio.Location = new System.Drawing.Point(308, 332);
			this.txtCambio.Name = "txtCambio";
			this.txtCambio.Size = new System.Drawing.Size(100, 20);
			this.txtCambio.TabIndex = 22;
			// 
			// txtPagado
			// 
			this.txtPagado.Location = new System.Drawing.Point(308, 296);
			this.txtPagado.Name = "txtPagado";
			this.txtPagado.Size = new System.Drawing.Size(100, 20);
			this.txtPagado.TabIndex = 23;
			this.txtPagado.TextChanged += new System.EventHandler(this.TxtPagadoTextChanged);
			// 
			// txtNeto
			// 
			this.txtNeto.Location = new System.Drawing.Point(308, 270);
			this.txtNeto.Name = "txtNeto";
			this.txtNeto.Size = new System.Drawing.Size(100, 20);
			this.txtNeto.TabIndex = 24;
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnGuardar.Location = new System.Drawing.Point(47, 378);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(75, 23);
			this.btnGuardar.TabIndex = 25;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// btnBorrar
			// 
			this.btnBorrar.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnBorrar.Location = new System.Drawing.Point(169, 378);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(75, 23);
			this.btnBorrar.TabIndex = 26;
			this.btnBorrar.Text = "Borrar";
			this.btnBorrar.UseVisualStyleBackColor = false;
			this.btnBorrar.Click += new System.EventHandler(this.BtnBorrarClick);
			// 
			// btnImprimir
			// 
			this.btnImprimir.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnImprimir.Location = new System.Drawing.Point(292, 378);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(75, 23);
			this.btnImprimir.TabIndex = 27;
			this.btnImprimir.Text = "Imprimir";
			this.btnImprimir.UseVisualStyleBackColor = false;
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(99, -2);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(307, 69);
			this.lblTitulo.TabIndex = 28;
			this.lblTitulo.Text = "Pasteleria";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(221, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 34);
			this.label1.TabIndex = 29;
			this.label1.Text = "Las Alucines";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PeachPuff;
			this.ClientSize = new System.Drawing.Size(473, 413);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.btnBorrar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtNeto);
			this.Controls.Add(this.txtPagado);
			this.Controls.Add(this.txtCambio);
			this.Controls.Add(this.txtSub);
			this.Controls.Add(this.txtDes);
			this.Controls.Add(this.lblNeto);
			this.Controls.Add(this.lblPagado);
			this.Controls.Add(this.lblCambio);
			this.Controls.Add(this.lblDescuento);
			this.Controls.Add(this.lblSub);
			this.Controls.Add(this.dgvProductos);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.lblCantidad);
			this.Controls.Add(this.lblPrecio);
			this.Controls.Add(this.cmbSeleccionar);
			this.Controls.Add(this.lblSeleccionar);
			this.Controls.Add(this.rdbDulce);
			this.Controls.Add(this.rdbSalado);
			this.Controls.Add(this.pictureBox1);
			this.Name = "MainForm";
			this.Text = "Pastel_Cake";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.Button btnBorrar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox txtNeto;
		private System.Windows.Forms.TextBox txtPagado;
		private System.Windows.Forms.TextBox txtCambio;
		private System.Windows.Forms.TextBox txtSub;
		private System.Windows.Forms.TextBox txtDes;
		private System.Windows.Forms.Label lblNeto;
		private System.Windows.Forms.Label lblPagado;
		private System.Windows.Forms.Label lblCambio;
		private System.Windows.Forms.Label lblDescuento;
		private System.Windows.Forms.Label lblSub;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridView dgvProductos;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.Label lblPrecio;
		private System.Windows.Forms.ComboBox cmbSeleccionar;
		private System.Windows.Forms.Label lblSeleccionar;
		private System.Windows.Forms.RadioButton rdbDulce;
		private System.Windows.Forms.RadioButton rdbSalado;
		private System.Windows.Forms.PictureBox pictureBox1;
		
		
	}
}
