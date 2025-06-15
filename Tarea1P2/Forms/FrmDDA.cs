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
using static System.Windows.Forms.MonthCalendar;

namespace Tarea1P2.Forms
{
    public partial class FrmDDA : Form
    {
        private DDA ObjDAA = new DDA();
        private static FrmDDA instance;

        public static FrmDDA GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmDDA();
            }
            return instance;
        }
        private FrmDDA()
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
            ObjDAA.InitializeData(txtInXi, txtInYi, txtInXf, txtInYf, trbVel, picCanvas, dgvPoints);
            lblVelValue.Text = "100 ms";
        }

        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            bool validInput = ObjDAA.ReadData(txtInXi, txtInXf, txtInYi, txtInYf);
            if (validInput)
            {
                ObjDAA.SetDGVPoints(dgvPoints);

                int delay = int.Parse(trbVel.Value.ToString());
                await ObjDAA.DrawLine(picCanvas, delay);
                return;
            }
        }
    }
}
