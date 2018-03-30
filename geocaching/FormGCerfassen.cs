using System;
using System.IO;
using System.Reflection;
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


            //Wenn File existiert Settings einlesen:
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
                tab1Labelpfad.Text = _df.GetCurrentDirectory();
                tab2Labelpfad.Text = _df.GetCurrentDirectory();

                //Save Button aktivieren
                buttonSave.Enabled = true;

                //Setting OpenNotepad anpassen:
                checkBoxOpenNotepad.Checked = _df.OpenNotepad;
                checkBoxOpenExplorer.Checked = _df.OpenExplorer;

                SetToolStatusLabel("Einstellung gespeichert!");
            }
            else
            {
                //Config File existiert nicht
                tab1Labelpfad.Text = @"Einstellungen => Verzeichnis wählen";
                tab2Labelpfad.Text = @"Verzeichnis wählen";
                SetToolStatusLabel(@"Verzeichnis wählen!");
            }
        }


        private void buttonChooseDirectory_Click(object sender, EventArgs e)
        {
            ChooseDirectory();
        }

        private void ChooseDirectory()
        {
            var result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var pfad = folderBrowserDialog1.SelectedPath;

                _df.SetCurrentDirectory(pfad);
                tab1Labelpfad.Text = pfad;
                tab2Labelpfad.Text = pfad;

                buttonSave.Enabled = true;
                _df.SaveObject(this);
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
            if (gc.GeocacheAusgabe(_df.OpenNotepad, _df.OpenExplorer))
            {
                //Cache ausgabe erfolgreich
                SetToolStatusLabel("Geocache gespeichert!");
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
            MessageBox.Show(@"Info
Version: " + Assembly.GetEntryAssembly().GetName().Version + @" 
Kevin Landolt geocache@klandolt.ch", @"Infos", MessageBoxButtons.OK);
        }

        public void SetToolStatusLabel(string paramString)
        {
            toolStripStatusLabel.Text = paramString + @" " + DateTime.Now.ToString("dd.mm.yyyy HH:mm:ss.FFF");
        }

        private void buttonSaveSetting_Click(object sender, EventArgs e)
        {
            _df.SaveObject(this);
        }
    }
}