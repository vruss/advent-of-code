namespace Rose.AzureFunctions.Day2;

public interface IHand
{
	const int WinWorth = 6;
	const int DrawWorth = 3;

	int Worth { get; }
	int Play(IHand opponentHand);
}
