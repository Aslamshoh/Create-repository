using System;

namespace CalculatorMVC.Models
{
    public class CalculatorModel
    {
        // Операнды (одно из чисел - long, второе - float)
        public long Operand1 { get; set; }
        public float Operand2 { get; set; }

        // Операция (+, -, *, /)
        public string Operation { get; set; }

        // Результат вычисления (float)
        public float Result { get; private set; }

        // Метод вычисления
        public void Calculate()
        {
            switch (Operation)
            {
                case "+":
                    Result = Operand1 + Operand2;
                    break;
                case "-":
                    Result = Operand1 - Operand2;
                    break;
                case "*":
                    Result = Operand1 * Operand2;
                    break;
                case "/":
                    if (Operand2 != 0)
                        Result = Operand1 / Operand2;
                    else
                        throw new DivideByZeroException("Ошибка: деление на ноль!");
                    break;
                default:
                    throw new InvalidOperationException("Неизвестная операция");
            }
        }
    }
}