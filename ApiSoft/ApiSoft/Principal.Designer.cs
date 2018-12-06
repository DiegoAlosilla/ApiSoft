namespace ApiSoft
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelInico = new System.Windows.Forms.Panel();
            this.pictureBoxPanal = new System.Windows.Forms.PictureBox();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelInico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPanal)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(165)))), ((int)(((byte)(3)))));
            this.panelTitulo.Controls.Add(this.pictureBox3);
            this.panelTitulo.Controls.Add(this.label1);
            this.panelTitulo.Controls.Add(this.pictureBox2);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(797, 110);
            this.panelTitulo.TabIndex = 0;
            this.panelTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(628, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(157, 82);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(54)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(248, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teresa\'s honey";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panelInico
            // 
            this.panelInico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelInico.BackgroundImage")));
            this.panelInico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelInico.Controls.Add(this.pictureBoxPanal);
            this.panelInico.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInico.Location = new System.Drawing.Point(0, 116);
            this.panelInico.Name = "panelInico";
            this.panelInico.Size = new System.Drawing.Size(797, 438);
            this.panelInico.TabIndex = 3;
            // 
            // pictureBoxPanal
            // 
            this.pictureBoxPanal.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPanal.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxPanal.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPanal.Image")));
            this.pictureBoxPanal.Location = new System.Drawing.Point(371, 191);
            this.pictureBoxPanal.Name = "pictureBoxPanal";
            this.pictureBoxPanal.Size = new System.Drawing.Size(60, 50);
            this.pictureBoxPanal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPanal.TabIndex = 0;
            this.pictureBoxPanal.TabStop = false;
            this.pictureBoxPanal.Click += new System.EventHandler(this.pictureBoxPanal_Click);
            this.pictureBoxPanal.MouseLeave += new System.EventHandler(this.pictureBoxPanal_MouseLeave);
            this.pictureBoxPanal.MouseHover += new System.EventHandler(this.pictureBoxPanal_MouseHover);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(797, 554);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelInico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelInico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPanal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelInico;
        private System.Windows.Forms.PictureBox pictureBoxPanal;
    }
}

