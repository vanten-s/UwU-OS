using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using SystemCommands;
using System.Runtime.CompilerServices;
using Finder;
using System.Security.Cryptography.X509Certificates;
using Cosmos.System.FileSystem.VFS;
using Cosmos.System.FileSystem;
using System.IO;
using System.Linq;
using System.Data.SqlTypes;
using UwU;

namespace FSC
{
    class fsc
    {

        public void ld()
        {
            Console.WriteLine("WIP");
        }

        public void ls()
        {
            var directory_list = Directory.GetFiles(@"0:\");

            try
            {
                foreach (var file in directory_list)
                {
                    Console.WriteLine(file);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

            }
        }

        public void touch(String Filename)
        {
            try
            {
                File.Create(@$"0:\{Filename}");

            }
            catch (Exception e) { Console.WriteLine(e.ToString()); }
        }

        public void write(string input)
        {
            string filename = "FailedWriteDataDump.txt";
            string tempFilename = "";
            string data = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ' && filename == "FailedWriteDataDump.txt")
                {
                    tempFilename += input[i];
                }

                else if (input[i] == ' ' && filename == "FailedWriteDataDump.txt")
                {
                    filename = tempFilename;
                }

                else
                {
                    data += input[i];
                }

            }
            try
            {
                Console.WriteLine($"Writing {data} to {filename}");
                File.WriteAllText(@$"0:\{filename}", data);
            }
            catch
            (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void cat(string Filename)
        {
            try
            {
                Console.WriteLine(File.ReadAllText(@$"0:\{Filename}"));

            }
            catch (Exception e) { Console.WriteLine(e.ToString()); }
        }

        public void rm(string filename)
        {

            try
            {
                File.Delete(@$"0:\{filename}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine($" '{filename}' might not be a file");
            }
        }

        public void rmdir(string DirName)
        {
            try
            {
                Directory.Delete(DirName);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine($" '{DirName}' might not be a directory");
            }
        }


    }
}