using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Caso_de_estudio
{
    public partial class Grafo : Form
    {
        CodGrafo g = new CodGrafo();
        Random rnd = new Random();

        public Grafo()
        {
            InitializeComponent();

            // Suscribir eventos
            pGrafo.Paint += pGrafo_Paint;
            btnAgregar.Click += btnAgregar_Click; // Solo un botón
            

            // Tamaño mínimo del panel
            if (pGrafo.Width < 300) pGrafo.Width = 500;
            if (pGrafo.Height < 200) pGrafo.Height = 400;
        }

        // --- Prompt para pedir texto al usuario ---
        public static string Prompt(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label textLabel = new Label() { Left = 10, Top = 20, Text = text, Width = 260 };
            TextBox inputBox = new TextBox() { Left = 10, Top = 50, Width = 260 };
            Button confirmation = new Button() { Text = "Ok", Left = 100, Width = 80, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : "";
        }

        // --- Botón único: agregar nodo o arista ---
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string opcion = Prompt("¿Desea agregar Nodo (N) o Arista (A)?", "Agregar");
            if (string.IsNullOrEmpty(opcion)) return;

            opcion = opcion.ToUpper();

            if (opcion == "N") // Nodo
            {
                string nombre = Prompt("Nombre del nodo:", "Agregar Nodo");
                if (!string.IsNullOrEmpty(nombre) && !g.Ady.ContainsKey(nombre))
                {
                    int ancho = pGrafo.Width > 0 ? pGrafo.Width : 500;
                    int alto = pGrafo.Height > 0 ? pGrafo.Height : 400;

                    Point p = new Point(rnd.Next(50, ancho - 50), rnd.Next(50, alto - 50));
                    g.AgregarNodo(nombre, p);
                    pGrafo.Invalidate();
                }
            }
            else if (opcion == "A") // Arista
            {
                string origen = Prompt("Nodo origen:", "Agregar Arista");
                string destino = Prompt("Nodo destino:", "Agregar Arista");

                if (g.Ady.ContainsKey(origen) && g.Ady.ContainsKey(destino))
                {
                    g.AgregarArista(origen, destino);
                    pGrafo.Invalidate();
                }
            }
        }

        
        private void btnBFS_Click(object sender, EventArgs e)
        {
           

            
        }

        // --- Dibujar grafo ---
        private void pGrafo_Paint(object sender, PaintEventArgs e)
        {
            Graphics gph = e.Graphics;
            gph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Pen lapiz = new Pen(Color.Black, 2);
            Brush nodoColor = Brushes.LightBlue;
            Font fuente = new Font("Arial", 12);
            int radio = 20;

            // Dibujar aristas sin duplicados
            HashSet<string> dibujadas = new HashSet<string>();
            foreach (var n in g.Ady)
            {
                foreach (var vecino in n.Value)
                {
                    string key = n.Key + "-" + vecino;
                    string keyInv = vecino + "-" + n.Key;
                    if (!dibujadas.Contains(key) && !dibujadas.Contains(keyInv))
                    {
                        gph.DrawLine(lapiz, g.Pos[n.Key], g.Pos[vecino]);
                        dibujadas.Add(key);
                    }
                }
            }

            // Dibujar nodos
            foreach (var n in g.Ady)
            {
                Point p = g.Pos[n.Key];
                gph.FillEllipse(nodoColor, p.X - radio, p.Y - radio, radio * 2, radio * 2);
                gph.DrawEllipse(Pens.Black, p.X - radio, p.Y - radio, radio * 2, radio * 2);
                gph.DrawString(n.Key, fuente, Brushes.Black, p.X - 10, p.Y - 10);
            }
        }
    }
}
