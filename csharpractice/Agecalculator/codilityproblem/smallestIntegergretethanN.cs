using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codilityproblem
{
    internal class smallestIntegergretethanN
    {
        static void Main()
        {
            solution(500);
        }
       static  int solution(int N)
        {
            string s = N.ToString();
            int c = Convert.ToInt32(s);
            int result = 0;
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                result = c % 10;
                count = count + result;
                c = c / 10;

                result = N + count;
               
            }
            Console.WriteLine(result);
            return result;
        }
    }
    
}
