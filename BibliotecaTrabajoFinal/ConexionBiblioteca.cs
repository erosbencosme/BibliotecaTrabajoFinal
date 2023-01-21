using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BibliotecaTrabajoFinal
{
     public class ConexionBiblioteca
    {
        string cadena = "server= DESKTOP-KBFE9EA\\SQLEXPRESS ; database= GestionDeBiblioteca ; integrated security = true";
        public SqlConnection conexion = new SqlConnection();

        public ConexionBiblioteca()
        {
            conexion.ConnectionString = cadena;
        }
        public void abrir()
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Exito Open");
                MessageBox.Show("Conexion completada");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mal Open" + ex.Message);
            }
        }
        public void cerrar()
        {
            try
            {
                conexion.Close();
                Console.WriteLine("Exito cerrar");
            }
            catch
            {
                Console.WriteLine("Mal cerrar");
            }
        }
    }
}
