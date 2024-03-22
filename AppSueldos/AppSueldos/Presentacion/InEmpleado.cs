using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppSueldos
{
    public partial class InEmpleado : Form
    {
        public InEmpleado()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            this.tbRUT.Clear();
            this.tbNOMBRE.Clear();
            this.tbAPELLIDO.Clear();
            this.tbDIRECCION.Clear();
            this.tbTELEFONO.Clear();    
            this.tbEMAIL.Clear();
            this.tbVHORA.Clear();
            this.tbVHORAE.Clear();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private bool EsNumero(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor)) return false; // Si está vacío, no es un número
            return int.TryParse(valor, out _); // Intenta convertir el valor a un número entero
        }

        public void MensajeError(string MensajeError)
        {
            MessageBox.Show(MensajeError, "Control de informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MensajeCorrecto(string MensajeError)
        {
            MessageBox.Show(MensajeError, "Control de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (tbRUT.Text == string.Empty) { 
                    this.MensajeError("Rellene los campos vacios!");
                    return;
                }
                if (tbNOMBRE.Text == string.Empty) {
                    this.MensajeError("Rellene los campos vacios!");
                    return;
                }
                if (tbAPELLIDO.Text == string.Empty) {
                    this.MensajeError("Rellene los campos vacios!");
                    return;
                }
                if (tbDIRECCION.Text == string.Empty) {
                    this.MensajeError("Rellene los campos vacios!");
                    return;
                }
                if (tbTELEFONO.Text == string.Empty) {
                    this.MensajeError("Rellene los campos vacios!");
                    return;
                }
                if (tbEMAIL.Text == string.Empty) {
                    this.MensajeError("Rellene los campos vacios!");
                    return;
                }
                if (!EsNumero(tbVHORA.Text))
                {
                    this.MensajeError("Ingrese un valor numérico en el campo Valor Hora.");
                    return;
                }
                if (!EsNumero(tbVHORAE.Text))
                {
                    this.MensajeError("Ingrese un valor numérico en el campo Valor Hora Extra.");
                    return;
                }
                
                Empleado obj = new Empleado();
                obj.RUT = tbRUT.Text;
                obj.NOMBRE = tbNOMBRE.Text;
                obj.APELLIDO = tbAPELLIDO.Text;
                obj.DIRECCION = tbDIRECCION.Text;
                obj.TELEFONO = tbTELEFONO.Text;
                obj.EMAIL = tbEMAIL.Text;
                obj.VALOR_HORA = tbVHORA.Text;
                obj.VALOR_EXTRA = tbVHORAE.Text;

                Empleados emp = new Empleados();
                respuesta = emp.InsertarEmpleado(obj);
                
                if(respuesta.Equals("OK"))
                {
                    this.MensajeCorrecto("Usuario registrado correctamente.");
                    this.Limpiar();
                } 
                else
                {
                    this.MensajeError(respuesta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
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
