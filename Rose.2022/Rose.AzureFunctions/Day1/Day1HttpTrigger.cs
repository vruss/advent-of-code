using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace Rose.AzureFunctions.Day1;

public class Day1HttpTrigger
{
	private readonly ICalorieCounter calorieCounter;

	public Day1HttpTrigger(ICalorieCounter calorieCounter)
	{
		this.calorieCounter = calorieCounter;
	}

	[FunctionName("Day1HttpTrigger")]
	public async Task<IActionResult> RunAsync([HttpTrigger(AuthorizationLevel.Function
			, "post"
			, Route = null
		)]
		HttpRequest req
		, ILogger log
	)
	{
		log.LogInformation("C# HTTP trigger function processed a request.");

		var requestBody = await new StreamReader(req.Body).ReadToEndAsync();

		var mostCalories = this.calorieCounter.GetMostCalories(requestBody, 1);
		var top3Calories = this.calorieCounter.GetMostCalories(requestBody, 3);

		return new OkObjectResult($"Answer to first: {mostCalories}\nAnswer to second: {top3Calories}");
	}
}
