namespace Hex_Writer
{
    partial class WelcomeForm
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
            this.body = new System.Windows.Forms.Panel();
            this.WelcomeTitle = new System.Windows.Forms.Label();
            this.ClloseButton = new System.Windows.Forms.Button();
            this.Text = new System.Windows.Forms.Label();
            this.body.SuspendLayout();
            this.SuspendLayout();
            // 
            // body
            // 
            this.body.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.body.Controls.Add(this.WelcomeTitle);
            this.body.Controls.Add(this.ClloseButton);
            this.body.Controls.Add(this.Text);
            this.body.ForeColor = System.Drawing.SystemColors.Control;
            this.body.Location = new System.Drawing.Point(38, 52);
            this.body.Margin = new System.Windows.Forms.Padding(4);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(549, 409);
            this.body.TabIndex = 8;
            // 
            // WelcomeTitle
            // 
            this.WelcomeTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WelcomeTitle.AutoSize = true;
            this.WelcomeTitle.Font = new System.Drawing.Font("Quicksand", 45F, System.Drawing.FontStyle.Bold);
            this.WelcomeTitle.Location = new System.Drawing.Point(122, 92);
            this.WelcomeTitle.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.WelcomeTitle.Name = "WelcomeTitle";
            this.WelcomeTitle.Size = new System.Drawing.Size(302, 89);
            this.WelcomeTitle.TabIndex = 9;
            this.WelcomeTitle.Text = "Welcome";
            this.WelcomeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClloseButton
            // 
            this.ClloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClloseButton.FlatAppearance.BorderSize = 0;
            this.ClloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClloseButton.Font = new System.Drawing.Font("Quicksand", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClloseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ClloseButton.Location = new System.Drawing.Point(187, 306);
            this.ClloseButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClloseButton.Name = "ClloseButton";
            this.ClloseButton.Size = new System.Drawing.Size(161, 55);
            this.ClloseButton.TabIndex = 8;
            this.ClloseButton.Text = "Got it";
            this.ClloseButton.UseVisualStyleBackColor = false;
            this.ClloseButton.Click += new System.EventHandler(this.ClloseButton_Click);
            // 
            // Text
            // 
            this.Text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text.AutoSize = true;
            this.Text.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold);
            this.Text.Location = new System.Drawing.Point(18, 193);
            this.Text.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(509, 60);
            this.Text.TabIndex = 8;
            this.Text.Text = "this Program is simple Hex Writer, you can convert\r\nany code or word to hex file," +
    " and enjoy !";
            this.Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(630, 507);
            this.Controls.Add(this.body);
            this.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WelcomeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.body.ResumeLayout(false);
            this.body.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.Label WelcomeTitle;
        private System.Windows.Forms.Button ClloseButton;
        private System.Windows.Forms.Label Text;
    }
}