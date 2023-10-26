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
    public partial class MatchColumnsControl : UserControl
    {
        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Reference: ChatGPT
        /// Chat Query:
        /// Write the step by step code in win Forms C# Visual studio on how to do the following: When the user runs the application, they should be presented with a user interface where they will match two columns: call number (top level only) and description. The user interface should consist of listBox with call numbers as their items to be matched with other listBox  with the description as their items. Store the call numbers and their descriptions in a dictionary. The user shall be allowed to answer as many questions* as they want to. Each question should have four randomly selected items in the first column of items in the listbox, and seven possible answers (three of which are incorrect) in the second column of the listBox. These questions should be based on the Dewey Decimal System, where the user matches the call number(e.g 100) with the description(e.g. "Philosophy & Psychology").  The questions on the listBoxs' items should alternate between matching 7 descriptions (Listbox A) to 4 call numbers (Listbox B) and 7 call numbers(Listbox A) to 4 descriptions (Listbox B). When the user selects an item in ListBox A (call number) and selects another items in ListBox B (description), the application should store the user's selection in a dictionary. Make sure that the items in each list box should be unclickable or change colout to indicated if the user is correct or incorrect. The application should validate for any duplicate call numbers and descriptions and also have a Check Answer button to check if the user's matching is correct, and a Try Again button to allow the user to try again. 
        /// Result:
        /// This application allows users to match call numbers with descriptions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        // To store call numbers and descriptions
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        // To store user's selections
        Dictionary<string, string> userSelections = new Dictionary<string, string>();
        // Random number generator
        Random random = new Random();
        // Toggle the state of the boolean variables
        private bool isSwaped = false;
        private int count;
        public MatchColumnsControl()
        {
            InitializeComponent();
            GenerateRandomQuestions();
           // Swap();


        }

        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// This method is used for storing category data in the dictionary
        /// </summary>
        private void Categories()
        {
            dictionary = new Dictionary<string, string>
            {
                {"000", "General Knowlege"},
                {"100", "Philosophy & Psychology"},
                {"200", "Religion"},
                {"300", "Social Sciences"},
                {"400", "Languages"},
                {"500", "Science"},
                {"600", "Technology"},
                {"700", "Art & Recreation"},
                {"800", "Literature"},
                {"900", "History & Geography"},
            };
        }

        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Ref: ChatGPT
        /// This method will be used to alternate between descriptions to call numbers and call numbers to descriptions.
        /// Note: Due to logic error, this method will be put on hold.
        /// </summary>
        private void Swap()
        {
            int swap = count % 2;
            if (swap == 0)
            {
                isSwaped = true;
                GenerateRandomQuestions();
            }
            else
            {
                isSwaped = false;
                GenerateNewQuestions();
            }
        }

        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Ref: ChatGPT
        /// This method generates random questions and randomly populates the keys and values from the dictionary into the list boxes for Call Numbers and Descriptions. This method genrates 7 random call numbers and 7 random descriiptions
        /// </summary>
        private void GenerateNewQuestions()
        {
            Categories();
            // Clear previous selections
            userSelections.Clear();

            // Get four random call numbers
            var callNumbers = dictionary.Keys.OrderBy(x => random.Next()).Take(7).ToList();


            // Get seven random descriptions, including three incorrect ones
            var descriptions = dictionary.Values.OrderBy(x => random.Next()).Take(4).ToList();
            descriptions.Insert(random.Next(4), dictionary[callNumbers[0]]);
            //descriptions.Insert(random.Next(5, 8), dictionary[callNumbers[1]]);
            // descriptions.Insert(random.Next(6, 9), dictionary[callNumbers[2]]);

            // Remove duplicates from listBoxDescriptions
            List<string> uniqueDescriptions = new List<string>();
            foreach (var description in descriptions)
            {
                if (!uniqueDescriptions.Contains(description))
                    uniqueDescriptions.Add(description);
            }

            // Clear and repopulate the listBoxDescriptions
            listBoxDescriptions.Items.Clear();
            foreach (var description in uniqueDescriptions)
            {
                listBoxCallNumbers.Items.Add(description);
            }

            // Populate the listBoxCallNumbers
            listBoxCallNumbers.Items.Clear();
            foreach (var number in callNumbers)
            {
                listBoxDescriptions.Items.Add(number);
            }
        }

        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Ref: ChatGPT
        /// This method generates random questions and randomly populates the keys and values from the dictionary into the list boxes for Call Numbers and Descriptions. This method genrates 4 random call numbers and 7 random descriiptions
        /// </summary>
        private void GenerateRandomQuestions()
        {
            Categories();
            pbtnMatchCheck.Enabled=true;
            // Clear previous selections
            userSelections.Clear();

            // Get four random call numbers
            var callNumbers = dictionary.Keys.OrderBy(x => random.Next()).Take(4).ToList();

            // Get seven random descriptions, including three incorrect ones
            var descriptions = dictionary.Values.OrderBy(x => random.Next()).Take(7).ToList();
            descriptions.Insert(random.Next(4), dictionary[callNumbers[0]]);
            descriptions.Insert(random.Next(5, 8), dictionary[callNumbers[1]]);
            // descriptions.Insert(random.Next(6, 9), dictionary[callNumbers[2]]);

            // Remove duplicates from listBoxDescriptions
            List<string> uniqueDescriptions = new List<string>();
            foreach (var description in descriptions)
            {
                if (!uniqueDescriptions.Contains(description))
                    uniqueDescriptions.Add(description);
            }

            // Clear and repopulate the listBoxDescriptions
            listBoxDescriptions.Items.Clear();
            foreach (var description in uniqueDescriptions)
            {
                listBoxDescriptions.Items.Add(description);
            }

            // Populate the listBoxCallNumbers
            listBoxCallNumbers.Items.Clear();
            foreach (var number in callNumbers)
            {
                listBoxCallNumbers.Items.Add(number);
            }
        }

        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Ref: ChatGPT
        /// This event handles the list box for call numbers and saves the selected items to the userSelection dictionary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxCallNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            tmrRemaining.Start();
            
            string selectedCallNumber = listBoxCallNumbers.SelectedItem.ToString();
            string selectedDescription = listBoxDescriptions.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedDescription))
            {
                userSelections[selectedCallNumber] = selectedDescription;
            }
        }

        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Ref: ChatGPT
        /// This event handles the list box for call numbers and saves the selected items to the userSelection dictionary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxDescriptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCallNumber = listBoxCallNumbers.SelectedItem?.ToString();
            string selectedDescription = listBoxDescriptions.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(selectedCallNumber))
            {
                userSelections[selectedCallNumber] = selectedDescription;

            }
        }

        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Ref: ChatGPT
        /// Use: This method checks the user's selection of items from each list box and compares the dictionaries orginal values. It also indicates if the user matched correctly or incorrectly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbtnMatchCheck_Click(object sender, EventArgs e)
        {
            bool isAnswerCorrect = true;

            // Check for duplicates in userSelections
            var duplicateCallNumbers = userSelections.GroupBy(x => x.Key).Where(group => group.Count() > 1).Select(group => group.Key).ToList();
            var duplicateDescriptions = userSelections.GroupBy(x => x.Value).Where(group => group.Count() > 1).Select(group => group.Key).ToList();

            if (duplicateCallNumbers.Any() || duplicateDescriptions.Any())
            {
                isAnswerCorrect = false;
            }
            else
            {
                foreach (var kvp in userSelections)
                {
                    if (dictionary[kvp.Key] != kvp.Value)
                    {
                        isAnswerCorrect = false;
                        break;
                    }
                }
            }

            string message = isAnswerCorrect ? "Your matching is correct!" : "Your matching is incorrect!";
            MessageBox.Show(message);

            // Adds five points to score everytime the user matches correctly
            int score = 0;
            if(message == "Your matching is correct!")
            {
                score = 5;
                score++;
                if(score > 50)
                {
                    lblScore.Text = "Score: " + score.ToString();
                }
          
            }
        }

        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// This click event allows the user to play again and regenerates new questions and answers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbtnTryAgain_Click(object sender, EventArgs e)
        {
            //restart timer
            tmrRemaining.Start();
            userSelections.Clear();
            GenerateRandomQuestions();
            //Swap();
        }
        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// This click event will close the current window, taking the user back to the previous page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbtnMainMenu_Click(object sender, EventArgs e)
        {
            //Stops timer in case of user exiting before game ends
            tmrRemaining.Stop();
            MatchColumns match = new MatchColumns();
            match.Hide();
        }

        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Reference: Computing Academy
        /// URL: https://www.youtube.com/watch?v=DDXC0juDBhg
        /// Use: The timer feature is added to make the player sort the books correctly before time runs out
        /// </summary>
        int timeRemaining = 60;
        private void tmrRemaining_Tick(object sender, EventArgs e)
        {
           
            if (timeRemaining > 0)
            {
                
                timeRemaining = timeRemaining - 1;
                lblTime.Text = timeRemaining + " " + "Seconds";
                
            }
            else
            {
                pbtnMatchCheck.Enabled = false;
      
            }
        }
    }
}
///-------------------------------------------->000ooo...END OF FILE...ooo000<---------------------------------------------