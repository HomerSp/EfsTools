﻿using CommandLine;

namespace EfsTools.CommandLineOptions
{
    [Verb("downloadDirectory", HelpText = "Download EFS directory to computer")]
    internal class EfsDowloadDirectoryOptions
    {
        [Option('i', "inEfsPath", Required = true, HelpText = "EFS directory path")]
        public string InEfsPath { get; set; }
        [Option('o', "outComputerPath", Required = true, HelpText = "Output directory path in computer")]
        public string OutComputerPath { get; set; }
        [Option('n', "noExtraData", Required = false, HelpText = "Don't save extra data in file name", Default = false)]
        public bool NoExtraData { get; set; }
    }
}
