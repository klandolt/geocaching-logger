using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace geocaching
{
    internal class Geocache
    {
        private readonly string _bemerkung;
        private readonly DefaultSettings _currentSettings;
        private readonly bool _directory; // Wenn True Ordner erstellen sonst nur File
        private readonly string _gcCode;
        private readonly string _name;
        private string _fileDirectoryName;
        private DateTime _gefunden;

        //Geocache Objekt erstellen
        public Geocache(bool paramDirectory, string paramName, string paramBemerkung, string paramGcCode,
            DateTime paramGefunden, DefaultSettings paramCurrentSettings)
        {
            _directory = paramDirectory;
            _name = paramName;
            _bemerkung = paramBemerkung;
            _gcCode = paramGcCode;
            _gefunden = paramGefunden;
            _currentSettings = paramCurrentSettings;

            //File Name Erstellen
            CreateFileDirectoryName();
        }

        public bool GeocacheAusgabe(bool paramOpenNotepad)
        {
            //Ausgabe Part
            var path = _currentSettings.GetCurrentDirectory();

            //Wenn Verzeichnis true erstellen und Pfad anpassen
            if (_directory)
            {
                //Path ergänzen um Geocachename
                path += "\\" + _fileDirectoryName;

                try
                {
                    // Determine whether the directory exists. 
                    if (Directory.Exists(path))
                    {
                        //Abbruch wenn Verzeichnis bereits existiert
                        MessageBox.Show(@"Fehler Verzeichnis existiert bereits!!!", @"Fehler!!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return false;
                    }

                    // Try to create the directory.
                    Directory.CreateDirectory(path);
                }
                catch (Exception e)
                {
                    MessageBox.Show(@"Fehler beim Verzeichnis erstellen!!! " + e, @"Fehler!!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }
            }

            //Pfad ergänzen um Filenamen:
            path += "\\" + _fileDirectoryName + ".txt";

            //Output 
            if (!File.Exists(path))
            {
                // Create a file to write to.
                var text = "Erstellt am " + DateTime.Now.ToString("dd.MM.yyyy") + " - " + DateTime.Now.ToString("mm:HH") +
                           " Uhr" + Environment.NewLine;
                text += _name + " - " + _gcCode + Environment.NewLine;
                text += "_______________________________________________________________" + Environment.NewLine;
                text += "Bemerkung: " + _bemerkung + Environment.NewLine;
                text += "_______________________________________________________________" + Environment.NewLine;
                text += "Dieser Cache wurde am " + _gefunden.ToString("dd.MM.yyyy") + " gefunden" + Environment.NewLine;
                try
                {
                    File.WriteAllText(path, text);
                }
                catch (Exception e)
                {
                    //File schreiben war nicht erfolgreich
                    MessageBox.Show(@"Fehler beim File Schreiben!!! " + e, @"Fehler!!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }
            }
            else
            {
                //Wenn File bereits existiert
                MessageBox.Show(@"Fehler File existiert bereits!!! ", @"Fehler!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (!paramOpenNotepad) return true;
            //Open Notepad++
            var process = new Process
            {
                StartInfo =
                {
                    FileName = "notepad++.exe",
                    WorkingDirectory = "c:\temp",
                    Arguments = path
                }
            };
            process.Start();

            //return true wenn erfolgreich gespeichert:
            return true;
        }

        private void CreateFileDirectoryName()
        {
            //Hier wird der Filename zusammengestz aus Geocache Name und GCCode plus Extension

            var unChecked = _name + " - " + _gcCode;

            var regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            var r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            _fileDirectoryName = r.Replace(unChecked, "");
        }
    }
}