using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterApp
{
    class Program
    {
        public static int counter;
        public static string[] lastfive = new string[6];

        static void Main(string[] args)
        {
            //run method
            run();
        }

        

        public static void run()
        {
            //initialise variables
            double result = 0;
            double inputnum;
            int conversiontype;
            
     

            //select conversion type
            Console.WriteLine("Please Select a Method of Conversion");
            Console.WriteLine("1. Convert Centimetres to Inches");
            Console.WriteLine("2. Convert Metres to Feet");
            Console.WriteLine("3. Convert Celsius to Fahrenheit");
            Console.WriteLine("4. Convert Centimetres to Feet");
            Console.WriteLine("5. Convert Kilometres to Miles");

            bool intoint = int.TryParse(Console.ReadLine(), out conversiontype);
            if (!intoint)
            {
                Console.WriteLine("Please Enter a valid number");
                Console.ReadLine();
                run();
                return;
            }

            //-------------------------------
            // select  number to convert
            Console.WriteLine("-------------------------");
            Console.WriteLine("Please Enter the number to convert");
            bool intodub = double.TryParse(Console.ReadLine(), out inputnum);
            if (!intodub)
            {
                Console.WriteLine("Please Enter a valid number");
                Console.ReadLine();
                run();
                return;
            }

            Console.WriteLine("-------------------------");
            // convert based on type
            switch (conversiontype)
            {
                case 1:

                    result = inputnum * 0.393701;
                    break;

                case 2:
                    result = inputnum * 3.28084;
                    break;

                case 3:
                    result = (inputnum * 9) / 5 + 32;
                    break;

                case 4:
                    result = inputnum * 0.0328084;
                    break;

                case 5:
                    result = inputnum * 0.621371;
                    break;

                default:
                    Console.WriteLine("No Number entered");
                    break;

            }
            // print result
            Console.WriteLine(result.ToString());

            counter++;
            if(counter > 5)
            {
                counter = 1;
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine("Previous results");
            lastfive[counter] = result.ToString();

            for (int i = 0; i < lastfive.Length; i++)
            {
                Console.WriteLine(lastfive[i]);
            }

            Console.WriteLine("-------------------------");
            Console.ReadLine();
            run();

        }


       
    }
}
