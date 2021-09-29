using Xunit;

namespace BDSA2021.Assignment3.Tests
{
    public class WizardTests
    {
        [Fact]
        public void Wizards_contains_12_wizards()
        {
            var wizards = Wizard.Wizards.Value;

            Assert.Equal(12, wizards.Count);
        }

        [Theory]
        [InlineData("Darth Vader", "Star Wars", 1977, "George Lucas")]
        [InlineData("Sauron", "The Fellowship of the Ring", 1954, "J.R.R. Tolkien")]
        [InlineData("Darth Maul","Star Wars",1999,"George Lucas")]
        [InlineData("Yoda","Star Wars",1980,"George Lucas")]
        [InlineData("Obi-Wan Kenobi","Star Wars",1977,"George Lucas")]
        [InlineData("Harry Potter","Harry Potter",1997,"J.K. Rowling")]
        [InlineData("Ron Weasley","Harry Potter",1997,"J.K. Rowling")]
        [InlineData("Hermione Granger","Harry Potter",1997,"J.K. Rowling")]
        [InlineData("Albus Dumbledore","Harry Potter",1997,"J.K. Rowling")]
        [InlineData("Gandalf","The Hobbit",1937,"J.R.R. Tolkien")]
        [InlineData("Doctor Stephen Strange","Strange Tales",1963,"Stan Lee & Steve Ditko")]
        [InlineData("Ganon","The Legend of Zelda",1986,"Shigeru Miyamoto")]
        public void Spot_check_wizards(string name, string medium, int year, string creator)
        {
            var wizards = Wizard.Wizards.Value;

            Assert.Contains(wizards, w =>
                w.Name == name &&
                w.Medium == medium &&
                w.Year == year &&
                w.Creator == creator
            );
        }
    }
}

