using System;
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

        private int counter;
        private int countQuest;
        private int countdown;
        private int currentQuestion = 0;
        private List<Question> quest;
        private bool placed = true;
        public ExamForm()
        {
            InitializeComponent();
            //List<Question> exam = db.GetQuestions();
        }

        public ExamForm(User user, int numQuest, bool timed, int []categories)
        {
            InitializeComponent();
            countQuest = numQuest;
            quest = db.GetQuestions(numQuest, categories);

            questionLabel.Text = quest[0].QuestionText;
            int corrNum = random.Next(1, 6);

            answer1RadioButton.Text = quest[0].CorrectAnswer;
            answer2RadioButton.Text = quest[0].IncorrectAnswer1;
            answer3RadioButton.Text = quest[0].IncorrectAnswer2;
            answer4RadioButton.Text = quest[0].IncorrectAnswer3;
            answer5RadioButton.Text = quest[0].IncorrectAnswer4;


            if (timed == true)
            {
                countdown = numQuest * 120;
                timer1 = new Timer();
                timer1.Enabled = true;
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Interval = 1000;
                timer1.Start();
                cdLabel.Text = countdown.ToString();

            }
            dateLabel.Text = "Date: " + DateTime.Now.ToLongDateString();
            examUserLabel.Text = "User: " + user.FirstName + " " + user.LastName;

            int rowCount = numQuest / 5;
            Point pt = new Point();
            pt.X = 10;
            pt.Y = 10;
            int num = 1;


            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < 5; j++)
                {
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

        /* protected void button_Click(object sender, EventArgs e)
         * used for navigated through the navigation tool on the form.
         * 
         * 
         * 
         * 
         */
        protected void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            for (int i = 0; i < counter; i++)
            {
                if (button.Name == ("button" + i))
                {
                    questionLabel.Text = quest[i].QuestionText;
                    answer1RadioButton.Text = quest[i].CorrectAnswer;
                    answer2RadioButton.Text = quest[i].IncorrectAnswer1;
                    answer3RadioButton.Text = quest[i].IncorrectAnswer2;
                    answer4RadioButton.Text = quest[i].IncorrectAnswer3;
                    answer5RadioButton.Text = quest[i].IncorrectAnswer4;

                }
            }

        }
        private void ExamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countdown--;
            cdLabel.Text = TimeSpan.FromSeconds(countdown).ToString();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if(currentQuestion == countQuest)
            {
                nextButton.Enabled = false;
            }
            else
            {
                currentQuestion++;
                questionLabel.Text = quest[currentQuestion].QuestionText;
                answer1RadioButton.Text = quest[currentQuestion].CorrectAnswer;
                answer2RadioButton.Text = quest[currentQuestion].IncorrectAnswer1;
                answer3RadioButton.Text = quest[currentQuestion].IncorrectAnswer2;
                answer4RadioButton.Text = quest[currentQuestion].IncorrectAnswer3;
                answer5RadioButton.Text = quest[currentQuestion].IncorrectAnswer4;
            }        
        }

        /* private void previousButton_Click(object sender, EventArgs e)
         * 
         * 
         * 
         * 
         */
        private void previousButton_Click(object sender, EventArgs e)
        {
            if (currentQuestion == 0)
            {
                previousButton.Enabled = false;
            }
            else
            {
                currentQuestion--;
                questionLabel.Text = quest[currentQuestion].QuestionText;
                answer1RadioButton.Text = quest[currentQuestion].CorrectAnswer;
                answer2RadioButton.Text = quest[currentQuestion].IncorrectAnswer1;
                answer3RadioButton.Text = quest[currentQuestion].IncorrectAnswer2;
                answer4RadioButton.Text = quest[currentQuestion].IncorrectAnswer3;
                answer5RadioButton.Text = quest[currentQuestion].IncorrectAnswer4;
            }
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
