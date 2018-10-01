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
using System.Xml.Linq;
using System.Deployment.Application;
using System.Reflection;
using System.Diagnostics;

namespace MyDirectory
{
    public partial class Main : Form
    {
        private string[] folders;
        private string directorySaveTo;
        private string[] lines;

        public Main()
        {
            InitializeComponent();
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                long total_size = 0;
                long total_sum = 0;
                string name = "";
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    button_save.Enabled = true;
                    string directory = new DirectoryInfo(fbd.SelectedPath).Name;
                    label_directory.Text = directory;
                    folders = Directory.GetDirectories(fbd.SelectedPath);
                    label_folder_num.Text = folders.Length.ToString();
                    lines = new string[folders.Length];
                    for (int i = 0; i < folders.Length; i++)
                    {
                        total_size += GetDirectorySize(folders[i]);
                        total_sum += GetDirectoryFilesNumber(folders[i]);
                        name = new DirectoryInfo(folders[i]).Name;
                        lines[i] = name;
                        Console.WriteLine(name);
                    }
                    label_size_num.Text = total_size.ToString()+" MB";
                    label_files_num.Text = total_sum.ToString();
                }
            }
        }

        private long GetDirectorySize(string directory)
        {
            long size = 0;
            string[] a = Directory.GetFiles(directory, "*.*");
            foreach (string name in a)
            {
                FileInfo info = new FileInfo(name);
                size += info.Length;
                //Console.WriteLine("FILE: "+name);
                //Console.WriteLine("SIZE: " + info.Length);
            }
            size = size / 1000000;
            return size;
        }

        private long GetDirectoryFilesNumber(string directory)
        {
            long sum = 0;
            string[] a = Directory.GetFiles(directory, "*.*");
            foreach (string name in a)
            {
                //Console.WriteLine("GettingDirectoryFilesNumber...");
                sum = sum + 1;
                //Console.WriteLine(name);
            }
            return sum;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo file = FileVersionInfo.GetVersionInfo(assembly.Location);
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                this.Text += " - " + ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4);
            }
            else
            {
               this.Text += "";
            }

            label_folder_num.Text = "";
            label_files_num.Text = "";
            label_size_num.Text = "";
            label_directory.Text = "";
            label_save.Text = "";
            this.MaximizeBox = false;
            button_save.Enabled = false;
            button_export.Enabled = false;
        }

        private void textBox_name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_name.Text))
            {
                e.Cancel = true;
                textBox_name.Focus();
                errorProvider_name.SetError(textBox_name, "Please Insert a file name!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_name.SetError(textBox_name, null);
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            using (var dSave = new FolderBrowserDialog())
            {

                DialogResult result = dSave.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dSave.SelectedPath))
                {
                    directorySaveTo = dSave.SelectedPath;
                    string directory = new DirectoryInfo(dSave.SelectedPath).Name;
                    label_save.Text = directory;
                    button_export.Enabled = true;
                }
            }
        }

        private void comboBox_format_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox_format.Text))
            {
                e.Cancel = true;
                comboBox_format.Focus();
                errorProvider_format.SetError(comboBox_format, "Please select the format of the exported file!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_format.SetError(comboBox_format, null);
            }
        }

        private void button_export_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string fileName = @"\" + textBox_name.Text;
                string format = comboBox_format.Text;
                string pathSave = directorySaveTo + fileName + format;
                Console.WriteLine("STORE TO: " + pathSave);
                if (comboBox_format.Text == ".txt")
                {
                    using (StreamWriter file = new StreamWriter (pathSave))
                    {
                        foreach (string line in lines)
                        {
                            file.WriteLine(line);
                        }
                    }
                }
                else if (comboBox_format.Text == ".csv")
                {
                    StringBuilder content = new StringBuilder();
                    foreach (string line in lines)
                    {
                        content.AppendLine(line);
                    }
                    File.AppendAllText(pathSave,content.ToString());
                }
            }
        }
    }
}
