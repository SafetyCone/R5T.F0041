using System;

using R5T.T0132;


namespace R5T.F0041
{
	[FunctionalityMarker]
	public partial interface IDirectoryPathOperator : IFunctionalityMarker
	{
		public string GetLocalRepositoryDirectoryPath(
			string repositoryName,
			string repositoryOwnerName)
        {
			var ownerDirectoryName = Instances.RepositoryDirectoryNameOperator.GetRepositoryOwnerDirectoryName(repositoryOwnerName);

			var localOwnerRepositoryDirectoryPath = Instances.PathOperator.GetDirectoryPath(
				Instances.DirectoryPaths.GitHubRepositoriesDirectory,
				ownerDirectoryName);

			var repositoryDirectoryName = Instances.RepositoryDirectoryNameOperator.GetRepositoryDirectoryName(repositoryName);

			var localRepositoryDirectoryPath = Instances.PathOperator.GetDirectoryPath(
				localOwnerRepositoryDirectoryPath,
				repositoryDirectoryName);

			return localRepositoryDirectoryPath;
		}
	}
}