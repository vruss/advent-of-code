using Rose.AzureFunctions.Day2;

namespace Rose.AzureFunctions.Tests.Day2;

[TestClass]
public class PaperTests
{
	[TestMethod]
	public void PaperBeatsRock()
	{
		var sut = new Paper();
		Assert.AreEqual(8, sut.Play(new Rock()));
	}

	[TestMethod]
	public void PaperDrawsPaper()
	{
		var sut = new Paper();
		Assert.AreEqual(5, sut.Play(new Paper()));
	}

	[TestMethod]
	public void PaperLosesToScissors()
	{
		var sut = new Paper();
		Assert.AreEqual(2, sut.Play(new Scissors()));
	}
}
