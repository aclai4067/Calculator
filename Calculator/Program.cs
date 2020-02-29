using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Operator(*, ^2, +, /, avg), a space, and then a List of Numbers (separated by commas with no spaces). example:'* 1,2,3'");
            var userEntry = Console.ReadLine();

            List<String> userEntryList = new List<String>(userEntry.Split(" "));
            var decision = userEntryList[0];
            var nums = userEntryList[1];


            List<String> numString = new List<String>(nums.Split(","));
            List<int> numbers = numString.Select(n => int.Parse(n)).ToList();
            var numArray = numbers.ToArray();

            switch (decision.ToLower())
            {
                case "*":
                    {
                        var prod = 1;
                        foreach (var nmbr in numArray)
                        {
                            prod *= nmbr;
                        }
                        Console.WriteLine(prod);
                        break;
                    }
                case "^2":
                    {
                        List<int> squaredNums = new List<int>();
                        foreach (var i in numArray)
                        {
                            squaredNums.Add(i * i);
                        }
                        var squaredResult = String.Join(",", squaredNums.Select(singleNum => singleNum.ToString()));
                        Console.WriteLine(squaredResult);
                        break;
                    }
                case "+":
                    {
                        var sum = 0;
                        foreach (var nmbr in numArray)
                        {
                            sum += nmbr;
                        }
                        Console.WriteLine(sum);
                        break;
                    }
                case "/":
                    {
                        var result = 0m;
                        for (int i = 0; i < numArray.Length; i++)
                        {
                            if (i == 0)
                            {
                                result = Convert.ToDecimal(numArray[i]);
                            }
                            else
                            {
                                result /= Convert.ToDecimal(numArray[i]);
                            }
                        }
                        Console.WriteLine(result);
                        break;
                    }
                case "avg":
                    {
                        var sum = 0;
                        foreach (var nmbr in numArray)
                        {
                            sum += nmbr;
                        }
                        var average = Convert.ToDecimal(sum) / Convert.ToDecimal(numArray.Length);
                        Console.WriteLine(average);
                        break;
                    }
                default:
                    Console.WriteLine("Sorry, your selection is not valid");
                    break;
            }

            Console.ReadKey();
        }
    }
}
