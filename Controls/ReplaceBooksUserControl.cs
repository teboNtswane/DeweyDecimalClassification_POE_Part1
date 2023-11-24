using DeweyDecimalClassification_POE_Part1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeweyDecimalClassification_POE_Part1.Controls
{
    public partial class ReplaceBooksUserControl : UserControl
    {
        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// These lists are used to to store the data received from the randomly generated values, the sorted generated values and the user's ordered values from the buttons selected.
        /// </summary>
        List<string> generateList = new List<string>();
        List<string> sortedList = new List<string>();
        List<string> userInputList = new List<string>();

        //Button delared for user selection
        Button selectedButton;
        public ReplaceBooksUserControl()
        {
            InitializeComponent();
            SetButtonText();
        }

        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// This method will change the buttons' texts and set them to the random values when the user opens the Replacing Books page.
        /// </summary>
        public void SetButtonText()
        {
            Random rand = new Random();
            RandomGenerator generate = new RandomGenerator();

            for (int j = 0; j < 10; j++)
            {
                var random = generate.RandomNumGenetrator(rand);
                generateList.Add(random);

            }

            //Sets buttons texts to strings from generated list 
            btnA.Text = generateList[0].ToString();
            btnB.Text = generateList[1].ToString();
            btnC.Text = generateList[2].ToString();
            btnD.Text = generateList[3].ToString();
            btnE.Text = generateList[4].ToString();
            btnF.Text = generateList[5].ToString();
            btnG.Text = generateList[6].ToString();
            btnH.Text = generateList[7].ToString();
            btnI.Text = generateList[8].ToString();
            btnJ.Text = generateList[9].ToString();

            //Hides picture boxes initially
            pBoxCorrect.Visible = false;
            pBoxIncorrect.Visible = false;

        }

        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Reference: ChatGPT
        /// Chat Query:
        /// Write down the step-by-step code on how to select 5 different buttons and replace each button (including each button's text) with the 5 other buttons that were initially selected in window Forms c#. The buttons A to E should be able slide to buttons F to j. Buttons F to J must not move from their position, only buttons A to E may move. For example, when button A is selected and you select button F after, button A must slide (vertical and/or diagonally) or visibly move to button F during the selection and should stop directly at button F's position.  Button F's text must also be replaced with button A's text. The same thing should happen if you select A then Select J or any other button from F to J.
        /// 
        /// Result:
        /// This method handles all button events. Selected buttons' text will swap with Clicked buttons' text based on the user's order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;



            if (selectedButton == null)
            {
                selectedButton = clickedButton;
                selectedButton.BackColor = SystemColors.Highlight;
                clickedButton.Enabled = false;
                return;
            }


            if (selectedButton != clickedButton)
            {
                // Swaps the text of the selected button with the clicked button
                string tempText = selectedButton.Text;
                selectedButton.Text = clickedButton.Text;
                clickedButton.Text = tempText;
                

                // Resets the background color of the selected button
                selectedButton.BackColor = SystemColors.Control;
                clickedButton.Enabled = false;
               

                // Swaps the positions of the selected button and the clicked button
                int tempIndex = Controls.IndexOf(clickedButton);
                Controls.SetChildIndex(selectedButton, tempIndex);

                selectedButton = null;


            }

            // Adds the users order of buttons to the List
            if (clickedButton == btn1 || clickedButton == btn2 || clickedButton == btn3 || clickedButton == btn4 || clickedButton == btn5 || clickedButton == btn6 || clickedButton == btn7 || clickedButton == btn8 || clickedButton == btn9 || clickedButton == btn10)
            {
                userInputList.Add(clickedButton.Text);

            }

        }

        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// The method will display the sorted elements in the List
        /// </summary>
        /// <param name="sorted"></param>
        public void DisplaySort(List<string> sorted)
        {

            foreach (string s in sorted)
            {

                lboxSorted.Items.Add(s);
            }

            Console.WriteLine();
        }

        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Reference: W3Resource
        /// URL:https://www.w3resource.com/csharp-exercises/string/csharp-string-exercise-12.php
        /// Use: The method uses the Bubble Sort Algorithm to sort the elements in the List in ascending order
        /// </summary>
        /// <returns></returns>
        public List<string> BubbleSort()
        {

            for (int s = 0; s < generateList.Count; s++)
            {
                sortedList.Add((string)generateList[s]);
            }
            string temp;

            for (int i = 0; i < sortedList.Count; i++)
            {
                for (int j = 0; j < sortedList.Count - 1; j++)
                {
                    if (sortedList[j].CompareTo(sortedList[j + 1]) > 0)
                    {
                        temp = sortedList[j];
                        sortedList[j] = sortedList[j + 1];
                        sortedList[j + 1] = temp;
                    }
                }
            }

            return sortedList;
        }

        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Reference:  C Sharp Corner - Compare Two Lists Using SequenceEquals - Keshav Singh
        /// URL: https://www.c-sharpcorner.com/blogs/compare-two-lists-using-sequenceequals1
        /// Use: This button will compare the userInputList with the Sorted List to check if the user's order of books in in ascending order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheck_Click(object sender, EventArgs e)
        {
            List<string> sortedList = BubbleSort();
            DisplaySort(sortedList);
            bool compareList = (userInputList == sortedList);

            compareList = userInputList.SequenceEqual(sortedList);
            if (compareList)
            {
                pBoxCorrect.Visible = true;
                tmrRemaining.Stop();
                pBCongrats.Visible = true;
                pbWin.Visible = true;
            }
            else if (!compareList)
            {
                pBoxIncorrect.Visible = true;
                tmrRemaining.Stop();
               
            }
        }


        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// This button resets all buttons and lists and hides the Correct and Incorrect Picture Boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetry_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            SetButtonText();
            //generateList.Clear();
            //sortedList.Clear();
            //userInputList.Clear();
            //lblTime.Text = null;
            ////resets timer
            //tmrRemaining.Dispose();
            //tmrRemaining.Start();

            //btn1.Text = null;
            //btn2.Text = null;
            //btn3.Text = null;
            //btn4.Text = null;
            //btn5.Text = null;
            //btn6.Text = null;
            //btn7.Text = null;
            //btn8.Text = null;
            //btn9.Text = null;
            //btn10.Text = null;

            //btnA.Enabled = true;
            //btnB.Enabled = true;
            //btnC.Enabled = true;
            //btnD.Enabled = true;
            //btnE.Enabled = true;
            //btnF.Enabled = true;
            //btnG.Enabled = true;
            //btnH.Enabled = true;
            //btnI.Enabled = true;
            //btnJ.Enabled = true;

            //pBoxCorrect.Visible = false;
            //pBoxIncorrect.Visible = false;

            //lboxSorted.Items.Clear();

            //SetButtonText();

        }

        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Reference: Computing Academy
        /// URL: https://www.youtube.com/watch?v=DDXC0juDBhg
        /// Use: The timer feature is added to make the player sort the books correctly before time runs out
        /// </summary>
        int timeRemaining = 55;
        private void tmrRemaining_Tick(object sender, EventArgs e)
        {
            if(timeRemaining > 0)
            {
                btnRetry.Enabled = true;
                timeRemaining = timeRemaining - 1;
                lblTime.Text = timeRemaining + " " + "Seconds";
                
            }
            else
            {
                btnCheck.Enabled = false;
                timeRemaining = 55;
                pBlost.Visible = true;
                pBOutOfTime.Visible = true;
            }
        }
    }
}
///-------------------------------------------->000ooo...END OF FILE...ooo000<---------------------------------------------