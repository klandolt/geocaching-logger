using System.IO;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace geocaching
{
    public sealed class DefaultSettings
    {
        private readonly string _fileName = "Settings.xml";

        public string CurrentDirectory;

        /// <summary>
        ///     True: Open Notepad++
        ///     False: Not open Notepad++
        /// </summary>
        public bool OpenNotepad;

        /// <summary>
        ///     True: Open Explorer after save
        ///     False: Not open Explorer after save
        /// </summary>
        public bool OpenExplorer;

        public DefaultSettings()
        {
            //leeren Konstruktor
            OpenNotepad = false;
            OpenExplorer = false;
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

        public void SetOpenExplorer(bool paramOpenExplorer)
        {
            OpenExplorer = paramOpenExplorer;
        }

        public bool GetOpenExplorer()
        {
            return OpenExplorer;
        }

        public bool SaveObject(FormGCerfassen ParamForm)
        {
            //Settings von Form holen:
            SetCurrentDirectory(ParamForm.folderBrowserDialog1.SelectedPath);
            SetOpenNotepad(ParamForm.checkBoxOpenNotepad.Checked);
            SetOpenExplorer(ParamForm.checkBoxOpenExplorer.Checked);


            var mySerializer = new XmlSerializer(typeof(DefaultSettings));

            var myWriter = new StreamWriter(GetFileNamen());
            mySerializer.Serialize(myWriter, this);
            myWriter.Close();

            ParamForm.SetToolStatusLabel("Einstellung gespeichert!");

            return true;
        }

        public string GetFileNamen()
        {
            return _fileName;
        }
    }
}