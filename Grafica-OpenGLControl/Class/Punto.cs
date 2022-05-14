using OpenTK;

namespace Grafica_OpenGLControl.Class
{
    class Punto
    {
        private float EjeX { get; set; }
        private float EjeY { get; set; }
        private float EjeZ { get; set; }
        //properties
        public float X { get { return EjeX; } set { EjeX = value; } }
        public float Y { get { return EjeY; } set { EjeY = value; } }
        public float Z { get { return EjeZ; } set { EjeZ = value; } }

        public Punto() : this(0, 0, 0) { }
        public Punto(float x, float y, float z)
        {
            this.EjeX = x;
            this.EjeY = y;
            this.EjeZ = z;
        }

        public Punto(Vector3 punto)
        {
            this.EjeX = punto.X;
            this.EjeY = punto.Y;
            this.EjeZ = punto.Z;
        }

        public Punto(Punto p)
        {
            this.EjeX = p.X;
            this.EjeY = p.Y;
            this.EjeZ = p.Z;
        }

        public void Sum(Punto p)
        {
            this.EjeX += p.X;
            this.EjeY += p.Y;
            this.EjeZ += p.Z;
        }

    }
}
