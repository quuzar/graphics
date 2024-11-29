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
        List<Object> cudes = new List<Object>();
        private Timer imageUpdateTimer;
        int i = 1;
        int numb;
        int cout = 0;
        int test = -1;
        
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
            double[] scale = new double[] { (double)sizX.Value, (double)sizY.Value, (double)sizZ.Value, };
            double[] translate = new double[] { (double)traX.Value, (double)traY.Value, (double)traZ.Value };
            double[] rotation = new double[] { (double)rolX.Value, (double)rolY.Value, (double)rolZ.Value };


            foreach(var obj in cudes)
            {
                if(obj is  ObjDodecahedron)
                {

                    if (cout == numb)
                    {
                        if(cout != test)
                        {
                            sizX.Value = (decimal)((ObjDodecahedron)obj).Scale[0];
                            sizY.Value = (decimal)((ObjDodecahedron)obj).Scale[1];
                            sizZ.Value = (decimal)((ObjDodecahedron)obj).Scale[2];

                            traX.Value = (decimal)((ObjDodecahedron)obj).Translate[0];
                            traY.Value = (decimal)((ObjDodecahedron)obj).Translate[1];
                            traZ.Value = (decimal)((ObjDodecahedron)obj).Translate[2];

                            rolX.Value = 0;
                            rolY.Value = 0;
                            rolZ.Value = 0;
                            test = cout;

                            scale = new double[] { (double)sizX.Value, (double)sizY.Value, (double)sizZ.Value, };
                            translate = new double[] { (double)traX.Value, (double)traY.Value, (double)traZ.Value };
                            rotation = new double[] { (double)rolX.Value, (double)rolY.Value, (double)rolZ.Value };
                        }
                        ((ObjDodecahedron)obj).Scale = scale;
                        ((ObjDodecahedron)obj).Translate = translate;
                        ((ObjDodecahedron)obj).Rolation = rotation;
                        ((ObjDodecahedron)obj).ApplyTransformations();
                        ((ObjDodecahedron)obj).Print_2(bitmap);
                        label1.Text = $"Расположение\n{((ObjDodecahedron)obj).Translate[0]}, {((ObjDodecahedron)obj).Translate[1]}, {((ObjDodecahedron)obj).Translate[2]}";
                        label2.Text = $"Размер\n{((ObjDodecahedron)obj).Scale[0]}, {((ObjDodecahedron)obj).Scale[1]}, {((ObjDodecahedron)obj).Scale[2]}";
                        label3.Text = $"Поворот\n{(int)(((ObjDodecahedron)obj).Rolation[0] * 114.59 / 2) % 360}, {(int)(((ObjDodecahedron)obj).Rolation[1] * 114.59 / 2) % 360}, {(int)(((ObjDodecahedron)obj).Rolation[2] * 114.59 / 2) % 360}";
                    }
                    else 
                    {
                        ((ObjDodecahedron)obj).ApplyTransformations();
                        ((ObjDodecahedron)obj).Print(bitmap);
                    }
                }
                else if(obj is ObjCube)
                {

                    if (cout == numb)
                    {
                        if (cout != test)
                        {
                            sizX.Value = (decimal)((ObjCube)obj).Scale[0];
                            sizY.Value = (decimal)((ObjCube)obj).Scale[1];
                            sizZ.Value = (decimal)((ObjCube)obj).Scale[2];

                            traX.Value = (decimal)((ObjCube)obj).Translate[0];
                            traY.Value = (decimal)((ObjCube)obj).Translate[1];
                            traZ.Value = (decimal)((ObjCube)obj).Translate[2];

                            rolX.Value = 0;
                            rolY.Value = 0;
                            rolZ.Value = 0;
                            test = cout;

                            scale = new double[] { (double)sizX.Value, (double)sizY.Value, (double)sizZ.Value, };
                            translate = new double[] { (double)traX.Value, (double)traY.Value, (double)traZ.Value };
                            rotation = new double[] { (double)rolX.Value, (double)rolY.Value, (double)rolZ.Value };
                        }
                        ((ObjCube)obj).Scale = scale;
                        ((ObjCube)obj).Translate = translate;
                        ((ObjCube)obj).Rolation = rotation;
                        ((ObjCube)obj).ApplyTransformations();
                        ((ObjCube)obj).Print_2(bitmap);
                        label1.Text = $"Расположение\n{((ObjCube)obj).Translate[0]}, {((ObjCube)obj).Translate[1]}, {((ObjCube)obj).Translate[2]}";
                        label2.Text = $"Размер\n{((ObjCube)obj).Scale[0]}, {((ObjCube)obj).Scale[1]}, {((ObjCube)obj).Scale[2]}";
                        label3.Text = $"Поворот\n{(int)(((ObjCube)obj).Rolation[0] * 114.59 / 2) % 360}, {(int)(((ObjCube)obj).Rolation[1] * 114.59 / 2) % 360}, {(int)(((ObjCube)obj).Rolation[2] * 114.59 / 2) % 360}";
                    }
                    else
                    {
                        ((ObjCube)obj).ApplyTransformations();
                        ((ObjCube)obj).Print(bitmap);
                    }
                }
                else if(obj is ObjPyramid)
                {
                    if (cout == numb)
                    {
                        if (cout != test)
                        {
                            sizX.Value = (decimal)((ObjPyramid)obj).Scale[0];
                            sizY.Value = (decimal)((ObjPyramid)obj).Scale[1];
                            sizZ.Value = (decimal)((ObjPyramid)obj).Scale[2];

                            traX.Value = (decimal)((ObjPyramid)obj).Translate[0];
                            traY.Value = (decimal)((ObjPyramid)obj).Translate[1];
                            traZ.Value = (decimal)((ObjPyramid)obj).Translate[2];

                            rolX.Value = 0;
                            rolY.Value = 0;
                            rolZ.Value = 0;
                            test = cout;

                            scale = new double[] { (double)sizX.Value, (double)sizY.Value, (double)sizZ.Value, };
                            translate = new double[] { (double)traX.Value, (double)traY.Value, (double)traZ.Value };
                            rotation = new double[] { (double)rolX.Value, (double)rolY.Value, (double)rolZ.Value };
                        }
                        ((ObjPyramid)obj).Scale = scale;
                        ((ObjPyramid)obj).Translate = translate;
                        ((ObjPyramid)obj).Rolation = rotation;
                        ((ObjPyramid)obj).ApplyTransformations();
                        ((ObjPyramid)obj).Print_2(bitmap);
                        label1.Text = $"Расположение\n{((ObjPyramid)obj).Translate[0]}, {((ObjPyramid)obj).Translate[1]}, {((ObjPyramid)obj).Translate[2]}";
                        label2.Text = $"Размер\n{((ObjPyramid)obj).Scale[0]}, {((ObjPyramid)obj).Scale[1]}, {((ObjPyramid)obj).Scale[2]}";
                        label3.Text = $"Поворот\n{(int)(((ObjPyramid)obj).Rolation[0] * 114.59 / 2) % 360}, {(int)(((ObjPyramid)obj).Rolation[1] * 114.59 / 2) % 360}, {(int)(((ObjPyramid)obj).Rolation[2] * 114.59 / 2) % 360}";
                    }
                    else
                    {
                        ((ObjPyramid)obj).ApplyTransformations();
                        ((ObjPyramid)obj).Print(bitmap);
                    }
                }
                cout++;
            }
            pictureBox1.Image = bitmap;

            error.Text = ErrorString.Print();

            cout = 0;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            imageUpdateTimer.Stop();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                cudes.Add(new ObjCube(20.0));
                comboBox1.Items.Add($"{i}. Cube");
                i++;
            }
            else if (radioButton2.Checked)
            {
                cudes.Add(new ObjPyramid());
                comboBox1.Items.Add($"{i}. Pyramid");
                i++;
            }
            else if(radioButton3.Checked)
            {
                cudes.Add(new ObjDodecahedron(20.0));
                comboBox1.Items.Add($"{i}. Dodecahedron");
                i++;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            numb = (int)comboBox1.Text[0] - 49;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            imageUpdateTimer.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            imageUpdateTimer.Start();
        }
    }
}
