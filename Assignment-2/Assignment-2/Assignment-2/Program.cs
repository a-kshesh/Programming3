using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
       
        public delegate bool Order(int stockAvailability, int sold);
      
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("cars available in stocks");
                int stockAvailability = Convert.ToInt32(Console.ReadLine());
                Program p = new Program();
                Order reOrder = new Order(p.CarSell);
                while (true)
                {
                    Console.WriteLine("To exit the program enter -1");
                    Console.WriteLine("cars sold today");
                    int soldCar = Convert.ToInt32(Console.ReadLine());

                    if (reOrder(stockAvailability, soldCar) == false)
                    {
                        Console.WriteLine("Stock is almost Empty please re-Stock");
                        Console.WriteLine("Please Re-order");
                        stockAvailability += Convert.ToInt32(Console.ReadLine());

                    }
                    else if(soldCar==-1)
                    {
                        Console.WriteLine("Thank you for using my car inventory application");
                        break;
                    }
                    else
                    {
                        stockAvailability = stockAvailability - soldCar;
                    }
                    
                }
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }
        public bool CarSell(int stockAvailability, int sold)
        {
            return stockAvailability - sold > 2;
        }
    }
}
