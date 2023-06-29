using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Extensions.Logging;
using R5T.F0057;
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

		public async Task Clone_NonIdempotent_Simple(
			string remoteRepositoryUrl,
			string localRepositoryDirectoryPath)
		{
            var authentication = await Instances.GitHubOperator.GetGitHubAuthentication();

            this.Clone_NonIdempotent(
                remoteRepositoryUrl,
                localRepositoryDirectoryPath,
                authentication);
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

			this.Clone_NonIdempotent(
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

		public void In_CommitContext(
			string repositoryLocalDirectoryPath,
			string commitMessage,
			ILogger logger,
			IEnumerable<Action> actions = default)
		{
			Instances.ActionOperator.Run(actions);

			this.PushAllChanges(
				repositoryLocalDirectoryPath,
				commitMessage,
				logger);
		}

        public void In_CommitContext(
            string repositoryLocalDirectoryPath,
            string commitMessage,
            ILogger logger,
            params Action[] actions)
		{
			this.In_CommitContext(
				repositoryLocalDirectoryPath,
				commitMessage,
				logger,
				actions.AsEnumerable());
		}

        public async Task In_CommitContext(
            string repositoryLocalDirectoryPath,
            string commitMessage,
            ILogger logger,
            IEnumerable<Func<Task>> actions = default)
        {
            await Instances.ActionOperator.Run(actions);

            this.PushAllChanges(
                repositoryLocalDirectoryPath,
                commitMessage,
                logger);
        }

        public Task In_CommitContext(
            string repositoryLocalDirectoryPath,
            string commitMessage,
            ILogger logger,
            params Func<Task>[] actions)
        {
            return this.In_CommitContext(
                repositoryLocalDirectoryPath,
                commitMessage,
                logger,
                actions.AsEnumerable());
        }

        public void Push(string localRepositoryDirectoryPath)
		{
			var authentication = Instances.GitHubOperator.GetGitHubAuthentication_Synchronous();

			this.Push(
				localRepositoryDirectoryPath,
				authentication);
		}

        /// <summary>
        /// Stages, commits, and pushes all changes in a local directory path using the given commit message.
        /// </summary>
        /// <returns>True if any unpushed changes were pushed (there were any changes to push), false if not (there were no unpushed changes to push).</returns>
        public bool PushAllChanges(
            string repositoryLocalDirectoryPath,
            string commitMessage,
            ILogger logger)
        {
            logger.LogInformation($"Pushing all changes...\n\t{repositoryLocalDirectoryPath}");

            logger.LogInformation($"Checking whether repository has any unpushed changes...\n\t{repositoryLocalDirectoryPath}");

            var hasUnpushedChanges = Instances.GitOperator.HasUnpushedLocalChanges(repositoryLocalDirectoryPath);

            logger.LogInformation($"Checked whether repository has any unpushed changes.\n\t{repositoryLocalDirectoryPath}");

            if (hasUnpushedChanges)
            {
                logger.LogInformation("Unpushed changes detected.");

                // Stage all unstaged paths.
                logger.LogInformation("Staging changes...");

                var unstagedPathsCount = Instances.GitOperator.StageAllUnstagedPaths(repositoryLocalDirectoryPath);

                logger.LogInformation($"Staged changes. (Unstaged paths count: {unstagedPathsCount})");

                // Commit changes with commit message.
                logger.LogInformation("Committing changes...");

                Instances.GitOperator.Commit(
                    repositoryLocalDirectoryPath,
                    commitMessage);

                logger.LogInformation("Committed changes.");

                // Push changes to GitHub.
                logger.LogInformation("Pushing changes...");

                Instances.GitOperator.Push(repositoryLocalDirectoryPath);

                logger.LogInformation("Pushed changes...");
            }
            else
            {
                logger.LogInformation("No unpushed changes detected. No need to push changes.");
            }

            // Return whether any changes were pushed.
            return hasUnpushedChanges;
        }
    }
}