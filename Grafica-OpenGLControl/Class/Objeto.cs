using Grafica_OpenGLControl.Interface;
using System.Collections.Generic;
using OpenTK;

namespace Grafica_OpenGLControl.Class
{
    class Objeto : IDibujable
    {
        private Dictionary<string, Parte> Partes { get; set; }
        private Punto Centro { get; set; }

        //properties
        public Dictionary<string, Parte> LPartes { get { return Partes; } set { Partes = value; } }
        public Punto Centro_Masa { get { return Centro; } set { Centro = value; } }


        public Objeto()
        {
            this.Partes = new Dictionary<string, Parte>();
            this.Centro = new Punto(new Vector3(0, 0, 0));
        }


        public Objeto(Objeto obj)
        {
            this.Partes = obj.LPartes;
            this.Centro = obj.Centro_Masa;
        }
        public void Add(string key, Parte p)
        {
            this.Partes.Add(key, p);
        }

        public Parte GetElemento(string key)
        {
            return this.Partes[key];
        }
        public void SumOrigen()
        {
            foreach (Parte parte in this.Partes.Values)
            {
                parte.SumOrigen(this.Centro);
            }
        }
        public void Remove(string key)
        {
            this.Partes.Remove(key);
        }

        public void Dibujar()
        {
            foreach (Parte parte in this.Partes.Values)
            {
                parte.ToMove(Centro);
                parte.Dibujar();
            }

        }
        public void Escalar(float x, float y, float z)
        {
            foreach (Parte p in this.Partes.Values)
            {
                p.Escalar(x, y, z);
            }
        }
        public void Trasladar(float x, float y, float z)
        {
            Centro_Masa.Sum(x, y, z);   
            foreach (Parte p in this.Partes.Values)
            {
                
                p.Trasladar();
            }
        }

        public void Rotar(Punto ejes, float angle, Punto c)
        {
            foreach (Parte p in this.Partes.Values)
            {
                
                p.RotarObj(ejes, angle, c);
            }
        }
        public void LimpiarTransform()
        {
            foreach (Parte p in this.Partes.Values)
            {
                p.LimpiarTransform();
            }
        }
    }
}
