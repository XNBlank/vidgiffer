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

            

            string palcmd = String.Format("-y -ss {0} -t {1} -i \"{2}\" -vf fps={3},scale={4}:-1:flags=lanczos,palettegen palette.png", start, length, path, fps, scale);

            Console.WriteLine(palcmd);

            p.StartInfo.Arguments = "/c ffmpeg " + palcmd;
            p.Start();
            p.WaitForExit();

            string cmd = String.Format("-y -ss {0} -t {1} -i \"{2}\" -i palette.png -filter_complex \"fps={3},scale={4}:-1:flags=lanczos[x];[x][1:v]paletteuse\" \"{5}\"", start,length,path,fps,scale,output);

            Console.WriteLine(cmd);

            p.StartInfo.Arguments = "/c ffmpeg " + cmd;
            p.Start();
            
        }
    }
}
