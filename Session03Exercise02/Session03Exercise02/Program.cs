using System;
using System.Diagnostics;
using System.Globalization;

namespace Session03Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett antal siffror, separerat med kommatecken.");
            var input = Console.ReadLine();
            var inputArray = input.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            double?[] numberArray = new double?[inputArray.Length];

            //for (int i = 0; i < inputArray.Length; i++)
            //{
            //    try
            //    {
            //        numberArray[i] = Convert.ToDouble(inputArray[i]);

            //    }

            //    catch (Exception)
            //    {
            //        numberArray[i] = 0;
            //    }

            //    finally
            //    {
            //        Console.WriteLine("Finally skrivs ALLTID!");
            //    }
            //}

            for (int i = 0; i < inputArray.Length; i++)
            {
                NumberStyles numberStyle = NumberStyles.Integer | NumberStyles.Float;

                bool parsed = double.TryParse(inputArray[i], numberStyle, CultureInfo.InvariantCulture, out double parsedValue);

                if (parsed)
                {
                    numberArray[i] = parsedValue;
                }
                else
                {
                    numberArray[i] = null;
                }
            }

            foreach (var number in numberArray)
            {
                Console.WriteLine("Värdet är " + number.ToString());
            }
        }
    }
}