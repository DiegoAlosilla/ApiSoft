using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public int RegistrarColmena(Colmena colmena,PictureBox img)
        {
            
            sqlConnection = conexion.GetConnection();
            sqlConnection.Open();
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            img.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            using (SqlTransaction tr = sqlConnection.BeginTransaction(IsolationLevel.Serializable))
            {
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_COLMENAS", sqlConnection, tr);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@FECHA", SqlDbType.Date).Value = colmena.date;
                cmd.Parameters.Add("@UBICACION", SqlDbType.VarChar).Value = colmena.ubicacion;
                cmd.Parameters.Add("@TIPO", SqlDbType.VarChar).Value = colmena.tipo;
                cmd.Parameters.Add("@MARCOS", SqlDbType.Int).Value = colmena.marcos;
                cmd.Parameters.Add("@FOTO", SqlDbType.Image).Value = ms.GetBuffer();
                cmd.Parameters.Add("@DESCRIPCION", SqlDbType.VarChar).Value = colmena.descripcion;
                cmd.Parameters.Add("@TIPO_ABEJA", SqlDbType.VarChar).Value = colmena.tipo_abeja;

                try
                {
                    int n = cmd.ExecuteNonQuery();
                    tr.Commit();
                    return n;
                }
                catch (Exception e)
                {
                    tr.Rollback();
                    Console.WriteLine(e);
                    throw;
                }

            }
        }
    }
}
