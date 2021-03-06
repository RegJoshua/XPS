﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XPS.Logic;
using XPS.Models;
using XPS.Properties;

namespace XPS.Forms
{
    public partial class ExamForm : Form
    {
        //The database manager object.
        private DatabaseManager db = new DatabaseManager();
        private Random random = new Random();
        private Test test = new Test();
        private User testUser;
        private List<Question> quest;
        private Dictionary<Question, int[]> questions;
        private List<QuestionResponse> response = new List<QuestionResponse>();
        private int counter; //holds the numQuest passed in for the buttonName
        private int countQuest; //holds the numQuest passed in
        private int cdTimer;
        private int initialTime; //used to subtract with cdTimer to get elapsed time    
        private int currentQuestion = 0;
        private int answered = 0;
        private string cat; //holds the category to print the category for each question

        public ExamForm()
        {
            InitializeComponent();
        }

        public ExamForm(User user, int numQuest, bool timed, int[] categories)
        {
            InitializeComponent();
            testUser = user;
            countQuest = numQuest;
            test.Attempted = numQuest;
            initialTime = numQuest * 120; //2 min per question
            test.UserID = user.UserID;
            questions = new Dictionary<Question, int[]>();//Holds key value pairs of questions and answer order

            try
            {
                //get the questions from the DB and store in a new list called quest
                quest = db.GetQuestions(numQuest, categories);
                quest = Utilities.ShuffleQuestions(quest);
            }
            catch(Exception)
            {
                MessageBox.Show("Error connecting to database. Try again later.", "Error");
            }
            
            //initializes a list of question responses
            for (int i = 0; i < numQuest; i++)
            {
                QuestionResponse resp = new QuestionResponse();
                resp.QuestionID = quest[i].QuestionID;
                resp.UserID = user.UserID;
                response.Add(resp);
            }

            foreach (Question q in quest)
            {
                for (int i = 0; i < 10000000; i++)
                { 
                    //Kill Time
                }
                
                questions.Add(q, Utilities.Permutation());
            }

            //set the questionLabel and radioButtons to the first element
            //in the quest array.
            int current = currentQuestion;

            questionLabel.Text = "Question " + (current + 1) + ": " + quest[0].QuestionText;
            conditionLabel.Text = "" + quest[0].Paragraph;
            cat = setQuestionCategory(quest[0].QuestionCategory);
            catLabel.Text = "Category: " + cat;

            setAnswerBtn(0);
            CreateDynamicButtons(numQuest);
            setTime(timed, numQuest);
          
            //used to print the current Date, user, and testID on examForm.
            dateLabel.Text = "Date: " + DateTime.Now.ToLongDateString();
            examUserLabel.Text = "User: " + user.FirstName + " " + user.LastName;       
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
            if (cdTimer < 300)
                cdLabel.BackColor = Color.Red;
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
                    questionLabel.Text = "Question " + current + ": " + quest[i].QuestionText;
                    conditionLabel.Text = "" + quest[i].Paragraph;

                    setAnswerBtn(i);

                    resetAnserBtn();
                    checkAnswer();
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
            Button button = sender as Button;

            //Loads information for the next question
            if (currentQuestion <= countQuest - 2)
            {
                previousButton.Enabled = true;
                currentQuestion++;
                int current = currentQuestion;
                
                questionLabel.Text = "Question " + (current + 1) + ": " + quest[currentQuestion].QuestionText;
                cat = setQuestionCategory(quest[currentQuestion].QuestionCategory);
                catLabel.Text = "Category: " + cat;
                conditionLabel.Text = "" + quest[currentQuestion].Paragraph;
                setAnswerBtn(currentQuestion);

                resetAnserBtn();
                checkAnswer();

                var buttons = navGroupBox.Controls.OfType<Button>();
                foreach (Button btn in buttons)
                {
                    if (btn.TabIndex == currentQuestion)
                    {
                        btn.Focus();
                    }
                }
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
            //Loads information for previous question
            if (currentQuestion != 0)
            {
                nextButton.Enabled = true;
                currentQuestion--;
                int current = currentQuestion;

                questionLabel.Text = "Question " + (current + 1) + ": " + quest[currentQuestion].QuestionText;
                cat = setQuestionCategory(quest[currentQuestion].QuestionCategory);
                catLabel.Text = "Category: " + cat;
                conditionLabel.Text = "" + quest[currentQuestion].Paragraph;

                setAnswerBtn(currentQuestion);

                resetAnserBtn();
                checkAnswer();

                var buttons = navGroupBox.Controls.OfType<Button>();
                foreach (Button btn in buttons)
                {
                    if (btn.TabIndex == currentQuestion)
                    {
                        btn.Focus();
                    }

                }
            }
        }

        /* private string setQuestionCategory(int num)
         * Displays the correct category for the current question
         */
        private string setQuestionCategory(int num)
        {
            string ans = "";

            if (num == 1)
                ans = "Discrete Structures";
            else if (num == 2)
                ans = "Programming";
            else if (num == 3)
                ans = "Algorithm and Complexity";
            else if (num == 4)
                ans = "Systems";
            else if (num == 5)
                ans = "Software Engineering";
            else if (num == 6)
                ans = "Information Management";
            else if (num == 7)
                ans = "Other";
            return ans;
        }

        /* private void saveQuestionButton_Click(object sender, EventArgs e)
         * Saves the users response to the current question when they click the save button
         * into the list of responses
         */
        private void saveQuestionButton_Click(object sender, EventArgs e)
        {
            //Checks which answer choice waas selected
            foreach (RadioButton button in questionGroupBox.Controls.OfType<RadioButton>())
            {
                if (button.Checked)
                {
                    response[currentQuestion].QuestionResponseID = button.Name[6] - 48;
                    //Grades the users answer choice
                    if (button.Text == quest[currentQuestion].CorrectAnswer)
                        response[currentQuestion].Correct = true;
                    else
                        response[currentQuestion].Correct = false;
                }
            }

            //Changes the current question's button color in the navigation panel to green
            if (response[currentQuestion].QuestionResponseID != 0)
            {
                var buttons = navGroupBox.Controls.OfType<Button>();
                foreach (Button btn in buttons)
                {
                    if (btn.TabIndex == currentQuestion)
                    {
                        btn.BackColor = Color.Green;
                        btn.Focus();
                    }

                }
            }
        }

        /* private void submitButton_Click(object sender, EventArgs e)
         * Submits the test and takes the user to the Test Reports form to view the details
         * of their test they took
         */
        private void submitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            int numCorrect = 0;
            
            int unanswered = 0;
            timer1.Stop();
            
            //Counts the number of correct answers and unanswered questions
            foreach (QuestionResponse resp in response)
            {
                if (resp.Correct == true)
                    numCorrect++;
                if (resp.QuestionResponseID == 0)
                    unanswered++;
            }

            //If there are some unanswered questions, prompts the user if they still want to 
            //submit the test
            if (unanswered != 0)
            {
                dialogResult = MessageBox.Show("Are you sure you want to submit? There are " + unanswered + " questions remaining.", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    FinalizeTest();
                    test.Correct = numCorrect;
                    test.Time = initialTime - cdTimer;
                    this.Hide();
                    ExamResultsForm ERF = new ExamResultsForm(test, testUser);
                    ERF.Show();
                }
                else
                {
                    timer1.Start();
                }            
            } 
            else
            {
                FinalizeTest();
                test.Correct = numCorrect;
                test.Time = initialTime - cdTimer;
                this.Hide();
                ExamResultsForm ERF = new ExamResultsForm(test, testUser);
                ERF.Show();
            }        
        }

