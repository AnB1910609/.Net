using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace PetShop
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }

        int startp = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startp += 1;
            Myprogress.Value = startp;
            PercentageLbl.Text = startp + "%";
            if (Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                Login obj = new Login();
                obj.Show();
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
