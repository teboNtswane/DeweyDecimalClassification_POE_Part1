using System;
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
    public partial class Replacing_Books : Form
    {
        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Reference: Continuation of queried result from ChatGPT
        /// Event Handlers for Buttons 1 to 10
        /// Event Handlers for Buttons A to J
        /// </summary>
        public Replacing_Books()
        {
            InitializeComponent();

            //Event Handlers for Buttons 1 to 10
            replaceBooksUserControl1.btn1.Click += new EventHandler(button_Click);
            replaceBooksUserControl1.btn2.Click += new EventHandler(button_Click);
            replaceBooksUserControl1.btn3.Click += new EventHandler(button_Click);
            replaceBooksUserControl1.btn4.Click += new EventHandler(button_Click);
            replaceBooksUserControl1.btn5.Click += new EventHandler(button_Click);
            replaceBooksUserControl1.btn6.Click += new EventHandler(button_Click);
            replaceBooksUserControl1.btn7.Click += new EventHandler(button_Click);
            replaceBooksUserControl1.btn8.Click += new EventHandler(button_Click);
            replaceBooksUserControl1.btn9.Click += new EventHandler(button_Click);
            replaceBooksUserControl1.btn10.Click += new EventHandler(button_Click);

            //Event Handlers for Buttons A to J
            replaceBooksUserControl1.btnA.Click += new EventHandler(button_Click);
            replaceBooksUserControl1.btnB.Click += new EventHandler(button_Click);
            replaceBooksUserControl1.btnC.Click += new EventHandler(button_Click);
            replaceBooksUserControl1.btnD.Click += new EventHandler(button_Click);
            replaceBooksUserControl1.btnE.Click += new EventHandler(button_Click);
            replaceBooksUserControl1.btnF.Click += new EventHandler(button_Click);
            replaceBooksUserControl1.btnG.Click += new EventHandler(button_Click);
            replaceBooksUserControl1.btnH.Click += new EventHandler(button_Click);
            replaceBooksUserControl1.btnI.Click += new EventHandler(button_Click);
            replaceBooksUserControl1.btnJ.Click += new EventHandler(button_Click);
        }


        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Button click event for all buttons that are books
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            // Invokes the Button_Click event of the ReplaceBooksUserControl 
            replaceBooksUserControl1.Button_Click(clickedButton, e);
        }
    }
}
///-------------------------------------------->000ooo...END OF FILE...ooo000<---------------------------------------------