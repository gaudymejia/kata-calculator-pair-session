using FluentAssertions;
using Machine.Specifications;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;


namespace kata_pair_session.Tests
{

        public class when_sum_input_is_empty
        {
            static CalculatorProgram _calculator;

            Establish context = () =>
                _calculator = new CalculatorProgram();

            Because of = () =>
                _calculator.SumValues(new List<decimal>());

            It should_numbers_are_empty = () =>
                _calculator.Results.Should().Contain(0);
        }
    
}
