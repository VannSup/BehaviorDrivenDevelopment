using System;
using System.Collections.Generic;

namespace BehaviorDrivenDevelopment
{
    public class Calculator
    {

        public List<int> InputsNumbers { get; set; }

        public Calculator()
        {
            InputsNumbers = new List<int>();
        }

        public int Add()
        {
            try
            {
                int result = InputsNumbers[0];
                int index = 0;
                InputsNumbers.ForEach(number =>
                    {
                        if (index != 0)
                            result += number;
                        index++;
                    }
                );
                return result;
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }

        public int Subtract()
        {
            try
            {
                int result = InputsNumbers[0];
                int index = 0;
                InputsNumbers.ForEach(number =>
                    {
                        if (index != 0)
                            result -= number;
                        index++;
                    }
                );
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }

        public int Multiply()
        {
            try
            {
                int result = InputsNumbers[0];
                int index = 0;
                InputsNumbers.ForEach(number =>
                    {
                        if (index != 0)
                            result *= number;
                        index++;
                    }
                );
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int Divide()
        {
            try
            {
                int result = InputsNumbers[0];
                int index = 0;
                InputsNumbers.ForEach(number =>
                    {
                        if (index != 0)
                            result /= number;
                        index++;
                    }
                );
                return result;
            }
            catch(Exception e)
            {
                if (e.Message == "Attempted to divide by zero.")
                    throw new InvalidOperationException("Cannot divide by 0");
                else
                    throw e;
            }
        }
    }
}
