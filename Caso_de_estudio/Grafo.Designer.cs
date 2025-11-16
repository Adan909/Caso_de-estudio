namespace Caso_de_estudio
{
    partial class Grafo
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
            this.pGrafo = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pGrafo
            // 
            this.pGrafo.Location = new System.Drawing.Point(12, 25);
            this.pGrafo.Name = "pGrafo";
            this.pGrafo.Size = new System.Drawing.Size(419, 357);
            this.pGrafo.TabIndex = 0;
            this.pGrafo.Paint += new System.Windows.Forms.PaintEventHandler(this.pGrafo_Paint);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(483, 114);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(218, 155);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnBFS_Click);
            // 
            // Grafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pGrafo);
            this.Name = "Grafo";
            this.Text = "Grafo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pGrafo;
        private System.Windows.Forms.Button btnAgregar;
    }
}