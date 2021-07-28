using System;

namespace Calculator
{
    public class InputConverter
    {
        public double ConvertInput(string argTextInput)
        {
            double convertedNumber;
            if (!double.TryParse(argTextInput, out convertedNumber))
            {
                throw new ArgumentException("Expected a numerical value.");
            }
            return convertedNumber;
        }
    }
}
