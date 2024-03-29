using System;
using System.Threading.Tasks;

using CliWrap;

using R5T.F0078.Extensions;
using R5T.T0132;


namespace R5T.F0088
{
	[FunctionalityMarker]
	public partial interface IVisualStudioOperator : IFunctionalityMarker
	{
		public void Open_SolutionFile(string solutionFilePath)
		{
			var command = Cli.Wrap(@"C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe")
				.WithArguments(argumentsBuilder =>
				{
					argumentsBuilder.Add(solutionFilePath, true);
				})
				.WithConsoleError()
				.WithConsoleOutput()
				;

			// Do not await. (Since completion will only come when the Visual Studio instance is closed!)
			command.ExecuteAsync();
		}

		public void Open_ProjectFile(string projectFilePath)
		{
            var command = Cli.Wrap(@"C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe")
                .WithArguments(argumentsBuilder =>
                {
                    argumentsBuilder.Add(projectFilePath, true);
                })
                .WithConsoleError()
                .WithConsoleOutput()
                ;

            // Do not await. (Since completion will only come when the Visual Studio instance is closed!)
            command.ExecuteAsync();
        }
	}
}