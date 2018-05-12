using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
// ReSharper disable UnusedVariable

namespace CleanUpTool
{
    internal class DateiValidation
    {
        private FileInfo[] _files;

        public DateiValidation(FileInfo[] paramFiles)
        {
            _files = paramFiles;
        }


        public FileInfo[] CheckDatesFileInfo()
        {
            List<FileInfo> probFileInfos = new List<FileInfo>();

            foreach (var file in _files)
            {
                // File Datum auslesen
                var dateFile = File.GetLastWriteTime(file.FullName);

                // Datum aus 1. Datei Zeile auslesen
                // Regex Erstellt am (\d\d)\.(\d\d)\.(\d\d\d\d) - (\d\d)\:(\d\d)\:(\d\d) Uhr
                var text = File.ReadLines(file.FullName);
                //Regex Pattern:
                var regex = new Regex(@"(?<day>\d.)\.(?<month>\d.)\.(?<year>\d\d\d\d) - (?<hour>\d\d)\:(?<min>\d\d)\:(?<sec>\d\d)");
                var match = regex.Match(text.First());
                if (match.Success)
                {
                    //var value = new DateTime(Int32.Parse(match.Groups["year"].Value), Int32.Parse(match.Groups["month"].Value), Int32.Parse(match.Groups["day"].Value));
                    int textday = Int32.Parse(match.Groups["day"].Value);
                    int textmonth = Int32.Parse(match.Groups["month"].Value);
                    int textyear = Int32.Parse(match.Groups["year"].Value);
                    int texthour = Int32.Parse(match.Groups["hour"].Value);
                    int textmin = Int32.Parse(match.Groups["min"].Value);
                    int textsec = Int32.Parse(match.Groups["sec"].Value);


                    //Diverse Checks ausführen
                   /* if (dateFile.Hour != texthour || dateFile.Minute != textmin || dateFile.Second != textsec)
                    {
                        Console.WriteLine($"Datei: {file.FullName}");
                        Console.WriteLine($"File Stunde: {dateFile.Hour} Text Stunde: {texthour}");
                        Console.WriteLine($"File Minuten: {dateFile.Minute} Text Stunde: {textmin}");
                        Console.WriteLine($"File Sekunden: {dateFile.Second} Text Stunde: {textsec}");

                        //probFileInfos.Add(file);
                    }

                    if (texthour == dateFile.Minute)
                    {
                        Console.WriteLine($"Datei: {file.FullName}");
                        Console.WriteLine($"File Stunde: {dateFile.Hour} Text Stunde: {texthour}");
                        Console.WriteLine($"File Minuten: {dateFile.Minute} Text Stunde: {textmin}");
                        Console.WriteLine($"File Sekunden: {dateFile.Second} Text Stunde: {textsec}");

                        probFileInfos.Add(file);
                    }*/

                    if (dateFile.Month != textmonth)
                    {
                        Console.WriteLine($"Datei: {file.FullName}");
                        Console.WriteLine($"File Month: {dateFile.Month} Text Monat: {textmonth}");

                        probFileInfos.Add(file);

                    }
                }
                
            }

            return probFileInfos.ToArray();
        }

        
    }
}
