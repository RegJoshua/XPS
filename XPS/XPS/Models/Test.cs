using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPS.Models
{
    public class Test
    {
        #region Private Fields

        private int _testID;
        private int _userID;
        private float _time;
        private int _attempted;
        private int _correct;

        #endregion

        public Test()
        {
            _testID = 0;
            _userID = 0;
            _time = 0;
            _attempted = 0;
        }

        #region Public Properties

        public int TestID
        {
            get
            {
                return _testID;
            }
            set
            {
                _testID = value;
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
        public float Time
        {
            get
            {
                return _time;
            }
            set
            {
                _time = value;
            }
        }
        public int Attempted
        {
            get
            {
                return _attempted;
            }
            set
            {
                _attempted = value;
            }
        }
        public int Correct
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

        #endregion
    }
}