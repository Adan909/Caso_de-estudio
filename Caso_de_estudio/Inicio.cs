using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caso_de_estudio
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void arbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tree tree = new Tree();
            tree.Show();
        }

        private void grafoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grafo grafoForm = new Grafo();
            grafoForm.Show();
        }
    }
}
