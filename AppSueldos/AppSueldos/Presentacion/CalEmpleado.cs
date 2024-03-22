using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppSueldos
{
    public partial class CalEmpleado : Form
    {
        string AFPEmpleado = "";
        string SALUDEmpleado = "";

        public CalEmpleado(string Rut, string Nombre, string Apellido, string ValorHora, string ValorExtra)
        {
            InitializeComponent();

            // Asigna los datos recibidos a los controles del formulario
            RUT.Text = Rut;
            nEmpleado.Text = Nombre;
            aEmpleado.Text = Apellido;
            ValorH.Text = ValorHora;
            ValorHE.Text = ValorExtra;

            cbAFP.Items.Add("CUPRUM");
            cbAFP.Items.Add("MODELO");
            cbAFP.Items.Add("CAPITAL");
            cbAFP.Items.Add("PROVIDA");

            cbSALUD.Items.Add("FONASA");
            cbSALUD.Items.Add("CONSALUD");
            cbSALUD.Items.Add("MASVIDA");
            cbSALUD.Items.Add("BANMEDICA");
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
        private void Limpiar()
        {
            this.HTrab.Clear();
            this.HExt.Clear();
        }
        private void cbSALUD_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* string Prevision = "";

            switch (Prevision)
            {
                case "FONASA":
                    this.SALUDEmpleado = "FONASA";
                    break;
                case "CONSALUD":
                    this.SALUDEmpleado = "CONSALUD";
                    break;
                case "MASVIDA":
                    this.SALUDEmpleado = "MASVIDA";
                    break;
                case "BANMEDICA":
                    this.SALUDEmpleado = "BANMEDICA";
                    break;
            }*/
        }

        private void cbAFP_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string AFP = "";

            switch (AFP)
           {
               case "CUPRUM":
                   this.AFPEmpleado = "CUPRUM";
                   break;
               case "MODELO":
                   this.AFPEmpleado = "MODELO";
                   break;
               case "CAPITAL":
                   this.AFPEmpleado = "CAPITAL";
                   break;
               case "PROVIDA":
                   this.AFPEmpleado = "PROVIDA";
                   break;
           }*/
        }
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void valorH_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string ValorHora = ValorH.Text;
            string ValorExtra = ValorHE.Text;
            string HorasTrab = HTrab.Text;
            string HorasExt = HExt.Text;
            CalcularSueldo calculadora = new CalcularSueldo(decimal.Parse(ValorHora), decimal.Parse(ValorExtra));

            try
            {
                string respuesta = "";

                if (!EsNumero(HTrab.Text))
                {
                    this.MensajeError("Ingrese un valor numérico en el campo de Horas de trabajo.");
                    return;
                }
                if (!EsNumero(HExt.Text))
                {
                    this.MensajeError("Ingrese un valor numérico en el campo Horas Extras de trabajo.");
                    return;
                }
                if (cbAFP.SelectedItem == null)
                {
                    this.MensajeError("Seleccione una opción en el recuadro de Previsión.");
                    return;
                }
                if (cbSALUD.SelectedItem == null)
                {
                    this.MensajeError("Seleccione una opción en el recuadro de Sistema de Salud.");
                    return;
                }

                decimal sueldoBruto = calculadora.CalcularSueldoBruto(int.Parse(HorasTrab), int.Parse(HorasExt));
                sBRUTO.Text = sueldoBruto.ToString();

                decimal DescuentoAFP = calculadora.CalcularDescuentoAFP(sueldoBruto, cbAFP.SelectedItem.ToString());
                decimal DescuentoSalud = calculadora.CalcularDescuentoSalud(sueldoBruto, cbSALUD.SelectedItem.ToString());
                decimal sueldoLiquido = sueldoBruto - DescuentoAFP - DescuentoSalud;
                sLIQUIDO.Text = Convert.ToInt32(sueldoLiquido).ToString();

                this.MensajeCorrecto("Cálculo realizado correctamente.");
                //this.Limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (sBRUTO.Text == string.Empty)
                {
                    this.MensajeError("No ha realizado el calculo!");
                    return;
                }
                if (sLIQUIDO.Text == string.Empty)
                {
                    this.MensajeError("No ha realizado el calculo!");
                    return;
                }
                

                Empleado obj = new Empleado();
                obj.RUT = RUT.Text;
                obj.SUELDO_BRUT = sBRUTO.Text;
                obj.SUELDO_LIQ = sLIQUIDO.Text;

                Empleados emp = new Empleados();
                respuesta = emp.ActualizarEmpleado(obj.RUT, obj.SUELDO_LIQ, obj.SUELDO_BRUT);

                if (respuesta.Equals("OK"))
                {
                    this.MensajeCorrecto("Usuario actualizado correctamente.");
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
            this.Close();
        }
        private void btnMinimizarApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
