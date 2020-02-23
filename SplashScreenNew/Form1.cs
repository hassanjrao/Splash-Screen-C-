using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreenNew
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
            this.progressBar1.Minimum = 1;
            this.progressBar1.Maximum = 100;
            this.progressBar1.Value = 1;
        }
        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval++;
            if (timer1.Interval == 200)
            {
                timer1.Stop();
                this.Hide();
                Form2 f2obj = new Form2();
                f2obj.Visible = true;
            }
            else
                this.progressBar1.Value++;
        }
    }
}
