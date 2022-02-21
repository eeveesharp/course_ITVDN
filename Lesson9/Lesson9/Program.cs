using System;

namespace Lesson9
{
    class Program
    {
        public delegate double Operation(double a, double b);

        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");

            double firstNumber = GetCorrectNumber();

            Console.WriteLine("Введите второе число");

            double secondNumber = GetCorrectNumber();

            Menu(firstNumber, secondNumber);
        }

        static public double GetCorrectNumber()
        {
            double number;

            while (!double.TryParse(Console.ReadLine(),out number))
            {
                Console.WriteLine("Введите число");
            }

            return number;
        }

        static public void Menu(double firstNumber,double secondNumber)
        {
            Operation operation = null;

            Console.WriteLine("Выберите операцию\n" +
                "+\n" +
                "-\n" +
                "/\n" +
                "*");

            char choose = char.Parse(Console.ReadLine());

            switch (choose)
            {
                case '+':
                    {
                        operation = (firstNumber, secondNumber) => { return firstNumber + secondNumber; };

                        break;
                    }
                case '-':
                    {
                        operation = (firstNumber, secondNumber) => firstNumber - secondNumber;

                        break;
                    }
                case '/':
                    {
                        operation = (firstNumber, secondNumber) => {

                            if (secondNumber == 0)
                            {
                                Console.WriteLine("На ноль делите нельзя");

                                return 0;
                            }
                            else 
                                return firstNumber / secondNumber;
                        };

                        break;
                    }
                case '*':
                    {
                        operation = (firstNumber, secondNumber) => firstNumber * secondNumber;

                        break;
                    }
                default:

                    Console.WriteLine("Вы ввели некорректное значение");

                    break;
            }

            if (operation != null)
            {
                Console.WriteLine($"Ответ:{operation(firstNumber,secondNumber)}");
            }
        }
    }
}
