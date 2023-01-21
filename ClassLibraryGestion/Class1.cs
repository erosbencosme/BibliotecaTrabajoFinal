using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibraryGestion
{
    public class Class1
    {
       
            public static DataSet Ejecutar(string cmd)
            {
                SqlConnection con = new SqlConnection(("Data source =.;Initial Catalog =add; integrated security = true");
                con.Open();

                DataSet DS = new DataSet();

                SqlDataAdapter DP = new SqlDataAdapter(cmd, con);

                DP.Fill(DS);

                con.Close();

                return DS;
            }
        
    }
}



