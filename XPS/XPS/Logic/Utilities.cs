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
    }
}
