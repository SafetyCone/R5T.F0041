using System;


namespace R5T.F0041
{
	public class GitHubRepositoryLicenseOperator : IGitHubRepositoryLicenseOperator
	{
		#region Infrastructure

	    public static IGitHubRepositoryLicenseOperator Instance { get; } = new GitHubRepositoryLicenseOperator();

	    private GitHubRepositoryLicenseOperator()
	    {
        }

	    #endregion
	}
}