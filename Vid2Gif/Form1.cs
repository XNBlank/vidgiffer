using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vid2Gif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bool check = ExistsOnPath("ffmpeg.exe");

            if ( !check )
            {
                MessageBox.Show("ffmpeg.exe is required and could not be found. Make sure it is in your system PATH or in the application directory.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1);
                Environment.Exit(0);
            }
        }

        private void fileSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog fs = new OpenFileDialog();
            string path = string.Empty;
            fs.Title = "Open Video File";
            fs.DefaultExt = ".mp4";
            fs.Filter = "MP4 Files|*.mp4|AVI Files|*.avi|FLV Files|*.flv|MOV files|*.mov";
            fs.InitialDirectory = @"C:\";
            DialogResult result = fs.ShowDialog();

            if (result == DialogResult.OK)
            {
                path = fs.FileName;
                fileText.Text = path;
            }
        }

        public Process p;

        private void submitButton_Click(object sender, EventArgs e)
        {
            string path = fileText.Text;

            p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.FileName = "CMD.EXE";

            string fps = fpsText.Value.ToString();
            string length = lengthText.Value.ToString();
            string start = startTimeText.Value.ToString();
            string scale = scaleText.Value.ToString();
            string extension = Path.GetExtension(path);
            string output = path.Replace(extension, ".gif");

            string palname = RandomString(12);

            string palcmd = String.Format("-y -ss {0} -t {1} -i \"{2}\" -vf fps={3},scale={4}:-1:flags=lanczos,palettegen {5}.png", start, length, path, fps, scale, palname);

            Console.WriteLine(palcmd);

            p.StartInfo.Arguments = "/c ffmpeg " + palcmd;
            p.Start();
            p.WaitForExit();

            string cmd = String.Format("-y -ss {0} -t {1} -i \"{2}\" -i {6}.png -filter_complex \"fps={3},scale={4}:-1:flags=lanczos[x];[x][1:v]paletteuse\" \"{5}\"", start,length,path,fps,scale,output,palname);

            Console.WriteLine(cmd);

            p.StartInfo.Arguments = "/c ffmpeg " + cmd;
            p.Start();
            p.WaitForExit();

            if (File.Exists(palname + ".png"))
            {
                File.Delete(palname + ".png");
            }

            MessageBox.Show("Done.", "Info", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static bool ExistsOnPath(string fileName)
        {
            return GetFullPath(fileName) != null;
        }

        public static string GetFullPath(string fileName)
        {
            if (File.Exists(fileName))
                return Path.GetFullPath(fileName);

            var values = Environment.GetEnvironmentVariable("PATH");
            foreach (var path in values.Split(';'))
            {
                var fullPath = Path.Combine(path, fileName);
                if (File.Exists(fullPath))
                    return fullPath;
            }
            return null;
        }

    }
}
