using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ColmenaDAO
    {
        Conexion conexion = new Conexion();
        SqlConnection sqlConnection = new SqlConnection();

        public DataTable ListarColmenas()
        {
            sqlConnection = conexion.GetConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SP_LISTAR_COLMENAS"
                , sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
