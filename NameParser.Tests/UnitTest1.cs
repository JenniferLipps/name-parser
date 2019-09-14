using System;
using Xunit;
using NameParser;

namespace NameParser.Tests
{
    public class NameParserTests
    {
        [Fact]
        public void FirstAndLastNameShouldParseAccurately()
        {
            //Arrange
            var name = "Martin Cross";
            var parser = new Parser();

            //Act
            var result = parser.ParseName(name);

            //Assert
            Assert.Equal("Martin", result.FirstName);
            Assert.Equal("Cross", result.LastName);
        }

        [Fact]
        public void ThreePartNamesShouldBeParsedAccurately()
        {
            //Arrange
            var name = "Martin Zachariah Cross";
            var parser = new Parser();

            //Act
            var result = parser.ParseName(name);

            //Assert
            Assert.Equal("Martin", result.FirstName);
            Assert.Equal("Cross", result.LastName);
        }
    }
}
