using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace XPS.Models
{
    public class Question
    {
        private int _questionID;
        private int _questionCategory;
        private string _questionText;
        private string _correctAnswer;
        private string _incorrectAnswer1;
        private string _incorrectAnswer2;
        private string _incorrectAnswer3;
        private string _incorrectAnswer4;
        private string _hint;

        public Question()
        {
            _questionID = 0;
            _questionCategory = 0;
            _questionText = "";
            _correctAnswer = "";
            _incorrectAnswer1 = "";
            _incorrectAnswer2 = "";
            _incorrectAnswer3 = "";
            _incorrectAnswer4 = "";
            _hint = "";
        }

        public int QuestionID
        {
            get
            {
                return _questionID;
            }
            set
            {
                _questionID = value;
            }

        }
        public int QuestionCategory
        {
            get
            {
                return _questionCategory;
            }
            set
            {
                if (Logic.Constants.QUESTION_CATEGORIES.Contains(value))
                {
                    _questionCategory = value;
                }
                else
                {
                    throw new Exception(String.Format("{0} is not a valid question category.", value));
                }
            }
        }
        public string QuestionText
        {
            get
            {
                return _questionText;
            }
            set
            {
                _questionText = value;
            }
        }
        public string CorrectAnswer
        {
            get
            {
                return _correctAnswer;
            }
            set
            {
                _correctAnswer = value;
            }
        }
        public string IncorrectAnswer1
        {
            get
            {
                return _incorrectAnswer1;
            }
            set
            {
                _incorrectAnswer1 = value;
            }
        }
        public string IncorrectAnswer2
        {
            get
            {
                return _incorrectAnswer2;
            }
            set
            {
                _incorrectAnswer2 = value;
            }
        }
        public string IncorrectAnswer3
        {
            get
            {
                return _incorrectAnswer3;
            }
            set
            {
                _incorrectAnswer3 = value;
            }
        }
        public string IncorrectAnswer4
        {
            get
            {
                return _incorrectAnswer4;
            }
            set
            {
                _incorrectAnswer4 = value;
            }
        }
        public string Hint
        {
            get
            {
                return _hint;
            }
            set
            {
                _hint = value;
            }
        }
    }
}