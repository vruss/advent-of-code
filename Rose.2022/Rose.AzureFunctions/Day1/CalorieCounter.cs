using System.Collections.Generic;
using System.Linq;

namespace Rose.AzureFunctions.Day1;

public interface ICalorieCounter
{
	int GetMostCalories(string input, int topCount);
}

public class CalorieCounter : ICalorieCounter
{
	private readonly INewLineResolver newLineResolver;

	public CalorieCounter(INewLineResolver newLineResolver)
	{
		this.newLineResolver = newLineResolver;
	}

	public int GetMostCalories(string input, int topCount)
	{
		var newLine = this.newLineResolver.Resolve(input);

		var caloriesPerElf = input
			.Split($"{newLine}{newLine}");

		var sums = new List<int>(caloriesPerElf.Length);

		foreach (var elfCalories in caloriesPerElf)
		{
			sums.Add(elfCalories
				.Split(newLine)
				.Select(int.Parse)
				.Sum()
			);
		}

		return sums
			.OrderByDescending(x => x)
			.Take(topCount)
			.Sum();
	}
}
