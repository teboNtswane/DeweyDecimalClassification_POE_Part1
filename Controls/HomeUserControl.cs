﻿using DeweyDecimalClassification_POE_Part1.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeweyDecimalClassification_POE_Part1.Controls
{
    public partial class HomeUserControl : UserControl
    {
        public HomeUserControl()
        {
            InitializeComponent();
        }

        private void btnReplaceBook_Click(object sender, EventArgs e)
        {

            Replacing_Books books = new Replacing_Books();
            WelcomeWindow welcome = new WelcomeWindow();
            welcome.Hide();
            books.ShowDialog();
        }

        private void btnIdentifyAreas_Click(object sender, EventArgs e)
        {
            IdentifyingAreas areas = new IdentifyingAreas();
            WelcomeWindow welcome = new WelcomeWindow();
            welcome.Hide();
            areas.ShowDialog();
        }

        private void btnFindCall_Click(object sender, EventArgs e)
        {
            FindCallNumber find = new FindCallNumber();
            find.ShowDialog();
        }
    }
}
