using System;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {





            #region 1.	Write a program that allows the user to enter a number then print it.
            //Console.Write("Enter number : ");
            //long number = Convert.ToInt64(Console.ReadLine());

            //Console.WriteLine("the number entered is " + number);
            #endregion
            #region 2 Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen
            //Console.Write("Enter a string contains non-numeric characters: ");
            //int input = int.Parse(Console.ReadLine());
            //Console.WriteLine(input);
            /*A non-numeric string cannot be converted to an integer*/
            #endregion
            #region 3-Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            //float Number_1 = 5.6f;
            //float Number_2 = 8.9f;
            /*adds two Numbers*/
            //float sum = Number_1 + Number_2;
            //Console.WriteLine($"the sum of number is :{Number_1}+{Number_2}={sum} ");
            #endregion
            #region 4-Write C# program that Extract a substring from a given string
            //I don't understand this task 
            #endregion
            #region 5-Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int Number1 = 20;
            //int Number2 = 30;
            //Number2 = Number1;
            //Console.WriteLine(Number1);
            //Console.WriteLine(Number2);
            /*Since I made number 2 equal to number 1, then the value of number 2 will change to the same value as number 1*/
            #endregion
            #region 6-Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //Point p1;
            //p1 = new Point();
            //Point P2 = new Point();/*unrechable object*/
            //p1.Number = 100;
            //P2 = p1;
            //Console.WriteLine(p1.Number);
            //Console.WriteLine(P2.Number);
            ///*p1 has Reference(p1, p2)*/
            ///*It will display the same number both times*/ 
            #endregion
            #region 7-Write C# program that take two string variables and print them as one variable 
            //string FName = "Karim";
            //string LName = "Saleh";
            //String FullName = FName + LName;
            //Console.WriteLine($"Full Name is : {FullName}");
            #endregion
            #region 8.	Write a program that calculates the simple interest given the principal amount, rate of interest, and time.     
            //Console.Write("Enter the principal amount: ");
            //double principal = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the rate of interest: ");
            //double rate = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the time in years: ");
            //double time = Convert.ToDouble(Console.ReadLine());

            //double interest = (principal * rate * time) / 100;

            //Console.WriteLine($"\nSimple Interest = {interest}");
            #endregion
            #region 9.	Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters.         

            //        Console.Write("Enter your weight in kilograms: ");
            //double weight = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter your height in meters: ");
            //double height = Convert.ToDouble(Console.ReadLine());

            //double bmi = weight / (height * height);

            //Console.WriteLine($"\nYour BMI is: {bmi:F2}");

            #endregion
            #region 10.	Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. 
            //Console.Write("Enter the temperature in Celsius: ");
            //double temperature = Convert.ToDouble(Console.ReadLine());
            //string result = temperature > 30 ? "Too hot" :
            //           temperature < 10 ? "Just cold" :
            //           "Just Good";

            //Console.WriteLine("The weather is: " + result);
            #endregion
            #region 11. Write a program that takes the date from the user and displays it in various formats using string interpolation.

            //Console.Write("Enter day: ");
            //int day = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter month: ");
            //int month = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter year: ");
            //int year = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"\nToday's date : {day} , {month} , {year}");
            //Console.WriteLine($"Today's date : {day} / {month} / {year}");
            //Console.WriteLine($"Today's date : {day} - {month} - {year}");


            #endregion
            #region 12- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number % 3 == 0 && number % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            #endregion
            #region 13- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.Write("Enter an integer: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number < 0)
            //{
            //    Console.WriteLine("negative");
            //}
            //else
            //{
            //    Console.WriteLine("positive");
            //}
            #endregion
            #region 14- Write a program that takes 3 integers from the user then prints the max element and the min element.
            //Console.Write("Enter first number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter third number: ");
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //int max = Math.Max(num1, Math.Max(num2, num3));
            //int min = Math.Min(num1, Math.Min(num2, num3));

            //Console.WriteLine($"\nMax element = {max}");
            //Console.WriteLine($"Min element = {min}");
            #endregion
            #region 15- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.Write("Enter an integer: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}
            #endregion
            #region 16- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //Console.Write("Enter a character: ");
            //char ch = Convert.ToChar(Console.ReadLine().ToLower()); 

            //if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            //{
            //    Console.WriteLine("vowel");
            //}
            //else
            //{
            //    Console.WriteLine("consonant");
            //}
            #endregion
            #region 17- Write a program to input the month number and print the number of days in that month.
            Console.Write("Enter month number (1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());

            int days;

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;

                case 2:
                    days = 28; // ثابت بدون حساب السنة الكبيسة
                    break;

                default:
                    Console.WriteLine("Invalid month number!");
                    return;
            }

            Console.WriteLine($"Days in Month: {days}");
            #endregion

        }
    }
}
