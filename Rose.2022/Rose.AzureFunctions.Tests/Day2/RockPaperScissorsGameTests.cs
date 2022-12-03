using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rose.AzureFunctions.Day2;

namespace Rose.AzureFunctions.Tests.Day2;

[TestClass]
public class RockPaperScissorsGameTests
{
	[TestMethod]
	public void Test()
	{
		var round1 = new RockPaperScissorsGame(new Rock(), new Paper());

		var result1 = round1.Result();
		Assert.AreEqual(8, result1);

		var round2 = new RockPaperScissorsGame(new Paper(), new Rock());

		var result2 = round2.Result();
		Assert.AreEqual(1, result2);

		var round3 = new RockPaperScissorsGame(new Scissors(), new Scissors());

		var result3 = round3.Result();
		Assert.AreEqual(6, result3);
	}
}
