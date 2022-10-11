using System;

using Octokit;

using R5T.T0132;


namespace R5T.F0041
{
	/// <summary>
	/// The Octokit <see cref="Repository"/> operator.
	/// </summary>
	[FunctionalityMarker]
	public partial interface IRepositoryOperator : IFunctionalityMarker
	{
		/// <summary>
		/// Gets the HTML URL of the repository (ex: https://github.com/SafetyCone/R5T.F0057).
		/// </summary>
		public string GetRepositoryUrl(Repository repository)
        {
			var repositoryUrl = repository.HtmlUrl;
			return repositoryUrl;
        }
	}
}