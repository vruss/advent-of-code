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

		var rockPaperScissorsGames = response
			.Split(newLine)
			.Select(x => this.paperScissorsGameFactory.Create(x));

		var totalScore = rockPaperScissorsGames
			.Sum(x => x.Result());

		return new OkObjectResult($"Answer to first: {totalScore}\nAnswer to second: NA");
	}
}
