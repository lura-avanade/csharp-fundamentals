﻿
int amount = 1234;
int months = 12;

int yearlyWage = CalculateYearlyWage(amount, months);

Console.WriteLine($"Yearly wage: {yearlyWage}");

Console.ReadLine();


static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
{
    //Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
    //return monthlyWage * numberOfMonthsWorked;

    if (numberOfMonthsWorked == 12)//let's add bonus month
        return monthlyWage * (numberOfMonthsWorked + 1);

    return monthlyWage * numberOfMonthsWorked;
}