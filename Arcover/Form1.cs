using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace Arcover
{
    public enum Mode { Dictionary, Force };

    public delegate void addOutputMessageDelegate(string message);
    
    public partial class Form1 : Form
    {
        public Mode bruteMode;

        public Form1()
        {
            Brute.GetOutput += GetOutputHandler;

            InitializeComponent();
        }

        private void openArchiveButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogArchive = new OpenFileDialog();

            if (openFileDialogArchive.ShowDialog() == DialogResult.OK) 
            {
                textBoxArchivePath.Text = openFileDialogArchive.FileName;
            }
        }

        private void openDictionaryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (bruteMode == Mode.Force) throw new Exception("WARNING: You can't use dictionary in bruteforce mode");

                OpenFileDialog openFileDialogDictionary = new OpenFileDialog();

                if (openFileDialogDictionary.ShowDialog() == DialogResult.OK)
                {
                    textBoxDictionaryPath.Text = openFileDialogDictionary.FileName;
                }
            }

            catch(Exception ex)
            {
                listViewLogger.Items.Add(ex.Message);
            }
        }

        private void radioButtonBruteforce_CheckedChanged(object sender, EventArgs e)
        {
            textBoxDictionaryPath.ReadOnly = true;

            string[] bruteModes = ForceBrute.Sets;
            checkedListBoxBruteMode.Items.AddRange(bruteModes);
            bruteMode = Mode.Force;
        }

        private void radioButtonDictionary_CheckedChanged(object sender, EventArgs e)
        {
            textBoxDictionaryPath.ReadOnly = false;
            checkedListBoxBruteMode.Items.Clear();
            bruteMode = Mode.Dictionary;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                Brute.ArchivePath = textBoxArchivePath.Text;

                if (bruteMode == Mode.Dictionary)
                {
                    DictionaryBrute br = new DictionaryBrute(textBoxDictionaryPath.Text);                    
                    br.Run(10);
                }

                else if (bruteMode == Mode.Force)
                {
                    ForceBrute br = new ForceBrute();
                    br.SetAlphabet(checkedListBoxBruteMode.CheckedItems); 
                    br.Run(10);
                }

                startButton.Text = (startButton.Text == "Start") ? "Stop" : "Start";
            }
            
            catch(Exception ex)
            {
                listViewLogger.Items.Add(ex.Message);
            }
        }

        private void GetOutputHandler(object sender, LoggerEventArgs e) 
        { 
            addOutputMessageDelegate del = new addOutputMessageDelegate(AddOutputMessage);
            
            this.Invoke(del, new object[]{e.Message});
        }

        private void AddOutputMessage(string message)
        {
            listViewLogger.Items.Add(message);
            // Scroll to bottom after updating
            listViewLogger.Items[listViewLogger.Items.Count - 1].EnsureVisible();
        }
    }

    /*
    public class LoggerListView : ListView 
    { 
        
    }
     */
}
