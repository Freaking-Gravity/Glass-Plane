using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glass_Shield
{
   
    public partial class Glass_Plane : Form
    {
        int Height = 600;
        int Width = 480;
        public Glass_Plane()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(Width, Height);
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = (float)numericUpDown1.Value;
            
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            groupBox.Visible = true;
            this.Opacity = 1;
            numericUpDown1.Value = 1;
        }

        private void transparentRadio_CheckedChanged(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            groupBox.Visible = false;
        }

        private void blackWindowButton_CheckedChanged(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            groupBox.Visible = false;
        }
    }
}
