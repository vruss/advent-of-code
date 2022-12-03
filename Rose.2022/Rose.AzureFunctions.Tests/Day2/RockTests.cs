using Rose.AzureFunctions.Day2;

namespace Rose.AzureFunctions.Tests.Day2;

[TestClass]
public class RockTests
{
	[TestMethod]
	public void RockDrawsRock()
	{
		var sut = new Rock();
		Assert.AreEqual(4, sut.Play(new Rock()));
	}

	[TestMethod]
	public void RockLosesToPaper()
	{
		var sut = new Rock();
		Assert.AreEqual(1, sut.Play(new Paper()));
	}

	[TestMethod]
	public void RockBeatsScissors()
	{
		var sut = new Rock();
		Assert.AreEqual(7, sut.Play(new Scissors()));
	}
}
