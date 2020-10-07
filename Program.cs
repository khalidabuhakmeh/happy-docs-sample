using System;

namespace happy_docs_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            //begin-snippet: new-calculator
            var calculator = new Calculator();
            // end-snippet

            int result;
            
            //begin-snippet: add-example
            result = calculator.Add(1, 1);
            // result is 2
            Console.WriteLine(result);
            // end-snippet

            //begin-snippet: minus-example
            result = calculator.Minus(1, 1);
            // result is 0
            Console.WriteLine(result);
            // end-snippet

            //begin-snippet: multiply-example
            result = calculator.Multiply(2, 2);
            // result is 4
            Console.WriteLine(result);
            // end-snippet
            
            
            //begin-snippet: divide-example
            result = calculator.Divide(4, 2);
            // result is 2
            Console.WriteLine(result);
            // end-snippet
            
        }
    }

    //begin-snippet: calculator-interface
    public interface ICalculator
    {
        int Add(int x, int y);
        int Minus(int x, int y);
        int Multiply(int x, int y);
        int Divide(int x, int y);
    }
    // end-snippet
    
    class Calculator : ICalculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Minus(int x, int y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Divide(int x, int y)
        {
            return x / y;
        }
    }
    
}
