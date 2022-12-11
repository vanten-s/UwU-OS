using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using SystemCommands;
using System.Runtime.CompilerServices;
using Finder;
using USF;

namespace UwU_OS
{
    public class Kernel : Sys.Kernel
    {
        Sys.FileSystem.CosmosVFS fs = new Sys.FileSystem.CosmosVFS();


        protected override void BeforeRun()
        {
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            Console.WriteLine("UwU-OS booted successfully");
        }

        protected override void Run()
        {
            // objects
            systemCommands sCom = new systemCommands();
            finder comFind = new finder();
            usf usf = new usf();

            // main
            Console.Write("> ");
            string input = Console.ReadLine();
            comFind.Find(usf.ComParser(input));
        }
    }
}
