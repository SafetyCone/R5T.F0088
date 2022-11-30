using System;
using System.Threading.Tasks;

using CliWrap;

using R5T.F0078;
using R5T.T0132;


namespace R5T.F0088
{
	[FunctionalityMarker]
	public partial interface IVisualStudioOperator : IFunctionalityMarker
	{
		public async Task OpenSolutionFile(string solutionFilePath)
		{
			var command = Cli.Wrap(@"C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe")
				.WithArguments(argumentsBuilder =>
				{
					argumentsBuilder.Add(solutionFilePath, true);
				})
				.WithConsoleError()
				.WithConsoleOutput()
				;

			var execution = command.ExecuteAsync();

			// Do not await.
		}
	}
}