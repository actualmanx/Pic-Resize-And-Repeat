namespace Pic_Resize_And_Repeat
{
    public partial class Form1 : Form
    {


        ModifyRegistry myRegistry = new ModifyRegistry();


        public Form1()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Image Files |*.JPEG;*.PNG;*.GIF;*.BMP;*.JPG";

            fileStripStatusLabel1.Text = myRegistry.Read("File Location");
            this.DragEnter += new DragEventHandler(Form_DragEnter);
            this.DragDrop += new DragEventHandler(Form_DragDrop);
        }


        void Form_DragEnter(object? sender, DragEventArgs e)
        {
            // Check if the Data object is not null and the Data format can be accepted
            // (we only accept file drops from Explorer, etc.)
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy; // Okay
            else
                e.Effect = DragDropEffects.None; // Unknown data, ignore it
        }

        void Form_DragDrop(object? sender, DragEventArgs e)
        {
            // clear the label
            fileStripStatusLabel1.Text = String.Empty;

            // Attempt to extract the data from the DataObject-Container into a string array
            if (e.Data.GetData(DataFormats.FileDrop, false) is string[] FileList && FileList != null)
            {
                // Do something with the data...

                // For example, add all files into a simple label control:
                foreach (string File in FileList)
                    this.fileStripStatusLabel1.Text += File;
                myRegistry.Write("File Location", this.fileStripStatusLabel1.Text);
            }
            else
            {
                // Handle the case where the data is not in the expected format or is null
                MessageBox.Show("No files were dropped or the data is not in the expected format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







        private void InputButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                myRegistry.Write("File Location", openFileDialog1.FileName);
                fileStripStatusLabel1.Text = myRegistry.Read("File Location");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputPath = fileStripStatusLabel1.Text;
            string outputPath = fileStripStatusLabel1.Text + ("." + formatComboBox.Text).ToLower();
            int outputWidth = int.Parse(widthtextBox1.Text);  // Convert string to int
            int outputHeight = int.Parse(heighttextBox1.Text);  // Convert string to int

            using (Image inputImage = Image.FromFile(inputPath))
            using (Bitmap outputImage = new Bitmap(outputWidth, outputHeight))
            using (Graphics graphics = Graphics.FromImage(outputImage))
            {
                for (int x = 0; x < outputWidth; x += inputImage.Width)
                {
                    for (int y = 0; y < outputHeight; y += inputImage.Height)
                    {
                        graphics.DrawImage(inputImage, new Point(x, y));
                    }
                }

                // Determine the ImageFormat based on the selected item in the ComboBox
                System.Drawing.Imaging.ImageFormat format;
                switch (formatComboBox.SelectedItem.ToString())
                {
                    case "PNG":
                        format = System.Drawing.Imaging.ImageFormat.Png;
                        break;
                    case "JPEG":
                        format = System.Drawing.Imaging.ImageFormat.Jpeg;
                        break;
                    case "BMP":
                        format = System.Drawing.Imaging.ImageFormat.Bmp;
                        break;
                    case "GIF":
                        format = System.Drawing.Imaging.ImageFormat.Gif;
                        break;
                    case "JPG":
                        format = System.Drawing.Imaging.ImageFormat.Jpeg;
                        break;
                    default:
                        throw new Exception("Unsupported image format.");
                }

                outputImage.Save(outputPath, format);
            }
        }
    }
}

