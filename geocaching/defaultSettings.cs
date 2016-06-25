using System.IO;
using System.Xml.Serialization;

namespace geocaching
{
    public class DefaultSettings
    {
        private readonly string _fileName = "Settings.xml";

        public string CurrentDirectory;

        /// <summary>
        ///     True: Open Notepad++
        ///     False: Not open Notepad++
        /// </summary>
        public bool OpenNotepad;

        public DefaultSettings()
        {
            //leeren Konstruktor
            OpenNotepad = true;
        }

        public DefaultSettings(string paramPfad)
        {
            CurrentDirectory = paramPfad;
        }

        public void SetCurrentDirectory(string paramPfad)
        {
            CurrentDirectory = paramPfad;
        }

        public string GetCurrentDirectory()
        {
            return CurrentDirectory;
        }

        public void SetOpenNotepad(bool paramOpenNotepad)
        {
            OpenNotepad = paramOpenNotepad;
        }

        public bool GetOpenNotepad()
        {
            return OpenNotepad;
        }

        public bool SaveObject()
        {
            var mySerializer = new XmlSerializer(typeof(DefaultSettings));

            var myWriter = new StreamWriter(GetFileNamen());
            mySerializer.Serialize(myWriter, this);
            myWriter.Close();

            return true;
        }

        public string GetFileNamen()
        {
            return _fileName;
        }
    }
}