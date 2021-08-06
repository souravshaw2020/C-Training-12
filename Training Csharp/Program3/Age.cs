using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    class Age
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the Date of Birth in the format \'YYYY/MM/DD\' : ");
                string dob = Console.ReadLine();
                DateTime DOB = Convert.ToDateTime(dob);
                DateTime Now = DateTime.Now;
                int Years, Months, Days;
                Years = new DateTime(DateTime.Now.Subtract(DOB).Ticks).Year - 1;
                DateTime PastYearDate = DOB.AddYears(Years);
                Months = 0;
                for (int i = 1; i <= 12; i++)
                {
                    if (PastYearDate.AddMonths(i) == Now)
                    {
                        Months = i;
                        break;
                    }
                    else if (PastYearDate.AddMonths(i) >= Now)
                    {
                        Months = i - 1;
                        break;
                    }
                }
                Days = Now.Subtract(PastYearDate.AddMonths(Months)).Days;
                Console.WriteLine("Age : {0} Years {1} Months {2} Days", Years, Months, Days);
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("Invalid Date : " + e);
            }
            Console.ReadKey();
        }
    }
}