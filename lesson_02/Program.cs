using System;

namespace lesson_02
{
    class Program
    {
        static void Main(string[] vargs)
        {
            
            ShowAgeIn10Years_Task01();
            CalculateRectangle_Task02();
            CalculateTriangle();
            CalculateCircle();
            ShowCurrentDate_Task03();
            FutureBirthday_Task04();
        }
        static void ShowAgeIn10Years_Task01()
        {
            
            Console.Write("Please give me your age: ");
            string input = Console.ReadLine();
            try
            {
                int age = int.Parse(input);
                age += 10;
                Console.WriteLine("In 10 years you will be " + age);
            }
            catch
            {
                Console.WriteLine("Error!");
            }
        }
        static void CalculateRectangle_Task02()
        {
            Console.WriteLine();
            Console.Write("Give me Rectangle's Side A: ");
            string inputA = Console.ReadLine();
            float sideA = float.Parse(inputA);
            Console.Write("Give me Rectangle's Side B: ");
            string inputB = Console.ReadLine();
            float sideB = float.Parse(inputB);
            Console.WriteLine("Area is " + (sideA * sideB));
            Console.WriteLine("Perimeter is " + (2 * (sideA + sideB)));
        }
        static void CalculateTriangle()
        {
            Console.WriteLine();
            Console.Write("Give me Triangle's Side A: ");
            string inputA = Console.ReadLine();
            float sideA = float.Parse(inputA);
            Console.Write("Give me Triangle's Side B: ");
            string inputB = Console.ReadLine();
            float sideB = float.Parse(inputB);
            Console.Write("Give me Triangle's Side C: ");
            string inputC = Console.ReadLine();
            float sideC = float.Parse(inputC);
            Console.Write("Give me Rectangle's height: ");
            string inputHeight = Console.ReadLine();
            float height = float.Parse(inputHeight);
            Console.WriteLine("Area is " + (sideA * height) / 2);
            Console.WriteLine("Perimeter is " + (sideA + sideB + sideC));
        }
        static void CalculateCircle()
        {
            Console.WriteLine();
            Console.Write("Give me Circle's Radio: ");
            string inputR = Console.ReadLine();
            try 
            { 
                float radius = float.Parse(inputR);
                Console.WriteLine("Area is " + MathF.PI * Math.Pow(radius, 2));
                Console.WriteLine("Perimeter is " + 2 * Math.PI * radius);
            }
            catch
            {
                Console.WriteLine("Error!");
            }

        }
        static void ShowCurrentDate_Task03()
        {
            Console.WriteLine();
            Console.WriteLine("Current date is " + DateTime.Now.ToShortDateString());
            Console.WriteLine("Current time is " + DateTime.Now.ToShortTimeString());
            Console.WriteLine("The date in 10 years is " + DateTime.Now.AddYears(10).ToLongDateString());
            Console.Write("Give me years: ");
            string input = Console.ReadLine();
            try
            {
                int years = int.Parse(input);
                Console.WriteLine("Future date is " + DateTime.Now.AddYears(years).ToShortDateString());
            }
            catch
            {
                Console.WriteLine("Error!");
            }
        }
        static void FutureBirthday_Task04()
        {
            Console.WriteLine();
            Console.WriteLine("Current Age is : ");
            int currentAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Future Age is : ");
            int futureAge = int.Parse(Console.ReadLine());
            Console.WriteLine("BdayMonth is : ");
            int BdayMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Bday Day is : ");
            int BdayDay = int.Parse(Console.ReadLine());
            int ageDifference = futureAge - currentAge;
            int futureYear = DateTime.Now.Year + ageDifference;
            var futureBDay = new DateTime(futureYear, BdayMonth, BdayDay);
            Console.WriteLine($"Your future Bday will be on : {futureBDay}");
            Console.ReadKey();



        }
    }   

}
