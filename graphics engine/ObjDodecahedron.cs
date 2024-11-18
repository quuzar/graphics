using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphics_engine
{
    internal class ObjDodecahedron
    {
        protected Vector4[] COORDINATE = new Vector4[20];
        protected Vector4[] OutCOORDINATE = new Vector4[20];
        protected Vector3 CENTRE = new Vector3();
        protected Vector3 ROLATION = new Vector3(0, 0, 0);
        protected Vector3 TRANSLATE = new Vector3(0, 0, 0);
        protected Vector3 SCALE = new Vector3(1, 1, 1);

        public ObjDodecahedron(double size)
        {
            InitializeVertices(size);
            Centre();
            Array.Copy(COORDINATE, OutCOORDINATE, 8);
        }

        private void InitializeVertices(double size)
        {
            double phi = (1 + Math.Sqrt(5)) / 2; 
            double a = size / Math.Sqrt(3);
            double b = a / phi;
            double c = a * phi;

            COORDINATE[0] = new Vector4(-a, -a, -a);
            COORDINATE[1] = new Vector4(-a, -a, a);
            COORDINATE[2] = new Vector4(-a, a, -a);
            COORDINATE[3] = new Vector4(-a, a, a);
            COORDINATE[4] = new Vector4(a, -a, -a);
            COORDINATE[5] = new Vector4(a, -a, a);
            COORDINATE[6] = new Vector4(a, a, -a);
            COORDINATE[7] = new Vector4(a, a, a);
            COORDINATE[8] = new Vector4(0, -b, -c);
            COORDINATE[9] = new Vector4(0, -b, c);
            COORDINATE[10] = new Vector4(0, b, -c);
            COORDINATE[11] = new Vector4(0, b, c);
            COORDINATE[12] = new Vector4(-b, -c, 0);
            COORDINATE[13] = new Vector4(-b, c, 0);
            COORDINATE[14] = new Vector4(b, -c, 0);
            COORDINATE[15] = new Vector4(b, c, 0);
            COORDINATE[16] = new Vector4(-c, 0, -b);
            COORDINATE[17] = new Vector4(c, 0, -b);
            COORDINATE[18] = new Vector4(-c, 0, b);
            COORDINATE[19] = new Vector4(c, 0, b);
        }

        public void Print(Bitmap bitmap)
        {
            Generate.Line(OutCOORDINATE[0], OutCOORDINATE[8], bitmap, Color.Black)  ;//1
            Generate.Line(OutCOORDINATE[0], OutCOORDINATE[12], bitmap, Color.Black) ;//2
            Generate.Line(OutCOORDINATE[0], OutCOORDINATE[16], bitmap, Color.Black);//3
            Generate.Line(OutCOORDINATE[1], OutCOORDINATE[9], bitmap, Color.Black) ;//4
            Generate.Line(OutCOORDINATE[1], OutCOORDINATE[12], bitmap, Color.Black);//5
            Generate.Line(OutCOORDINATE[1], OutCOORDINATE[18], bitmap, Color.Black);//6
            Generate.Line(OutCOORDINATE[2], OutCOORDINATE[10], bitmap, Color.Black);//7
            Generate.Line(OutCOORDINATE[2], OutCOORDINATE[13], bitmap, Color.Black);//8
            Generate.Line(OutCOORDINATE[2], OutCOORDINATE[16], bitmap, Color.Black);//9
            Generate.Line(OutCOORDINATE[3], OutCOORDINATE[11], bitmap, Color.Black);//10
            Generate.Line(OutCOORDINATE[3], OutCOORDINATE[13], bitmap, Color.Black);//11
            Generate.Line(OutCOORDINATE[3], OutCOORDINATE[18], bitmap, Color.Black);//12
            Generate.Line(OutCOORDINATE[4], OutCOORDINATE[8], bitmap, Color.Black);//13
            Generate.Line(OutCOORDINATE[4], OutCOORDINATE[14], bitmap, Color.Black) ;//14
            Generate.Line(OutCOORDINATE[4], OutCOORDINATE[17], bitmap, Color.Black);//15
            Generate.Line(OutCOORDINATE[5], OutCOORDINATE[9], bitmap, Color.Black);//16
            Generate.Line(OutCOORDINATE[5], OutCOORDINATE[14], bitmap, Color.Black) ;//17
            Generate.Line(OutCOORDINATE[5], OutCOORDINATE[19], bitmap, Color.Black) ;//18
            Generate.Line(OutCOORDINATE[6], OutCOORDINATE[10], bitmap, Color.Black);//19
            Generate.Line(OutCOORDINATE[6], OutCOORDINATE[15], bitmap, Color.Black);//20
            Generate.Line(OutCOORDINATE[6], OutCOORDINATE[17], bitmap, Color.Black);//21
            Generate.Line(OutCOORDINATE[7], OutCOORDINATE[11], bitmap, Color.Black);//22
            Generate.Line(OutCOORDINATE[7], OutCOORDINATE[15], bitmap, Color.Black);//23
            Generate.Line(OutCOORDINATE[7], OutCOORDINATE[19], bitmap, Color.Black);//24
            Generate.Line(OutCOORDINATE[8], OutCOORDINATE[10], bitmap, Color.Black);//25
            Generate.Line(OutCOORDINATE[9],OutCOORDINATE[11], bitmap, Color.Black);//26
            Generate.Line(OutCOORDINATE[12], OutCOORDINATE[14], bitmap, Color.Black);//27
            Generate.Line(OutCOORDINATE[13] ,OutCOORDINATE[15], bitmap, Color.Black)  ;//28
            Generate.Line(OutCOORDINATE[16],OutCOORDINATE[18], bitmap, Color.Black);//29
            Generate.Line(OutCOORDINATE[17],OutCOORDINATE[19], bitmap, Color.Black);//30
        }

        public void Print_2(Bitmap bitmap)
        {
            Generate.Line(OutCOORDINATE[0], OutCOORDINATE[8], bitmap, Color.DarkRed);//1
            Generate.Line(OutCOORDINATE[0], OutCOORDINATE[12], bitmap, Color.DarkRed);//2
            Generate.Line(OutCOORDINATE[0], OutCOORDINATE[16], bitmap, Color.DarkRed);//3
            Generate.Line(OutCOORDINATE[1], OutCOORDINATE[9], bitmap, Color.DarkRed);//4
            Generate.Line(OutCOORDINATE[1], OutCOORDINATE[12], bitmap, Color.DarkRed);//5
            Generate.Line(OutCOORDINATE[1], OutCOORDINATE[18], bitmap, Color.DarkRed);//6
            Generate.Line(OutCOORDINATE[2], OutCOORDINATE[10], bitmap, Color.DarkRed);//7
            Generate.Line(OutCOORDINATE[2], OutCOORDINATE[13], bitmap, Color.DarkRed);//8
            Generate.Line(OutCOORDINATE[2], OutCOORDINATE[16], bitmap, Color.DarkRed);//9
            Generate.Line(OutCOORDINATE[3], OutCOORDINATE[11], bitmap, Color.DarkRed);//10
            Generate.Line(OutCOORDINATE[3], OutCOORDINATE[13], bitmap, Color.DarkRed);//11
            Generate.Line(OutCOORDINATE[3], OutCOORDINATE[18], bitmap, Color.DarkRed);//12
            Generate.Line(OutCOORDINATE[4], OutCOORDINATE[8], bitmap, Color.DarkRed);//13
            Generate.Line(OutCOORDINATE[4], OutCOORDINATE[14], bitmap, Color.DarkRed);//14
            Generate.Line(OutCOORDINATE[4], OutCOORDINATE[17], bitmap, Color.DarkRed);//15
            Generate.Line(OutCOORDINATE[5], OutCOORDINATE[9], bitmap, Color.DarkRed);//16
            Generate.Line(OutCOORDINATE[5], OutCOORDINATE[14], bitmap, Color.DarkRed);//17
            Generate.Line(OutCOORDINATE[5], OutCOORDINATE[19], bitmap, Color.DarkRed);//18
            Generate.Line(OutCOORDINATE[6], OutCOORDINATE[10], bitmap, Color.DarkRed);//19
            Generate.Line(OutCOORDINATE[6], OutCOORDINATE[15], bitmap, Color.DarkRed);//20
            Generate.Line(OutCOORDINATE[6], OutCOORDINATE[17], bitmap, Color.DarkRed);//21
            Generate.Line(OutCOORDINATE[7], OutCOORDINATE[11], bitmap, Color.DarkRed);//22
            Generate.Line(OutCOORDINATE[7], OutCOORDINATE[15], bitmap, Color.DarkRed);//23
            Generate.Line(OutCOORDINATE[7], OutCOORDINATE[19], bitmap, Color.DarkRed);//24
            Generate.Line(OutCOORDINATE[8], OutCOORDINATE[10], bitmap, Color.DarkRed);//25
            Generate.Line(OutCOORDINATE[9], OutCOORDINATE[11], bitmap, Color.DarkRed);//26
            Generate.Line(OutCOORDINATE[12], OutCOORDINATE[14], bitmap, Color.DarkRed);//27
            Generate.Line(OutCOORDINATE[13], OutCOORDINATE[15], bitmap, Color.DarkRed);//28
            Generate.Line(OutCOORDINATE[16], OutCOORDINATE[18], bitmap, Color.DarkRed);//29
            Generate.Line(OutCOORDINATE[17], OutCOORDINATE[19], bitmap, Color.DarkRed);//30
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

        public void Centre()
        {
            foreach (var poin in COORDINATE)
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
