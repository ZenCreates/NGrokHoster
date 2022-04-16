namespace NGronk_Host
{
    using System;
    using System.IO;
    using System.Diagnostics;
    using System.Net;
    using System.Net.Sockets;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = textBox1.Text;
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.WorkingDirectory = @$"{folderBrowserDialog1.SelectedPath}";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = false;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.WriteLine($@"cd {folderBrowserDialog1.SelectedPath}");
            process.StandardInput.WriteLine($"ngrok config add-authtoken {password}");
            Properties.Settings.Default.Auth = true;
            Properties.Settings.Default.Path = folderBrowserDialog1.SelectedPath;
            Properties.Settings.Default.Save();
            Form2 f3 = new Form2();
            closewindow();
            f3.ShowDialog();
        }

        private void closewindow()
        {
            this.Hide();
        }
        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            label4.Text = $"Path: {folderBrowserDialog1.SelectedPath}";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://youtu.be/RSwsXMYhSy0",
                UseShellExecute = true
            });
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Auth == false)
            {

            }
            else
            {
                Form2 f3 = new Form2();
                closewindow();
                f3.ShowDialog();
            }
        }
    }
}