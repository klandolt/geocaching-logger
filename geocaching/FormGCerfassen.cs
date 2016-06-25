using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace geocaching
{
    public partial class FormGCerfassen : Form
    {
        //Global Variablen:

        private DefaultSettings _df = new DefaultSettings();


        public FormGCerfassen()
        {
            InitializeComponent();
            //Settings laden:

            LoadSettings();
        }

        public void LoadSettings()
        {
            ResetForms();


            //Wenn File existiert einlesen:
            if (File.Exists(_df.GetFileNamen()))
            {
                //Deserializer erstellen
                var mySerializer = new XmlSerializer(typeof(DefaultSettings));
                //Filestream herstellen
                var myFileStream = new FileStream(_df.GetFileNamen(), FileMode.Open);
                //Objekt erzeugen
                _df = (DefaultSettings) mySerializer.Deserialize(myFileStream);
                //Filestream schliessen
                myFileStream.Close();

                //Label setzten
                labelpfad.Text = _df.GetCurrentDirectory();
                //Save Button aktivieren
                buttonSave.Enabled = true;
            }
            else
            {
                //Config FIle existiert nicht

                labelpfad.Text = @"Verzeichnis wählen";
            }
        }


        private void buttonChooseDirectory_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var pfad = folderBrowserDialog1.SelectedPath;


                WritePathSettings(pfad);


                buttonSave.Enabled = true;
            }
        }

        private void WritePathSettings(string paramPathtxt)
        {
            labelpfad.Text = paramPathtxt;
            _df.SetCurrentDirectory(paramPathtxt);


            //Speicherb in File:

            if (_df.SaveObject())
            {
                //Speichern erfolgreich
                MessageBox.Show(@"Object Save to File");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetForms();
        }


        public void ResetForms()
        {
            //Clear all Texboxes
            textBoxName.Text = "";
            textBoxBemerkung.Text = "";
            textBoxGCCode.Text = "";
            dateTimePickerGefunden.Value = DateTime.Now;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Geocache speichern
            var gc = new Geocache(radioButtonDirectory.Checked, textBoxName.Text, textBoxBemerkung.Text,
                textBoxGCCode.Text, dateTimePickerGefunden.Value, _df);
            if (gc.GeocacheAusgabe())
            {
                //Cache ausgabe erfolgreich
                MessageBox.Show(@"Geocache gespeichert", @"Save", MessageBoxButtons.OK);
            }
            else
            {
                //Cache Ausgabe nicht Erfolgreich
                MessageBox.Show(@"Geocache NICHT gespeichert!!", @"Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close Application
            Application.Exit();
        }

        private void infosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Info ausgabe
            //TODO: Info ausgabe fertigstellen 
            MessageBox.Show("Info\nVersion \nKevin Landolt geocache@klandolt.ch", "Infos", MessageBoxButtons.OK);
        }
    }
}