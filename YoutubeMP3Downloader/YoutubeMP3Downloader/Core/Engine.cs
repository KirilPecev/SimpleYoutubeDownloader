namespace YoutubeMP3Downloader.Core
{
    using Contracts;
    using MediaToolkit.Model;
    using System;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using VideoLibrary;

    public class Engine : IEngine
    {
        private readonly YouTube youTube;
        private readonly string link;
        private readonly string saveAdress;
        private readonly ProgressBar progressBar;
        private readonly CheckBox videoCheckBox;
        private readonly string source;
        private readonly int resolution;

        public Engine(YouTube youTube, string link, string saveAdress, ProgressBar progressBar, CheckBox videoCheckBox, int resolution)
        {
            this.youTube = youTube;
            this.link = link;
            this.saveAdress = saveAdress;
            this.progressBar = progressBar;
            this.videoCheckBox = videoCheckBox;
            this.resolution = resolution;
            this.source = Environment.CurrentDirectory + "\\";
        }

        public void Run()
        {
            var convertThisVideoToMp3 = this.youTube.GetAllVideos(this.link).FirstOrDefault(v => v.Resolution == this.resolution);
            File.WriteAllBytes(this.source + convertThisVideoToMp3.FullName, convertThisVideoToMp3.GetBytes());

            PerformProgressBar(30);

            if (this.videoCheckBox.Checked)
            {
                File.WriteAllBytes(this.saveAdress + convertThisVideoToMp3.FullName, convertThisVideoToMp3.GetBytes());
            }

            PerformProgressBar(70);

            MediaFile inputFile = new MediaFile() { Filename = this.source + convertThisVideoToMp3.FullName };
            MediaFile outputFile = new MediaFile { Filename = $"{this.saveAdress + convertThisVideoToMp3.FullName}.mp3" };

            ConvertToMp3(inputFile, outputFile);

            PerformProgressBar(90);

            var file = $"{this.source}\\{convertThisVideoToMp3.FullName}";
            if (File.Exists(file))
            {
                File.Delete(file);
            }
        }

        private static void ConvertToMp3(MediaFile inputFile, MediaFile outputFile)
        {
            using (var engine = new MediaToolkit.Engine())
            {
                engine.GetMetadata(inputFile);
                engine.Convert(inputFile, outputFile);
            }
        }

        private void PerformProgressBar(int value)
        {
            this.progressBar.Value = value;
            this.progressBar.PerformStep();
        }
    }
}
