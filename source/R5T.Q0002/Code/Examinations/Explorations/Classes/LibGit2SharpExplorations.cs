using System;


namespace R5T.Q0002
{
	public class LibGit2SharpExplorations : ILibGit2SharpExplorations
	{
		#region Infrastructure

	    public static LibGit2SharpExplorations Instance { get; } = new();

	    private LibGit2SharpExplorations()
	    {
	    }

	    #endregion
	}
}