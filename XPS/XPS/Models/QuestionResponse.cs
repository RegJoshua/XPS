using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPS.Models
{
    public class QuestionResponse
    {
        private int _questionResponseID;
        private int _userID;
        private int _quesitonID;
        private bool _correct;

        public QuestionResponse()
        {
            _questionResponseID = 0;
            _userID = 0;
            _quesitonID = 0;
            _correct = false;
        }

        public int QuestionResponseID
        {
            get
            {
                return _questionResponseID;
            }
            set
            {
                _questionResponseID = value;
            }
        }
        public int UserID
        {
            get
            {
                return _userID;
            }
            set
            {
                _userID = value;
            }
        }
        public int QuestionID
        {
            get
            {
                return _quesitonID;
            }
            set
            {
                _quesitonID = value;
            }
        }
        public bool Correct
        {
            get
            {
                return _correct;
            }
            set
            {
                _correct = value;
            }
        }
    }
}