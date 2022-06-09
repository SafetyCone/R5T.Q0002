using System;

using LibGit2Sharp;

using R5T.T0141;


namespace R5T.Q0002
{
	[ExplorationsMarker]
	public interface ILibGit2SharpExplorations : IExplorationsMarker
	{
        public void ExploreRepositoryDiscoverMethod()
        {
            // Result: <null>
            var nonRepositoryDirectoryPath = @"C:\Code\DEV\Git\GitHub\SafetyCone\";
            var nonRepositoryDirectoryPathDiscovery = Repository.Discover(nonRepositoryDirectoryPath);

            Console.WriteLine(nonRepositoryDirectoryPathDiscovery);

            // Result: C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Q0000\.git\
            var repositoryDirectoryPath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Q0000\";
            var repositoryDirectoryPathDiscovery = Repository.Discover(repositoryDirectoryPath);

            Console.WriteLine(repositoryDirectoryPathDiscovery);

            // Result: C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Q0000\.git\
            var inRepositoryDirectoryPath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Q0000\source";
            var inRepositoryDirectoryPathDiscovery = Repository.Discover(inRepositoryDirectoryPath);

            Console.WriteLine(inRepositoryDirectoryPathDiscovery);
        }

        public void ExploreRepositoryIsValidMethod()
        {
            // Result: FALSE
            var nonRepositoryDirectoryPath = @"C:\Code\DEV\Git\GitHub\SafetyCone\";
            var nonRepositoryDirectoryPathIsValid = Repository.IsValid(nonRepositoryDirectoryPath);

            Console.WriteLine(nonRepositoryDirectoryPathIsValid);

            // Result: TRUE
            var repositoryDirectoryPath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Q0000\";
            var repositoryDirectoryPathIsValid = Repository.IsValid(repositoryDirectoryPath);

            Console.WriteLine(repositoryDirectoryPathIsValid);

            // Result: FALSE
            var inRepositoryDirectoryPath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Q0000\source";
            var inRepositoryDirectoryPathIsValid = Repository.IsValid(inRepositoryDirectoryPath);

            Console.WriteLine(inRepositoryDirectoryPathIsValid);
        }
    }
}