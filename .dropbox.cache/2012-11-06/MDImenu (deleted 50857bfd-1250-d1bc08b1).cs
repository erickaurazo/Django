using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace rSunat.ReportesSunat.Presentacion
{
    public partial class MDImenu : Form
    {
        private int childFormNumber = 0;

        public MDImenu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }


        private void libroMayorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarReporte frmLibroDiarioMayor = new frmConsultarReporte();
            //frmLibroDiarioMayor.MdiParent = this;
            // Para mostrarlo maximizado:
            // frmLibroDiarioMayor.WindowState = FormWindowState.Maximized;
            frmLibroDiarioMayor.Show();
        }

        private void registroDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroComprasVentas frmRegistroComprasVentas = new frmRegistroComprasVentas();
            //frmRegistroComprasVentas.MdiParent = this;
            // Para mostrarlo maximizado:
            //frmRegistroComprasVentas.WindowState = FormWindowState.Maximized;
            frmRegistroComprasVentas.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizarTodasLasVentanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                this.MdiChildren[i].WindowState = FormWindowState.Minimized;
            }
        }

        private void libroDeKARDEXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLibroKARDEX frmLibroKARDEX = new frmLibroKARDEX();
            //frmLibroKARDEX.MdiParent = this;
            // Para mostrarlo maximizado:
            //frmLibroKARDEX.WindowState = FormWindowState.Maximized;
            frmLibroKARDEX.Show();

        }
    }
}
