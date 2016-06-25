using System.IO;
using System.Xml.Serialization;

namespace geocaching
{
    public class DefaultSettings
    {
        private readonly string _fileName = "Settings.xml";

        public string CurrentDirectory;


        public DefaultSettings()
        {
            //leeren Konstruktor
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


        public bool SaveObject()
        {
            //labelpfad.Text = reader.ReadLine();
            //df.SetCurrentDirectory(labelpfad.Text);

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