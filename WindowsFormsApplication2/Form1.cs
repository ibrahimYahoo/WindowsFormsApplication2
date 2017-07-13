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

   

    public partial class Form1 : Form
    {
       public static List<int> qanswers = new List<int>();
       public static string tago;
        public Form1()
        {
            InitializeComponent();
        }

        private void q1Click(object sender, EventArgs e)
        {
            PictureBox imgObj = sender as PictureBox;
            //this.Hide();

            if (imgObj.Tag == pictureBox1.Tag)
            {


                qanswers.Add(1);

                //this.Close();

            }
            else if (imgObj.Tag == pictureBox2.Tag)
            {
                qanswers.Add(2);
            }
            else
            {
               qanswers.Add(3);
            }
            bool IsOpen = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "q2")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                q2 form = new q2();
                form.Show();
            }
            this.Hide();
        }
       
        }
    }

