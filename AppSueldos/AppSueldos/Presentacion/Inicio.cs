using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppSueldos
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btiniciarsesion_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbnombreusuario.Text) && !string.IsNullOrEmpty(tbcontrasena.Text))
            {
                try
                {
                    // Crear una instancia de la clase Login
                    DatosSql bd = new DatosSql();

                    // Intentar iniciar sesión con las credenciales ingresadas
                    bool res = bd.IniciarSesion(tbnombreusuario.Text, tbcontrasena.Text);

                    if (res)
                    {
                        string tipoUsuario = bd.ObtenerTipoUsuario(tbnombreusuario.Text, tbcontrasena.Text);

                        if (tipoUsuario == "User")
                        {
                            // Redirige al formulario de usuarios
                            BsqEmpleado p = new BsqEmpleado();
                            p.Show();
                            this.Hide();
                        }
                        else if (tipoUsuario == "Admin")
                        {
                            // Redirige al formulario de administradores
                            InEmpleado m = new InEmpleado();
                            m.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        // Las credenciales son incorrectas, mostrar un mensaje de error
                        MessageBox.Show("Datos Incorrectos");
                        Console.WriteLine("Usuario Ingresa Datos Incorrectos");
                    }
                }
                catch (Exception ex)
                {
                    // Capturar cualquier excepción y mostrar un mensaje de error
                    MessageBox.Show("Error: " + ex.Message);
                    Console.WriteLine("Se Presenta un Error de Tipo: " + ex.Message);
                }
            }
            else
            {
                // Datos incompletos, mostrar un mensaje de error
                MessageBox.Show("Complete los datos");
                Console.WriteLine("Usuario NO Ingresa Datos Correctamente");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbcontrasena.UseSystemPasswordChar = true;
        }

        private void tbcontrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizarApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

