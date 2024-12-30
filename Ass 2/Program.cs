using System;
using System.ComponentModel.Design;

namespace Ass_2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q1

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //
            //if (number % 3 == 0 && number % 4 == 0)
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}

            #endregion


            #region Q2

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //
            //if (number < 0)
            //{
            //    Console.WriteLine("Negative");
            //}
            //else
            //{
            //    Console.WriteLine("Positive");
            //}

            #endregion


            #region Q3

            //Console.Write("Enter the first number: ");
            //int num1 = int.Parse(Console.ReadLine());
            //
            //Console.Write("Enter the second number: ");
            //int num2 = int.Parse(Console.ReadLine());
            //
            //Console.Write("Enter the third number: ");
            //int num3 = int.Parse(Console.ReadLine());
            //
            //int max = Math.Max(num1, Math.Max(num2, num3));
            //
            //int min = Math.Min(num1, Math.Min(num2, num3));
            //
            //Console.WriteLine("The maximum number is: " + max);
            //Console.WriteLine("The minimum number is: " + min);

            #endregion


            #region Q4

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("even");
            //}
            //else
            //{
            //    Console.WriteLine("odd");
            //}
            #endregion


            #region Q5

            //Console.Write("Enter a character: ");
            //char character = char.Parse(Console.ReadLine().ToLower());
            //
            //if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
            //{
            //    Console.WriteLine("vowel");
            //}
            //else
            //{
            //    Console.WriteLine("consonant");
            //}




            #endregion


            #region Q6
            //int i = 1;
            //Console.WriteLine(" Enter the Number : ");
            //int Number = int.Parse(Console.ReadLine());
            //
            //while (i < Number)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.WriteLine(i);



            #endregion


            #region Q7

            //Console.Write("Enter an integer number: ");
            //int number = int.Parse(Console.ReadLine());
            //
            //for (int i = 1; i <= 12; i++)
            //{
            //    int result = number * i;
            //    Console.WriteLine($"{number} x {i} = {result}");
            //}




            #endregion


            #region Q8

            //Console.Write("Enter an integer number: ");
            //int number = int.Parse(Console.ReadLine());
            //
            //for (int i = 1; i <= number; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}




            #endregion


            #region Q9


            //Console.Write("Enter the number : ");
            //int Number = int.Parse(Console.ReadLine());
            //
            //Console.Write("Enter the power : ");
            //int power = int.Parse(Console.ReadLine());
            //
            //double result = Math.Pow(Number, power);
            //
            //Console.WriteLine(result);




            #endregion


            #region Q10

            //Console.Write("Enter the marks for subject 1: ");
            //int subject1 = int.Parse(Console.ReadLine());
            //
            //Console.Write("Enter the marks for subject 2: ");
            //int subject2 = int.Parse(Console.ReadLine());
            //
            //Console.Write("Enter the marks for subject 3: ");
            //int subject3 = int.Parse(Console.ReadLine());
            //
            //Console.Write("Enter the marks for subject 4: ");
            //int subject4 = int.Parse(Console.ReadLine());
            //
            //Console.Write("Enter the marks for subject 5: ");
            //int subject5 = int.Parse(Console.ReadLine());
            //
            //int total = subject1 + subject2 + subject3 + subject4 + subject5;
            //double average = total / 5.0;
            //double percentage = (total / 500.0) * 100; 
            //
            //Console.WriteLine("Total Marks: " + total);
            //Console.WriteLine("Average Marks: " + average);
            //Console.WriteLine("Percentage: " + percentage + "%");




            #endregion


            #region Q11

            // Console.Write("Enter the month number : ");
            // int month = int.Parse(Console.ReadLine());
            //
            // int days;
            //
            // switch (month)
            // {
            //     case 1:  
            //     case 3:  
            //     case 5:  
            //     case 7:  
            //     case 8:  
            //     case 10: 
            //     case 12: 
            //         days = 31;
            //         break;
            //     
            //     case 4:  
            //     case 6:  
            //     case 9:  
            //     case 11: 
            //         days = 30;
            //         break;
            //     
            //     case 2:  
            //         days = 28;         
            //         break;
            //     default:
            //         Console.WriteLine("Invalid month number.");
            //         return;
            // }
            // Console.WriteLine($" days in month is : {days}");



            #endregion


            #region Q12

            //Console.Write("Enter the first number: ");
            //double num1 = double.Parse(Console.ReadLine());
            //
            //Console.Write("Enter operation : ");
            //char operation = char.Parse(Console.ReadLine());
            //
            //Console.Write("Enter the second number: ");
            //double num2 = double.Parse(Console.ReadLine());
            //
            //double result;
            //
            //switch (operation)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        break;
            //    case '/':
            //        if (num2 != 0)
            //        {
            //            result = num1 / num2;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Division by zero is not allowed.");
            //            return;
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operator.");
            //        return;
            //}
            //
            //Console.WriteLine($"{num1} {operation} {num2} = {result}");




            #endregion


            #region Q13

            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();
            //
            //char[] charArray = input.ToCharArray();
            //
            //Array.Reverse(charArray);
            //
            //string reversedString = new string(charArray);
            //
            //Console.WriteLine("Reversed string: " + reversedString);



            #endregion


            #region Q14

            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());
            //
            //string numberString = number.ToString();
            //
            //char[] charArray = numberString.ToCharArray();
            //
            //Array.Reverse(charArray);
            //
            //string reversedString = new string(charArray);
            //
            //int reversedNumber = int.Parse(reversedString);
            //
            //Console.WriteLine("Reversed number: " + reversedNumber);




            #endregion

            #region Q15

            #endregion


            #region Q16

            #endregion


            #region Q17

            //Console.Write("Enter x1: ");
            //double x1 = double.Parse(Console.ReadLine());
            //
            //Console.Write("Enter y1: ");
            //double y1 = double.Parse(Console.ReadLine());
            //
            //Console.Write("Enter x2: ");
            //double x2 = double.Parse(Console.ReadLine());
            //
            //Console.Write("Enter y2: ");
            //double y2 = double.Parse(Console.ReadLine());
            //
            //Console.Write("Enter x3: ");
            //double x3 = double.Parse(Console.ReadLine());
            //
            //Console.Write("Enter y3: ");
            //double y3 = double.Parse(Console.ReadLine());
            //
            //double slope1 = (y2 - y1) / (x2 - x1);
            //double slope2 = (y3 - y2) / (x3 - x2);
            //
            //if (slope1 == slope2)
            //{
            //    Console.WriteLine("The points lie on a single straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do not lie on a single straight line.");
            //}



            #endregion


            #region Q18
            
                //Console.Write("Enter the time taken to complete the task : ");
                //double timeTaken = double.Parse(Console.ReadLine());
                //
                //if (timeTaken >= 2 && timeTaken <= 3)
                //{
                //    Console.WriteLine(" highly efficient.");
                //}
                //else if (timeTaken > 3 && timeTaken <= 4)
                //{
                //    Console.WriteLine(" improve your speed.");
                //}
                //else if (timeTaken > 4 && timeTaken <= 5)
                //{
                //    Console.WriteLine(" training to enhance your speed.");
                //}
                //else if (timeTaken > 5)
                //{
                //    Console.WriteLine(" required to leave the company.");
                //}
                //else
                //{
                //    Console.WriteLine("Invalid input. ");
                //}

            
        

        #endregion






    }
}
}