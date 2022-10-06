using System;

using R5T.T0131;


namespace R5T.F0041
{
	[ValuesMarker]
	public partial interface IFilePaths : IValuesMarker
	{
		public string GitHubAuthenticationFile_Json => @"C:\Users\David\Dropbox\Organizations\Rivet\Shared\Data\Secrets\Authentication-GitHub-Aalborg.json";
		public string GitHubAuthorFile_Json => @"C:\Users\David\Dropbox\Organizations\Rivet\Shared\Data\Secrets\GitHub-Author-David.json";
	}
}