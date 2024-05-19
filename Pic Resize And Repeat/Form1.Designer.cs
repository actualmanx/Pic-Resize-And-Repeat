namespace Pic_Resize_And_Repeat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            statusStrip1 = new StatusStrip();
            fileStripStatusLabel1 = new ToolStripStatusLabel();
            openFileDialog1 = new OpenFileDialog();
            formatComboBox = new ComboBox();
            widthtextBox1 = new TextBox();
            heighttextBox1 = new TextBox();
            InputButton1 = new Button();
            saveButton1 = new Button();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.ControlDarkDark;
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { fileStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 262);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(628, 32);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // fileStripStatusLabel1
            // 
            fileStripStatusLabel1.Name = "fileStripStatusLabel1";
            fileStripStatusLabel1.Size = new Size(179, 25);
            fileStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // formatComboBox
            // 
            formatComboBox.FormattingEnabled = true;
            formatComboBox.Items.AddRange(new object[] { "PNG", "GIF", "BMP", "JPEG", "JPG" });
            formatComboBox.Location = new Point(53, 44);
            formatComboBox.Name = "formatComboBox";
            formatComboBox.Size = new Size(150, 33);
            formatComboBox.TabIndex = 2;
            formatComboBox.Text = "PNG";
            // 
            // widthtextBox1
            // 
            widthtextBox1.Location = new Point(53, 118);
            widthtextBox1.Name = "widthtextBox1";
            widthtextBox1.Size = new Size(150, 31);
            widthtextBox1.TabIndex = 3;
            widthtextBox1.Text = "3840";
            // 
            // heighttextBox1
            // 
            heighttextBox1.Location = new Point(53, 176);
            heighttextBox1.Name = "heighttextBox1";
            heighttextBox1.Size = new Size(150, 31);
            heighttextBox1.TabIndex = 4;
            heighttextBox1.Text = "2160";
            // 
            // InputButton1
            // 
            InputButton1.Location = new Point(455, 115);
            InputButton1.Name = "InputButton1";
            InputButton1.Size = new Size(153, 34);
            InputButton1.TabIndex = 0;
            InputButton1.Text = "Input File";
            InputButton1.UseVisualStyleBackColor = true;
            InputButton1.Click += InputButton1_Click;
            // 
            // saveButton1
            // 
            saveButton1.Location = new Point(455, 173);
            saveButton1.Name = "saveButton1";
            saveButton1.Size = new Size(153, 34);
            saveButton1.TabIndex = 1;
            saveButton1.Text = "Convert N Save";
            saveButton1.UseVisualStyleBackColor = true;
            saveButton1.Click += button1_Click;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(628, 294);
            Controls.Add(saveButton1);
            Controls.Add(InputButton1);
            Controls.Add(heighttextBox1);
            Controls.Add(widthtextBox1);
            Controls.Add(formatComboBox);
            Controls.Add(statusStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(650, 350);
            Name = "Form1";
            Text = "Pic Resize &  Repeat";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel fileStripStatusLabel1;
        private OpenFileDialog openFileDialog1;
        private ComboBox formatComboBox;
        private TextBox widthtextBox1;
        private TextBox heighttextBox1;
        private Button InputButton1;
        private Button saveButton1;
    }
}
