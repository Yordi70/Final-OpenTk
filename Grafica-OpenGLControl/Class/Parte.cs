using OpenTK;
using Grafica_OpenGLControl.Interface;
using System.Collections.Generic;
using OpenTK.Graphics.OpenGL;
using Grafica_OpenGLControl.extras;
namespace Grafica_OpenGLControl.Class
{
    class Parte : IDibujable
    {
        private Dictionary<string, Punto> Puntos { get; set; }
        private Punto Centro { get; set; }
        private Matrix4 Scale { get; set; }
        private Matrix4 Translate { get; set; }
        private Matrix4 Rotate { get; set; }
        private Shader Shaders { get; set; }

        //properties
        public Dictionary<string, Punto> LPuntos { get { return Puntos; } set { Puntos = value; } }
        public Punto Centro_Masa { get { return Centro; } set { Centro = value; } }
        public Matrix4 P_Scale { get { return Scale; } set { Scale = value; } }
        public Matrix4 P_Translate { get { return Translate; } set { Translate = value; } }
        public Matrix4 P_Rotate { get { return Rotate; } set { Rotate = value; } }
        public Shader P_Shaders { get { return Shaders; } set { Shaders = value; } }

        public Parte()
        {
            this.Puntos = new Dictionary<string, Punto>();
            this.Centro = new Punto(new Vector3(0, 0, 0));
            this.Shaders = new Shader("Shaders/shader.vert", "Shaders/shader.frag");
            this.Scale = Matrix4.CreateScale(1.0f, 1.0f, 1.0f);
            this.Translate = Matrix4.CreateTranslation(0f, 0f, 0f);
            this.Rotate = Matrix4.CreateRotationX((float)MathHelper.DegreesToRadians(0f));
        }
        public Parte(Parte p)
        {
            this.Puntos = p.LPuntos;
            this.Centro = p.Centro_Masa;
        }

        public void Add(string key, Punto p)
        {
            this.Puntos.Add(key, p);
        }

        public Punto GetElemento(string key)
        {
            return this.Puntos[key];
        }
        public void Remove(string key)
        {
            this.Puntos.Remove(key);
        }

        public void SumOrigen(Punto origen)
        {
            this.Centro.Sum(origen);
        }
        public int CantElements()
        {
            return this.Puntos.Count * 6;
        }

        public int CantPuntos()
        {
            return this.Puntos.Count;
        }
        public void ToMove(Punto p)
        {
            var move = Matrix4.CreateTranslation(p.X, p.Y, p.Z) * Matrix4.CreateTranslation(Centro.X, Centro.Y, Centro.Z);
            Shaders.Use();
            Shaders.SetMatrix4("move", move);
        }
        public float[] ToArray()
        {
            List<float> _vertices = new List<float>() { };
            foreach (Punto p in this.Puntos.Values)
            {
                _vertices.Add(p.X);
                _vertices.Add(p.Y);
                _vertices.Add(p.Z);
               
            }

            return _vertices.ToArray();
        }

        public void Dibujar()
        {
            Matrix4 transform = Matrix4.Identity * Translate * Rotate * Scale;
            Shaders.Use();
            Shaders.SetMatrix4("transform", transform);

            GL.BufferData(BufferTarget.ArrayBuffer, this.CantElements() * sizeof(float), this.ToArray(), BufferUsageHint.StaticDraw);
            GL.DrawArrays(PrimitiveType.LineLoop, 0, this.CantPuntos());

        }
        public void Escalar(float x, float y, float z)
        {
            Scale = Matrix4.CreateScale(x, y, z);
        }

        public void Trasladar(float x, float y, float z)
        {
            Translate = Matrix4.CreateTranslation(x, y, z);
        }
        public void Rotar(float angle, Punto c)
        {
            Rotate = Matrix4.CreateTranslation(c.X, c.Y, c.Z) * Matrix4.CreateRotationX((float)MathHelper.DegreesToRadians(angle)) * Matrix4.CreateRotationY((float)MathHelper.DegreesToRadians(angle)) * Matrix4.CreateRotationZ((float)MathHelper.DegreesToRadians(angle)) * Matrix4.CreateTranslation(-c.X, -c.Y, -c.Z);
        }
    }
}
