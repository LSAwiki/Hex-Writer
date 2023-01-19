namespace Hex_Writer
{
    partial class AboutForm
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
            this.MinB = new System.Windows.Forms.Button();
            this.CloseB = new System.Windows.Forms.Button();
            this.Body = new System.Windows.Forms.Panel();
            this.ClloseButton = new System.Windows.Forms.Button();
            this.Text = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Body.SuspendLayout();
            this.SuspendLayout();
            // 
            // MinB
            // 
            this.MinB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinB.BackColor = System.Drawing.SystemColors.Control;
            this.MinB.FlatAppearance.BorderSize = 0;
            this.MinB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinB.Font = new System.Drawing.Font("Quicksand", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinB.ForeColor = System.Drawing.Color.Black;
            this.MinB.Location = new System.Drawing.Point(400, 3);
            this.MinB.Margin = new System.Windows.Forms.Padding(4);
            this.MinB.Name = "MinB";
            this.MinB.Size = new System.Drawing.Size(66, 55);
            this.MinB.TabIndex = 6;
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
            this.CloseB.Location = new System.Drawing.Point(472, 2);
            this.CloseB.Margin = new System.Windows.Forms.Padding(4);
            this.CloseB.Name = "CloseB";
            this.CloseB.Size = new System.Drawing.Size(66, 55);
            this.CloseB.TabIndex = 5;
            this.CloseB.Text = "x";
            this.CloseB.UseVisualStyleBackColor = false;
            this.CloseB.Click += new System.EventHandler(this.CloseB_Click);
            // 
            // Body
            // 
            this.Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Body.BackColor = System.Drawing.Color.White;
            this.Body.Controls.Add(this.ClloseButton);
            this.Body.Controls.Add(this.Text);
            this.Body.Location = new System.Drawing.Point(-2, 58);
            this.Body.Margin = new System.Windows.Forms.Padding(4);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(549, 409);
            this.Body.TabIndex = 4;
            this.Body.Paint += new System.Windows.Forms.PaintEventHandler(this.FileConvB_Paint);
            // 
            // ClloseButton
            // 
            this.ClloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClloseButton.BackColor = System.Drawing.Color.Gainsboro;
            this.ClloseButton.FlatAppearance.BorderSize = 0;
            this.ClloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClloseButton.Font = new System.Drawing.Font("Quicksand", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClloseButton.ForeColor = System.Drawing.Color.Black;
            this.ClloseButton.Location = new System.Drawing.Point(180, 275);
            this.ClloseButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClloseButton.Name = "ClloseButton";
            this.ClloseButton.Size = new System.Drawing.Size(161, 55);
            this.ClloseButton.TabIndex = 8;
            this.ClloseButton.Text = "Close";
            this.ClloseButton.UseVisualStyleBackColor = false;
            this.ClloseButton.Click += new System.EventHandler(this.ClloseButton_Click);
            // 
            // Text
            // 
            this.Text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text.AutoSize = true;
            this.Text.Font = new System.Drawing.Font("Quicksand", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text.Location = new System.Drawing.Point(33, 96);
            this.Text.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(463, 129);
            this.Text.TabIndex = 8;
            this.Text.Text = "Program name : LSA Hex Writer\r\nversion : 1.0 public version\r\nDeveloper : LSADD Co" +
    "mpany™";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Quicksand", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(8, 9);
            this.Title.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(103, 43);
            this.Title.TabIndex = 7;
            this.Title.Text = "About";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(540, 460);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.MinB);
            this.Controls.Add(this.CloseB);
            this.Controls.Add(this.Body);
            this.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.Body.ResumeLayout(false);
            this.Body.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MinB;
        private System.Windows.Forms.Button CloseB;
        private System.Windows.Forms.Panel Body;
        private System.Windows.Forms.Button ClloseButton;
        private System.Windows.Forms.Label Text;
        private System.Windows.Forms.Label Title;
    }
}