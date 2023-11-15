using MySqlConnector;
using System;
using System.Windows.Forms;

namespace FormularioClubDeportivo
{
    public partial class frmLogin : Form
    {
        private frmPrincipal frmPrincipal;

        public frmLogin(frmPrincipal frmPrincipal)
        {
            InitializeComponent();
            this.frmPrincipal = frmPrincipal;
            // Inicializa la ProgressBar
            progressBarLogin.Visible = false;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=ClubDeportivodb;User ID=root;Password=nico;Port=3306";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM usuario WHERE NombreUsu = @usuario AND PassUsu = @contrasena";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                        cmd.Parameters.AddWithValue("@contrasena", txtPassword.Text);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Las credenciales son correctas, inicia la ProgressBar
                                progressBarLogin.Visible = true;

                                // Realiza alg�n trabajo simulado (aqu� simulado por un bucle)
                                for (int i = 0; i <= 100; i++)
                                {
                                    progressBarLogin.Value = i;
                                    System.Threading.Thread.Sleep(50); // Simula alg�n trabajo
                                }

                                // Abre el formulario principal
                                AbrirFormularioPrincipal();
                            }
                            else
                            {
                                MessageBox.Show("Credenciales incorrectas");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexi�n: " + ex.Message);
                }
                finally
                {
                    // Aseg�rate de ocultar la ProgressBar al finalizar
                    progressBarLogin.Visible = false;
                }
            }
        }

        private void AbrirFormularioPrincipal()
        {
            try
            {
                // Verifica si ya existe una instancia del formulario principal
                if (this.frmPrincipal == null)
                {
                    // Si no hay una instancia, crea una nueva
                    this.frmPrincipal = new frmPrincipal();
                }

                // Muestra el formulario principal
                this.frmPrincipal.Show();

                // Cierra el formulario de inicio de sesi�n si ya no es necesario
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario principal: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar el contenido de los TextBox u otros controles que desees
            txtUsuario.Text = string.Empty;
            txtPassword.Text = string.Empty;
            // Puedes agregar m�s l�neas para limpiar otros controles si es necesario
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Puedes agregar cualquier acci�n de limpieza que necesites antes de salir
            // Cierra la aplicaci�n
            Application.Exit();
        }

        private void progressBarLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
