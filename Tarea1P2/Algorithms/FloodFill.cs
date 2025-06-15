using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1P2.Algorithms
{
    internal class FloodFill
    {
        public int r { get; private set; }
        public List<Point> totPixels { get; private set; }

        public FloodFill()
        {
            ResetValues();
        }

        public async Task FillFigure(PictureBox picCanvas, Bitmap bmp, Point origin, Color targetColor, Color newColor, int delay, DataGridView table)
        {
            totPixels.Clear();
            table.Rows.Clear();

            if (origin.X < 0 || origin.Y < 0 || origin.X >= bmp.Width || origin.Y >= bmp.Height)
                return;

            Stack<Point> stack = new Stack<Point>();
            stack.Push(origin);

            while (stack.Count > 0)
            {
                Point p = stack.Pop();

                if (p.X < 0 || p.Y < 0 || p.X >= bmp.Width || p.Y >= bmp.Height)
                    continue;

                if (bmp.GetPixel(p.X, p.Y).ToArgb() != targetColor.ToArgb())
                    continue;

                bmp.SetPixel(p.X, p.Y, newColor);

                totPixels.Add(p);
                table.Rows.Add(p.X, p.Y);

                picCanvas.Invalidate();
                await Task.Delay(delay);

                stack.Push(new Point(p.X + 1, p.Y));
                stack.Push(new Point(p.X - 1, p.Y));
                stack.Push(new Point(p.X, p.Y + 1));
                stack.Push(new Point(p.X, p.Y - 1));
            }
        }

        private void ResetValues()
        {
            totPixels = new List<Point>();
            r = 0;
        }

        public bool ReadData(TextBox txtInputRadius, Bitmap canvas, Point center)
        {
            try
            {
                r = int.Parse(txtInputRadius.Text);

                if (r <= 0)
                {
                    MessageBox.Show("El radio no puede ser menor o igual a cero", "Mensaje de error");
                    return false;
                }

                Graphics graphics = Graphics.FromImage(canvas);
                graphics.Clear(Color.White);
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                graphics.DrawEllipse(Pens.Black, center.X - r, center.Y-r, r * 2, r * 2);

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
            trbVel.Value = 0;

            picCanvas.Image = null;

            table.Rows.Clear();

            txtInputRadius.Focus();
        }
    }
}
