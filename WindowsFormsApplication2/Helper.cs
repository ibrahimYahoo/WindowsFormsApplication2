using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class Helper
    {
        public static void SaveImageCapture(System.Drawing.Image image)
        {

            Bitmap b = new Bitmap(image);
            b.Save(Path.Combine(@"C:\Users\ibrahim-01\documents\visual studio 2015\Projects\WindowsFormsApplication2\WindowsFormsApplication2\Resources", Path.GetFileName("ne22wimage.jpg")));

           // SaveFileDialog s = new SaveFileDialog();
           // s.FileName = "Image";// Default file name
           // s.DefaultExt = ".Jpg";// Default file extension
           //// s.Filter = "Image (.jpg)|*.jpg"; // Filter files by extension
           //                                  // s.ShowDialog()
           //                                  // Show save file dialog box
           //                                  // Process save file dialog box results
           // File.(s.FileName, Path.Combine(@"C:\Users\ibrahim-01\documents\visual studio 2015\Projects\WindowsFormsApplication2\WindowsFormsApplication2\Resources", Path.GetFileName(s.FileName)));
           // //File.Copy()
           // //if (s.ShowDialog() == DialogResult.OK)
           // //{
           // //    // Save Image
           // //    string filename = s.FileName;
           // //    FileStream fstream = new FileStream(filename, FileMode.Create);
           // //    image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
           // //    fstream.Close();

           // //}

        }
    }
}
