using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphics_engine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine(_one);
            _one = new Vector4(1, 2, 3, 4);
            _one[2] = 3653;
            label1.Text = $"{_one[2]}";
        }

        Vector4 _one;
        Vector3 _two = 79;


        
    }
}
