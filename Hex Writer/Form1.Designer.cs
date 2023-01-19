namespace Hex_Writer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Title = new System.Windows.Forms.Label();
            this.Body = new System.Windows.Forms.Panel();
            this.BrowseB = new System.Windows.Forms.Button();
            this.HexConvB = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MinB = new System.Windows.Forms.Button();
            this.CloseB = new System.Windows.Forms.Button();
            this.Binary = new System.Windows.Forms.TabControl();
            this.Body.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Quicksand", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(9, 13);
            this.Title.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(168, 43);
            this.Title.TabIndex = 0;
            this.Title.Text = "Hex Writer";
            // 
            // Body
            // 
            this.Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Body.BackColor = System.Drawing.Color.White;
            this.Body.Controls.Add(this.Binary);
            this.Body.Controls.Add(this.BrowseB);
            this.Body.Controls.Add(this.HexConvB);
            this.Body.Controls.Add(this.menuStrip1);
            this.Body.Location = new System.Drawing.Point(-2, 64);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(676, 343);
            this.Body.TabIndex = 1;
            // 
            // BrowseB
            // 
            this.BrowseB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseB.BackColor = System.Drawing.Color.Gainsboro;
            this.BrowseB.FlatAppearance.BorderSize = 0;
            this.BrowseB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseB.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Bold);
            this.BrowseB.ForeColor = System.Drawing.Color.Black;
            this.BrowseB.Location = new System.Drawing.Point(525, 120);
            this.BrowseB.Name = "BrowseB";
            this.BrowseB.Size = new System.Drawing.Size(124, 49);
            this.BrowseB.TabIndex = 5;
            this.BrowseB.Text = "Open file";
            this.BrowseB.UseVisualStyleBackColor = false;
            this.BrowseB.Click += new System.EventHandler(this.BrowseB_Click);
            // 
            // HexConvB
            // 
            this.HexConvB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HexConvB.BackColor = System.Drawing.Color.Gainsboro;
            this.HexConvB.FlatAppearance.BorderSize = 0;
            this.HexConvB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HexConvB.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Bold);
            this.HexConvB.ForeColor = System.Drawing.Color.Black;
            this.HexConvB.Location = new System.Drawing.Point(525, 208);
            this.HexConvB.Name = "HexConvB";
            this.HexConvB.Size = new System.Drawing.Size(124, 49);
            this.HexConvB.TabIndex = 4;
            this.HexConvB.Text = "remove file";
            this.HexConvB.UseVisualStyleBackColor = false;
            this.HexConvB.Click += new System.EventHandler(this.HexConvB_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 311);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(676, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(68, 28);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.programToolStripMenuItem.Text = "Program";
            this.programToolStripMenuItem.Click += new System.EventHandler(this.programToolStripMenuItem_Click);
            // 
            // MinB
            // 
            this.MinB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinB.BackColor = System.Drawing.SystemColors.Control;
            this.MinB.FlatAppearance.BorderSize = 0;
            this.MinB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinB.Font = new System.Drawing.Font("Quicksand", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinB.ForeColor = System.Drawing.Color.Black;
            this.MinB.Location = new System.Drawing.Point(546, 4);
            this.MinB.Name = "MinB";
            this.MinB.Size = new System.Drawing.Size(57, 54);
            this.MinB.TabIndex = 3;
            this.MinB.Text = "-";
            this.MinB.UseVisualStyleBackColor = false;
            this.MinB.Click += new System.EventHandler(this.MinB_Click);
            // 
            // CloseB
            // 
            this.CloseB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseB.BackColor = System.Drawing.SystemColors.Control;
            this.CloseB.FlatAppearance.BorderSize = 0;
            this.CloseB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseB.Font = new System.Drawing.Font("Quicksand", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseB.ForeColor = System.Drawing.Color.Black;
            this.CloseB.Location = new System.Drawing.Point(607, 4);
            this.CloseB.Name = "CloseB";
            this.CloseB.Size = new System.Drawing.Size(57, 54);
            this.CloseB.TabIndex = 2;
            this.CloseB.Text = "x";
            this.CloseB.UseVisualStyleBackColor = false;
            this.CloseB.Click += new System.EventHandler(this.CloseB_Click);
            // 
            // Binary
            // 
            this.Binary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Binary.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Binary.Location = new System.Drawing.Point(19, 22);
            this.Binary.Name = "Binary";
            this.Binary.SelectedIndex = 0;
            this.Binary.Size = new System.Drawing.Size(487, 262);
            this.Binary.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(672, 404);
            this.Controls.Add(this.MinB);
            this.Controls.Add(this.CloseB);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hex Writer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Body.ResumeLayout(false);
            this.Body.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel Body;
        private System.Windows.Forms.Button MinB;
        private System.Windows.Forms.Button BrowseB;
        private System.Windows.Forms.Button HexConvB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.Button CloseB;
        private System.Windows.Forms.TabControl Binary;
    }
}

