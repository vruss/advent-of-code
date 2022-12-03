using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rose.AzureFunctions.Day2;

namespace Rose.AzureFunctions.Tests.Day2;

[TestClass]
public class RockPaperScissorsGameFactoryTests
{
	[TestMethod]
	[DataRow("A Y", 8)]
	[DataRow("B X", 1)]
	[DataRow("C Z", 6)]
	public void CanCreateGames(string input, int expected)
	{
		var sut = new RockPaperScissorsGameFactory();

		var rockPaperScissorsGame = sut.Create(input);

		Assert.AreEqual(expected, rockPaperScissorsGame.Result());
	}

	[TestMethod]
	[DataRow("A X", 4)]
	[DataRow("A Y", 8)]
	[DataRow("A Z", 3)]
	[DataRow("B X", 1)]
	[DataRow("B Y", 5)]
	[DataRow("B Z", 9)]
	[DataRow("C X", 7)]
	[DataRow("C Y", 2)]
	[DataRow("C Z", 6)]
	public void CanCreateAllGames(string input, int expected)
	{
		var sut = new RockPaperScissorsGameFactory();

		var rockPaperScissorsGame = sut.Create(input);

		Assert.AreEqual(expected, rockPaperScissorsGame.Result());
	}

	[TestMethod]
	[DataRow("A Y", 4)]
	[DataRow("B X", 1)]
	[DataRow("C Z", 7)]
	public void CanCreateGames2(string input, int expected)
	{
		var sut = new RockPaperScissorsGameFactory();

		var rockPaperScissorsGame = sut.Create2(input);

		Assert.AreEqual(expected, rockPaperScissorsGame.Result());
	}
}
