using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using WebCamAppCsharp;

namespace WebCamApp
{
    public partial class Form1 : Form
    {
        WebCam webcam;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webcam = new WebCam();
            webcam.InitializeWebCam(ref pictureBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webcam.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webcam.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Helper.SaveImageCapture(pictureBox2.Image);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
