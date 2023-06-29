using System;


namespace R5T.F0041
{
	public class GitHubRepositorySpecificationOperator : IGitHubRepositorySpecificationOperator
	{
		#region Infrastructure

	    public static IGitHubRepositorySpecificationOperator Instance { get; } = new GitHubRepositorySpecificationOperator();

	    private GitHubRepositorySpecificationOperator()
	    {
        }

	    #endregion
	}
}