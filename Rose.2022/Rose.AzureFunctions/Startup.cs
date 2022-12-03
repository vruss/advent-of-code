using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Rose.AzureFunctions.Day1;
using Rose.AzureFunctions.Day2;

[assembly: FunctionsStartup(typeof(Rose.AzureFunctions.Startup))]

namespace Rose.AzureFunctions
{
	public class Startup : FunctionsStartup
	{
		public override void Configure(IFunctionsHostBuilder builder)
		{
			builder.Services.AddHttpClient();

			builder.Services.AddSingleton<ICalorieCounter, CalorieCounter>();
			builder.Services.AddSingleton<INewLineResolver, NewLineResolver>();
			builder.Services.AddSingleton<IRockPaperScissorsGameFactory, RockPaperScissorsGameFactory>();
		}
	}
}
