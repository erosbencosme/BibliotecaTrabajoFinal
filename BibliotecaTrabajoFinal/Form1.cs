using System.Data.SqlClient;

namespace BibliotecaTrabajoFinal
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        ConexionBiblioteca Conexion = new ConexionBiblioteca();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion.abrir();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string cadena = " SELECT* From TblEmpleado WHERE C�dula = " + txtUsuario.Text + "  AND Contrase�a = " + txtContrase�a.Text;
            SqlCommand comando = new SqlCommand(cadena, Conexion.conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                textBox1.AppendText(registros[0].ToString());
      
            }
            //hola


            MessageBox.Show("Se cerr� la conexi�n.");

        }// SELECT* From TblEmpleado


    }
}

