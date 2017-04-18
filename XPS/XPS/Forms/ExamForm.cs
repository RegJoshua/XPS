﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XPS.Logic;
using XPS.Models;

namespace XPS.Forms
{
    public partial class ExamForm : Form
    {
        DatabaseManager db = new DatabaseManager();
        Random random = new Random();

        private int counter; //holds the numQuest passed in for the buttonName
        private int countQuest; //holds the numQuest passed in
        private int cdTimer;
        private string cat; //holds the category to print the category for each question
        private int currentQuestion = 0;
        private List<Question> quest;

        public ExamForm()
        {
            InitializeComponent();
        }

        public ExamForm(User user, int numQuest, bool timed, int []categories)
        {
            InitializeComponent();
            countQuest = numQuest;

            int corrNum = random.Next(1, 6);

            //get the questions from the DB and store in a new list called quest
            quest = db.GetQuestions(numQuest, categories);

            //set the questionLabel and radioButtons to the first element
            //in the quest array.
            int current = currentQuestion;
           
            questionLabel.Text = "Question " + (current+1) + ": " +quest[0].QuestionText;                
            answer1RadioButton.Text = quest[0].CorrectAnswer;
            answer2RadioButton.Text = quest[0].IncorrectAnswer1;
            answer3RadioButton.Text = quest[0].IncorrectAnswer2;
            answer4RadioButton.Text = quest[0].IncorrectAnswer3;
            answer5RadioButton.Text = quest[0].IncorrectAnswer4;

            //if timed is checked from the mainMenu form then
            //a label will print the time allocated (120s/2 min) per question.
            if (timed == true)
            {
                cdTimer = numQuest * 120;
                timer1 = new Timer();
                timer1.Enabled = true;
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Interval = 1000; //1000 = 1s
                timer1.Start();
                cdLabel.Text = cdTimer.ToString();
            }

            //used to print the current Date and the user on the Exam Form.
            dateLabel.Text = "Date: " + DateTime.Now.ToLongDateString();
            examUserLabel.Text = "User: " + user.FirstName + " " + user.LastName;

            //Below is used to dynamically create the navigation for the exam form.
            //We will get the number of buttons needed based on the number of questions
            //that is passed from the mainMenuForm (what the user selects).
            int rowCount = numQuest / 5; //want 5 buttons in a row
            Point pt = new Point(); //Point is used to tell where each button goes
            pt.X = 10;
            pt.Y = 10;
            int num = 1;
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    //create a button, give it a name, color, location, and add
                    //to the navGroupBox.
                    Button button = new Button();
                    button.Click += new EventHandler(button_Click);
                    button.Name = "button" + counter;
                    button.Text = (num).ToString();
                    button.BackColor = Color.Gray;
                    button.ForeColor = Color.White;
                    button.Location = pt;
                    button.Width = 30;
                    button.Height = 30;
                    navGroupBox.Controls.Add(button);
                    pt.X = pt.X + 35;
                    num++;
                    counter++;
                }

                pt.X = 10;
                pt.Y = pt.Y + 35;
            }

