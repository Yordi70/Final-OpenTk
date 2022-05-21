using Grafica_OpenGLControl.Interface;
using System.Collections.Generic;
using OpenTK;
namespace Grafica_OpenGLControl.Class
{
    class Escenario : IDibujable
    {
        private Dictionary<string, Objeto> Objetos { get; set; }
        private Punto Centro { get; set; }

        //properties
        public Dictionary<string, Objeto> LObjetos { get { return Objetos; } set { Objetos = value; } }
        public Punto Centro_Masa { get { return Centro; } set { Centro = value; } }


        public Escenario()
        {
            this.Objetos = new Dictionary<string, Objeto>();
            this.Centro = new Punto(new Vector3(0, 0, 0));
        }

        public Escenario(Escenario esc)
        {
            this.Objetos = esc.LObjetos;
            this.Centro = esc.Centro_Masa;
        }

        public void Add(string key, Objeto obj)
        {
            this.Objetos.Add(key, obj);
        }

        public Objeto GetElemento(string key)
        {
            return this.Objetos[key];
        }

        public void Remove(string key)
        {
            this.Objetos.Remove(key);
        }


        public void Dibujar()
        {
            foreach (Objeto obj in this.Objetos.Values)
            {
                obj.Dibujar();
            }

        }
        public void Escalar(float x, float y, float z)
        {
            foreach (Objeto obj in this.Objetos.Values)
            {
                obj.Escalar(x, y, z);
            }
        }
        public void Trasladar(float x, float y, float z)
        {
            foreach (Objeto obj in this.Objetos.Values)
            {
                obj.Trasladar(x, y, z);
            }
        }
        public void Rotar(Punto ejes, float angle, Punto c)
        {
            foreach (Objeto obj in this.Objetos.Values)
            {
                obj.Rotar(ejes, angle, c);
            }
        }
        public void LimpiarTransform()
        {
            foreach (Objeto obj in this.Objetos.Values)
            {
                obj.LimpiarTransform();
            }
        }

    }
}
