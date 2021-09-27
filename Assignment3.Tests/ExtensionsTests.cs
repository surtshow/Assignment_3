using System;
using Xunit;
using System.Collections.Generic;

namespace BDSA2021.Assignment3.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void Flatten_given_1_2_and_3_4_return_1_2_3_4()
        {
            IEnumerable<int> innerlist1 = new List<int>{1,2};
            IEnumerable<int> innerlist2 = new List<int>{3,4};
            IEnumerable<int>[] outerlist = {innerlist1, innerlist2};

            IEnumerable<int> actuel = outerlist.Flatten();

            IEnumerable<int> expected = new List<int>{1,2,3,4};
            Assert.Equal(expected, actuel);
        }

        [Fact]
        public void Filter_given_14_49_54_56_60_return_49_56()
        {
            var input = new List<int>{14,49,54,56,60};
            var output = input.Filter<int>();
            var expected = new List<int>{49,56};
            Assert.Equal(expected,output);
        }

        [Fact]
        public void LeapYear_given_4_100_1643_2001_2020_4000_return_4_2020_4000()
        {
            var input = new[]{4,100,1643,2001,2020,4000};
            var output = input.LeapYearFilter<int>();
            var expected = new[]{4,2020,4000};
            Assert.Equal(expected,output);
        }
    }
}
