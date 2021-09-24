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
    }
}
