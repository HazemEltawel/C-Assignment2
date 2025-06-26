using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Threading.Channels;

class prgram
{
    static void Main()

    {
        #region qustion1
        //1.Write a program that allows the user to enter a number then print it.
        //Console.Write("Enter a number: ");
        //int input = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(input);
        #endregion

        #region qustion2
        //2.Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen
        //Console.Write("enter data ");
        //int number;
        //bool result = int.TryParse(Console.ReadLine(), out number);
        //Console.WriteLine(result);
        #endregion

        #region qustion3
        //3.Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
        //int A = 10;
        //int B = 3;
        //int C = 5;
        //int result = (A * C) + B;
        //Console.WriteLine(result);

        #endregion

        #region qustion4
        //4.Write C# program that Extract a substring from a given string.
        //string cra = "Hello, World!";
        //string input = cra.Substring(7, 5);
        //Console.WriteLine(input);
        //Console.ReadLine();
        #endregion

        #region qustion5
        //5.Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
        //int x = 10;
        //int y = x;
        //y = 20;
        //Console.WriteLine(x);
        //Console.WriteLine(y);
        #endregion

        #region qustion6
        //6.Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
        //int[] num = { 1, 2, 3 };
        //int[] num2 = num;
        //num2[0] = 10;
        //Console.WriteLine(num[0]);
        //Console.WriteLine(num2[0]);
        #endregion

        #region qustion7
        //7.Write C# program that take two string variables and print them as one variable 
        //string FirstName = "Hazem";
        //string LastName = "Eltawel";
        //string FullName = FirstName + " " + LastName;
        //Console.WriteLine(FullName);
        #endregion

        #region qustion8
        //8.Write a program that calculates the simple interest given the principal amount, rate of interest, and time. 
        //Note: The formula for simple interest is Interest = (principal * rate * time) / 100.

        Console.Write("Enter the principal ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the rate of interest");
        double rate = Convert.ToDouble(Console.ReadLine());


        Console.Write("Enter the time in years");
        double time = Convert.ToDouble(Console.ReadLine());

        double interest = (principal * rate * time) / 100; x
        Console.WriteLine("The simple interest is: " + interest);
        #endregion

        #region qustion9
        //9.Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 
        //Note: The formula for BMI is BMI = (Weight) / (Height * Height)
        //Console.Write("Enter your weight ");
        //double weight = Convert.ToDouble(Console.ReadLine());

        //Console.Write("Enter your height");
        //double height = Convert.ToDouble(Console.ReadLine());
        //double wh = weight / (height * height);
        //Console.WriteLine("Your wh is: " + wh);
        #endregion

        #region qustion10
        //Console.Write("Enter the temperature");
        //int tem = Convert.ToInt32(Console.ReadLine());
        //string result = "";
        //if (tem > 30) { result = "it's hot"; }
        //else if (tem < 10) { result = "it's cold"; }
        //else { result = "Just Good"; }
        //Console.WriteLine(result);
        #endregion

        #region qustion11
        //11. Write a program that takes the date from the user and displays it in various formats using string interpolation.
        //Ex:
        //Today’s date : 20 , 11 , 2001
        //Today's date : 20 / 11 / 2001
        //Today's date : 20 – 11 – 2001

        //Console.Write("Enter The day");
        //int day = Convert.ToInt32(Console.ReadLine());

        //Console.Write("Enter The month");
        //int month = Convert.ToInt32(Console.ReadLine());

        //Console.Write("Enter The Year");
        //int year = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine($"Today's date : {day} , {month} , {year}");
        //Console.WriteLine($"Today's date : {day} / {month} / {year} ");
        //Console.WriteLine($"Today's date : {day} - {month} - {year}");
        #endregion

        #region qustion12
        //12. Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
        //Example(1)
        //Input: 12
        //Output: Yes
        //Example(2)
        //Input: 9
        //Output: No

        Console.Write("Enter a Number");
        int Number = Convert.ToInt32(Console.ReadLine());
        if (Number % 3 == 0 && Number % 4 == 0)
        { Console.WriteLine("Yes"); }
        else { Console.WriteLine("NO"); }
        #endregion

        #region qustion13
        //13. Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
        //Example(1)
        //Input: -5
        //Output: negative
        //Example(2)
        //Input: 10
        //Output: positive

        //Console.Write("Enter Number");
        //int Number = Convert.ToInt32(Console.ReadLine());
        //if (Number < 0) { Console.WriteLine("negative"); }
        //else { Console.WriteLine("positive"); }

        #endregion

        #region qustion14
        //14. Write a program that takes 3 integers from the user then prints the max element and the min element.
        //Example(1)
        //Input: 7,8,5
        //Output:
        //max element = 8
        //min element = 5
        //—--------------------------------
        //Example(2)
        //Input: 3 6 9
        //Outputs:
        //Max element = 9
        //Min element = 3

        //Console.Write("first number");
        //int number1 = Convert.ToInt32(Console.ReadLine());

        //Console.Write("second number");
        //int number2 = Convert.ToInt32(Console.ReadLine());

        //Console.Write("Third number");
        //int number3 = Convert.ToInt32(Console.ReadLine());

        //int max = number1;

        //if (number2 > max) { max = number2; }
        //if (number3 > max) { max = number3; }

        //int min = number1;
        //if (number2 < min) { min = number2; }
        //if (number3 < min) { min = number3; }

        //Console.WriteLine("Max element = " + max);
        //Console.WriteLine("min element = " + min);


        #endregion

        #region qustion15
        //15. Write a program that allows the user to insert an integer number then check If a number is even or odd.
        //Console.Write("Enter Number");
        //int Number = Convert.ToInt32(Console.ReadLine());
        //if(Number % 2 ==0) { Console.WriteLine("Even"); }
        //else { Console.WriteLine("odd"); }

        #endregion

        #region qustion16
        //16. Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
        //Example(1)
        //Input: O
        //Output: vowel
        //Example(2)
        //Input: b
        //Output: Consonant

        //Console.WriteLine("Enter chracter");
        //string cha = Convert.ToString(Console.ReadLine().ToLower());
        //if(cha=="a" || cha == "e" || cha == "i"|| cha == "o" || cha == "u") 
        //{ Console.WriteLine("vowel"); }
        //else { Console.WriteLine("consonant"); }

        #endregion

        #region qustion17
        //17.  Write a program to input the month number and print the number of days in that month.
        //Example
        //Input: Month Number: 1
        //Output: Days in Month: 31

        //Console.Write("Enter month number (1 - 12) ");
        //bool isValid = int.TryParse(Console.ReadLine(), out int month);
        //if (!isValid || month < 1 || month > 12)
        //{
        //    Console.WriteLine("Invalid month number.");
        //    return;
        //}
        //int day;
        //if (month == 1 || month == 3 || month == 5 || month == 7 ||
        //    month == 8 || month == 10 || month == 12)
        //    { day = 31; }

        //else if (month == 4 || month == 6 || month == 9 || month == 11)
        //        { day = 30;}
        //else if (month == 2)
        //        { day = 28; }
        //else {
        //    Console.WriteLine("Invalid month number.");
        //    return;
        //     }
        //Console.WriteLine("Days in Month: " + day );

        #endregion

    }
}
    