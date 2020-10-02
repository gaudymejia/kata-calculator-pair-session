using FluentAssertions;
using Machine.Specifications;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;


namespace kata_pair_session.Tests
{

        public class when_sum_input_numbers_are_negative
        {
            static CalculatorProgram _calculator;

            Establish context = () =>
                _calculator = new CalculatorProgram();

            Because of = () =>
                _calculator.SumValues(new List<decimal>()
                    { -8, -3, -2 });

            It should_numbers_are_negative_not_saved_sum = () =>
                _calculator.Results.Should().HaveCount(0);
    }
    
}
