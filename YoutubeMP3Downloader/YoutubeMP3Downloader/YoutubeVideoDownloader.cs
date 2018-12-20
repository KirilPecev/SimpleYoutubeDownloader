using System;
using System.Windows.Forms;
using VideoLibrary;
using YoutubeMP3Downloader.Core;
using YoutubeMP3Downloader.Core.Contracts;

namespace YoutubeMP3Downloader
{
    public partial class YoutubeVideoDownloader : Form
    {
        private const int resolution = 360;

        private string saveDirectory;

        public YoutubeVideoDownloader()
        {
            InitializeComponent();
            this.convertBtn.Enabled = false;
            this.saveDirectoryBtn.Enabled = false;
            this.saveDirectory = string.Empty;
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            if (this.progressBar.Value == this.progressBar.Maximum)
            {
                this.progressBar.Value = 0;
            }

            string link = linkTextBox.Text;

            var youTube = new YouTube();
            IEngine engine = new Engine(youTube, link, this.saveDirectory, this.progressBar, videoCheckBox, resolution);

            progressBar.Value = 30;
            this.progressBar.PerformStep();
            engine.Run();

            progressBar.Value = 100;
            this.progressBar.PerformStep();
        }

        private void saveDirectoryBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.saveDirectory = folderBrowserDialog.SelectedPath;
            }

            saveDirectoryTextBox.Text = this.saveDirectory;

            this.saveDirectory += "\\";

            this.convertBtn.Enabled = true;
        }

        private void progressBar_Click(object sender, EventArgs e)
        {
            progressBar.Maximum = 100;
            progressBar.Value = 0;
        }

        private void linkTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.linkTextBox.Text != string.Empty)
            {
                this.saveDirectoryBtn.Enabled = true;
            }

            if (this.linkTextBox.Text == string.Empty)
            {
                this.saveDirectoryBtn.Enabled = false;
                this.convertBtn.Enabled = false;
            }
        }
    }
}
