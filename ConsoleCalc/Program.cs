using System;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Console Calculator!");
            Console.WriteLine("Input first operand: ");
            double firstOperand = Calculator.NumInput();
            Console.WriteLine();
            Console.Write("Input operator (+ - * / % sqrt !): ");

            bool isSecondNeed = Calculator.OperatorInput(out string marhOperator);
            double secondOperand = 0;
            if (isSecondNeed)
            {
                Console.WriteLine("Input scond operand: ");
                secondOperand = Calculator.NumInput();
            }
            double result = 0;

            switch (marhOperator)
            {
                case "+":
                    Calculator.Add(firstOperand, secondOperand);
                    break;
                case "-":
                    Calculator.Subtract(firstOperand, secondOperand);
                    break;
                case "*":
                    Calculator.Multiply(firstOperand, secondOperand);
                    break;
                case "/":
                    Calculator.Divide(firstOperand, secondOperand);
                    break;
                case "%":
                    Calculator.RestOfDivide(firstOperand, secondOperand);
                    break;
                //case "^":
                //    //Calculator.Add(firstOperand, secondOperand);
                //    break;
                //case "sqrt":
                //    //Calculator.Add(firstOperand, secondOperand);
                //    break;
                //case "!":
                //    //Calculator.Add(firstOperand, secondOperand);
                //    break;
                default:
                    Console.WriteLine("no such operator '\\_O_/'");
                    break;
            }
        }
    }
}
