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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void ClloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            ControlExtension.Draggable(this, true);
        }
    }
}
