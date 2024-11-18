using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace graphics_engine
{
    class ObjCube
    {
        protected Vector4[] COORDINATE = new Vector4[8];
        protected Vector4[] OutCOORDINATE = new Vector4[8];
        protected Vector3 CENTRE = new Vector3();
        protected Vector3 ROLATION = new Vector3(0, 0, 0);
        protected Vector3 TRANSLATE = new Vector3(0, 0, 0);
        protected Vector3 SCALE = new Vector3(1, 1, 1);



        public ObjCube(double size)
        {
            InitializeVertices(size);
            Centre();
            Array.Copy(COORDINATE, OutCOORDINATE, 8);
        }


        public double[] Rolation
        {
            get => new double[] { ROLATION[0], ROLATION[1], ROLATION[2] };
            set
            {
                ROLATION[0] = (ROLATION[0] + value[0]) % 360;
                ROLATION[1] = (ROLATION[1] + value[1]) % 360;
                ROLATION[2] = (ROLATION[2] + value[2]) % 360;
            }
        }

        public double[] Translate
        {
            get => new double[] { TRANSLATE[0], TRANSLATE[1], TRANSLATE[2] };
            set
            {
                TRANSLATE[0] = value[0];
                TRANSLATE[1] = value[1];
                TRANSLATE[2] = value[2];
            }
        }

        public double[] Scale
        {
            get => new double[] { SCALE[0], SCALE[1], SCALE[2] };
            set
            {
                SCALE[0] = value[0];
                SCALE[1] = value[1];
                SCALE[2] = value[2];
            }
        }


        private void InitializeVertices(double size)
        {
            double halfSize = size / 2.0;
            COORDINATE[0] = new Vector4(-halfSize, -halfSize, -halfSize);
            COORDINATE[1] = new Vector4(halfSize, -halfSize, -halfSize);
            COORDINATE[2] = new Vector4(halfSize, halfSize, -halfSize);
            COORDINATE[3] = new Vector4(-halfSize, halfSize, -halfSize);
            COORDINATE[4] = new Vector4(-halfSize, -halfSize, halfSize);
            COORDINATE[5] = new Vector4(halfSize, -halfSize, halfSize);
            COORDINATE[6] = new Vector4(halfSize, halfSize, halfSize);
            COORDINATE[7] = new Vector4(-halfSize, halfSize, halfSize);
        }

        public void Print(Bitmap bitmap)
        {
            Generate.Line(OutCOORDINATE[0], OutCOORDINATE[1], bitmap, Color.Black);
            Generate.Line(OutCOORDINATE[1], OutCOORDINATE[2], bitmap, Color.Black);
            Generate.Line(OutCOORDINATE[2], OutCOORDINATE[3], bitmap, Color.Black);
            Generate.Line(OutCOORDINATE[3], OutCOORDINATE[0], bitmap, Color.Black);
            Generate.Line(OutCOORDINATE[4], OutCOORDINATE[5], bitmap, Color.Black);
            Generate.Line(OutCOORDINATE[5], OutCOORDINATE[6], bitmap, Color.Black);
            Generate.Line(OutCOORDINATE[6], OutCOORDINATE[7], bitmap, Color.Black);
            Generate.Line(OutCOORDINATE[7], OutCOORDINATE[4], bitmap, Color.Black);
            Generate.Line(OutCOORDINATE[0], OutCOORDINATE[4], bitmap, Color.Black);
            Generate.Line(OutCOORDINATE[1], OutCOORDINATE[5], bitmap, Color.Black);
            Generate.Line(OutCOORDINATE[2], OutCOORDINATE[6], bitmap, Color.Black);
            Generate.Line(OutCOORDINATE[3], OutCOORDINATE[7], bitmap, Color.Black);
        }

        public void Print_2(Bitmap bitmap)
        {
            Generate.Line(OutCOORDINATE[0], OutCOORDINATE[1], bitmap, Color.DarkRed);
            Generate.Line(OutCOORDINATE[1], OutCOORDINATE[2], bitmap, Color.DarkRed);
            Generate.Line(OutCOORDINATE[2], OutCOORDINATE[3], bitmap, Color.DarkRed);
            Generate.Line(OutCOORDINATE[3], OutCOORDINATE[0], bitmap, Color.DarkRed);
            Generate.Line(OutCOORDINATE[4], OutCOORDINATE[5], bitmap, Color.DarkRed);
            Generate.Line(OutCOORDINATE[5], OutCOORDINATE[6], bitmap, Color.DarkRed);
            Generate.Line(OutCOORDINATE[6], OutCOORDINATE[7], bitmap, Color.DarkRed);
            Generate.Line(OutCOORDINATE[7], OutCOORDINATE[4], bitmap, Color.DarkRed);
            Generate.Line(OutCOORDINATE[0], OutCOORDINATE[4], bitmap, Color.DarkRed);
            Generate.Line(OutCOORDINATE[1], OutCOORDINATE[5], bitmap, Color.DarkRed);
            Generate.Line(OutCOORDINATE[2], OutCOORDINATE[6], bitmap, Color.DarkRed);
            Generate.Line(OutCOORDINATE[3], OutCOORDINATE[7], bitmap, Color.DarkRed);
        }

        public void Centre()
        {
            foreach(var poin in COORDINATE)
            {
                CENTRE += (Vector3)poin;
            }

            CENTRE /= COORDINATE.Length;
        }

        public void ApplyTransformations()
        {
            for (int i = 0; i < COORDINATE.Length; i++)
            {
                Vector4 scaled = Matrix.Scale(COORDINATE[i] - (Vector4)CENTRE, (Vector4)SCALE);
                scaled += (Vector4)CENTRE;

                Vector4 rotated = Matrix.Rotation(scaled - (Vector4)CENTRE, ROLATION);
                rotated += (Vector4)CENTRE;

                OutCOORDINATE[i] = Matrix.Translate(rotated, (Vector4)TRANSLATE);
            }
        }
    }
}
