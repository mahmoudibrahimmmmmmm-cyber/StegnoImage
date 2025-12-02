using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stegnographyLSB
{
    public partial class CloseSplashScreen : Form
    {
        public CloseSplashScreen()
        {
            InitializeComponent();
        }

       
   
        private void ClosingTimer_Tick(object sender, EventArgs e)
        {
            ClosingTimer.Stop();
            Application.Exit();
        }
    }
}
