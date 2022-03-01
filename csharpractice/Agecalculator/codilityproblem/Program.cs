using System;

namespace binaryGap
{
    public class binary
    {
        static void Main()
        {
            Solution(75);
        }
        static int Solution(int N)
        {
            int count = 0;
            int largestring = 0;
            string n = Convert.ToString(N,2);

            for(int i=0;i<n.Length;i++)
            {
                if(n[i]=='0')
                {
                    if(count>0)
                    
                        count++;
               
                    else
                 
                        count = 1;
                 
                    
                }
                else
                {
                    count = 0;
                }
            }
            if(largestring<count)
            {
                largestring = count;
            }
            Console.WriteLine(n);
           
            
            return largestring;
        }
    }
}
