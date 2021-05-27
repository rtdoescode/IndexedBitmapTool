using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndexedBitmapTool {

    
    public partial class MainForm : Form {

        private OpenFileDialog bitmapFilePicker;
        private Bitmap img;
        private PixelFormat pformat;

        private List<String> formatOptions = new List<String>() {
            "4 Bit Indexed Bitmap",
            "8 Bit Indexed Bitmap",
            "8 Bit Indexed Grayscale Bitmap (Heightmap)",
            "24 Bit Bitmap",
            "32 Bit Bitmap"
        };
        
        private Dictionary<String, Func<Bitmap, Bitmap>> formatDict = new Dictionary<String, Func<Bitmap, Bitmap>>();

        public MainForm() {
            InitializeComponent();
            
            foreach(String s in formatOptions) {
                comboBox1.Items.Add(s);
            }

            formatDict.Add("4 Bit Indexed Bitmap", FormatFunctions.Convert4bitIndexed);
            formatDict.Add("8 Bit Indexed Bitmap", FormatFunctions.Convert8bitIndexed);
            formatDict.Add("8 Bit Indexed Grayscale Bitmap (Heightmap)", FormatFunctions.Convert8bitGrayscale);
            formatDict.Add("24 Bit Bitmap", FormatFunctions.Convert24bitIndexed);
            formatDict.Add("32 Bit Bitmap", FormatFunctions.Convert32bitIndexed);
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            bitmapFilePicker = new OpenFileDialog();
            if (bitmapFilePicker.ShowDialog() == DialogResult.OK) {
                try {
                    FileStream fs = new FileStream(bitmapFilePicker.FileName, FileMode.Open, FileAccess.Read);
                    img = (Bitmap)Bitmap.FromStream(fs);
                    bmpPreview.Image = img;
                    fs.Close();
                }
                catch (Exception ex) {
                    MessageBox.Show("Could not load the specified file.");
                    return;
                }
            }
            else {
                return;
            }

            imageChanged();

        }

        private void getFormatData() {
            String format = "";
            pformat = img.PixelFormat;
            switch (pformat) {

                case PixelFormat.Format8bppIndexed:
                    format = "8-bit indexed bitmap"; break;
                case PixelFormat.Format24bppRgb:
                    format = "24-bit regular bitmap"; break;
                case PixelFormat.Format4bppIndexed:
                    format = "4-bit Indexed bitmap"; break;
                default:
                    format = "This is not an indexed bitmap."; break;

            }
            outputBox.Text = format;
            btnChangeFormat.Enabled = true;
        }

        private void refreshImg() {
            bmpPreview.Image = img;
        }

        private void getPalletteData() {
            palletteListBox.Items.Clear();
            if (pformat != PixelFormat.Format8bppIndexed && pformat != PixelFormat.Format4bppIndexed) {
                return;
            }

            ColorPalette pal = img.Palette;
            for (int i = 0; i < pal.Entries.Length; i++) {
                palletteListBox.Items.Add(pal.Entries.GetValue(i));
            }
        }

        private void palletteListBox_SelectedIndexChanged(object sender, EventArgs e) {
            enablePalletteControls();
        }

        private void disablePalletteControls() {
            btnPalletteUp.Enabled = false;
            btnPalletteDown.Enabled = false;
            btnPalletteEdit.Enabled = false;
        }

        private void enablePalletteControls() {
            btnPalletteEdit.Enabled = true;

            if (palletteListBox.SelectedIndex == 0) {
                btnPalletteUp.Enabled = false;
            } else {
                btnPalletteUp.Enabled = true;
            }

            if (palletteListBox.SelectedIndex == palletteListBox.Items.Count - 1) {
                btnPalletteDown.Enabled = false;
            } else {
                btnPalletteDown.Enabled = true;
            }
        }

        private void btnPalletteUp_Click(object sender, EventArgs e) {
            disablePalletteControls();
            ColorPalette pal = img.Palette;
            int i = palletteListBox.SelectedIndex;

            Color c1 = pal.Entries[i];
            Color c2 = pal.Entries[i-1];

            pal.Entries[i - 1] = c1;
            pal.Entries[i] = c2;

            img.Palette = pal;

            if (persistentColorsChk.Checked) {
                swapIndicies(i, i - 1);
            }

            imageChanged();
            palletteListBox.SelectedIndex = i - 1;
            enablePalletteControls();
        }

        private void btnPalletteDown_Click(object sender, EventArgs e) {
            disablePalletteControls();
            ColorPalette pal = img.Palette;
            int i = palletteListBox.SelectedIndex;

            Color c1 = pal.Entries[i];
            Color c2 = pal.Entries[i + 1];

            pal.Entries[i + 1] = c1;
            pal.Entries[i] = c2;

            img.Palette = pal;

            if (persistentColorsChk.Checked) {
                swapIndicies(i, i+1);
            }

            imageChanged();
            palletteListBox.SelectedIndex = i + 1;
            enablePalletteControls();
        }

        private void swapIndicies(int i1, int i2) {

            BitmapData data = img.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
            byte[] bytes = new byte[data.Height * data.Stride];
            Marshal.Copy(data.Scan0, bytes, 0, bytes.Length);

            for (int y = 0; y < img.Height; y++) {
                for (int x = 0; x < img.Width; x++) {
                    
                    if((int)bytes[y * data.Stride + x] == i1) {
                        bytes[y * data.Stride + x] = (byte)i2;
                    }

                    else if ((int)bytes[y * data.Stride + x] == i2) {
                        bytes[y * data.Stride + x] = (byte)i1;
                    }

                }
            }

            // Copy the bytes from the byte array into the image
            Marshal.Copy(bytes, 0, data.Scan0, bytes.Length);
            img.UnlockBits(data);

        }

        private void imageChanged() {

            exportToolStripMenuItem.Enabled = true;
            importToolStripMenuItem.Enabled = true;

            refreshImg();
            getFormatData();
            getPalletteData();
        }

        private void btnPalletteEdit_Click(object sender, EventArgs e) {
            ColorPalette pal = img.Palette;
            int i = palletteListBox.SelectedIndex;

            ColorDialog colorPicker = new ColorDialog();
            colorPicker.FullOpen = true;
            colorPicker.Color = img.Palette.Entries[palletteListBox.SelectedIndex];

            if (colorPicker.ShowDialog() == DialogResult.OK) {
                pal.Entries[palletteListBox.SelectedIndex] = colorPicker.Color;
            }

            img.Palette = pal;
            imageChanged();
            palletteListBox.SelectedIndex = i;
            enablePalletteControls();
        }

        private void btnChangeFormat_Click(object sender, EventArgs e) {
            btnChangeFormat.Enabled = false;
            try {
                img = formatDict[comboBox1.Text](img);
            }
            catch(NotImplementedException exc) {
                MessageBox.Show("Conversions to this format are not currently implemented.");
                return;
            }
            imageChanged();
            btnChangeFormat.Enabled = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.InitialDirectory = bitmapFilePicker.FileName;
            saveDialog.Title = "Save Image File";
            saveDialog.CheckPathExists = true;
            saveDialog.DefaultExt = "bmp";
            saveDialog.RestoreDirectory = true;
            if (saveDialog.ShowDialog() == DialogResult.OK) {
                //if (System.IO.File.Exists(saveDialog.FileName)) {
                //    System.IO.File.Delete(saveDialog.FileName);
                //}

                //Bitmap savingBmp = img.Clone(new Rectangle(0, 0, img.Width, img.Height), img.PixelFormat);
                //img.Dispose();
                MessageBox.Show("Attempting to save to " + saveDialog.FileName);
                img.Save(saveDialog.FileName);

            } else {
                return;
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e) {

            if(img.PixelFormat != PixelFormat.Format8bppIndexed && img.PixelFormat != PixelFormat.Format4bppIndexed) {
                MessageBox.Show("Color pallette operations are only valid for indexed format bitmaps.");
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Save Color Pallette";
            saveDialog.CheckPathExists = true;
            saveDialog.DefaultExt = "bmpal";
            saveDialog.RestoreDirectory = true;
            if (saveDialog.ShowDialog() == DialogResult.OK) {

                using (StreamWriter writer = new StreamWriter(saveDialog.FileName)) {
                    foreach (Color c in img.Palette.Entries) {
                        writer.WriteLine(c.R + " " + c.G + " " + c.B);
                    }
                    writer.Close();
                }

            }

        }

        public bool warnOnQualityLoss() {
            return warnAboutQualityLossToolStripMenuItem.Checked;
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e) {

            if(img == null) {
                MessageBox.Show("An image must be loaded before a color pallette can be imported.");
            }

            if (img.PixelFormat != PixelFormat.Format8bppIndexed && img.PixelFormat != PixelFormat.Format4bppIndexed) {
                MessageBox.Show("Color pallette operations are only valid for indexed format bitmaps.");
            }

            int limit = 256;
            if(img.PixelFormat != PixelFormat.Format4bppIndexed) { limit = 16; }

            ColorPalette cp = img.Palette;
            string[] line;

            OpenFileDialog ppicker = new OpenFileDialog();
            if (ppicker.ShowDialog() == DialogResult.OK) {
                try {
                    using (StreamReader sr = new StreamReader(ppicker.FileName)) {
                        // Read the stream to a string, and write the string to the console.

                        for (int i = 0; i < limit; i++) {
                            if (sr.EndOfStream) {
                                if(i == 16) {
                                    break; // this is valid for 4 bit indexed palettes
                                } else {
                                    throw new IOException("Requires exactly 16 or 256 colors.");
                                }
                            }
                            line = sr.ReadLine().Split(' ');
                            if (line.Length != 3) { throw new IOException("Malformed data."); }
                            cp.Entries[i] = Color.FromArgb(
                                Int32.Parse(line[0]),
                                Int32.Parse(line[1]),
                                Int32.Parse(line[2]));
                        }
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("Could not read the specified file:\n\n" + ex.Message);
                    return;
                }

                img.Palette = cp;
                imageChanged();
            }
        }
    }
}
