using System;


namespace R5T.F0041
{
	public class GitHubLicenseIdentifiers : IGitHubLicenseIdentifiers
	{
		#region Infrastructure

	    public static IGitHubLicenseIdentifiers Instance { get; } = new GitHubLicenseIdentifiers();

	    private GitHubLicenseIdentifiers()
	    {
        }

	    #endregion
	}
}