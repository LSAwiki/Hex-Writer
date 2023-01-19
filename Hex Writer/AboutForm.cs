using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hex_Writer
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void MinB_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void CloseB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FileConvB_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            ControlExtension.Draggable(this, true);
        }
    }
}
