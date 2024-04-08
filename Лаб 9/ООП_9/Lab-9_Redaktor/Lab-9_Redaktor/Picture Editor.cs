using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Lab_9_Redaktor
{
    public partial class PictureEditor : Form
    {

        public PictureEditor()
        {
            InitializeComponent();
            openFileDialog1.Filter = saveFileDialog1.Filter = "Binary files(*.dat)|*.dat";
            openFileDialog1.FileName = string.Empty;
            saveFileDialog1.FileName = savePictureDialog1.FileName = "myPainting";

            savePictureDialog1.Filter = 
                "PNG|*.png|" +
                "JPEG|*.jpeg; *.jpg; *.jpe; *.jfif|" +
                "BMP|*.bmp|" +
                "GIF pictures|*.gif";
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            polotno1.ActiveColor = colorDialog1.Color;
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            polotno1.Clear();
        }

        private void RB_Horizontal_CheckedChanged(object sender, EventArgs e)
        {
            polotno1.symetryNumb = Polotno.Symetry.HorizontalAxis;
        }

        private void RB_Vertical_CheckedChanged(object sender, EventArgs e)
        {
            polotno1.symetryNumb = Polotno.Symetry.VerticalAxis;
        }

        private void RB_Double_CheckedChanged(object sender, EventArgs e)
        {
            polotno1.symetryNumb = Polotno.Symetry.TwoAxis;
        }

        private void RB_Central_CheckedChanged(object sender, EventArgs e)
        {
            polotno1.symetryNumb = Polotno.Symetry.CentralAxis;
        }

        private void RB_NoSym_CheckedChanged(object sender, EventArgs e)
        {
            polotno1.symetryNumb = Polotno.Symetry.NoAxis;
        }

        private void PictureEditor_Load(object sender, EventArgs e)
        {

        }
        private void writeToFile(string protokol, string path)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(protokol);
            }
        }
        private void файлToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string path = saveFileDialog1.FileName;
            writeToFile(polotno1.protokol, path);
        }

        private void загрузитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string path = openFileDialog1.FileName;
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                polotno1.protokol = reader.ReadString();
                polotno1.Invalidate();
            }
        }

        private Bitmap SavePicture()
        {
            int k = 30;
            Bitmap picture = new Bitmap(polotno1.Width + k, polotno1.Height + k);

            for (int x = 0; x < picture.Width; x++)
            {
                for (int y = 0; y < picture.Height; y++)
                {
                    picture.SetPixel(x, y, Color.White);
                }
            }

            var temp = polotno1.protokol.Trim();
            temp = System.Text.RegularExpressions.Regex.Replace(temp, @"\s+", " ");

            string tempNumb = string.Empty;
            int[] Point = new int[6];
            for (int i = 0, ArrayPlace = 0; i < temp.Length; i++)
            {
                if (temp[i] == ' ')
                {
                    Point[ArrayPlace] = Convert.ToInt32(tempNumb);
                    //MessageBox.Show(tempNumb);
                    tempNumb = string.Empty;
                    ArrayPlace++;
                }
                else
                {
                    if (ArrayPlace == 6)
                    {
                        ArrayPlace = 0;
                        picture.SetPixel(Point[0], Point[1],
                            Color.FromArgb(Point[2], Point[3], Point[4], Point[5]));
                    }
                    tempNumb += temp[i];
                }
            }
            return picture;
        }
        private void картинкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (savePictureDialog1.ShowDialog() == DialogResult.Cancel) return;
            SavePicture().Save(savePictureDialog1.FileName);
        }

        
        private void друкToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(SavePicture(), 0, 0);
        }
    }
}
