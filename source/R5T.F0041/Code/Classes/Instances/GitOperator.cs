using System;


namespace R5T.F0041
{
	public class GitOperator : IGitOperator
	{
		#region Infrastructure

	    public static IGitOperator Instance { get; } = new GitOperator();

	    private GitOperator()
	    {
        }

	    #endregion
	}
}