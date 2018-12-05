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
            pictureBoxPanal.Location = new Point(366, 186);
            pictureBoxPanal.Size = new Size(70, 60);
            this.pictureBoxPanal.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void pictureBoxPanal_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxPanal.Location = new Point(371, 191);
            pictureBoxPanal.Size = new Size(60, 50);
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
