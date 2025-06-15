using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace Tarea1P2.Forms
{
    public partial class FrmDDA : Form
    {
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
        }


        private void velocityScroll(object sender, EventArgs e)
        {
            float velocity = (trbVel.Value);

            lblVelValue.Text = $"{velocity:0} ms";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblVelValue.Text = "100 ms";
        }
    }
}
