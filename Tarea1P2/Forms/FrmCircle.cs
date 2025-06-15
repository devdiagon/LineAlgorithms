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
    public partial class FrmCircle : Form
    {
        private BresCircle ObjBresCir = new BresCircle();
        private static FrmCircle instance;

        public static FrmCircle GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmCircle();
            }
            return instance;
        }
        private FrmCircle()
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
            ObjBresCir.InitializeData(txtInRadius, trbVel, picCanvas, dgvPoints);
            lblVelValue.Text = "5 ms";
        }

        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            bool validInput = ObjBresCir.ReadData(txtInRadius, picCanvas);
            if (validInput)
            {
                ObjBresCir.SetDGVPoints(dgvPoints);

                int delay = int.Parse(trbVel.Value.ToString());
                await ObjBresCir.DrawCircle(picCanvas, delay);
            }
        }
    }
}
