using System;

namespace TablizaUmnojeniya
{
    public class Program
    {
        public static void Main()    
        {
            while (true)
            {
                Console.WriteLine("\t\tПроверьте Ваши знания таблицы умножения");
                int firstNumber = GetRandomNumber();
                int secondNumber = GetRandomNumber();
                int res = GetResult(firstNumber, secondNumber);
                WriteCase(firstNumber, secondNumber);
                Validate(res);

                if (IsEnd())
                    break;
            }
        }

        private static int GetRandomNumber()
        {
            Random rnd = new Random();
            return rnd.Next(1, 10);
        }

        public static int GetResult(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        static void WriteCase(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Пример: {0} * {1}", firstNumber, secondNumber);
        }

        static int GetAnswer()
        {
            Console.WriteLine("Введите ответ:");
            return int.Parse(Console.ReadLine());
        }

        public static bool Validate_(int answer, int res)
        {
            return answer == res;
        }

        static void Validate(int res)
        {
            if (Validate_(GetAnswer(), res)) Console.WriteLine("Правильно");
            else Console.WriteLine("Не правильно. Ответ {0}", res);
        }

        public static bool IsEnd_(string answer)
        {
            return answer == "n";
        }

        static bool IsEnd()
        {
            Console.WriteLine("Если вы хотите выйти, нажмите \"n\"");
            Console.WriteLine("Если хотите продолжить нажмите любую клавишу");
            var answer = Console.ReadLine();
            return IsEnd_(answer);
        }
    }
}
