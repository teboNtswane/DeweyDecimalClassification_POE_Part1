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
    public partial class IdentifyAreasControl : UserControl
    {
        public IdentifyAreasControl()
        {
            InitializeComponent();
        }

        //---------------------------------------------------------------------------------------------------------------
        private void btnStart_Clicked(object sender, EventArgs e)
        {
            MatchColumns match = new MatchColumns();
            match.ShowDialog();
        }

        //---------------------------------------------------------------------------------------------------------------
        private void btnMenu_Clicked(object sender, EventArgs e)
        {
           
            IdentifyingAreas areas = new IdentifyingAreas();
            areas.Close();
        }
    }
}
///-------------------------------------------->000ooo...END OF FILE...ooo000<---------------------------------------------