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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        int posX, posY = 0;
        private void pictureBoxPanal_MouseHover(object sender, EventArgs e)
        {
            pictureBoxPanal.Location = new Point(352, 175);
            pictureBoxPanal.Size = new Size(95, 83);
            this.pictureBoxPanal.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void pictureBoxPanal_MouseLeave(object sender, EventArgs e)
        {
          
            pictureBoxPanal.Location = new Point(357, 180);
            pictureBoxPanal.Size = new Size(85, 73);
        }

        private void pictureBoxPanal_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListarColmenas fmr = new FormListarColmenas();
            fmr.ShowDialog();
            
        }

        private void panelTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button!= MouseButtons.Left)
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
