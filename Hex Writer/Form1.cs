using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hex_Writer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CloseB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ControlExtension.Draggable(this, true);

            WelcomeForm welcomeForm= new WelcomeForm();
            welcomeForm.ShowDialog();
        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm a = new AboutForm();
            a.ShowDialog();
        }

        private void MinB_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BrowseB_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select your file";
            //openFileDialog.Filter = "all files (*.*)| *.*|";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string title = openFileDialog.SafeFileName;
                ByteViewer byteViewer = new ByteViewer();
                TabPage newTab = new TabPage();
                Binary.TabPages.Add(newTab);
                newTab.Text = title;
                newTab.Controls.Add(byteViewer);
                byteViewer.Dock= DockStyle.Fill;
                byteViewer.SetFile(openFileDialog.FileName);
                Binary.SelectTab(newTab);
            }
        }

        private void HexConvB_Click(object sender, EventArgs e)
        {
            if (Binary.TabCount != 0)
            {
                Binary.TabPages.Remove(Binary.SelectedTab);
            }
            else
            {
                MessageBox.Show("there is no files will be removed !", "Hex Writer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
