using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheHackerThing
{
    public partial class frmStartup : Form
    {
        public frmStartup()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int heightForFrmIP = calculateHeightForFrmIP();

            frmIP myFrmIP = new frmIP();
            myFrmIP.Height = heightForFrmIP;

            myFrmIP.Show();
            this.Hide();
        }

        private int calculateHeightForFrmIP()
        {
            System.Drawing.Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

            int height = workingArea.Height;

            return height;
        }
    }
}
