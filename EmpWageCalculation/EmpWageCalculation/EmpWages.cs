using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCalculation
{
    public class EmpWages
    {
        public const int EMP_ABSENT = 0, PART_TIME = 1, FULL_TIME = 2, FULL_TIME_HOURS = 8, PART_TIME_HOURS = 4;
        private int empRatePerHour, NumOfworkingDays, maxHoursPerMonth,totalEmpWage;
        private string company;
        public EmpWages(string company, int empRatePerHour, int NumOfworkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.NumOfworkingDays = NumOfworkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public string  ComputeEmpWage()
        {
            int totalEmpHrs = 0, totalworkingDays = 0, empHours = 0;

            while (totalEmpHrs <= this.maxHoursPerMonth && totalworkingDays < this.NumOfworkingDays)
            {
                totalworkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case EMP_ABSENT:
                        break;
                    case PART_TIME:
                        empHours = PART_TIME_HOURS;
                        break;
                    case FULL_TIME:
                        empHours = FULL_TIME_HOURS;
                        break;
                }
                totalEmpHrs += empHours;
                Console.WriteLine($"Day {totalworkingDays}; emp Hours{empHours}");
            }
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
           return " Total Emp Wage For Compeny : " + company + " is " + totalEmpWage + "\n";

        }
       
    }
}
