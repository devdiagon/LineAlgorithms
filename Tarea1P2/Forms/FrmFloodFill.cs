using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea1P2.Algorithms;

namespace Tarea1P2.Forms
{
    public partial class FrmFloodFill : Form
    {
        private FloodFill ObjFlood = new FloodFill();
        private static FrmFloodFill instance;
        private bool generatedCircle = false;
        private bool painted = false;
        private Bitmap canvas;
        private Point center;


        public static FrmFloodFill GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmFloodFill();
            }
            return instance;
        }
        private FrmFloodFill()
        {
            InitializeComponent();
            dgvPoints.Columns.Add("X", "X");
            dgvPoints.Columns.Add("Y", "Y");
            center = new Point(picCanvas.Width / 2, picCanvas.Height / 2);

            canvas = new Bitmap(picCanvas.Width, picCanvas.Height);
        }

        private void velocityScroll(object sender, EventArgs e)
        {
            float velocity = (trbVel.Value);

            lblVelValue.Text = $"{velocity:0} ms";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjFlood.InitializeData(txtInRadius, trbVel, picCanvas, dgvPoints);
            lblVelValue.Text = "0 ms";
            generatedCircle = false;
            painted = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            painted = false;
            generatedCircle = ObjFlood.ReadData(txtInRadius, canvas, center);
            picCanvas.Image = canvas;
        }

        private async void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (!generatedCircle)
            {
                MessageBox.Show("Debe generar un círculo primero", "Mensaje de error");
                return;
            }

            if (!InsideCircle(e.Location))
            {
                MessageBox.Show("Punto de inicio fuera del círculo", "Mensaje de error");
                return;
            }

            if (painted)
            {
                MessageBox.Show("Cree otro círculo para volver a pintar", "Mensaje de error");
                return;
            }

            int delay = int.Parse(trbVel.Value.ToString());
            Color target = canvas.GetPixel(e.X, e.Y);
            Point origin = new Point(e.X, e.Y);

            await ObjFlood.FillFigure(picCanvas, canvas, origin, target, Color.Green, delay, dgvPoints);
            painted = true;
        }

        private bool InsideCircle(Point point)
        {
            int radius = ObjFlood.r;

            int dx = point.X - center.X;
            int dy = point.Y - center.Y;

            return (dx * dx + dy * dy) <= (radius * radius);
        }
    }
}
