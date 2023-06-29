using System;

using R5T.T0132;


namespace R5T.F0041
{
	[FunctionalityMarker]
	public partial interface IGitHubRepositoryVisibilityOperator : IFunctionalityMarker
	{
		public GitHubRepositoryVisibility Get_GitHubRepositoryVisibility(bool isPrivate)
		{
			var output = isPrivate
				? GitHubRepositoryVisibility.Private
				: GitHubRepositoryVisibility.Public
				;

			return output;
		}

		public bool IsPrivate(GitHubRepositoryVisibility gitHubRepositoryVisibility)
		{
			var isPrivate = Instances.GitHubRepositoryVisibilityOperator.IsPrivate(gitHubRepositoryVisibility);
			return isPrivate;
		}
	}
}