using System.Collections.Generic;
using CommandLine;
using CommandLine.Text;

namespace NugetUtility
{

    [Verb("file", HelpText = "Encrypt File(s) Or Folder(s")]
    public class PackageOptions
    { //normal options here

        [Option('i', "input", HelpText = "Project Directory")]
        public string ProjectDirectory { get; set; }

        [Option('u', "unique", Default = false , HelpText="Print unique licenses list")]
        public bool UniqueOutput {get;set;} 
        
        [Option('j', "json", Default = false , HelpText="Print unique licenses list in a json file (licenses.json)")]
        public bool JsonOutput {get; set;}
        
        [Option('o', "output", Default = false , HelpText="Output file")]
        public bool Output { get; set; }

        [Usage(ApplicationAlias = "dotnet-nuget")]
        public static IEnumerable<Example> Examples
        {
            get
            {
                return new List<Example>() {
                new Example("encrypt folder", new PackageOptions { ProjectDirectory = "~/Projects/test-project" }),
                };
            }
        }
    }

}