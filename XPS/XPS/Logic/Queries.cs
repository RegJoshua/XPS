using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPS.Logic
{
    class Queries
    {
        public static string REPORT_INDIVIDUAL_STUDENT_RESULTS = @"
            SELECT 
	            TestID
	            , Attempted
	            , QuestionsCorrect
                , ROUND(QuestionsCorrect / Attempted * 100, 2) AS Score
	            , Time
            FROM
	            Test
            WHERE
	            UserID = {0};";
    }
}
