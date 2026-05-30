namespace CpParcial2AMRV
{
    partial class FrmPrograma
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCanal = new System.Windows.Forms.Label();
            this.cbxCanal = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.nudDuracion = new System.Windows.Forms.NumericUpDown();
            this.lblProductor = new System.Windows.Forms.Label();
            this.txtProductor = new System.Windows.Forms.TextBox();
            this.lblFechaEstreno = new System.Windows.Forms.Label();
            this.dtpFechaEstreno = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.erpTitulo = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCanal = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCategoria = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpDuracion = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpProductor = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblParametro = new System.Windows.Forms.Label();
            this.pnlAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.pnlFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCanal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpProductor)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnNuevo);
            this.pnlAcciones.Controls.Add(this.btnEditar);
            this.pnlAcciones.Controls.Add(this.btnEliminar);
            this.pnlAcciones.Controls.Add(this.btnCerrar);
            this.pnlAcciones.Location = new System.Drawing.Point(14, 251);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(1097, 43);
            this.pnlAcciones.TabIndex = 4;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(0, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(103, 32);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(114, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(103, 32);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(229, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 32);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(983, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(103, 32);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(80, 13);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(342, 22);
            this.txtParametro.TabIndex = 1;
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(434, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 27);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLista.ColumnHeadersHeight = 29;
            this.dgvLista.Location = new System.Drawing.Point(14, 48);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(1097, 192);
            this.dgvLista.TabIndex = 3;
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.Controls.Add(this.lblTitulo);
            this.pnlFormulario.Controls.Add(this.txtTitulo);
            this.pnlFormulario.Controls.Add(this.lblDescripcion);
            this.pnlFormulario.Controls.Add(this.txtDescripcion);
            this.pnlFormulario.Controls.Add(this.lblCanal);
            this.pnlFormulario.Controls.Add(this.cbxCanal);
            this.pnlFormulario.Controls.Add(this.lblCategoria);
            this.pnlFormulario.Controls.Add(this.cbxCategoria);
            this.pnlFormulario.Controls.Add(this.lblDuracion);
            this.pnlFormulario.Controls.Add(this.nudDuracion);
            this.pnlFormulario.Controls.Add(this.lblProductor);
            this.pnlFormulario.Controls.Add(this.txtProductor);
            this.pnlFormulario.Controls.Add(this.lblFechaEstreno);
            this.pnlFormulario.Controls.Add(this.dtpFechaEstreno);
            this.pnlFormulario.Controls.Add(this.btnGuardar);
            this.pnlFormulario.Controls.Add(this.btnCancelar);
            this.pnlFormulario.Location = new System.Drawing.Point(14, 299);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(1097, 224);
            this.pnlFormulario.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(11, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(43, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(137, 10);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(342, 22);
            this.txtTitulo.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(11, 48);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(137, 45);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(571, 22);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblCanal
            // 
            this.lblCanal.AutoSize = true;
            this.lblCanal.Location = new System.Drawing.Point(11, 83);
            this.lblCanal.Name = "lblCanal";
            this.lblCanal.Size = new System.Drawing.Size(45, 16);
            this.lblCanal.TabIndex = 4;
            this.lblCanal.Text = "Canal:";
            // 
            // cbxCanal
            // 
            this.cbxCanal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCanal.Location = new System.Drawing.Point(137, 80);
            this.cbxCanal.Name = "cbxCanal";
            this.cbxCanal.Size = new System.Drawing.Size(285, 24);
            this.cbxCanal.TabIndex = 5;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(11, 118);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 16);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoría:";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.Location = new System.Drawing.Point(137, 115);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(228, 24);
            this.cbxCategoria.TabIndex = 7;
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(11, 154);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(96, 16);
            this.lblDuracion.TabIndex = 8;
            this.lblDuracion.Text = "Duración (min):";
            // 
            // nudDuracion
            // 
            this.nudDuracion.Location = new System.Drawing.Point(137, 150);
            this.nudDuracion.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.nudDuracion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDuracion.Name = "nudDuracion";
            this.nudDuracion.Size = new System.Drawing.Size(114, 22);
            this.nudDuracion.TabIndex = 9;
            this.nudDuracion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblProductor
            // 
            this.lblProductor.AutoSize = true;
            this.lblProductor.Location = new System.Drawing.Point(470, 86);
            this.lblProductor.Name = "lblProductor";
            this.lblProductor.Size = new System.Drawing.Size(68, 16);
            this.lblProductor.TabIndex = 10;
            this.lblProductor.Text = "Productor:";
            // 
            // txtProductor
            // 
            this.txtProductor.Location = new System.Drawing.Point(544, 83);
            this.txtProductor.Name = "txtProductor";
            this.txtProductor.Size = new System.Drawing.Size(274, 22);
            this.txtProductor.TabIndex = 11;
            // 
            // lblFechaEstreno
            // 
            this.lblFechaEstreno.AutoSize = true;
            this.lblFechaEstreno.Location = new System.Drawing.Point(377, 115);
            this.lblFechaEstreno.Name = "lblFechaEstreno";
            this.lblFechaEstreno.Size = new System.Drawing.Size(97, 16);
            this.lblFechaEstreno.TabIndex = 12;
            this.lblFechaEstreno.Text = "Fecha Estreno:";
            // 
            // dtpFechaEstreno
            // 
            this.dtpFechaEstreno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEstreno.Location = new System.Drawing.Point(480, 115);
            this.dtpFechaEstreno.Name = "dtpFechaEstreno";
            this.dtpFechaEstreno.Size = new System.Drawing.Size(228, 22);
            this.dtpFechaEstreno.TabIndex = 13;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(869, 181);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 32);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(983, 181);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 32);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // erpTitulo
            // 
            this.erpTitulo.ContainerControl = this;
            // 
            // erpDescripcion
            // 
            this.erpDescripcion.ContainerControl = this;
            // 
            // erpCanal
            // 
            this.erpCanal.ContainerControl = this;
            // 
            // erpCategoria
            // 
            this.erpCategoria.ContainerControl = this;
            // 
            // erpDuracion
            // 
            this.erpDuracion.ContainerControl = this;
            // 
            // erpProductor
            // 
            this.erpProductor.ContainerControl = this;
            // 
            // lblParametro
            // 
            this.lblParametro.AutoSize = true;
            this.lblParametro.Location = new System.Drawing.Point(14, 16);
            this.lblParametro.Name = "lblParametro";
            this.lblParametro.Size = new System.Drawing.Size(52, 16);
            this.lblParametro.TabIndex = 0;
            this.lblParametro.Text = "Buscar:";
            // 
            // FrmPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 533);
            this.Controls.Add(this.lblParametro);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.pnlFormulario);
            this.Name = "FrmPrograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programas - Parcial2AMRV";
            this.Load += new System.EventHandler(this.FrmPrograma_Load);
            this.pnlAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.pnlFormulario.ResumeLayout(false);
            this.pnlFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCanal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpProductor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCanal;
        private System.Windows.Forms.ComboBox cbxCanal;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.NumericUpDown nudDuracion;
        private System.Windows.Forms.Label lblProductor;
        private System.Windows.Forms.TextBox txtProductor;
        private System.Windows.Forms.Label lblFechaEstreno;
        private System.Windows.Forms.DateTimePicker dtpFechaEstreno;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider erpTitulo;
        private System.Windows.Forms.ErrorProvider erpDescripcion;
        private System.Windows.Forms.ErrorProvider erpCanal;
        private System.Windows.Forms.ErrorProvider erpCategoria;
        private System.Windows.Forms.ErrorProvider erpDuracion;
        private System.Windows.Forms.ErrorProvider erpProductor;
        private System.Windows.Forms.Label lblParametro;
    }
}
