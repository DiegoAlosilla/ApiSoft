using CapaEntidad;
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
    public partial class FormRegistrarColmena : Form
    {
        private ColmenaNE colmenaNe;
        public FormRegistrarColmena()
        {
            InitializeComponent();
            colmenaNe = new ColmenaNE();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonImportar_Click(object sender, EventArgs e)
        {
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.pictureBox1.Image = Image.FromFile(this.openFileDialog1.FileName);
        }

        private void FormRegistrarColmena_Load(object sender, EventArgs e)
        {

            
        }

        private void textBoxUbicacion_Enter(object sender, EventArgs e)
        {
            if (textBoxUbicacion.Text == "Ubicacion")
            {
                textBoxUbicacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                textBoxUbicacion.Text = "";
                textBoxUbicacion.ForeColor = Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(54)))), ((int)(((byte)(33)))));
            }
        }

        private void textBoxUbicacion_Leave(object sender, EventArgs e)
        {
            if (textBoxUbicacion.Text == "")
            {
                textBoxUbicacion.Text = "Ubicacion";
                textBoxUbicacion.ForeColor = Color.DarkGoldenrod;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        int posX, posY = 0;

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Colmena colmena = new Colmena();
                colmena.date = dateTimePicker1.Value;
                colmena.ubicacion = textBoxUbicacion.Text;
                colmena.tipo = comboBoxTipoColemna.Text;
                // colmena.marcos = int.Parse(textBoxNroMarcos.Text);
                colmena.marcos = int.Parse(numericUpDownMarcos.Text);
                colmena.descripcion = textBoxDescripcion.Text;
                colmena.tipo_abeja = comboBoxReina.Text;

                int i = colmenaNe.RegistrarColmena(colmena, pictureBox1);
                MessageBox.Show("Colmena Guardada " + MessageBoxButtons.OK);
                this.Hide();
                FormListarColmenas frm = new FormListarColmenas();
                frm.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ocurrio un error" + exception, "Mensaje", MessageBoxButtons.OK);
                throw;
            }
        }

        private void buttonImportar_Click_1(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
        }

        private void panelTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
    }
}
