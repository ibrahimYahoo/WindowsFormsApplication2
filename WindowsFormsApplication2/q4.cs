using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class q4 : Form
    {
        public static int max1 = 0;

        public q4()
        {
            InitializeComponent();
        }

        private void q4Click(object sender, EventArgs e)
        {
            PictureBox imgObj = sender as PictureBox;
            this.Hide();

            if (imgObj.Tag == pictureBox1.Tag)
            {


                Form1.qanswers.Add(1);

                //this.Close();

            }
            else if (imgObj.Tag == pictureBox2.Tag)
            {
                Form1.qanswers.Add(2);
            }
            else
            {
                Form1.qanswers.Add(3);
            }


            var result = Form1.qanswers.GroupBy(x => x).ToDictionary(y => y.Key, y => y.Count()).OrderByDescending(z => z.Value);
            int max = 0;
            foreach (var x in result)
            {
                if (max < x.Value)
                {
                    max = x.Value;
                    max1 = x.Key;
                }


               // textBox1.Text = max1.ToString();



            }

            takeSelfieForm selfieObj = new takeSelfieForm();
            selfieObj.ShowDialog();

        }
    }
}
