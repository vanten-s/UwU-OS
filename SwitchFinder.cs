using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using SystemCommands;
using System.Runtime.CompilerServices;
using USF;
using FSC;

namespace Finder
{
    public class finder
    {
        public string Find((string, string) AppData)
        {
            systemCommands sCom = new systemCommands();
            fsc fsc = new fsc();
            Console.WriteLine($"command: {AppData.Item1}    input: {AppData.Item2}");

            switch (AppData.Item1)
            {

                case "y":
                    sCom.y(AppData.Item2);
                    break;

                case "clear":
                    sCom.clear();
                    break;

                case "math":
                    sCom.math(AppData.Item2);
                    break;

                case "echo":
                    sCom.echo(AppData.Item2);
                    break;

                case "poweroff":
                    sCom.poweroff();
                    break;

                case "ld":
                    fsc.ld();
                    break;
                case "ls":
                    fsc.ls();
                    break;
                case "touch":
                    fsc.touch(AppData.Item2);
                    break;
                case "write":
                    fsc.write(AppData.Item2);
                    break;
                case "cat":
                    fsc.cat(AppData.Item2);
                    break;
                case "rm":
                    fsc.rm(AppData.Item2);
                    break;
                case "rmdir":
                    fsc.rmdir(AppData.Item2);
                    break;

                default:
                    Console.WriteLine($" {AppData.Item1} not found");
                    return "1";
            }






            return "0";
        }
    }
}