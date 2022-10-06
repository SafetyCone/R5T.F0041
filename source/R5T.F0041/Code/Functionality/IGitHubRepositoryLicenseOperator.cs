using System;

using R5T.T0132;


namespace R5T.F0041
{
	[FunctionalityMarker]
	public partial interface IGitHubRepositoryLicenseOperator : IFunctionalityMarker
	{
        public string GetLicenseIdentifier(GitHubRepositoryLicense gitHubRepositoryLicense)
        {
            return gitHubRepositoryLicense switch
            {
                GitHubRepositoryLicense.MIT => Instances.GitHubLicenseIdentifiers.MIT,
                _ => throw Instances.EnumerationHelper.GetSwitchDefaultCaseException(gitHubRepositoryLicense),
            };
        }
    }
}