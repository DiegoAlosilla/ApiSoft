namespace ApiSoft
{
    partial class FormListarColmenas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewColmenas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColmenas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewColmenas
            // 
            this.dataGridViewColmenas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewColmenas.Location = new System.Drawing.Point(23, 35);
            this.dataGridViewColmenas.Name = "dataGridViewColmenas";
            this.dataGridViewColmenas.Size = new System.Drawing.Size(566, 338);
            this.dataGridViewColmenas.TabIndex = 0;
            // 
            // FormListarColmenas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewColmenas);
            this.Name = "FormListarColmenas";
            this.Text = "FormListarColmenas";
            this.Load += new System.EventHandler(this.FormListarColmenas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColmenas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewColmenas;
    }
}