using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stegnographyLSB
{
    public partial class StartSplashScreen1 : Form
    {
        public StartSplashScreen1()
        {
            InitializeComponent();
            
        }



       

        private void WaitingTimer_Tick(object sender, EventArgs e)
        {
            WaitingTimer.Stop();
            this.Hide();
            StegnoImage MainAppScreen = new StegnoImage();
            MainAppScreen.Show();
        }

        private void txtLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
