using System;
using System.Collections.Generic;
using System.Text;

namespace kata_pair_session
{
    public class CalculatorProgram
    {
        public CalculatorProgram()
        {
            Results = new List<decimal>();

        }

        public IList<decimal> Results { get; set; }


        public void SumValues(List<decimal> numbersToCalculate)
        {
            decimal sumAcumulated = 0;
            foreach (var number in numbersToCalculate)
            {
                sumAcumulated = sumAcumulated + number;
            }
            Results.Add(sumAcumulated);
        }
    }
}

