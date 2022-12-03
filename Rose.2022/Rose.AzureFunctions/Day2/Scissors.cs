using System;

namespace Rose.AzureFunctions.Day2;

public class Scissors : IHand
{
	public int Worth => 3;

	public int Play(IHand opponentHand)
	{
		return opponentHand switch
		{
			Rock => this.Worth,
			Scissors => this.Worth + IHand.DrawWorth,
			Paper => this.Worth + IHand.WinWorth,
			_ => throw new ArgumentOutOfRangeException(nameof(opponentHand))
		};
	}
}
