using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace WindowsFormsApplication2
{
    public partial class q2 : Form
    {
        const int AW_SLIDE = 0X40000;
        const int AW_HOR_POSITIVE = 0X1;
        const int AW_HOR_NEGATIVE = 0X2;
        const int AW_BLEND = 0X80000;

        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);

        public q2()
        {
            InitializeComponent();
           
        }
        protected override void OnLoad(EventArgs e)
        {
            //Load the Form At Position of Main Form
            int WidthOfMain = Application.OpenForms["Form1"].Width;
            int HeightofMain = Application.OpenForms["Form1"].Height;
            int LocationMainX = Application.OpenForms["Form1"].Location.X;
            int locationMainy = Application.OpenForms["Form1"].Location.Y;

            //Set the Location
            this.Location = new Point(LocationMainX + WidthOfMain, locationMainy + 10);

            //Animate form
            AnimateWindow(this.Handle, 500, AW_SLIDE | AW_HOR_POSITIVE);
        }


        private void q2label_Click(object sender, EventArgs e)
        {
            
            //Form1.qanswers.Add(22);
            //textBox1.Text = string.Join(" ", Form1.qanswers);

            
        }

        private void q2_Load(object sender, EventArgs e)
        {

        }

        private void q2Click(object sender, EventArgs e)
        {
            PictureBox imgObj = sender as PictureBox;
           // this.Hide();

            if (imgObj.Tag == pictureBox1.Tag)
            {


                Form1.qanswers.Add(1);
                
                //this.Close();

            }
            else if(imgObj.Tag == pictureBox2.Tag)
            {
                Form1.qanswers.Add(2);
            }
            else 
            {
                Form1.qanswers.Add(3);
            }
            bool IsOpen = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "q3")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                q3 form = new q3();
                form.Show();
            }
            this.Hide();

        }
        

    }


}
