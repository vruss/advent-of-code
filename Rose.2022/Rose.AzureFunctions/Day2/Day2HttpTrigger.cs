using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Rose.AzureFunctions.Day2;

public class Day2HttpTrigger
{
	private readonly IRockPaperScissorsGameFactory paperScissorsGameFactory;
	private readonly INewLineResolver newLineResolver;

	public Day2HttpTrigger(IRockPaperScissorsGameFactory paperScissorsGameFactory
		, INewLineResolver newLineResolver
		)
	{
		this.paperScissorsGameFactory = paperScissorsGameFactory;
		this.newLineResolver = newLineResolver;
	}

	[FunctionName("Day2HttpTrigger")]
	public async Task<IActionResult> RunAsync([HttpTrigger(AuthorizationLevel.Function
			, "post"
			, Route = null
		)]
		HttpRequest req
		, ILogger log
	)
	{
		log.LogInformation("C# HTTP trigger function processed a request.");

		var response = await new StreamReader(req.Body).ReadToEndAsync();
		var newLine = this.newLineResolver.Resolve(response);

		var games = response
			.Split(newLine)
			.ToList();

		var rockPaperScissorsGames1 = games
			.Select(x => this.paperScissorsGameFactory.Create(x));

		var totalScore1 = rockPaperScissorsGames1
			.Sum(x => x.Result());

		var rockPaperScissorsGames2 = games
			.Select(x => this.paperScissorsGameFactory.Create2(x));

		var totalScore2 = rockPaperScissorsGames2
			.Sum(x => x.Result());

		return new OkObjectResult($"Answer to first: {totalScore1}\nAnswer to second: {totalScore2}");
	}
}
