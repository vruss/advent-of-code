using System;

namespace Rose.AzureFunctions.Day2;

public class Paper : IHand
{
	public int Worth => 2;

	public int Play(IHand opponentHand)
	{
		return opponentHand switch
		{
			Scissors => this.Worth,
			Paper => this.Worth + IHand.DrawWorth,
			Rock => this.Worth + IHand.WinWorth,
			_ => throw new ArgumentOutOfRangeException(nameof(opponentHand))
		};
	}
}
