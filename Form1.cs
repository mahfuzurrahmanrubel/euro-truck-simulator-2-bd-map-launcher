using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace copy_maker

// namespace MyDesktopApp
{
    public partial class MainForm : Form
    {
        private Button btnLaunchGame;
        private Button btnCopyAssets;
        private Button btnBrowse;
        private TextBox txtGameLocation;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCopyAssets_Click(object sender, EventArgs e)
        {
            try
            {
                // Source directory containing your static files and folders
                string sourceDirectory = @"G:\application\gcp";

                // Destination directory (Windows default Documents directory)
                string destinationDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                // Copy the contents of the source directory to the destination directory
                CopyDirectory(sourceDirectory, destinationDirectory);

                MessageBox.Show("Assets copied successfully to Documents directory.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*";
            openFileDialog.Title = "Select Game Executable";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtGameLocation.Text = openFileDialog.FileName;
            }
        }


        private void btnLaunchGame_Click(object sender, EventArgs e)
        {
            try
            {
                // Path to the game application executable
                // string gamePath = @"D:\Crack game\ETS\Euro Truck Simulator 2 V1.42.1.0s +All DLC\bin\win_x64\eurotrucks2.exe";
                string gamePath = @"D:\Crack game\ETS\Euro Truck Simulator 2 V1.42.1.0s +All DLC\bin\win_x64\eurotrucks2.exe";
                //Console.WriteLine("Game Path: " + gamePath);
                Console.WriteLine("Game Path: " + txtGameLocation.Text);

                // Launch the game application
                Process.Start(txtGameLocation.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error launching the game: " + ex.Message);
            }
        }

        // Function to copy a directory and its contents
        private void CopyDirectory(string sourceDir, string destDir)
        {
            if (!Directory.Exists(destDir))
            {
                Directory.CreateDirectory(destDir);
            }

            foreach (string file in Directory.GetFiles(sourceDir))
            {
                string destFile = Path.Combine(destDir, Path.GetFileName(file));
                File.Copy(file, destFile, true);
            }

            foreach (string folder in Directory.GetDirectories(sourceDir))
            {
                string destFolder = Path.Combine(destDir, Path.GetFileName(folder));
                CopyDirectory(folder, destFolder);
            }
        }
    }
}
