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

        public static string REPORT_TEST_HISTORY = @"
             SELECT 
	            Test.TestID
                , CONCAT(User.FirstName, ' ', User.LastName) AS Name
	            , Test.Attempted
	            , Test.QuestionsCorrect
                , ROUND(Test.QuestionsCorrect / Test.Attempted * 100, 2) AS Score
	            , Test.Time
            FROM
	            Test
	            INNER JOIN User ON User.UserID = Test.UserID;";

        public static string REPORT_RESULTS_BY_CATEGORY = @"
            SELECT 
	            QC.Category
                , COUNT(DISTINCT QR.QuestionResponseID)	AS Attempted
                , SUM(CASE WHEN QR.Correct = 1 THEN 1 ELSE 0 END) AS Correct
                , ROUND(SUM(CASE WHEN QR.Correct = 1 THEN 1 ELSE 0 END) / COUNT(DISTINCT QR.QuestionResponseID) * 100, 2) AS Average
            FROM
	            QuestionResponse QR
                INNER JOIN Question Q ON Q.QuestionID = QR.QuestionID
                INNER JOIN QuestionCategory QC ON QC.CategoryID = Q.Category
            GROUP BY
	            QC.Category;";
    }
}
