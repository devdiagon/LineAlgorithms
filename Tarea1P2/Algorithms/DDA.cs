using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1P2.Algorithms
{
    internal class DDA
    {
        private Point puntoI;
        private Point puntoF;
        public List<Point> totalPoints { get; private set; }
        private float m;
        private float k;
        private Graphics graphics;

        public DDA() 
        {
            ResetValues();
        }

        private void ResetValues()
        {
            puntoF = new Point(0, 0);
            puntoI = new Point(0, 0);
            totalPoints = new List<Point>();
            m = 0; k = 0;
            graphics = null;
        }

        private void GeneratePoints()
        {
            int dx = puntoF.X - puntoI.X;
            int dy = puntoF.Y - puntoI.Y;

            m = (float) dy / dx;
            k = Math.Max(Math.Abs(dx), Math.Abs(dy));

            float xStep = 1;
            float yStep = 1;

            if (dx == 0)
            {
                xStep = 0;
                yStep = Math.Sign(dy);
            }

            if (m > 1)
            {
                xStep = 1 / m;
            }

            if(m < 1)
            {
                yStep = m;
            }

            float xPrev = puntoI.X;
            float yPrev = puntoI.Y;

            for (int i = 0; i <= k; i++)
            {
                Point pk = new Point((int)Math.Round(xPrev), (int)Math.Round(yPrev));
                totalPoints.Add(pk);

                xPrev += xStep;
                yPrev += yStep;
            }
        }

        public async Task DrawLine(PictureBox picCanvas, int delay)
        {
            Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            graphics = Graphics.FromImage(bmp);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            for (int i = 0; i <= k; i++)
            {
                int x = totalPoints[i].X;
                int y = totalPoints[i].Y;
                if (x >= 0 && x < bmp.Width && y >= 0 && y < bmp.Height)
                {
                    bmp.SetPixel(totalPoints[i].X, totalPoints[i].Y, Color.Red);
                    picCanvas.Image = (Bitmap)bmp.Clone();
                    await Task.Delay(delay);
                }
            }

            picCanvas.Image = bmp;
        }

        public void SetDGVPoints(DataGridView table)
        {
            table.Rows.Clear();
            foreach (Point p in totalPoints)
            {
                table.Rows.Add(p.X, p.Y);
            }
        }

        public bool ReadData(TextBox txtInputXi, TextBox txtInputXf, TextBox txtInputYi, TextBox txtInputYf)
        {
            try
            {
                int xi = int.Parse(txtInputXi.Text);
                int xf = int.Parse(txtInputXf.Text);
                int yi = int.Parse(txtInputYi.Text);
                int yf = int.Parse(txtInputYf.Text);

                if(xi < 0 || xf < 0 || yi < 0 || yf < 0)
                {
                    MessageBox.Show("Ninguna de las coordenadas puede ser negativa", "Mensaje de error");
                    return false;
                }

                puntoI = new Point(xi, yi);
                puntoF = new Point(xf, yf);

                totalPoints.Clear();
                GeneratePoints();

                return true;
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
                return false;
            }
        }

        public void InitializeData(
            TextBox txtInputXi, TextBox txtInputYi,
            TextBox txtInputXf, TextBox txtInputYf,
            TrackBar trbVel, PictureBox picCanvas,
            DataGridView table)
        {
            ResetValues();

            txtInputXi.Text = ""; txtInputYi.Text = "";
            txtInputXf.Text = ""; txtInputYf.Text = "";
            trbVel.Value = 100;

            picCanvas.Image = null;

            table.Rows.Clear();

            txtInputXi.Focus();
        }
    }
}
