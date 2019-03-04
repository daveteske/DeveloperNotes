// #tool "nuget:?package=Wyam"
// #addin "Cake.Powershell"

// var RootDir = MakeAbsolute(Directory(".")); 
// var buildtarget = Argument("target", "Default");
// var waymexe = RootDir + "/tools/wyam/Wyam/tools/net462/Wyam.exe";

// Task("Build")
//     .Does(() => StartProcess(waymexe, "build"));

// Task("Preview")
//     .Does(() => StartProcess(waymexe, "-p -w"));

// Task("Deploy")
//     .IsDependentOn("Build")
//     .Does(() => 
//     {
//         if(FileExists("./CNAME"))
//             CopyFile("./CNAME", "output/CNAME");

//         StartProcess("git", "checkout master");
//         StartProcess("git", "add .");
//         StartProcess("git", "commit -m \"Checking output in for subtree\"");
//         StartProcess("git", "subtree split --prefix output -b gh-pages");
//         StartProcess("git", "push -f origin gh-pages:gh-pages");
//         StartProcess("git", "branch -D gh-pages");

//     });

// RunTarget(buildtarget);
// --------------------------------------------------------------

#tool nuget:?package=Wyam&version=2.1.1
#addin nuget:?package=Cake.Wyam&version=2.1.1

// var RootDir = MakeAbsolute(Directory(".")); 
var buildtarget = Argument("target", "Default");
// var waymexe = RootDir + "/tools/wyam/Wyam/tools/net462/Wyam.exe";

Task("Build")
    .Does(() => 
    {
        Wyam();        
    });

Task("Preview")
    .Does(() =>
    {
        Wyam(new WyamSettings
        {
            ConfigurationFile = "config.wyam.local",
            Preview = true,
            Watch = true
        });        
    });

Task("Deploy")
    .IsDependentOn("Build")
    .Does(() => 
    {
        if(FileExists("./CNAME"))
            CopyFile("./CNAME", "output/CNAME");

        StartProcess("git", "checkout master");
        StartProcess("git", "add .");
        StartProcess("git", "commit -m \"Checking output in for subtree\"");
        StartProcess("git", "subtree split --prefix output -b gh-pages");
        StartProcess("git", "push -f origin gh-pages:gh-pages");
        StartProcess("git", "branch -D gh-pages");

    });

RunTarget(buildtarget);