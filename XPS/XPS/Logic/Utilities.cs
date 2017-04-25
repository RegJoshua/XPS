using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XPS.Models;

namespace XPS.Logic
{
    public class Utilities
    {
        public static String CategoryString(int[] categories)
        {
            String result = "(";

            for (int i = 0; i < categories.Length; i++)
            {
                if (categories[i] == 1)
                {
                    result += i.ToString() + ',';
                }
            }

            result = result.Substring(0, result.Length - 1);
            result += ")";
            return result;
        }

        public static int[] Permutation()
        {
            Random rand = new Random();
         
            List<int> tempList = new List<int>();
            int randInt = 0;

            while (tempList.Count != 5)
            {
                randInt = rand.Next() % 5;
                if (!tempList.Contains(randInt))
                {
                    tempList.Add(randInt);
                }
            }

            return tempList.ToArray();
        }

        public static List<Question> ShuffleQuestions(List<Question> questions)
        {
            List<Question> result = new List<Question>();
            Random rand = new Random();

            result = questions.OrderBy(x => rand.Next()).ToList();  

            return result;
        }
    }
}
