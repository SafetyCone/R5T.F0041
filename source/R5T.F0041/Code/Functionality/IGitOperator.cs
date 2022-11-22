using System;
using System.Threading.Tasks;

using R5T.T0046;
using R5T.T0132;


namespace R5T.F0041
{
	[FunctionalityMarker]
	public partial interface IGitOperator : IFunctionalityMarker,
		F0019.IGitOperator
	{
		/// <inheritdoc cref="Clone_NonIdempotent(string, string)"/>
		public Task<string> Clone_NonIdempotent(string repositoryName)
		{
			return this.Clone_NonIdempotent(
				repositoryName,
				Instances.GitHubOwners.SafetyCone);
        }

        /// <inheritdoc cref = "F0019.IGitOperator.Clone_NonIdempotent(string, string, T0144.Authentication)" />
        public async Task<string> Clone_NonIdempotent(
			string repositoryName,
			string repositoryOwnerName)
		{
			var cloneUrl = await Instances.GitHubOperator.GetCloneUrl(
				repositoryOwnerName,
				repositoryName);

			var localRepositoryDirectoryPath = Instances.DirectoryPathOperator.GetLocalRepositoryDirectoryPath(
				repositoryName,
				repositoryOwnerName);

			var authentication = await Instances.GitHubOperator.GetGitHubAuthentication();

			var _ = this.Clone_NonIdempotent(
				cloneUrl,
				localRepositoryDirectoryPath,
				authentication);

			return localRepositoryDirectoryPath;
		}

		public void Commit(
			string localRepositoryDirectoryPath,
			string commitMessage)
		{
			var author = this.GetAuthor();

			this.Commit(
				localRepositoryDirectoryPath,
				commitMessage,
				author);
		}

		public Author GetAuthor()
		{
			var author = Instances.JsonOperator.LoadFromFile_Synchronous<Author>(
				Instances.FilePaths.GitHubAuthorFile_Json,
				"GitHubAuthor");

			return author;
		}

		public void Push(string localRepositoryDirectoryPath)
		{
			var authentication = Instances.GitHubOperator.GetGitHubAuthentication_Synchronous();

			this.Push(
				localRepositoryDirectoryPath,
				authentication);
		}
	}
}