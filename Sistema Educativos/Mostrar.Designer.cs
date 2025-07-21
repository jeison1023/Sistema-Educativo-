namespace Sistema_Educativos
{
    partial class Mostrar
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
            this.dgvMostrarDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrarDatos
            // 
            this.dgvMostrarDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarDatos.Location = new System.Drawing.Point(26, 12);
            this.dgvMostrarDatos.Name = "dgvMostrarDatos";
            this.dgvMostrarDatos.RowHeadersWidth = 51;
            this.dgvMostrarDatos.RowTemplate.Height = 24;
            this.dgvMostrarDatos.Size = new System.Drawing.Size(793, 532);
            this.dgvMostrarDatos.TabIndex = 0;
            this.dgvMostrarDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarDatos_CellContentClick);
            // 
            // Mostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 556);
            this.Controls.Add(this.dgvMostrarDatos);
            this.Name = "Mostrar";
            this.Text = "Mostrar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrarDatos;
    }
}