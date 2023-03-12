using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls
{
    public partial class userDrAnaSayfa : UserControl
    {
        public userDrAnaSayfa()
        {
            InitializeComponent();
        }

        private void userDrAnaSayfa_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblTarih.Text = dateTime.ToShortDateString();
            lblSaat.Text = dateTime.Hour.ToString() + ":" + dateTime.Minute.ToString();

            
        }

    }
}
