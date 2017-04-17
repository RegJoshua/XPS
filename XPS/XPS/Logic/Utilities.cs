using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPS.Logic
{
    class Utilities
    {
        public static String CategoryString(int[] categories)
        {
            String result = "(";

            if (categories.Length == 1)
            {
                result += categories[0].ToString();
            }

            if (categories.Length > 1)
            {
                foreach (int cat in categories)
                {
                    result += String.Format("{0}, ", cat); 
                }

                result = result.Substring(0, result.Length - 1);
            }

            result += ")";
            return result;
        }
    }
}
