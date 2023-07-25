using Cake.Common;
using Cake.Common.IO;
using Cake.Common.Tools.DotNet.Build;
using Cake.Common.Tools.DotNet;
using Cake.Core;
using Cake.Frosting;
using System.IO.Compression;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;

public static class Program
{
    public static int Main(string[] args)
    {
        return new CakeHost()
            .UseContext<BuildContext>()
            .Run(args);
    }
}

public class BuildContext : FrostingContext
{
    public string MsBuildConfiguration { get; set; }

    public BuildContext(ICakeContext context)
        : base(context)
    {
        MsBuildConfiguration = context.Argument("configuration", "Release");
    }
}

[TaskName("Clean")]
public sealed class CleanTask : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        Console.WriteLine("Cleaning bin directories...");
        context.CleanDirectory($"../../bin/{context.MsBuildConfiguration}/ImGui.NET");
        context.CleanDirectory($"../../bin/{context.MsBuildConfiguration}/ImGui.NET.API");
    }
}

[TaskName("Replace")]
[IsDependentOn(typeof(CleanTask))]
public sealed class ReplaceTask : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        string target = "ImGuiNative";
        foreach (var file in Directory.EnumerateFiles("../ImGui.NET", "*", SearchOption.AllDirectories))
        {
            if (!file.Contains(target))
            {
                continue;
            }
            var lines = File.ReadAllLines(file);
            bool isChanged = false;
            for (var i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains("mupen64plus"))
                {
                    Console.WriteLine($"{file} line {i}");
                    lines[i] = lines[i].Replace("mupen64plus", context.Argument<string>("emulatordll"));
                    isChanged = true;
                }
            }
            if (isChanged)
            {
                File.WriteAllLines(file, lines);
            }
        }
    }
}

[TaskName("Build")]
[IsDependentOn(typeof(ReplaceTask))]
public sealed class BuildTask : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        context.DotNetBuild("../ImGui.NET.sln", new DotNetBuildSettings
        {
            Configuration = context.MsBuildConfiguration,
        });
    }
}

[TaskName("Package")]
[IsDependentOn(typeof(BuildTask))]
public sealed class PackageTask : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        foreach(var file in Directory.EnumerateFiles("../../bin/Release/ImGui.NET/net6.0"))
        {
            if (Path.GetExtension(file) == ".json" || Path.GetExtension(file) == ".pdb")
            {
                File.Delete(file);
            }
        }
        if (!Directory.Exists("../../out"))
        {
            Directory.CreateDirectory("../../out");
        }
        if (File.Exists("../../out/ImGui_Binding.zip"))
        {
            File.Delete("../../out/ImGui_Binding.zip");
        }
        ZipFile.CreateFromDirectory("../../bin/Release/ImGui.NET/net6.0", "../../out/ImGui_Binding.zip");
    }
}

[TaskName("Default")]
[IsDependentOn(typeof(PackageTask))]
public class DefaultTask : FrostingTask
{
}