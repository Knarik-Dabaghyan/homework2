using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApplication64
{
    public class Calculator
    {
        private string expression { set; get; }
        private double res { set; get; }


        public Calculator()
        {
            Console.WriteLine("Please enter an expression like this -> 1 + 1");
            expression = Console.ReadLine();
        }
        public double Result()
        {

            int tmp = expression.IndexOfAny(new char[] { '+', '-', '/', '*', '%' }), i = 0;
            var y = (expression.Split(new char[] { '+', '-', '/', '*', '%' }));
            switch (expression[tmp])
            {
                case '+':
                    res = int.Parse(y[i]) + int.Parse(y[++i]);
                    break;
                case '-':
                    res = int.Parse(y[i]) - int.Parse(y[++i]);
                    break;
                case '*':
                    res = int.Parse(y[i]) * int.Parse(y[++i]);
                    break;
                case '/':
                    res = int.Parse(y[i]) / int.Parse(y[++i]);
                    break;
                case '%':
                    res = int.Parse(y[i]) % int.Parse(y[++i]);
                    break;
                default:
                    break;

            }
            return res;
        }

            public void Show( ){

            WriteLine($"Result={Result()}");
        }

        


    }

}
