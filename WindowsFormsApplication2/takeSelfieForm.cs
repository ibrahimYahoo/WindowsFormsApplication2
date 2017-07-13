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
    public partial class takeSelfieForm : Form
    {

        public takeSelfieForm()
        {
            if(q4.max1 == 1)
            {
                this.BackgroundImage = Properties.Resources.Screen_6;

            }
            else if (q4.max1 == 2)
            {
                this.BackgroundImage = Properties.Resources.Screen_6_1;

            }
            else 
            {
                this.BackgroundImage = Properties.Resources.Screen_6_2; 

            }


            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCameraControlTool cameraObj = new FormCameraControlTool();
            cameraObj.ShowDialog();
        }
    }
}
