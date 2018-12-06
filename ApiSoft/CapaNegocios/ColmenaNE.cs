using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class ColmenaNE
    {
        private ColmenaDAO colmenaDAO;

        public ColmenaNE()
        {
            colmenaDAO = new ColmenaDAO();
        }

        public DataTable ListarColmenas()
        {
            return colmenaDAO.ListarColmenas();
        }
    }
}
