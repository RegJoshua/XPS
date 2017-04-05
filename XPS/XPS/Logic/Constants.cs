using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPS.Logic
{
    class Constants
    {
        public const int USER_FIRSTNAME_LENGTH = 30;
        public const int USER_LASTNAME_LENGTH = 30;
        public const int USER_USERNAME_LENGTH = 30;
        public const int USER_PASSWORD_LENGTH = 30;
        public readonly static char[] USER_USERTYPES = "AS".ToCharArray();

        public readonly static int[] QUESTION_CATEGORIES = new int[] { 1, 2, 3, 4, 5, 6, 7 };
    }
}
