using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_set_1
{
    class Program
    {
        static void Main(string[] args)
        {
            set1_Q13();
        }
        static void set1_Q1()
        {
            //write a program to display the sum,difference,and their product...
            int number1 = 5;
            int number2 = 5;
            int sumoftwonumbers = (number1 + number2);
            Console.WriteLine(sumoftwonumbers);
            Console.ReadKey();

            int productoftwonumbers = (number1 * number2);
            Console.WriteLine(productoftwonumbers);
            Console.ReadKey();

            int differenceoftwonumbers = (number1 / number2);
            Console.WriteLine(differenceoftwonumbers);
            Console.ReadKey();
        }


        static void set1_Q2()
        {
            //To find the value of a raised to the power of b ,where a and b are positive integers....
            int a = 2;
            int b = 3;
            Console.WriteLine(Math.Pow(a, b));

        }

        static void set1_Q3()
        {
            //To find the volume...
            Console.WriteLine("Enter the lenghth");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height");
            int height = int.Parse(Console.ReadLine());
            int volumeofrectangular = (length * width * height);
            Console.WriteLine(volumeofrectangular);
        }

        static void set1_Q4()
        {

            //perimeter of a circle....     TYPE 1...
            double GetPI = 3.14;
            double Getr = 2;
            Console.WriteLine(2 * GetPI * Getr);
            Console.ReadKey();

            // perimeter of a circle ...     TYPE 2...


            double r = 2;
            double perimeter = 2 * Math.PI * r;
            Console.WriteLine("perimeter of a circle" + perimeter);
        }

        static void set1_Q5()
        {
            //Given a numeritor and denominator,find the quotient and remainder...
            Console.WriteLine("Enter the numerator");
            int numerator = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the denominator");
            int denominator = int.Parse(Console.ReadLine());
            int quotient = (numerator / denominator);
            Console.WriteLine("your quotient" + quotient);
            int remainder = (numerator % denominator);
            Console.WriteLine("your remainder" + remainder);


        }
        static void set1_Q6()
        {
            //Find the square of a given number...

            Console.WriteLine("Find the square of a given number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("square of a given number");
            Console.WriteLine(Math.Pow(a, 2));    //Using math function...
        }
        static void set1_Q7()
        {
            //Find the square Root of a given number...
            Console.WriteLine(" Find Square root of a given number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Square root of a number");
            Console.WriteLine(Math.Sqrt(a));   //using math function....
        }

        static void set1_Q8()
        {
            //Calculate the Area of a Triangle....
            Console.WriteLine("Enter the breadth value");
            double breadth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height value");
            double height = Convert.ToDouble(Console.ReadLine());
            double triangle = ((breadth * height) / 2);
            Console.WriteLine("triangle value" + triangle);
        }
        static void set1_Q9()
        {
            //Program to Convert Kilometers to Miles....
            double kilometer = 0.621371;
            double mile = 1.60934;

            double ktomvalue = (mile * 4);
            Console.WriteLine("convert kilometers to miles");
            Console.WriteLine("kilometer to mile value" + ktomvalue);
            Console.WriteLine("\n");

            //Program to Convert Miles to kilometers....
            Console.WriteLine("convert miles to kilometers");
            double mtokvalue = (kilometer / 4);
            Console.WriteLine("mile to kilometer value" + mtokvalue);

        }

        static void set1_Q10()
        {
            //Program to Convert Celsius to Fahrenheit...
            Console.WriteLine("celsius to fahrehint");
            double cel = 95.5;
            double fahrehint = (cel * 9 / 5) + 32;
            Console.WriteLine("celsius value is " + fahrehint);
            Console.ReadKey();
        }

        static void set1_Q11()
        {
            //Program to swap two variables...
            Console.WriteLine("Swapping of two Variables");

            Console.WriteLine("assign a value");
            int a, b, t;
            a = 10;
            b = 20;
            t = a;
            a = b;
            b = t;

            Console.WriteLine("swap of a is b:" + a);
            Console.WriteLine("swap of b is a:" + b);
        }

        static void set1_Q12()
        {
            //program to swap two variables without using temporary variable...
            Console.WriteLine("Swapping of two variables without using temporary variable");
            int a, b;
            a = 20;
            b = 10;
            a = a - b;
            b = a + b;
            Console.WriteLine("swap of a :" + a);
            Console.WriteLine("swap of b :" + b);
        }
        static void set1_Q13()
        {
            //program to swap two variables without causing overflow...
            Console.WriteLine("Swapping two variables without causing overflow");
            int a, b;
            a = 5;
            b = 10;
            a = a ^ b;
            b = a ^ b;
            a = b ^ a;
            Console.WriteLine("swap of two variables without causing overflow a is " + a);
            Console.WriteLine("swap of two variables without causing overflow b is " + b);
        }
        public void set1_Q14()
        {
            //program to Generate a Random Number between 1 and 100...
            Console.WriteLine("Random number");
            Random rnd = new Random();              //Using random function...
            int randomnumber = rnd.Next(0, 2);
            Console.WriteLine("Random number" + randomnumber);

        }

        public void set1_Q15()
        {
            //Find the area of a field in acres,whose length and width are Given in feet...
            Console.WriteLine("Enter the length of the field:");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width of the field");
            double width = double.Parse(Console.ReadLine());

            //Calculate the area in acres...
            double AreaInAcres = (length * width) / 43560;

            Console.WriteLine("The area of the field is:" + AreaInAcres + "Acres");



        }

        public void set1_Q16()
        {
            //To Find the Sum of Natural Numbers up to N.....
            Console.WriteLine("Enter of natural numbers");
            int Nvalue = int.Parse(Console.ReadLine());
            Console.WriteLine(" The Natural Number is " + Nvalue);
            int Sumofnaturalnumbers = (Nvalue * (Nvalue + 1) / 2);
            Console.WriteLine("The sum of natural number is " + Sumofnaturalnumbers);
        }
        public void set1_Q17()
        {
            //Get three numbers as input from the user and find their Average...
            Console.WriteLine("Enter the value A");
            float A = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value B");
            float B = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value C");
            float C = float.Parse(Console.ReadLine());
            float Average = (A + B + C) / 3;
            Console.WriteLine("The Average is" + Average);
        }


        public void set1_Q18()
        {
            //To Calculate the tip to be provided to the waiter, at 5% bill Amount...
            Console.WriteLine("Calculate the tip to be provider to the waiter");
            Console.WriteLine("Enter the bill Amount");
            double billAmount = double.Parse(Console.ReadLine());

            double tipAmount = billAmount * 5 / 100; //(bill amount * 5/100);
            Console.WriteLine("The tip Amount is" + tipAmount);


        }

        public void set1_Q19()
        {
            //Given the total Amount paid and the tax percentage,Calculate the net amount of the product backwards....
            Console.WriteLine("Enter the total Amount");
            double totalAmount = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the tax Percentage");
            double taxpercentage = double.Parse(Console.ReadLine());

            //Calculate the net Amount...
            double netAmount = totalAmount / (1 + (taxpercentage / 100));
            Console.WriteLine("The net Amount is: " + netAmount);

        }

        public void set1_Q20()
        {
            //Given the basic pay, DA%  & TA% PF @8% deduction , calculate the gross pay...
            Console.WriteLine("Enter the basic pay");
            double basicpay = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the DA Percentage");
            double DA_Percentage = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the TA Percentage");
            double TA_Percentage = double.Parse(Console.ReadLine());

            //Calculate the gross pay...
            double DA_Amount = (basicpay * DA_Percentage) / 100;
            double TA_Amount = (basicpay * TA_Percentage) / 100;
            double PfAmount = (basicpay * 8) / 100;
            double grosspay = basicpay + DA_Amount + TA_Amount - PfAmount;
            Console.WriteLine("The grosspay is : " + grosspay);
        }

        public void set1_Q21()
        {
            Console.WriteLine("Calculate simple interest");
            int P = 10000;
            int R = 10;
            int N = 1;
            int Amount = (P * R * N / 100);
            Console.WriteLine("The Amount is " + Amount);
        }

        public void set1_Q22()
        {
            //To Compute compound Interest
            Console.WriteLine("Enter the initial principal balance:");
            double principalBalance = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Interest Rate:");
            double InterestRate = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the no . of times interest in compounded per time period:");
            int times_Compounded = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of time periods:");
            double Timeperiods = double.Parse(Console.ReadLine());

            //Calculate the compound interest..
            double Compound_Interst = principalBalance * Math.Pow((1 + (InterestRate / times_Compounded)), (times_Compounded * Timeperiods)) - principalBalance;
            Console.WriteLine("The Compound interest is" + Compound_Interst);
        }

        public void set1_Q23()
        {
            //Print the height in feet & inches...
            Console.WriteLine(" Enter the height in centimeters");
            double heightIn_cm = double.Parse(Console.ReadLine());

            //convert height from cm to inches...
            double heightIn_Inches = heightIn_cm / 2.54;

            //Convert height from inches to feet and remaining Inches...
            int heightin_Feet = (int)heightIn_Inches / 12;
            double RemainingInches = heightIn_Inches % 12;

            Console.WriteLine("The height is" + heightin_Feet + "Feet" + RemainingInches + "Inches");

        }

        public void set1_Q24()
        {
            //Find BMI....
            Console.WriteLine("Enter the height in meters:");
            double height_In_Meters = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the weight in Kilograms:");
            double Weight_In_Kilograms = double.Parse(Console.ReadLine());

            double bmi = Weight_In_Kilograms / (height_In_Meters * height_In_Meters);
            Console.WriteLine("The BMI is :" + bmi);
        }
        public void set1_Q25()
        {
            //Calculate the Total and Average...
            Console.WriteLine("Enter the Roll Number:");
            int RollNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Name:");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter the marks of Sub1:");
            int Marks_Sub1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the marks of Sub2:");
            int Marks_Sub2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter the marks of Sub3:");
            int Marks_Sub3 = int.Parse(Console.ReadLine());

            //Calculate the total marks and Average...
            int totalMarks = (Marks_Sub1+Marks_Sub2+Marks_Sub3);

            double Averagemarks = totalMarks / 3.0;

            Console.WriteLine("Roll Number:" + RollNo);
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Total Marks" + totalMarks);
            Console.WriteLine("Average marks " + Averagemarks);
        }
    }
}