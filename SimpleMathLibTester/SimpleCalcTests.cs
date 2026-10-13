using static SimpleMathLib.SimpleCalc;

namespace SimpleMathLibTester
{
    /*
     * Principles of Automated Testing
     * 1. Be granular, test exactly one thing.
     * 2. Every test should think it's the only test.
     * 3. Every test should start from a place of newness.
     * 4. Test every possible path.
     */
    public class SimpleCalcTests
    {
        // To name a test, we often use the name of the unit
        // under test, underscore, scenario [, underscore,
        // expected result]
        [Fact]
        public void Add_BothPositive()
        {
            // To set up a test, follow the AAA approach:
            // Arrange
            int x = 5;
            int y = 34;
            int expected = 39;

            // Act
            int actual = Add(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Add_BothNegative()
        {
            // Arrange
            int x = -34;
            int y = -10;
            int expected = -44;
            // Act
            int actual = Add(x, y);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
