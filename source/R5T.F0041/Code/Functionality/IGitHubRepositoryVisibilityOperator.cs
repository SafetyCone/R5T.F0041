using System;

using R5T.F0041;
using R5T.T0132;

using Instances = R5T.F0041.Instances;


namespace System
{
	[FunctionalityMarker]
	public partial interface IGitHubRepositoryVisibilityOperator : IFunctionalityMarker
	{
		public bool IsPrivate(GitHubRepositoryVisibility gitHubRepositoryVisibility)
		{
			var isPrivate = Instances.GitHubRepositoryVisibilityOperator.IsPrivate(gitHubRepositoryVisibility);
			return isPrivate;
		}
	}
}