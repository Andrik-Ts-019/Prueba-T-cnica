using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invertir_Cadena
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void TimerSS_Tick(object sender, EventArgs e)
        {
            if (timerSS != null)
            {
                timerSS.Stop();
                timerSS.Enabled = false;

                Home home = new()
                {
                    splashScreenForm = this
                };

                home.Show();

                this.Hide();
            }
        }
    }
}
