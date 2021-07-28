using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                Console.WriteLine("CALCULATOR");

                Console.Write("First number: ");
                double firstNumber = inputConverter.ConvertInput(Console.ReadLine());

                Console.Write("Second number: ");
                double secondNumber = inputConverter.ConvertInput(Console.ReadLine());

                Console.Write("Operator (+-*/): ");
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                // TODO: start logging exceptions
                Console.WriteLine(ex.Message);
            }
        }
    }
}
