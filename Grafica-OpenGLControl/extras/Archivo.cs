using System.IO;
using System.Collections.Generic;
namespace Grafica_OpenGLControl.extras
{
    class Archivo
    {
        private Dictionary<string ,Dictionary<string, bool>> Archivos { get; set; }

        //propiedades
        public Dictionary<string, Dictionary<string, bool>> F_archivos { get { return Archivos; } set { Archivos = value; } }
        public Archivo()
        {
            this.Archivos = new Dictionary<string, Dictionary<string, bool>> { };
        }


        public bool Cargado(string file, string key)
        {
            return this.Archivos[file][key];
        }
        public void Cargar(string file,string key)
        {
            this.Archivos[file][key] = true;
        }
        public void Add(string file, bool key)
        {
            var value = new Dictionary<string, bool> { };
            value.Add("cargado", key);
            this.Archivos.Add(file, value);
        }
        public int Count()
        {
            return this.Archivos.Count;
        }
        public Dictionary<string, bool> GetElemento(string key)
        {
            return this.Archivos[key];
        }
    }
}
