using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        public void PictureBoxDegis(PictureBox pictureBox)
        {
            pictureBox.Image = Image.FromFile("C:\\Users\\arsla\\source\\repos\\WinFormsApp3\\WinFormsApp3\\Properties\\tick.png");
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
