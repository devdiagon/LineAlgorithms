using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea1P2.Algorithms;

namespace Tarea1P2.Forms
{
    public partial class FrmBresenham : Form
    {
        private Bresenham ObjBres = new Bresenham();
        private static FrmBresenham instance;

        public static FrmBresenham GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmBresenham();
            }
            return instance;
        }
        private FrmBresenham()
        {
            InitializeComponent();
            dgvPoints.Columns.Add("X", "X");
            dgvPoints.Columns.Add("Y", "Y");
        }

        private void velocityScroll(object sender, EventArgs e)
        {
            float velocity = (trbVel.Value);

            lblVelValue.Text = $"{velocity:0} ms";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjBres.InitializeData(txtInXi, txtInYi, txtInXf, txtInYf, trbVel, picCanvas, dgvPoints);
            lblVelValue.Text = "50 ms";
        }

        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            bool validInput = ObjBres.ReadData(txtInXi, txtInXf, txtInYi, txtInYf);
            if (validInput)
            {
                ObjBres.SetDGVPoints(dgvPoints);

                int delay = int.Parse(trbVel.Value.ToString());
                await ObjBres.DrawLine(picCanvas, delay);
                return;
            }
        }
    }
}