        public void resetAnserBtn()
        {
            answer1RadioButton.Checked = false;
            answer2RadioButton.Checked = false;
            answer3RadioButton.Checked = false;
            answer4RadioButton.Checked = false;
            answer5RadioButton.Checked = false;
        }

        //If the user answered a question already and comes back to that question, the 
        //form will display the answer choice they chose before
        public void checkAnswer()
        {
            if (response[currentQuestion].QuestionResponseID == 1)
                answer1RadioButton.Checked = true;
            else if (response[currentQuestion].QuestionResponseID == 2)
                answer2RadioButton.Checked = true;
            else if (response[currentQuestion].QuestionResponseID == 3)
                answer3RadioButton.Checked = true;
            else if (response[currentQuestion].QuestionResponseID == 4)
                answer4RadioButton.Checked = true;
            else if (response[currentQuestion].QuestionResponseID == 5)
                answer5RadioButton.Checked = true;
        }

        /* public void setAnswerBtn(int i)
         * When the user comes back to a question, the form will display the answer choices
         * in the same configuration as they were, as well as display any image if the 
         * current question requires it
         */
        public void setAnswerBtn(int i)
        {
            string[] array = { quest[i].CorrectAnswer, quest[i].IncorrectAnswer1,
                    quest[i].IncorrectAnswer2, quest[i].IncorrectAnswer3,
                    quest[i].IncorrectAnswer4 };
            answer1RadioButton.Text = array[questions[quest[i]][0]];
            answer2RadioButton.Text = array[questions[quest[i]][1]];
            answer3RadioButton.Text = array[questions[quest[i]][2]];
            answer4RadioButton.Text = array[questions[quest[i]][3]];
            answer5RadioButton.Text = array[questions[quest[i]][4]];

            try
            {
                //Gets the image if there is one from the resources
                if (quest[currentQuestion].ImageName != "")
                {
                    System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
                    string test = "XPS." + quest[currentQuestion].ImageName;
                    Stream myStream = myAssembly.GetManifestResourceStream(test);
                    Bitmap image = new Bitmap(myStream);
                    pictureBox1.Image = image;
                    pictureBox1.Show();       
                }
                else
                    pictureBox1.Hide();
            }
            catch
            {
                MessageBox.Show("Error getting images.");
            }     
        }

        private void FinalizeTest()
        { 
            Test test = new Test()
	        {
		        //The ID of the user taking the test.
		        UserID = testUser.UserID
		        , Attempted = questions.Count
		        //LINQ expression to count the correct answers.
		        , Correct = response.Count(x => x.Correct)
		        , Time = initialTime - cdTimer
	        };
	
	        //Saves Test Object.
	        if(!db.InsertTest(test))
	        {
		        throw new Exception("Error saving test.");
	        }
	
	        //Saves the individual question responses.
            foreach (QuestionResponse qr in response)
	        {
		        if(!db.InsertQuestionResponse(qr))
		        {
			        throw new Exception("Error saving test.");
		        }
	        }
        }

        private void CreateDynamicButtons(int quest)
        {
            //Below is used to dynamically create the navigation for the exam form.
            //We will get the number of buttons needed based on the number of questions
            //that is passed from the mainMenuForm (what the user selects).
            int rowCount = quest / 5; //want 5 buttons in a row
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
        }

        private void setTime(bool timed, int numQuest)
        {
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
        }
    }
}