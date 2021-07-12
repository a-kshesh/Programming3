using System;

namespace Assignment_1
{
    delegate void CalculateDel(double a,double b);
    class Program
    {
        public static void addDel(double a, double b)
        {
            Console.WriteLine("Addition {0} ", a + b);
        }
        public static void subDel(double a, double b)
        {
            Console.WriteLine("Subtraction {0} ", a - b);
        }

        public static void mulDel(double a, double b)
        {
            Console.WriteLine("Multiplication {0} ", a* b);
        }
        public static void divDel(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("value cannot be divided by zero");
            }
            else
            {
                Console.WriteLine("Division {0} ", a / b);
            }
        }

        public static void multiCast(CalculateDel calculateDel,double a,double b)
        {
            calculateDel(a,b);
        }
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("please enter two numbers");
                    double a = Convert.ToDouble(Console.ReadLine());
                    if (a == -1)
                    {
                        Console.WriteLine("Thank you for using my application. ");
                        break;
                    }
                    double b = Convert.ToDouble(Console.ReadLine());
                    CalculateDel delAdd = new CalculateDel(addDel);
                    CalculateDel delSub = new CalculateDel(subDel);
                    CalculateDel delMul = new CalculateDel(mulDel);
                    CalculateDel delDiv = new CalculateDel(divDel);
                    CalculateDel multicastDel = delAdd + delSub + delMul + delDiv;
                    multiCast(multicastDel, a, b);

                }
            }

            catch (Exception exception)
            { Console.WriteLine("this Input is not correct"); }
        }
    }
}
