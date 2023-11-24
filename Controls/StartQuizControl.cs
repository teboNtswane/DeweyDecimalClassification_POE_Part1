using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DeweyDecimalClassification_POE_Part1.Tree.MyTree;

namespace DeweyDecimalClassification_POE_Part1.Controls
{
    public partial class StartQuizControl : UserControl
    {

        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// These variables will be used to store data in the Binary Tree, and globally share the data in the different methods below.
        /// </summary>

        private BinaryTree<string> dataTree;
        private int level;
        private int score;
        private string actualAnswer;
        private Button sender;

        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Reference: ChatGPT and OpenAI  
        /// Url:
        /// https://chatgpt.org/
        /// https://chat.openai.com/
        /// https://echatgpt.org
        /// 
        /// Chat Query:
        /// 
        /// Write the step by step code of how to create a quiz app that finds call numbers and their descriptions to the nearest integer in Window Form Visual Studio C#. Make use of a binary tree to store the data in memory. The following requirements must be added to the application: 1. Create a file containing the data that contains call numbers and their description in a multi-level list (e.g. • 700Arts & Recreation o 750 Paining  751 Techniques, procedures, apparatus, equipment, materials, forms  752 Color ) in a format that can be read by the application. Provide the exact format that will be used in this application. 2. When the user chooses starts the application, the application must load the Dewey Decimal classification data into memory from the file created in Step 1. 3. The quiz must work as follows: a. For each question, randomly select a third level entry from the data, for example, 752 Color. Display only the description, not the call number. b. Display four top level options to the user to choose between, one of which must be the correct one and the other three randomly selected incorrect answers. For example: 000 General 400 Language 700 Arts & Recreation (Correct answer) 800 Literature c. For the options, display both the call number and description. Display the options in numerical order by call number. d. If the user selects the correct option, show them four options from the next level, until the most detailed level is reached. e. If the user selects the wrong option anywhere along the way, indicate this and then ask the next question. f.add a timer and score to the app.
        /// 
        /// Result: 
        /// 
        /// This is a quiz app that finds call numbers and their descriptions using a binary tree data structure in memory. 
        /// 
        /// </summary>
        public StartQuizControl()
        {
            InitializeComponent();
            dataTree = new BinaryTree<string>();

            // Load the data into the binary tree
            LoadData();

            //Hides retry button
            pBtnRetry.Visible = false;

            // Initialize the level 1
            level = 1;

            // Initial score 
            score = 0;
        }

        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Reference: Continued chat result
        /// Use: This method will read the data from the DeweyDataNew file and insert/store it as nodes in the binary tree class. This method will be loaded on to the form when the user starts the game.
        /// </summary>
        private void LoadData()
        {

            string[] lines = File.ReadAllLines("DeweyDataNew.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(new char[] { ':' }, 2);
                string callNumber = parts[0].Trim();
                string description = parts[1].Trim();
                dataTree.Insert(callNumber + " " + description);
            }
        }

        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Reference: Continued chat result
        /// Use: This method will generated a question that will be displayed on the labelDescription, and search the data stored in the binary tree for random entries and then displays those entries on each button's text. When the game starts, this will provide the user with the multiple choice questions and answer for the quiz.
        /// </summary>
        private void GenerateQuestion()
        {
            // Get a random third-level entry from the binary tree
            List<BinaryTreeNode<string>> options = new List<BinaryTreeNode<string>>();
            BinaryTreeNode<string> thirdLevelNode = dataTree.GetRandomNodeAtLevel(4);
            string[] parts = thirdLevelNode.Value.Split(' ');
            string description = parts[1];

            // Display the description in the label
            labelDescription.Text = description;

            //This answer will be compared with the user's selected option
            actualAnswer = thirdLevelNode.Value;

            // Get four top-level options
            options.Add(dataTree.GetRandomNodeAtLevel(0));
            options.Add(dataTree.GetRandomNodeAtLevel(1));
            options.Add(dataTree.GetRandomNodeAtLevel(2));
            //options.Add(dataTree.GetRandomNodeAtLevel(3));
            options.Add(thirdLevelNode); // Add the correct option
            //Shuffle the options using Fisher-Yates algorithm
            Random random = new Random();
            int n = options.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                BinaryTreeNode<string> temp = options[k];
                options[k] = options[n];
                options[n] = temp;
            }

            options.Sort((x, y) => x.Value.Split(' ')[1].CompareTo(y.Value.Split(' ')[1]));

            // Display the options on the buttons
            btnOption1.Text = options[0].Value;
            btnOption2.Text = options[1].Value;
            btnOption3.Text = options[2].Value;
            btnOption4.Text = options[3].Value;
        }


        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Reference: Continued chat result
        /// Use: This method check the user's selected answer and compares it to the question asked. If the answers correctly, the score will increment by 10 points and continue on to the next level. If the answers wrong, they will receive 0 points and continue on to the next question. When the user completes all rounds, they will be given the option to try again.
        /// </summary>
        /// <param name="selectedOption"></param>
        private void CheckAnswer(string selectedOption)
        {

            BinaryTreeNode<string> correctOption = dataTree.GetRandomNodeAtLevel(4);

            if (selectedOption == actualAnswer)
            {
                // Correct answer, show options from the next level
                if (level < 3)
                {
                    level++;
                    MessageBox.Show($"Correct Answer! On to Level: {level}", "Next Level", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    score += 10;
                    lblScore.Text = score.ToString();
                    GenerateQuestion();
                }
                else
                {
                    MessageBox.Show($"Congratulations! You've completed 3 levels.\nYou can try again. \nScore: {score}", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    pBtnRetry.Visible = true;
                    btnOption1.Enabled = false;
                    btnOption2.Enabled = false;
                    btnOption3.Enabled = false;
                    btnOption4.Enabled = false;

                }


            }
            else
            {
                // User selected the wrong option
                MessageBox.Show($"Wrong! Moving to the next question.\nYour Answer: {selectedOption} \nCorrect Answer: {actualAnswer}", "Wrong Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Nothing is added to the score
                score = 0;

                // Proceed to the next question
                GenerateQuestion();
            }
        }

        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Reference: Continued chat result
        /// Use: These click events will trigger the Check Answer method to compare the selected answer with the question asked, every time the user selects any of the four buttons below.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOption1_Click(object sender, EventArgs e)
        {
            CheckAnswer(btnOption1.Text);
        }

        private void btnOption2_Click(object sender, EventArgs e)
        {
            CheckAnswer(btnOption2.Text);
        }

        private void btnOption3_Click(object sender, EventArgs e)
        {
            CheckAnswer(btnOption3.Text);
        }

        private void btnOption4_Click(object sender, EventArgs e)
        {
            CheckAnswer(btnOption4.Text);
        }

        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// This event will allow the user to retry anytime they wish. When they do, the form will reset and the controls will be cleared and repopulated again.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pBtnRetry_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            level = 1;
            labelDescription.Text = null;
            lblScore.Text = null;
            btnOption1.Enabled = true;
            btnOption2.Enabled = true;
            btnOption3.Enabled = true;
            btnOption4.Enabled = true;
        }
    }
}
///-------------------------------------------->000ooo...END OF FILE...ooo000<---------------------------------------------