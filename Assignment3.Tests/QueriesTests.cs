using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace BDSA2021.Assignment3.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void getRowlingWizards_given_wizards_returns_only_HP_wizards()
        {
            var actual = Queries.getRowlingWizards(Wizard.Wizards);
            var expected = new List<string>{"Harry Potter", "Ron Weasley", "Hermione Granger", "Albus Dumbledore"};
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void getRowlingWizardsLINQ_given_wizards_returns_only_HP_wizards()
        {
            var actual = Queries.getRowlingWizardsLINQ(Wizard.Wizards);
            var expected = new List<string>{"Harry Potter", "Ron Weasley", "Hermione Granger", "Albus Dumbledore"};
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void getFirstSithLordYear_given_wizards_return_1977()
        {
            var actual = Queries.getFirstSithLordYear(Wizard.Wizards);
            Assert.Equal(1977, actual);
        }

        [Fact]
        public void getFirstSithLordLINQ_given_wizards_return_1977()
        {
            var actual = Queries.getFirstSithLordYearLINQ(Wizard.Wizards);
            Assert.Equal(1977, actual);
        }

        [Fact]
        public void getHarryPotterWizards_given_wizards_return_unique_HP_wizards_and_year()
        {
            var actual = Queries.getHarryPotterWizards(Wizard.Wizards);
            var expected = new List<(string,int?)>{("Harry Potter",1997), ("Ron Weasley",1997), ("Hermione Granger",1997), ("Albus Dumbledore",1997)};
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void getHarryPotterWizardsLINQ_given_wizards_return_unique_HP_wizards_and_year()
        {
            var actual = Queries.getHarryPotterWizardsLINQ(Wizard.Wizards);
            var expected = new List<(string,int?)>{("Harry Potter",1997), ("Ron Weasley",1997), ("Hermione Granger",1997), ("Albus Dumbledore",1997)};
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void getSortedWizards_given_wizards_return_yoda_last()
        {
            var actual = Queries.getSortedWizards(Wizard.Wizards).Last();
            var expected = "Yoda";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void getSortedWizardsLINQ_given_wizards_return_yoda_last()
        {
            var actual = Queries.getSortedWizardsLINQ(Wizard.Wizards).Last();
            var expected = "Yoda";
            Assert.Equal(expected, actual);
        }
    }
}
