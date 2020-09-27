﻿using System;

namespace EmpWagesUC6
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 2;
            int IS_PART_TIME = 1;
            int EMP_WAGE_PER_HOUR = 20;
            int WorkingDays = 0;
            int Total_Working_Hours = 100;
            int EmpHours = 0, EmpWage = 0;
            int WorkingHours = 0;
            Random r = new Random();
            while (WorkingDays < 20 && WorkingHours < 100)
            {
                WorkingDays++;
                int check = r.Next(1, 3);
                switch (check)
                {
                    case 2:
                        EmpHours = 8;
                        break;
                    case 1:
                        EmpHours = 4;
                        break;
                    default:
                        EmpHours = 0;
                        break;
                }
                WorkingHours += EmpHours;
                EmpWage += EmpHours * EMP_WAGE_PER_HOUR;
            }
            Console.WriteLine("Employee Wage: " + EmpWage);
            Console.WriteLine(WorkingHours + " " + WorkingDays);
        }
    }
}
