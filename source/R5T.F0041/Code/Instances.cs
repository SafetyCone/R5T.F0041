using System;


namespace R5T.F0041
{
    public static class Instances
    {
        public static F0000.IActionOperator ActionOperator => F0000.ActionOperator.Instance;
        public static IDirectoryPathOperator DirectoryPathOperator => F0041.DirectoryPathOperator.Instance;
        public static F0057.IDirectoryPaths DirectoryPaths => F0057.DirectoryPaths.Instance;
        public static F0002.IEnumerationHelper EnumerationHelper => F0002.EnumerationHelper.Instance;
        public static IFilePaths FilePaths => F0041.FilePaths.Instance;
        public static IGitHubLicenseIdentifiers GitHubLicenseIdentifiers => F0041.GitHubLicenseIdentifiers.Instance;
        public static IGitHubOperator GitHubOperator => F0041.GitHubOperator.Instance;
        public static F0047.IGitHubOwnerNames GitHubOwnerNames => F0047.GitHubOwnerNames.Instance;
        public static F0047.IGitHubOwnerOperator GitHubOwnerOperator => F0047.GitHubOwnerOperator.Instance;
        public static F0047.IGitHubOwners GitHubOwners => F0047.GitHubOwners.Instance;
        public static IGitHubRepositoryLicenseOperator GitHubRepositoryLicenseOperator => F0041.GitHubRepositoryLicenseOperator.Instance;
        public static IGitHubRepositorySpecificationOperator GitHubRepositorySpecificationOperator => F0041.GitHubRepositorySpecificationOperator.Instance;
        public static IGitHubRepositoryUrlOperator GitHubRepositoryUrlOperator => F0041.GitHubRepositoryUrlOperator.Instance;
        public static IGitHubRepositoryVisibilityOperator GitHubRepositoryVisibilityOperator => F0041.GitHubRepositoryVisibilityOperator.Instance;
        public static IGitOperator GitOperator => F0041.GitOperator.Instance;
        public static F0032.IJsonOperator JsonOperator => F0032.JsonOperator.Instance;
        public static F0002.IPathOperator PathOperator => F0002.PathOperator.Instance;
        public static F0057.IRepositoryDirectoryNameOperator RepositoryDirectoryNameOperator => F0057.RepositoryDirectoryNameOperator.Instance;
        public static F0046.IRepositoryNameOperator RepositoryNameOperator => F0046.RepositoryNameOperator.Instance;
        public static IRepositoryOperator RepositoryOperator => F0041.RepositoryOperator.Instance;
        public static F0124.IStringOperator StringOperator => F0124.StringOperator.Instance;
    }
}