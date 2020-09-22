using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace SClipper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            processListBox.DisplayMember = "WindowTitle";
            processListBox.ValueMember = "ProcessId";

            SystemTrayIcon.Visible = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                SystemTrayIcon.Text = String.Format("SClipper: {0}", selectedProcessTextBox.Text);
                Hide();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        public void getWindows()
        {
            processListBox.Items.Clear();

            Process[] processlist = Process.GetProcesses();

            foreach (Process process in processlist)
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    if (enableFilterCheckBox.Checked && process.ProcessName.Contains(filterProcessTextBox.Text))
                    {
                        processListBox.Items.Add(new WindowInformation(process.ProcessName, process.MainWindowTitle, process.Id));
                    }
                    if (!enableFilterCheckBox.Checked)
                    {
                        processListBox.Items.Add(new WindowInformation(process.ProcessName, process.MainWindowTitle, process.Id));
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getWindows();
        }

        private void processListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProcessTextBox.Text = ((WindowInformation)processListBox.SelectedItem).WindowTitle;

            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "SClipper.txt"), selectedProcessTextBox.Text);
        }
    }
}
