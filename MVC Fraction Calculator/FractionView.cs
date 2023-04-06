using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Fraction_Calculator
{
  class FractionView : IFractionView
    {
        private readonly FractionPresenter presenter;

        public FractionView(FractionPresenter presenter)
        {
            this.presenter = presenter;
        }

        public void Run()
        {
            while (true)
            {
                Console.Write("Введите первую дробь в формате 'a/b': ");
                string input1 = Console.ReadLine();
                Console.Write("Введите вторую дробь в формате 'c/d': ");
                string input2 = Console.ReadLine();
                Console.Write("Введите операцию (1 - умножение, 2 - деление): ");
                string op = Console.ReadLine();

                int numerator1, denominator1, numerator2, denominator2;
                if (!TryParseFraction(input1, out numerator1, out denominator1) ||
                    !TryParseFraction(input2, out numerator2, out denominator2))
                {
                    Console.WriteLine("Неверный формат дроби!");
                    continue;
                }

                int resultNumerator, resultDenominator;
                switch (op)
                {
                    case "1":
                        presenter.MultiplyFractions(numerator1, denominator1, numerator2, denominator2, out resultNumerator, out resultDenominator);
                        Console.WriteLine("{0}/{1} * {2}/{3} = {4}/{5}", numerator1, denominator1, numerator2, denominator2, resultNumerator, resultDenominator);
                        break;

                    case "2":
                        if (numerator2 == 0)
                        {
                            Console.WriteLine("Деление на ноль!");
                            continue;
                        }

                        presenter.DivideFractions(numerator1, denominator1, numerator2, denominator2, out resultNumerator, out resultDenominator);
                        Console.WriteLine("{0}/{1} / {2}/{3} = {4}/{5}", numerator1, denominator1, numerator2, denominator2, resultNumerator, resultDenominator);
                        break;

                    default:
                        Console.WriteLine("Неверный выбор операции!");
                        break;
                }
            }
        }
        private bool TryParseFraction(string input, out int numerator, out int denominator)
        {
            numerator = 0;
            denominator = 0;

            string[] parts = input.Split('/');
            if (parts.Length != 2)
            {
                return false;
            }

            if (!int.TryParse(parts[0], out numerator) || !int.TryParse(parts[1], out denominator) || denominator == 0)
            {
                return false;
            }

            return true;
        }
    }

    
}
