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
            ((System.ComponentModel.ISupportInitialize)(this.erpDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpProductor)).BeginInit();
            this.SuspendLayout();

            // lblParametro
            this.lblParametro.AutoSize = true;
            this.lblParametro.Location = new System.Drawing.Point(12, 15);
            this.lblParametro.Text = "Buscar:";

            // txtParametro
            this.txtParametro.Location = new System.Drawing.Point(70, 12);
            this.txtParametro.Size = new System.Drawing.Size(300, 23);
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);

            // btnBuscar
            this.btnBuscar.Location = new System.Drawing.Point(380, 11);
            this.btnBuscar.Size = new System.Drawing.Size(80, 25);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            // dgvLista
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.ReadOnly = true;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Location = new System.Drawing.Point(12, 45);
            this.dgvLista.Size = new System.Drawing.Size(960, 180);
            this.dgvLista.Anchor = ((System.Windows.Forms.AnchorStyles)(
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right));

            // pnlAcciones
            this.pnlAcciones.Location = new System.Drawing.Point(12, 235);
            this.pnlAcciones.Size = new System.Drawing.Size(960, 40);
            this.pnlAcciones.Controls.Add(this.btnNuevo);
            this.pnlAcciones.Controls.Add(this.btnEditar);
            this.pnlAcciones.Controls.Add(this.btnEliminar);
            this.pnlAcciones.Controls.Add(this.btnCerrar);

            // btnNuevo
            this.btnNuevo.Location = new System.Drawing.Point(0, 5);
            this.btnNuevo.Size = new System.Drawing.Size(90, 30);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);

            // btnEditar
            this.btnEditar.Location = new System.Drawing.Point(100, 5);
            this.btnEditar.Size = new System.Drawing.Size(90, 30);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);

            // btnEliminar
            this.btnEliminar.Location = new System.Drawing.Point(200, 5);
            this.btnEliminar.Size = new System.Drawing.Size(90, 30);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            // btnCerrar
            this.btnCerrar.Location = new System.Drawing.Point(860, 5);
            this.btnCerrar.Size = new System.Drawing.Size(90, 30);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            // pnlFormulario
            this.pnlFormulario.Location = new System.Drawing.Point(12, 280);
            this.pnlFormulario.Size = new System.Drawing.Size(960, 180);
            this.pnlFormulario.Controls.Add(this.lblTitulo);
            this.pnlFormulario.Controls.Add(this.txtTitulo);
            this.pnlFormulario.Controls.Add(this.lblDescripcion);
            this.pnlFormulario.Controls.Add(this.txtDescripcion);
            this.pnlFormulario.Controls.Add(this.lblCanal);
            this.pnlFormulario.Controls.Add(this.cbxCanal);
            this.pnlFormulario.Controls.Add(this.lblDuracion);
            this.pnlFormulario.Controls.Add(this.nudDuracion);
            this.pnlFormulario.Controls.Add(this.lblProductor);
            this.pnlFormulario.Controls.Add(this.txtProductor);
            this.pnlFormulario.Controls.Add(this.lblFechaEstreno);
            this.pnlFormulario.Controls.Add(this.dtpFechaEstreno);
            this.pnlFormulario.Controls.Add(this.btnGuardar);
            this.pnlFormulario.Controls.Add(this.btnCancelar);

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(10, 12);
            this.lblTitulo.Text = "Título:";

            // txtTitulo
            this.txtTitulo.Location = new System.Drawing.Point(120, 9);
            this.txtTitulo.Size = new System.Drawing.Size(300, 23);

            // lblDescripcion
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(10, 45);
            this.lblDescripcion.Text = "Descripción:";

            // txtDescripcion
            this.txtDescripcion.Location = new System.Drawing.Point(120, 42);
            this.txtDescripcion.Size = new System.Drawing.Size(500, 23);

            // lblCanal
            this.lblCanal.AutoSize = true;
            this.lblCanal.Location = new System.Drawing.Point(10, 78);
            this.lblCanal.Text = "Canal:";

            // cbxCanal
            this.cbxCanal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCanal.Location = new System.Drawing.Point(120, 75);
            this.cbxCanal.Size = new System.Drawing.Size(250, 23);

            // lblDuracion
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(10, 111);
            this.lblDuracion.Text = "Duración (min):";

            // nudDuracion
            this.nudDuracion.Location = new System.Drawing.Point(120, 108);
            this.nudDuracion.Size = new System.Drawing.Size(100, 23);
            this.nudDuracion.Minimum = 1;
            this.nudDuracion.Maximum = 1440;

            // lblProductor
            this.lblProductor.AutoSize = true;
            this.lblProductor.Location = new System.Drawing.Point(280, 78);
            this.lblProductor.Text = "Productor:";

            // txtProductor
            this.txtProductor.Location = new System.Drawing.Point(380, 75);
            this.txtProductor.Size = new System.Drawing.Size(240, 23);

            // lblFechaEstreno
            this.lblFechaEstreno.AutoSize = true;
            this.lblFechaEstreno.Location = new System.Drawing.Point(280, 111);
            this.lblFechaEstreno.Text = "Fecha Estreno:";

            // dtpFechaEstreno
            this.dtpFechaEstreno.Location = new System.Drawing.Point(380, 108);
            this.dtpFechaEstreno.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaEstreno.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // btnGuardar
            this.btnGuardar.Location = new System.Drawing.Point(760, 140);
            this.btnGuardar.Size = new System.Drawing.Size(90, 30);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // btnCancelar
            this.btnCancelar.Location = new System.Drawing.Point(860, 140);
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // ErrorProviders
            this.erpTitulo.ContainerControl = this;
            this.erpDescripcion.ContainerControl = this;
            this.erpCanal.ContainerControl = this;
            this.erpDuracion.ContainerControl = this;
            this.erpProductor.ContainerControl = this;

            // FrmPrograma
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
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
        private System.Windows.Forms.ErrorProvider erpDuracion;
        private System.Windows.Forms.ErrorProvider erpProductor;
        private System.Windows.Forms.Label lblParametro;
    }
}
