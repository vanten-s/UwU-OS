using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using SystemCommands;
using System.Runtime.CompilerServices;
using Finder;
using System.Security.Cryptography.X509Certificates;

namespace USF
{
    class usf
    {

        public (string, string) ComParser(string UnParsedCommand = "")
        {
        string CommandInput = "";
        string ParsedCommand = "";
        int CommandEnd = 0;

            for (int i = 0; i < UnParsedCommand.Length; i++)
            {

                if (UnParsedCommand[i] == ' ')
                {
                    CommandEnd = i;
                    break;
                }

                else
                {
                    ParsedCommand += UnParsedCommand[i];
                }

            }

            for(int i = CommandEnd + 1; i < UnParsedCommand.Length; i++)
            {
                CommandInput+= UnParsedCommand[i];
            }
         return (ParsedCommand, CommandInput);
        }
    }
}