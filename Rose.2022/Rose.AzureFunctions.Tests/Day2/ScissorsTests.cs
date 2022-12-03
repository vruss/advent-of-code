using Rose.AzureFunctions.Day2;

namespace Rose.AzureFunctions.Tests.Day2;

[TestClass]
public class ScissorsTests
{
	[TestMethod]
	public void ScissorsDrawsScissors()
	{
		var sut = new Scissors();
		Assert.AreEqual(6, sut.Play(new Scissors()));
	}

	[TestMethod]
	public void ScissorsBeatsPaper()
	{
		var sut = new Scissors();
		Assert.AreEqual(9, sut.Play(new Paper()));
	}

	[TestMethod]
	public void ScissorsLosesToRock()
	{
		var sut = new Scissors();
		Assert.AreEqual(3, sut.Play(new Rock()));
	}
}
