using System;
using System.IO;

namespace CleanUpTool
{
    class Program
    {
        static void Main(string[] args)
        {
            // Root Directory über Übergabeparameter erhalten

            var targetFolder = args[0];
            DirectoryInfo di = new DirectoryInfo(targetFolder);
            FileInfo[] files = null;

            try
            {
                files = di.GetFiles("*.txt", SearchOption.AllDirectories);
            }
            // This is thrown if even one of the files requires permissions greater
            // than the application provides.
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            DateiValidation validation = new DateiValidation(files);

            // ReSharper disable once UnusedVariable
            var test = validation.CheckDatesFileInfo();


        }
    }
}
