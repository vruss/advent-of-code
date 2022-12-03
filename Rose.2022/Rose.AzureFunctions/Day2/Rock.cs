using System;

namespace Rose.AzureFunctions.Day2;

public class Rock : IHand
{
	public int Worth => 1;

	public int Play(IHand opponentHand)
	{
		return opponentHand switch
		{
			Paper => this.Worth,
			Rock => this.Worth + IHand.DrawWorth,
			Scissors => this.Worth + IHand.WinWorth,
			_ => throw new ArgumentOutOfRangeException(nameof(opponentHand))
		};
	}
}
