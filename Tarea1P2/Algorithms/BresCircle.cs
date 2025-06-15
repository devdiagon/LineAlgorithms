using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1P2.Algorithms
{
    internal class BresCircle
    {
        private int r;
        private int xc;
        private int yc;
        public List<Point> totalPoints { get; private set; }
        private Graphics graphics;

        public BresCircle()
        {
            ResetValues();
        }

        private void ResetValues()
        {
            totalPoints = new List<Point>();
            r = 0; xc = 0; yc = 0;
            graphics = null;
        }

        private void GeneratePoints()
        {
            int x = 0;
            int y = r;
            int p = 1 - r;

            while (x <= y)
            {
                totalPoints.Add(new Point(xc + x, yc + y));
                totalPoints.Add(new Point(xc - x, yc + y));
                totalPoints.Add(new Point(xc + x, yc - y));
                totalPoints.Add(new Point(xc - x, yc - y));
                totalPoints.Add(new Point(xc + y, yc + x));
                totalPoints.Add(new Point(xc - y, yc + x));
                totalPoints.Add(new Point(xc + y, yc - x));
                totalPoints.Add(new Point(xc - y, yc - x));

                x++;
                if (p < 0)
                {
                    p += 2 * x + 1;
                }
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }
            }
        }

        public async Task DrawCircle(PictureBox picCanvas, int delay)
        {
            Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            graphics = Graphics.FromImage(bmp);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            foreach (Point p in totalPoints)
            {
                if (p.X >= 0 && p.X < bmp.Width && p.Y >= 0 && p.Y < bmp.Height)
                {
                    bmp.SetPixel(p.X, p.Y, Color.Black);
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

        public bool ReadData(TextBox txtInputRadius, PictureBox picCanvas)
        {
            try
            {
                r = int.Parse(txtInputRadius.Text);

                if (r <= 0)
                {
                    MessageBox.Show("El radio no puede ser menor o igual a cero", "Mensaje de error");
                    return false;
                }

                xc = picCanvas.Width / 2;
                yc = picCanvas.Height / 2;

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
            TextBox txtInputRadius,
            TrackBar trbVel, PictureBox picCanvas,
            DataGridView table)
        {
            ResetValues();

            txtInputRadius.Text = "";
            trbVel.Value = 5;

            picCanvas.Image = null;

            table.Rows.Clear();

            txtInputRadius.Focus();
        }
    }
}
