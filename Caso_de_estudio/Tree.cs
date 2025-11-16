using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caso_de_estudio
{
    public partial class Tree : Form
    {
        public Tree()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tvArbol.SelectedNode != null)
            {
                tvArbol.SelectedNode.Nodes.Add(tbElemento.Text);
            }
            else
                tvArbol.Nodes.Add(tbElemento.Text);

            tbElemento.Clear();

            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscado = tbElementoBuscado.Text.Trim();

            if (string.IsNullOrEmpty(buscado))
            {
                MessageBox.Show("Ingrese un elemento a buscar.");
                return;
            }

            TreeNode resultado = BuscarNodo(tvArbol.Nodes, buscado);

            if (resultado != null)
            {
                tvArbol.SelectedNode = resultado;
                resultado.EnsureVisible(); 
                MessageBox.Show("Elemento encontrado: " + resultado.Text);
            }
            else
            {
                MessageBox.Show("No existe en el TreeView.");
            }
        }

        private TreeNode BuscarNodo(TreeNodeCollection nodos, string texto)
        {
            foreach (TreeNode nodo in nodos)
            {
                
                if (nodo.Text.Equals(texto, StringComparison.OrdinalIgnoreCase))
                    return nodo;

                
                TreeNode encontrado = BuscarNodo(nodo.Nodes, texto);
                if (encontrado != null)
                    return encontrado;
            }

            
            return null;
        }

        private void MostrarCon_Click(object sender, EventArgs e)
        {
            tvArbol.ExpandAll();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int hijos = ContarHijosSeleccionados();

            MessageBox.Show("El nodo seleccionado tiene " + hijos + " hijos.");
        }
        private int ContarHijosSeleccionados()
        {
            if (tvArbol.SelectedNode == null)
                return 0;

            return tvArbol.SelectedNode.Nodes.Count;
        }

    }

}
