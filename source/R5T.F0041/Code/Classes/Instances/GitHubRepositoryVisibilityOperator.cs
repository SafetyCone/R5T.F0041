using System;


namespace R5T.F0041
{
	public class GitHubRepositoryVisibilityOperator : IGitHubRepositoryVisibilityOperator
	{
		#region Infrastructure

	    public static IGitHubRepositoryVisibilityOperator Instance { get; } = new GitHubRepositoryVisibilityOperator();

	    private GitHubRepositoryVisibilityOperator()
	    {
        }

	    #endregion
	}
}