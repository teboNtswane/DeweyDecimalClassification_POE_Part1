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
    public partial class FindingCallNumbers : UserControl
    {
        public FindingCallNumbers()
        {
            InitializeComponent();
        }

        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// This event will take the user to the Instructions Form where they will be informed on how to play the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptnStart_Click(object sender, EventArgs e)
        {
            CallNrInstructions instruct = new CallNrInstructions();
            instruct.ShowDialog();
        }
    }
}
///-------------------------------------------->000ooo...END OF FILE...ooo000<---------------------------------------------