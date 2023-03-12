﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.AccessDb;
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
    public partial class userBransaGoreGrafik : UserControl
    {
        public userBransaGoreGrafik()
        {
            InitializeComponent();
        }
         SekreterRepository sekreterRepository = new SekreterRepository();
        SekreterManager sekreterManager = new SekreterManager(new SekreterRepository());
        private void userBransaGoreGrafik_Load(object sender, EventArgs e)
        {
            chartBransaGoreHasta= sekreterManager.BransaGoreHastaSayisiGrafigiGetir(chartBransaGoreHasta);
            //chartBransaGoreHasta= sekreterRepository.BransaGoreHastaSayisiGrafigiGetir(chartBransaGoreHasta);
        }
    }
}
