using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphics_engine
{
    internal class ObjPyramid
    {
        public ObjPyramid()
        {
            COORDINATE[0] = new Vector4(0, 0, 0);       
            COORDINATE[1] = new Vector4(0, 50, 0);      
            COORDINATE[2] = new Vector4(50, 50, 0);      
            COORDINATE[3] = new Vector4(50, 0, 0);     
            COORDINATE[4] = new Vector4(25, 25, 50);    

            Array.Copy(COORDINATE, OutCOORDINATE, 5);

            Centre();
        }

        protected Vector4[] COORDINATE = new Vector4[5];
        protected Vector4[] OutCOORDINATE = new Vector4[5];
        protected Vector3 CENTRE;
        protected Vector3 ROLATION = new Vector3(0, 0, 0);
        protected Vector3 TRANSLATE = new Vector3(0, 0, 0);
        protected Vector3 SCALE = new Vector3(1, 1, 1);

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

        public void Print(Bitmap bitmap)
        {
            Generate.Triangle(OutCOORDINATE[0], OutCOORDINATE[1], OutCOORDINATE[4], bitmap);
            Generate.Triangle(OutCOORDINATE[1], OutCOORDINATE[2], OutCOORDINATE[4], bitmap);
            Generate.Triangle(OutCOORDINATE[2], OutCOORDINATE[3], OutCOORDINATE[4], bitmap);
            Generate.Triangle(OutCOORDINATE[3], OutCOORDINATE[0], OutCOORDINATE[4], bitmap);
            Generate.Triangle(OutCOORDINATE[0], OutCOORDINATE[1], OutCOORDINATE[2], bitmap);
            Generate.Triangle(OutCOORDINATE[2], OutCOORDINATE[3], OutCOORDINATE[0], bitmap);
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

        public void Centre()
        {
            CENTRE = (Vector3)(COORDINATE[0] + COORDINATE[1] + COORDINATE[2] + COORDINATE[3] + COORDINATE[4])/5d;
        }
    }
}

