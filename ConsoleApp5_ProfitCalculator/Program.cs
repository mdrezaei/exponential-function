using System;

namespace ConsoleApp5_ProfitCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            for ( ; j < 1; )
            {
                Console.WriteLine("Enter Initial Value :");
                double InitialValue = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Percentage of Increase per each Month :");
                double PercentageOfIncrease = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter The Amount of Increases at The Beginning of each Month :");
                double AmountIncreases = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter The Number of Months of The Process :");
                double NumberOfMonths = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter The Starter Month : (a number between 1~12)");
                double StarterMonth = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter The Starter Year : (a 4 Digits Number)");
                double StarterYear = double.Parse(Console.ReadLine());

                double a = PercentageOfIncrease + 100;
                double FinalValueOfEachMonth = a / 100;
                double b = (InitialValue * FinalValueOfEachMonth) + AmountIncreases;

                Console.WriteLine($"Initial Value : {InitialValue}  Percentage of Increase : {PercentageOfIncrease}  Amount of Increases at The Beginning of each Month : {AmountIncreases}");
                
                for (int i = 1; i <= NumberOfMonths; i++)
                {
                    StarterMonth++;
                    if (StarterMonth >= 13)
                    {
                        StarterMonth = 1;
                    }
                    if (StarterMonth == 1)
                    {
                        StarterYear++;
                    }

                    if (i == 1)
                    {
                        Console.WriteLine($"{StarterYear}/{StarterMonth} : " + b);
                    }
                    else
                    {
                        b = ((b * FinalValueOfEachMonth) + AmountIncreases);
                        Console.WriteLine($"{StarterYear}/{StarterMonth} : " + b);
                    }
                }

                Console.WriteLine("Do You Want to Continu: (Y/N)");
                string YesOrNo = Console.ReadLine().ToLower();

                if (YesOrNo=="y")
                {
                    j = 0;
                }
                else if (YesOrNo=="n")
                {
                    j++;
                }
            }
        }
    }
}
