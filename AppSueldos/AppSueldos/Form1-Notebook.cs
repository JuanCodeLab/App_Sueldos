using System;
using System.Windows.Forms;

namespace AppSueldos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btiniciarsesion_Click_Click(object sender, EventArgs e)
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
                        // Inicio de sesión exitoso, mostrar el formulario principal y ocultar el actual
                        Principal p = new Principal();
                        p.Show();
                        this.Hide();
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

        }

        private void tbcontrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

