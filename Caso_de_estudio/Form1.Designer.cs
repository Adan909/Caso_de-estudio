namespace Caso_de_estudio
{
    partial class Form1
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
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.tbElemento = new System.Windows.Forms.TextBox();
            this.MostrarCon = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnContar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbElementoBuscado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tvArbol
            // 
            this.tvArbol.Location = new System.Drawing.Point(21, 23);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.Size = new System.Drawing.Size(288, 314);
            this.tvArbol.TabIndex = 0;
            // 
            // tbElemento
            // 
            this.tbElemento.Location = new System.Drawing.Point(346, 51);
            this.tbElemento.Name = "tbElemento";
            this.tbElemento.Size = new System.Drawing.Size(163, 20);
            this.tbElemento.TabIndex = 1;
            // 
            // MostrarCon
            // 
            this.MostrarCon.Location = new System.Drawing.Point(346, 107);
            this.MostrarCon.Name = "MostrarCon";
            this.MostrarCon.Size = new System.Drawing.Size(132, 23);
            this.MostrarCon.TabIndex = 2;
            this.MostrarCon.Text = "Mostrar Conexiones";
            this.MostrarCon.UseVisualStyleBackColor = true;
            this.MostrarCon.Click += new System.EventHandler(this.MostrarCon_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(546, 172);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(346, 223);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(75, 23);
            this.btnContar.TabIndex = 4;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(568, 48);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbElementoBuscado
            // 
            this.tbElementoBuscado.Location = new System.Drawing.Point(346, 172);
            this.tbElementoBuscado.Name = "tbElementoBuscado";
            this.tbElementoBuscado.Size = new System.Drawing.Size(163, 20);
            this.tbElementoBuscado.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbElementoBuscado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.MostrarCon);
            this.Controls.Add(this.tbElemento);
            this.Controls.Add(this.tvArbol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvArbol;
        private System.Windows.Forms.TextBox tbElemento;
        private System.Windows.Forms.Button MostrarCon;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbElementoBuscado;
    }
}

