using System;
using System.Windows.Forms;

namespace AppSueldos
{
    public partial class BsqEmpleado : Form
    {

        private CalEmpleado calEmpleado; 

        public BsqEmpleado()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string valorBuscado = tbBusqueda.Text;
            Empleados sql = new Empleados();
            dgvEmpleados.DataSource = sql.BuscarEmpleados(valorBuscado);
        }

        private void listar()
        {
            try
            {
                Empleados sql = new Empleados();
                dgvEmpleados.DataSource = sql.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvEmpleados.Rows[e.RowIndex];

                string rut = selectedRow.Cells["Rut"].Value.ToString();
                string nombre = selectedRow.Cells["Nombre"].Value.ToString();
                string apellido = selectedRow.Cells["Apellido"].Value.ToString();
                string vhora = selectedRow.Cells["ValorHora"].Value.ToString();
                string vextra = selectedRow.Cells["ValorExtra"].Value.ToString();

                // Crea una instancia del formulario "CalEmpleado" y pasa los datos
                CalEmpleado editForm = new CalEmpleado(rut, nombre, apellido, vhora, vextra);
                editForm.Show();
            }
        }


        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvEmpleados.Rows[e.RowIndex];

                string rut = selectedRow.Cells["Rut"].Value.ToString();
                string nombre = selectedRow.Cells["Nombre"].Value.ToString();
                string apellido = selectedRow.Cells["Apellido"].Value.ToString();
                string vhora = selectedRow.Cells["ValorHora"].Value.ToString();
                string vextra = selectedRow.Cells["ValorExtra"].Value.ToString();

                // Crea una instancia del formulario "CalEmpleado" y pasa los datos
                CalEmpleado editForm = new CalEmpleado(rut, nombre, apellido, vhora, vextra);
                editForm.Show();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                string respuesta = "";
                Opcion = MessageBox.Show("¿Está seguro/a que desea eliminar el campo?",
                    "Eliminar Empleado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    if (dgvEmpleados.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectedRow = dgvEmpleados.SelectedRows[0];
                        string empleadoRut = selectedRow.Cells["Rut"].Value.ToString();
                        Empleados sql = new Empleados();

                        respuesta = sql.EliminarEmpleado(empleadoRut); // Actualiza respuesta con la respuesta de EliminarEmpleado

                        if (respuesta == "OK")
                        {
                            MessageBox.Show("Empleado eliminado correctamente", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el empleado: " + respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        listar(); // Refresca la vista después de eliminar en ambos casos
                    }
                    else
                    {
                        MessageBox.Show("Por favor, seleccione un empleado a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnMinimizarApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
