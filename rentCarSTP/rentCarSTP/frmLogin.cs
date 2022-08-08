using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using rentCarSTP.Frondend;



namespace rentCarSTP
{
    public partial class frmLogin : Form
    {

        string nombreUsuario, passwordUsuario;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                nombreUsuario = textBox1.Text;
                passwordUsuario = textBox2.Text;
                

                //Aqui el programa se conecta con la base de datos y compara los valores de los textBox y verifica que sean compatibles con los valores en la base de datos
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=rentCarTP;Integrated Security=True");
                con.Open();
                string query = $"Select * from usuarios where nombreUsuario = '{nombreUsuario}' and passwordUsuario = '{passwordUsuario}';";
                SqlDataAdapter adaptUsuario = new SqlDataAdapter(query, con);
                DataTable usuarios = new DataTable();
                adaptUsuario.Fill(usuarios);
                

                con.Close();


                //Este método toma el valor del nombre de usuario y lo muestra en la esquina superior del dashboard una vez logeado
                if (usuarios.Rows.Count == 1)
                {
                    dashboardUI dashboard1 = new dashboardUI(nombreUsuario.ToUpper());
                    dashboard1.Show();
                    dashboard1.StartPosition = FormStartPosition.Manual;
                    dashboard1.Location = new Point(50, 16);
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Revisa tus credenciales");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error" + ex.Message);
                throw;
            }

        }
    }
}