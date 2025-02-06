using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccursedImageProcessing
{
    public partial class BorderCzar : Form
    {
        #region Fields

        private Color _borderColor = Color.Magenta; // Magenta border by default
        private string _imageDirectory = "";
        private const double WIDTH_MULTIPLIER = 2.37; // Multiply this by the image height to get the new width

        #endregion Fields

        #region Constructors

        public BorderCzar()
        {
            InitializeComponent();
            Initialize();
        }

        #endregion Constructors

        #region Methods

        public void Initialize()
        {
            colorPickerButton.BackColor = _borderColor;
            directoryTextBox.Text = Directory.GetCurrentDirectory();
        }

        #endregion Methods

        #region Event Handlers

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] images;

            // Ensure a valid directory was selected
            try
            {
                images = Directory.GetFiles(_imageDirectory, "*.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a valid directory.");
                return;
            }

            int imageCount = images.Length;
            int i = 0;

            foreach (string image in images)
            {
                Bitmap originalBitmap = (Bitmap)Image.FromFile(image);

                // Ensure that the new width is rounded DOWN to the nearest EVEN integer.
                int newWidth = (int)Math.Floor(originalBitmap.Height * WIDTH_MULTIPLIER);
                if (newWidth % 2 == 1)
                {
                    newWidth -= 1;
                }

                Bitmap bitmap = new Bitmap(newWidth, originalBitmap.Height);
                Bitmap monochrome = new Bitmap(newWidth, originalBitmap.Height);

                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    // Draw border first
                    graphics.DrawRectangle(new Pen(_borderColor, (float)(newWidth / 2)), new Rectangle(0, 0, newWidth, originalBitmap.Height));

                    // Draw image on top
                    int middlePos = (newWidth / 2) - (originalBitmap.Width / 2);
                    graphics.DrawImage(originalBitmap, middlePos, 0, originalBitmap.Width, originalBitmap.Height);
                }

                using (Graphics graphics = Graphics.FromImage(monochrome))
                {
                    Brush whiteBrush = new SolidBrush(Color.White);
                    Brush blackBrush = new SolidBrush(Color.Black);

                    // Draw white background                 
                    graphics.FillRectangle(whiteBrush, new Rectangle(0, 0, newWidth, originalBitmap.Height));

                    // Draw and fill black rectangle
                    int middlePos = (newWidth / 2) - (originalBitmap.Width / 2);
                    graphics.FillRectangle(blackBrush, new Rectangle(middlePos, 0, originalBitmap.Width, originalBitmap.Height));
                }

                FileInfo imageFile = new FileInfo(image);
                string borderedDir = imageFile.DirectoryName + "\\" + "_BORDERED";

                // Check for _BORDERED dir the first time around.
                if (i == 0)
                {
                    if (Directory.Exists(borderedDir) == false)
                    {
                        Directory.CreateDirectory(borderedDir);
                    }
                    else
                    {
                        // If there is already a folder here called _BORDERED, it is likely we put it there.
                        // Double-check before potentially overwriting any existing images.

                        DialogResult overwriteCheck = MessageBox.Show(
                            "There is already a folder here called _BORDERED. Continuing to process may cause existing images in this folder to be overwritten. Continue?",
                            "Potential Overwrite",
                            MessageBoxButtons.YesNo);

                        if (overwriteCheck == DialogResult.No)
                        {
                            return;
                        }
                    }
                }

                string extensionlessName = imageFile.Name.Remove(imageFile.Name.Length - 4);
                string newName = borderedDir + "\\" + extensionlessName + "_BORDERED" + imageFile.Extension;
                string monochromeName = borderedDir + "\\" + extensionlessName + "_MONO" + imageFile.Extension;

                bitmap.Save(newName);
                monochrome.Save(monochromeName);

                // Update progress bar
                i++;
                float progressPercent = (i / imageCount) * 100;
                backgroundWorker.ReportProgress((int)progressPercent);
            }

            MessageBox.Show("Processing complete.");
            progressBar.Value = 0; // Reset progress bar
        }

        private void backgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void colorPickerButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.ShowHelp = true;
                colorDialog.Color = _borderColor;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    _borderColor = colorDialog.Color;
                    colorPickerButton.BackColor = _borderColor;
                }
            }
        }

        private void directoryButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    directoryTextBox.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void directoryTextBox_TextChanged(object sender, EventArgs e)
        {
            _imageDirectory = directoryTextBox.Text;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
        }

        #endregion Event Handlers
    }
}
