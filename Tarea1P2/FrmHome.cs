using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea1P2.Forms;

namespace Tarea1P2
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
            FrmDDA frmDDA = FrmDDA.GetInstance();
            placeForm(frmDDA);
        }

        private void placeForm(Form formulario)
        {
            pnlWrapper.Controls.Clear();                       // Quita los formulario del panel
            formulario.TopLevel = false;                       // Evita que el fomrulario se abra como ventana independiente
            formulario.FormBorderStyle = FormBorderStyle.None; // Quita botones de minimizar, maximizar, cerrar y ajuste
            formulario.Dock = DockStyle.Fill;                  // El formulario se expande en el panel
            pnlWrapper.Controls.Add(formulario);               // Muestra el formulario en el panel
            formulario.Show();
        }

        private void dDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDDA frmDDA = FrmDDA.GetInstance();
            placeForm(frmDDA);
        }

        private void bresenhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBresenham frmBresenham = FrmBresenham.GetInstance();
            placeForm(frmBresenham);
        }

        private void circuloBresenhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCircle frmCircle = FrmCircle.GetInstance();
            placeForm(frmCircle);
        }

        private void floodFillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFloodFill frmFloodFill = FrmFloodFill.GetInstance();
            placeForm(frmFloodFill);
        }
    }
}
