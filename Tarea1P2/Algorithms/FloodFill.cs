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
        private Graphics graphics;

        public FloodFill()
        {
            ResetValues();
        }

        public void FillFigure(Bitmap bmp, int x, int y, Color targetColor, Color newColor)
        {
            totPixels.Clear();

            graphics = Graphics.FromImage(bmp);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (x < 0 || y < 0 || x >= bmp.Width || y >= bmp.Height)
                return;

            Stack<Point> stack = new Stack<Point>();
            stack.Push(new Point(x, y));

            while (stack.Count > 0)
            {
                Point p = stack.Pop();

                if (p.X < 0 || p.Y < 0 || p.X >= bmp.Width || p.Y >= bmp.Height)
                    continue;

                if (bmp.GetPixel(p.X, p.Y).ToArgb() != targetColor.ToArgb())
                    continue;

                bmp.SetPixel(p.X, p.Y, newColor);
                totPixels.Add(p);

                stack.Push(new Point(p.X + 1, p.Y));
                stack.Push(new Point(p.X - 1, p.Y));
                stack.Push(new Point(p.X, p.Y + 1));
                stack.Push(new Point(p.X, p.Y - 1));
            }
        }

        private void ResetValues()
        {
            totPixels = new List<Point>();
            graphics = null;
        }

        public void SetDGVPoints(DataGridView table)
        {
            table.Rows.Clear();
            foreach (Point p in totPixels)
            {
                table.Rows.Add(p.X, p.Y);
            }
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

                graphics = Graphics.FromImage(canvas);
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
            trbVel.Value = 1;

            picCanvas.Image = null;

            table.Rows.Clear();

            txtInputRadius.Focus();
        }
    }
}
