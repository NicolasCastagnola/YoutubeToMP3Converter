using System;
using System.IO;
using System.Windows.Forms;
using MediaToolkit;
using VideoLibrary;

namespace Youtube_Downloader
{
    public partial class Form1 : Form
    {
        private bool _isMp3Format = true;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;

            var folderBrowserDialog = new FolderBrowserDialog();

            if (Link.TextLength > 10 && Link.Text.Contains("https://www.youtube.com/watch?v="))
            {
                var yt = YouTube.Default;
                var video = await yt.GetVideoAsync(Link.Text);

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Downloading...", "Valid Link. Starting Download...", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    var inputFile = new MediaToolkit.Model.MediaFile
                    {
                        Filename = folderBrowserDialog.SelectedPath + @"/" + video.FullName
                    };

                    await File.WriteAllBytesAsync(folderBrowserDialog.SelectedPath + @"\" + video.FullName, await video.GetBytesAsync());

                    var outputFile = new MediaToolkit.Model.MediaFile
                    {
                        Filename = $"{ folderBrowserDialog.SelectedPath + @"\" + video.FullName}.mp3"
                    };

                    using (var engine = new Engine())
                    {
                        engine.GetMetadata(inputFile);
                        engine.Convert(inputFile, outputFile);
                    }

                    if (_isMp3Format) File.Delete(folderBrowserDialog.SelectedPath + @"\" + video.FullName);
  
                    else File.Delete($"{ folderBrowserDialog.SelectedPath + @"\" + video.FullName}.mp3");

                    progressBar.Value = 100;

                    MessageBox.Show("Success!", "Convertion Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error!", "Something went wrong... Please Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            else MessageBox.Show("Invalid Link", "Please insert a valid Youtube link", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void mp3_CheckedChanged(object sender, EventArgs e)
        {
            _isMp3Format = true;
        }

        private void mp4_CheckedChanged(object sender, EventArgs e)
        {
            _isMp3Format = false;
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

    }
}
