using System;

namespace Rose.AzureFunctions;

public interface INewLineResolver
{
	string Resolve(string input);
}

public class NewLineResolver : INewLineResolver
{
	public string Resolve(string input)
	{
		if (input.Contains(Environment.NewLine))
		{
			return Environment.NewLine;
		}

		return "\n";
	}
}
