using System;


namespace R5T.F0041
{
	public class GitHubOperator : IGitHubOperator
	{
		#region Infrastructure

	    public static IGitHubOperator Instance { get; } = new GitHubOperator();

	    private GitHubOperator()
	    {
        }

	    #endregion
	}
}