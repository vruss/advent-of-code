namespace Rose.AzureFunctions.Tests;

[TestClass]
public class NewLineResolverTests
{
	[TestMethod]
	[DataRow("1234\n5123", "\n")]
	[DataRow("1234\r\n5123", "\r\n")]
	public void ShouldResolveCorrectNewLine(string input, string expected)
	{
		var sut = new NewLineResolver();

		Assert.AreEqual(expected, sut.Resolve(input));
	}
}
