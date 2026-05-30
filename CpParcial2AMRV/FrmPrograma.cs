using CadParcial2AMRV;
using ClnParcial2AMRV;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CpParcial2AMRV
{
    public partial class FrmPrograma : Form
    {
        private bool esNuevo = false;

        public FrmPrograma()
        {
            InitializeComponent();
        }

        // ─── Listado ──────────────────────────────────────────────────────────

        private void listar()
        {
            var lista = ProgramaCln.listarPa(txtParametro.Text);
            dgvLista.DataSource = lista;

            // Columnas ocultas
            dgvLista.Columns["id"].Visible      = false;
            dgvLista.Columns["idCanal"].Visible  = false;
            dgvLista.Columns["estado"].Visible   = false;

            // Encabezados amigables
            dgvLista.Columns["titulo"].HeaderText       = "Título";
            dgvLista.Columns["descripcion"].HeaderText  = "Descripción";
            dgvLista.Columns["canal"].HeaderText        = "Canal";
            dgvLista.Columns["duracion"].HeaderText     = "Duración (min)";
            dgvLista.Columns["productor"].HeaderText    = "Productor";
            dgvLista.Columns["fechaEstreno"].HeaderText = "Fecha de Estreno";

            if (lista.Count > 0)
                dgvLista.CurrentCell = dgvLista.Rows[0].Cells["titulo"];

            btnEditar.Enabled  = lista.Count > 0;
            btnEliminar.Enabled = lista.Count > 0;
        }

        private void cargarCanal()
        {
            cbxCanal.DataSource    = CanalCln.listar();
            cbxCanal.ValueMember   = "id";
            cbxCanal.DisplayMember = "nombre";
            cbxCanal.SelectedIndex = -1;
        }

        // ─── Eventos del formulario ───────────────────────────────────────────

        private void FrmPrograma_Load(object sender, EventArgs e)
        {
            Size = new Size(1000, 360);
            listar();
            cargarCanal();
        }

        private void btnBuscar_Click(object sender, EventArgs e) => listar();

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        // ─── Nuevo ────────────────────────────────────────────────────────────

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            pnlAcciones.Enabled = false;
            Size = new Size(1000, 500);
            limpiar();
            txtTitulo.Focus();
        }

        // ─── Editar ───────────────────────────────────────────────────────────

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            pnlAcciones.Enabled = false;
            Size = new Size(1000, 500);
            resetearErrores();

            int id = (int)dgvLista.CurrentRow.Cells["id"].Value;
            var programa = ProgramaCln.obtenerUno(id);

            txtTitulo.Text             = programa.titulo;
            txtDescripcion.Text        = programa.descripcion;
            cbxCanal.SelectedValue     = programa.idCanal;
            nudDuracion.Value          = programa.duracion;
            txtProductor.Text          = programa.productor;
            dtpFechaEstreno.Value      = programa.fechaEstreno;

            txtTitulo.Focus();
        }

        // ─── Cancelar ─────────────────────────────────────────────────────────

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlAcciones.Enabled = true;
            Size = new Size(1000, 360);
        }

        // ─── Guardar ──────────────────────────────────────────────────────────

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar()) return;

            var programa = new Programa()
            {
                idCanal      = (int)cbxCanal.SelectedValue,
                titulo       = txtTitulo.Text.Trim(),
                descripcion  = txtDescripcion.Text.Trim(),
                duracion     = (int)nudDuracion.Value,
                productor    = txtProductor.Text.Trim(),
                fechaEstreno = dtpFechaEstreno.Value.Date
            };

            if (esNuevo)
            {
                programa.estado = 1;
                ProgramaCln.crear(programa);
            }
            else
            {
                programa.id = (int)dgvLista.CurrentRow.Cells["id"].Value;
                ProgramaCln.modificar(programa);
            }

            listar();
            btnCancelar.PerformClick();
            MessageBox.Show("Programa guardado correctamente",
                "::: Mensaje - Parcial2AMRV :::",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ─── Eliminar (lógico) ────────────────────────────────────────────────

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id     = (int)dgvLista.CurrentRow.Cells["id"].Value;
            string titulo = dgvLista.CurrentRow.Cells["titulo"].Value.ToString();

            DialogResult dialog = MessageBox.Show(
                $"¿Está seguro que desea eliminar el programa \"{titulo}\"?",
                "::: Mensaje - Parcial2AMRV :::",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                ProgramaCln.eliminar(id);
                listar();
                MessageBox.Show("Programa dado de baja correctamente",
                    "::: Mensaje - Parcial2AMRV :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ─── Cerrar ───────────────────────────────────────────────────────────

        private void btnCerrar_Click(object sender, EventArgs e) => Close();

        // ─── Helpers ──────────────────────────────────────────────────────────

        private void limpiar()
        {
            txtTitulo.Clear();
            txtDescripcion.Clear();
            cbxCanal.SelectedIndex = -1;
            nudDuracion.Value      = 1;
            txtProductor.Clear();
            dtpFechaEstreno.Value  = DateTime.Today;
            resetearErrores();
        }

        private void resetearErrores()
        {
            erpTitulo.Clear();
            erpDescripcion.Clear();
            erpCanal.Clear();
            erpDuracion.Clear();
            erpProductor.Clear();
        }

        private bool validar()
        {
            bool esValido = true;
            resetearErrores();

            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                erpTitulo.SetError(txtTitulo, "El Título es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                erpDescripcion.SetError(txtDescripcion, "La Descripción es obligatoria");
                esValido = false;
            }
            if (cbxCanal.SelectedIndex == -1)
            {
                erpCanal.SetError(cbxCanal, "El Canal es obligatorio");
                esValido = false;
            }
            if (nudDuracion.Value <= 0)
            {
                erpDuracion.SetError(nudDuracion, "La Duración debe ser mayor a cero");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtProductor.Text))
            {
                erpProductor.SetError(txtProductor, "El Productor es obligatorio");
                esValido = false;
            }

            return esValido;
        }
    }
}
