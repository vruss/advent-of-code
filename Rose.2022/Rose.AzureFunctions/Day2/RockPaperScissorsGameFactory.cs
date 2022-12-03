using System;

namespace Rose.AzureFunctions.Day2;

public interface IRockPaperScissorsGameFactory
{
	IRockPaperScissorsGame Create(string input);
}

public class RockPaperScissorsGameFactory : IRockPaperScissorsGameFactory
{
	public IRockPaperScissorsGame Create(string input)
	{
		return input.Split(' ') switch
		{
			["A", "X"] => new RockPaperScissorsGame(new Rock(), new Rock()),
			["A", "Y"] => new RockPaperScissorsGame(new Rock(), new Paper()),
			["A", "Z"] => new RockPaperScissorsGame(new Rock(), new Scissors()),
			["B", "X"] => new RockPaperScissorsGame(new Paper(), new Rock()),
			["B", "Y"] => new RockPaperScissorsGame(new Paper(), new Paper()),
			["B", "Z"] => new RockPaperScissorsGame(new Paper(), new Scissors()),
			["C", "X"] => new RockPaperScissorsGame(new Scissors(), new Rock()),
			["C", "Y"] => new RockPaperScissorsGame(new Scissors(), new Paper()),
			["C", "Z"] => new RockPaperScissorsGame(new Scissors(), new Scissors()),
			_ => throw new ArgumentOutOfRangeException(nameof(input), input, null),
		};
	}
}
