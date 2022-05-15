#load nuget:?package=Cake.Dungeon&prerelease

Build.SetParameters
(
    title: "GitHubActions.Dungeon",

    logEnvironment: true,
    logBuildSystem: true
);

Build.Run();
