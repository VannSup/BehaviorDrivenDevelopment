using System;

namespace BehaviorDrivenDevelopment
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }

        public int Subtract()
        {
            return FirstNumber - SecondNumber;
        }

        public int Multiply()
        {
            return FirstNumber * SecondNumber;
        }

        public int Divide()
        {
            try
            {
                return FirstNumber / SecondNumber;
            }
            catch(Exception e)
            {
                if (SecondNumber == 0)
                    throw new InvalidOperationException("Cannot divide by 0");
                else
                    throw e;
            }
        }
    }
}
