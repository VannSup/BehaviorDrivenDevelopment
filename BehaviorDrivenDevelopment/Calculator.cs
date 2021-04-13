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
            throw new NotImplementedException();
        }

        public int Divide()
        {
            throw new NotImplementedException();
        }
    }
}
