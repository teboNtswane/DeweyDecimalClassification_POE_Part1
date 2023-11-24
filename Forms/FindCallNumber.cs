﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeweyDecimalClassification_POE_Part1.Forms
{
    public partial class FindCallNumber : Form
    {
        public FindCallNumber()
        {
            InitializeComponent();

            //Closes the current page
            findingCallNumbers1.pBtnBack.Click += Menu_Click;
        }

        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// This event allows the user to go back to the previous page by closing the current page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Menu_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    }
}
///-------------------------------------------->000ooo...END OF FILE...ooo000<---------------------------------------------
