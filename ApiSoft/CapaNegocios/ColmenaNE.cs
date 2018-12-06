using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public int RegistrarColmena(Colmena colmena, PictureBox img)
        {
            return colmenaDAO.RegistrarColmena(colmena, img);
        }

    }
}
