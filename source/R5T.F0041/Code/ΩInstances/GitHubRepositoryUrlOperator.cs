using System;


namespace R5T.F0041
{
    public class GitHubRepositoryUrlOperator : IGitHubRepositoryUrlOperator
    {
        #region Infrastructure

        public static IGitHubRepositoryUrlOperator Instance { get; } = new GitHubRepositoryUrlOperator();


        private GitHubRepositoryUrlOperator()
        {
        }

        #endregion
    }
}