            testIDLabel.Text = "Test ID: " + currentQuestion;
        }

        /* private void ExamForm_FormClosing(object sender, FormClosingEventArgs e)
        * This is used so the applicaiton will close when the user clicks the 'x'
        */
        private void ExamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /* private void timer1_Tick(object sender, EventArgs e)
         * timer1_Tick is used to countdown from the allocated time and print
         */
        private void timer1_Tick(object sender, EventArgs e)
        {
            cdTimer--;
            cdLabel.Text = TimeSpan.FromSeconds(cdTimer).ToString();
        }

        /* protected void button_Click(object sender, EventArgs e)
         * button_Click is used for the navigation within the Exam Form.
         * When the user clicks on the button, it prints the corresponding
         * question and choices on the Exam Form. 
         */
        protected void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            for (int i = 0; i < counter; i++)
            {
                int current = (i + 1);
                if (button.Name == ("button" + i))
                {
                    //must set i to currentQuestion or panel and next/prev button are out of order
                    currentQuestion = i;
                    cat = setQuestionCategory(quest[currentQuestion].QuestionCategory);
                    catLabel.Text = "Category: " + cat;
                    questionLabel.Text = "Question " + current + ": " +quest[i].QuestionText;
                    answer1RadioButton.Text = quest[i].CorrectAnswer;
                    answer2RadioButton.Text = quest[i].IncorrectAnswer1;
                    answer3RadioButton.Text = quest[i].IncorrectAnswer2;
                    answer4RadioButton.Text = quest[i].IncorrectAnswer3;
                    answer5RadioButton.Text = quest[i].IncorrectAnswer4;
                }
            }
        }

       

        /* private void nextButton_Click(object sender, EventArgs e)
         * NOTE: Do we want the next button to be disabled when the user
         * is on the last question or wrap around to the beginning?
         * 
         * created a variable called currentQuestion which will get the 
         * next element in the array when it is incremented. The next
         * question and answers will show when the user clicks 'Next'.
         */
        private void nextButton_Click(object sender, EventArgs e)
        {
            testIDLabel.Text = "test ID: " + countQuest;
            
            if(currentQuestion == (countQuest-1))
            {
                nextButton.Enabled = false;
            }
            else
            {
                previousButton.Enabled = true;
                currentQuestion++;
                int current = currentQuestion;
                
                questionLabel.Text = "Question " + (current+1) + ": " + quest[currentQuestion].QuestionText;
                cat = setQuestionCategory(quest[currentQuestion].QuestionCategory);
                catLabel.Text = "Category: " + cat;
                answer1RadioButton.Text = quest[currentQuestion].CorrectAnswer;
                answer2RadioButton.Text = quest[currentQuestion].IncorrectAnswer1;
                answer3RadioButton.Text = quest[currentQuestion].IncorrectAnswer2;
                answer4RadioButton.Text = quest[currentQuestion].IncorrectAnswer3;
                answer5RadioButton.Text = quest[currentQuestion].IncorrectAnswer4;
            }        
        }

        /* private void previousButton_Click(object sender, EventArgs e)
         * NOTE: Same as nextButton, do we want previous to go to the last 
         * question when the user is on the first question when clicked or 
         * disable the button on the first question.
         * 
         * previousButton functions the same as nextButton_Click but decrements
         * the variable currentQuestion which gets the previous Question in the list.
         */
        private void previousButton_Click(object sender, EventArgs e)
        {

            if (currentQuestion == 0)
            {
                previousButton.Enabled = false;
            }
            else
            {
                nextButton.Enabled = true;
                currentQuestion--;
                int current = currentQuestion;
                         
                questionLabel.Text = "Question " + (current+1) + ": " + quest[currentQuestion].QuestionText;
                cat = setQuestionCategory(quest[currentQuestion].QuestionCategory);
                catLabel.Text = "Category: " + cat;
                answer1RadioButton.Text = quest[currentQuestion].CorrectAnswer;
                answer2RadioButton.Text = quest[currentQuestion].IncorrectAnswer1;
                answer3RadioButton.Text = quest[currentQuestion].IncorrectAnswer2;
                answer4RadioButton.Text = quest[currentQuestion].IncorrectAnswer3;
                answer5RadioButton.Text = quest[currentQuestion].IncorrectAnswer4;
            }
        }

        private string setQuestionCategory(int num)
        {
            string ans = "";

            if(num == 1)
            {
                ans = "Discrete Structures";
              
            }
            else if(num == 2)
            {
                ans = "Programming";
               
            }
            else if(num == 3)
            {
                ans = "Algorithm and Complexity";
                
            }
            else if(num == 4)
            {
                ans = "Systems";
                
            }
            else if(num == 5)
            {
                ans = "Software Engineering";
                
            }
            else if(num == 6)
            {
                ans = "Information Management";
                
            }

            return ans;
        }

        //private bool setAnswer(int num, string answer)
        //{


        //    if (num == 1 && answer1RadioButton.Text == "")
        //    {
        //        answer1RadioButton.Text = answer;
        //        return false;
        //    }
        //    if (num == 2 && answer2RadioButton.Text == "")
        //    {
        //        answer2RadioButton.Text = answer;
        //        return false;
        //    }

        //    if (num == 3 && answer3RadioButton.Text == "")
        //    {
        //        answer3RadioButton.Text = answer;
        //        return false;
        //    }
                
        //    if (num == 4 && answer4RadioButton.Text == "")
        //    {
        //        answer4RadioButton.Text = answer;
        //        return false;
        //    }
                
        //    if (num == 5 && answer5RadioButton.Text == "")
        //    {
        //        answer5RadioButton.Text = answer;
        //        return false;
        //    }

        //    return true;               
        //}
    }
}
