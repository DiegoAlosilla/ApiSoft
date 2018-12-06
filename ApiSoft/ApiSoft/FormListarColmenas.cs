using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiSoft
{
    public partial class FormListarColmenas : Form
    {

        private int colmenaSeleccionada;
        private ColmenaNE colmenaNE;
        public FormListarColmenas()
        {
            InitializeComponent();
            colmenaNE = new ColmenaNE();
        }

        private void FormListarColmenas_Load(object sender, EventArgs e)
        {
            dataGridViewColmenas.DataSource = colmenaNE.ListarColmenas();
        }
    }
}
