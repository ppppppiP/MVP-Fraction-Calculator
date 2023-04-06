using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Fraction_Calculator
{
   class FractionPresenter
    {
        public void MultiplyFractions(int numerator1, int denominator1, int numerator2, int denominator2, out int resultNumerator, out int resultDenominator)
        {
            resultNumerator = numerator1 * numerator2;
            resultDenominator = denominator1 * denominator2;
        }

        public void DivideFractions(int numerator1, int denominator1, int numerator2, int denominator2, out int resultNumerator, out int resultDenominator)
        {
            resultNumerator = numerator1 * denominator2;
            resultDenominator = denominator1 * numerator2;
        }
    }
}
