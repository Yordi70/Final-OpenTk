using System;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System.Windows.Forms;
using OpenTK;
using Grafica_OpenGLControl.Class;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Grafica_OpenGLControl.extras;
namespace Grafica_OpenGLControl
{
    public partial class Form1 : Form

    {
        Escenario escenario;
        GLControl miglControl;
        private int _vertexBufferObject;
        private int _vertexArrayObject;
        Archivo archivos;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.miglControl = new GLControl
            {
                BackColor = System.Drawing.Color.Red,
                Location = new System.Drawing.Point(400, 37),
                Name = "miglControl",
                Size = new System.Drawing.Size(690, 560),
                TabIndex = 2,
                VSync = false
            };
            this.miglControl.Paint += new System.Windows.Forms.PaintEventHandler(this.GlControl1_Paint);
            this.miglControl.Resize += new System.EventHandler(this.GlControl1_Resize);
            this.miglControl.Load += new System.EventHandler(this.GlControl1_Load);
            this.panel1.Controls.Add(miglControl);
            archivos = new Archivo();
            escenario = new Escenario();

        }

        
        public Form1()
        {
            InitializeComponent();
        }

        private void GlControl1_Load(object sender, EventArgs e)
        {
            OnLoad();
        }
        private void GlControl1_Paint(object sender, PaintEventArgs e)
        {
            OnRenderFrame();
        }

        

        private void GlControl1_Resize(object sender, EventArgs e)
        {
            OnResize();
        }

        public void OnLoad()
        {
            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);
            _vertexBufferObject = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, _vertexBufferObject);

            _vertexArrayObject = GL.GenVertexArray();
            GL.BindVertexArray(_vertexArrayObject);

            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0);
            GL.EnableVertexAttribArray(0);

           


        }

        private void OnRenderFrame() {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            
            escenario.Dibujar();
            this.miglControl.SwapBuffers();
        }

       

        private void OnResize() {

            GL.Viewport(0, 0, miglControl.Width, miglControl.Height);
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            escenario.LObjetos["Casa5.txt"].Trasladar(0.0f, 0.0f, 0.5f);
            escenario.LObjetos["Casa5.txt"].Escalar(0.5f, 0.5f, 0.5f);
            escenario.LObjetos["Casa4.txt"].Escalar(0.5f, 0.5f, 0.5f);
            //escenario.LObjetos["Casa5.txt"].Rotar(45f, escenario.LObjetos["Casa5.txt"].Centro_Masa);
            escenario.LObjetos["Casa4.txt"].Rotar(20f, escenario.LObjetos["Casa5.txt"].Centro_Masa);
            escenario.LObjetos["Casa5.txt"].LPartes["Pfrontal"].Trasladar(0.5f, 0.5f, 0.5f);
            escenario.LObjetos["Casa5.txt"].LPartes["TIzq"].Trasladar(0.5f, 0.5f, 0.5f);
            OnRenderFrame();
        }

        private void ingresarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog guardar_objeto = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\yordi\Descargas",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,
                Title = "Guardar Objeto"
            };
            if (guardar_objeto.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string str_RutaArchivo = guardar_objeto.FileName;
                    string ruta_final = @"C:\Users\yordi\source\repos\Program-Grafica\Program-Grafica\bin\Debug\net5.0-windows\Objetos\" + guardar_objeto.SafeFileName;

                    File.Copy(str_RutaArchivo, ruta_final);
                    archivos.Add(guardar_objeto.FileName, false);

                }
                catch (Exception)
                {

                    MessageBox.Show($"Ya se encuentra el archivo {guardar_objeto.SafeFileName} en el directorio", "Error");
                }
            }
        }

        
        public void CargarDatos()
        {
            if(archivos.Count() == 0 ) { 
                DirectoryInfo _directory = new DirectoryInfo(@"Objetos");
                FileInfo[] files = _directory.GetFiles("*.txt");
                foreach (FileInfo file in files)
                {
                        archivos.Add(file.Name, true);
                        string jsonString = File.ReadAllText("Objetos/" + file.Name); 
                        Objeto obj = JsonConvert.DeserializeObject<Objeto>(jsonString);
                        escenario.Add(file.Name, obj);
                }
            }
            else
            {
                foreach (var archivo in archivos.F_archivos)
                {
                    if (!archivos.Cargado(archivo.Key,"cargado"))
                    {
                        string jsonString = File.ReadAllText("Objetos/" + archivo.Key);
                        Objeto obj = JsonConvert.DeserializeObject<Objeto>(jsonString);
                        escenario.Add(archivo.Key, obj);
                        archivos.Cargar(archivo.Key, "cargado");
                    }
                }
            }
        }

        private void cargarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
