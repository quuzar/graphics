using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphics_engine
{
    public partial class Form1 : Form
    {

        Vector3 trans = new Vector3();
        ObjPyramid pyramid = new ObjPyramid();
        private Timer imageUpdateTimer;
        
        public Form1()
        {
            InitializeComponent();
            
            imageUpdateTimer = new Timer();
            imageUpdateTimer.Interval = 100; // Интервал 
            imageUpdateTimer.Tick += ImageUpdateTimer_Tick;
            imageUpdateTimer.Start();
        }
        
        private void ImageUpdateTimer_Tick(object sender, EventArgs e)
        {   
            int height = pictureBox1.Height;
            int width = pictureBox1.Width;
            Bitmap bitmap = new Bitmap(width, height);


            pyramid.Scale = new double[] { (double)sizX.Value, (double)sizY.Value, (double)sizZ.Value, };
            pyramid.Translate = new double[] { (double)traX.Value, (double)traY.Value, (double)traZ.Value };
            pyramid.Rolation = new double[] {(double)rolX.Value, (double)rolY.Value, (double)rolZ.Value };

            pyramid.ApplyTransformations();
            pyramid.Print(bitmap);

            pictureBox1.Image = bitmap;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            imageUpdateTimer.Stop();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
