using DeweyDecimalClassification_POE_Part1.Forms;
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
    public partial class Instructions : UserControl
    {
        public Instructions()
        {
            InitializeComponent();
        }

        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// This event will allow the user to start the quiz after reading the instructions provided on this form before playing the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void pBtnLetsGo_Click(object sender, EventArgs e)
        {
            StartQuiz quiz = new StartQuiz();
            quiz.ShowDialog();
        }
    }
}
///-------------------------------------------->000ooo...END OF FILE...ooo000<---------------------------------------------