using Grafica_OpenGLControl.Class;

namespace Grafica_OpenGLControl.Interface
{
    interface IDibujable
    {
        void Dibujar();
        void Escalar(float x, float y, float z);
        void Trasladar(float x, float y, float z);
        void Rotar(float angle, Punto c);
    }
}
