namespace Rose.AzureFunctions.Day2;

public interface IRockPaperScissorsGame
{
	int Result();
}

public class RockPaperScissorsGame : IRockPaperScissorsGame
{
	private readonly IHand opponentHand;
	private readonly IHand myHand;

	public RockPaperScissorsGame(IHand opponentHand, IHand myHand)
	{
		this.opponentHand = opponentHand;
		this.myHand = myHand;
	}

	public int Result()
	{
		return this.myHand.Play(this.opponentHand);
	}
}
