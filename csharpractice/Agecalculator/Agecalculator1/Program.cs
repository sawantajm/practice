using System;

namespace practice
{
    internal class Agecalculaor
    {
        static void Main()
        {
            Console.WriteLine("Enetr Date of Birth");
            DateTime dob = Convert.ToDateTime(Console.ReadLine());
            DateTime noedate = Convert.ToDateTime(DateTime.Now);

            var year = noedate.Year - dob.Year;
            var mont = 12 - dob.Month;
            var day = noedate.Day - dob.Day;
            Console.WriteLine(year + " Years " + mont + " Month " + day + " Day ");
        }
    }
}
