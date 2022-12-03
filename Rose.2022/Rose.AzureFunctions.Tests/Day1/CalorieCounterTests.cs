using Rose.AzureFunctions.Day1;

namespace Rose.AzureFunctions.Tests.Day1;

[TestClass]
public class CalorieCounterTests
{
	[TestMethod]
	public void ShouldReturnTheMostCalories()
	{
		var input = @"1000
2000
3000

4000

5000
6000

7000
8000
9000

10000";

		var sut = new CalorieCounter(new NewLineResolver());

		Assert.AreEqual(24000, sut.GetMostCalories(input, 1));
	}

	[TestMethod]
	public void ShouldReturnTheTop3Calories()
	{
		var input = @"1000
2000
3000

4000

5000
6000

7000
8000
9000

10000";

		var sut = new CalorieCounter(new NewLineResolver());

		Assert.AreEqual(45000, sut.GetMostCalories(input, 3));
	}
}
