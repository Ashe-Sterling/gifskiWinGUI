using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace gifskiWinGUI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        static string LoadPath;
        static string SavePath;
        static string fps;
        static string Quality;
        static string WidthOut;
        static string HeightOut;
        public void Loadfile_Browsebutton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog loadFileDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            loadFileDialog1.Description = "Choose the source folder";
            string initialpath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);
            loadFileDialog1.SelectedPath = initialpath;
            loadFileDialog1.ShowDialog();
            LoadPath = loadFileDialog1.SelectedPath;
            LoadFile_Pathbox.Text = LoadPath;
            if (Resize_Check.Checked == false)
            {
                ///DirectoryInfo d = new DirectoryInfo(LoadPath);
                string[] fileArray = Directory.GetFiles(LoadPath);
                Console.WriteLine(fileArray);
                var FileInfoP = Image.FromFile(fileArray[0]);
                decimal DefaultHeight = FileInfoP.Height;
                decimal DefaultWidth = FileInfoP.Width;
                HeightNumeric.Value = DefaultHeight;
                WidthNumeric.Value = DefaultWidth;
            }
        }
        private void Savefile_Browsebutton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.SaveFileDialog saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog1.Filter = "Graphics Interchange Format|*.GIF";
            saveFileDialog1.Title = "Choose the save destination and name";
            string initialpath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);
            saveFileDialog1.InitialDirectory = initialpath;
            saveFileDialog1.ShowDialog();
            SavePath = saveFileDialog1.FileName;
            SaveFile_Pathbox.Text = SavePath;
        }

        private void LoadFile_Pathbox_TextChanged(object sender, EventArgs e)
        {
            string LoadPath = LoadFile_Pathbox.Text;
        }

        private void SaveFile_Pathbox_TextChanged(object sender, EventArgs e)
        {
            string Saveath = SaveFile_Pathbox.Text;
        }

        private void Resize_Check_CheckedChanged(object sender, EventArgs e)
        {
            if (Resize_Check.Checked == true)
            {
                HeightLabel.Enabled = true;
                WidthLabel.Enabled = true;
                HeightNumeric.Enabled = true;
                WidthNumeric.Enabled = true;
            }
            else if (Resize_Check.Checked == false)
            {
                HeightLabel.Enabled = false;
                WidthLabel.Enabled = false;
                HeightNumeric.Enabled = false;
                WidthNumeric.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HeightNumeric_ValueChanged(object sender, EventArgs e)
        {
            HeightOut = HeightNumeric.Value.ToString();
        }

        private void WidthNumeric_ValueChanged(object sender, EventArgs e)
        {
            WidthOut = WidthNumeric.Value.ToString();
        }

        private void fpsNumeric_ValueChanged(object sender, EventArgs e)
        {
            fps = fpsNumeric.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void QualityNumeric_ValueChanged(object sender, EventArgs e)
        {
            Quality = QualityNumeric.Value.ToString();
        }

        private void RenderButton_Click(object sender, EventArgs e)
        {
            if (LoadFile_Pathbox.Text != null && SaveFile_Pathbox.Text != null)
            {
                string LoadPathF = (LoadPath + @"\*");
                Console.WriteLine(LoadPathF);
                string[] CommandArray = { " -r ", fps, " -Q ", Quality, " -W ", WidthOut, " -H ", HeightOut, " ", LoadPathF, " --output ", SavePath };
                string CommandSep = "";
                string Command = string.Join(CommandSep, CommandArray);
                string CurrentPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                ///System.Console.WriteLine(CurrentPath);
                int chars = CurrentPath.Length;
                string BatFileName = CurrentPath.Insert(chars, @"\gifski.exe");
                ///System.Console.WriteLine(BatFileName);
                ///System.IO.File.WriteAllText(BatFileName, Command);
                System.Diagnostics.Process cmd = new System.Diagnostics.Process();
                cmd.StartInfo.FileName = BatFileName;
                cmd.StartInfo.WorkingDirectory = CurrentPath;
                cmd.StartInfo.Arguments = Command;
                cmd.Start();
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            string ReadResource(string name)
            {
                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = "gifskiWinGUI.HelpBox.rtf";

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
            Form helpForm = new Form();
            RichTextBox helpBox = new RichTextBox();
            Button OKButton = new Button();
            void OKButton_Click(object sender1, EventArgs e1)
            {
                helpForm.Close();
            }
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            helpForm.Size = new System.Drawing.Size(600, 800);
            helpForm.MinimizeBox = false;
            helpForm.MaximizeBox = false;
            helpForm.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            helpBox.ReadOnly = true;
            helpBox.Size = new System.Drawing.Size(500, 700);
            helpBox.Location = new System.Drawing.Point(50, 10);
            helpBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            helpBox.Rtf = ReadResource(Text);
            ///helpBox.Text = ReadResource(Text);
            OKButton.Text = "OK";
            OKButton.Size = new System.Drawing.Size(70, 35);
            OKButton.Location = new System.Drawing.Point(265, 712);
            OKButton.Click += new EventHandler(OKButton_Click);
            helpForm.Controls.Add(helpBox);
            helpForm.Controls.Add(OKButton);
            helpForm.Show();
        }
        
    }
}
