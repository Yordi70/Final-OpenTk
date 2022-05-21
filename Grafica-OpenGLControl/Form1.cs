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

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (escenario.LObjetos.Count != 0)
            {
                
                Dibujar_Check();
                miglControl.MakeCurrent();
                OnRenderFrame();
            }
            else
            {
                MessageBox.Show("Cargue los Datos", "Error");
            }
        }

        private void IngresarDatosToolStripMenuItem_Click(object sender, EventArgs e)
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
                    
                    string ruta_final = @"C:\Users\yordi\source\repos\Grafica-OpenGLControl\Grafica-OpenGLControl\bin\Debug\Objetos\" + guardar_objeto.SafeFileName;

                    File.Copy(str_RutaArchivo, ruta_final);
                    string fileName = guardar_objeto.SafeFileName;
                    int fileExtPos = fileName.LastIndexOf(".");
                    if (fileExtPos >= 0)
                    {
                        fileName = fileName.Substring(0, fileExtPos);
                    }

                    archivos.Add(fileName, false);

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
                    string fileName = file.Name; 
                    int fileExtPos = fileName.LastIndexOf("."); 
                    if (fileExtPos >= 0) {
                        fileName = fileName.Substring(0, fileExtPos);
                    }

                        archivos.Add(fileName, true);
                        string jsonString = File.ReadAllText("Objetos/" + file.Name); 
                        Objeto obj = JsonConvert.DeserializeObject<Objeto>(jsonString);
                        escenario.Add(fileName, obj);
                        
                }
            }
            else
            {
                foreach (var archivo in archivos.F_archivos)
                {
                    if (!archivos.Cargado(archivo.Key,"cargado"))
                    {
                        string jsonString = File.ReadAllText("Objetos/" + archivo.Key +".txt");
                        Objeto obj = JsonConvert.DeserializeObject<Objeto>(jsonString);
                        
                        escenario.Add(archivo.Key, obj);
                        archivos.Cargar(archivo.Key, "cargado");
                    }
                }
            }
        }

        public void CargarTreeView()
        {
            treeView1.Nodes.Clear();
            if (treeView1.Nodes.Count == 0) { 
                int index = 0;
                foreach (var o in archivos.F_archivos)
                {
                    treeView1.Nodes.Add(o.Key);

                    foreach (var tree in escenario.LObjetos[o.Key].LPartes)
                    {
                        treeView1.Nodes[index].Nodes.Add(tree.Key);

                    }
                    index++;
                }
            }

        }
        private void CargarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarDatos();
            CargarTreeView();
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        private void TreeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Checked == true && e.Node.Parent == null)
            {
                foreach (TreeNode tree in e.Node.Nodes)
                {
                    tree.Checked = true;
                }
            }
            else
            {
                foreach (TreeNode tree in e.Node.Nodes)
                {
                    tree.Checked = false;
                }
            }
           

        }
        public void Dibujar_Check()
        {
            int index = 0;
            foreach (TreeNode raiz in treeView1.Nodes)
            {
                
                    foreach (TreeNode hijo in treeView1.Nodes[index].Nodes)
                    {
                        if (hijo.Checked)
                        {
                            escenario.GetElemento(raiz.Text).GetElemento(hijo.Text).P_Visible = true;
                        }
                        else {
                            escenario.GetElemento(raiz.Text).GetElemento(hijo.Text).P_Visible = false;
                        }
                    }
                
                index++;
            }
        }
        

        
        private void Button2_Click(object sender, EventArgs e)
        {
            Punto ejes = new Punto((float)Rot_X.Value, (float)Rot_Y.Value, (float)Rot_Z.Value);
            

            int index = 0;
            foreach (TreeNode raiz in treeView1.Nodes)
            {
                if (raiz.Checked)
                {
                    
                    escenario.GetElemento(raiz.Text).Rotar(ejes,15f, escenario.GetElemento(raiz.Text).Centro_Masa);
                    
                    OnRenderFrame();

                }
                else
                {
                    foreach (TreeNode hijo in treeView1.Nodes[index].Nodes)
                    {
                        if (hijo.Checked)
                        {
                            escenario.GetElemento(raiz.Text).GetElemento(hijo.Text).Rotar(ejes, 15f, escenario.GetElemento(raiz.Text).Centro_Masa);
                            OnRenderFrame();
                            
                        }
                    }
                }

                index++;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            float x = (float)Tras_X.Value;
            float y = (float)Tras_Y.Value;
            float z = (float)Tras_Z.Value;
            int index = 0;
            foreach (TreeNode raiz in treeView1.Nodes)
            {
                if (raiz.Checked)
                {
                    escenario.GetElemento(raiz.Text).Trasladar(x, y, z);
                    
                    OnRenderFrame();
                }
                else
                {
                    foreach (TreeNode hijo in treeView1.Nodes[index].Nodes)
                    {
                        if (hijo.Checked)
                        {
                            escenario.GetElemento(raiz.Text).GetElemento(hijo.Text).Trasladar(x, y, z);
                            
                            OnRenderFrame();
                        }
                    }
                }

                index++;
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Tras_X.Value = 0;
            Tras_Y.Value = 0;
            Tras_Z.Value = 0;
            Rot_X.Value = 0;
            Rot_Y.Value = 0;
            Rot_Z.Value = 0;
            Esc_X.Value = 1;
            Esc_Y.Value = 1;
            Esc_Z.Value = 1;
        }

        

        private void Escalar_Click(object sender, EventArgs e)
        {
            float x = (float)Esc_X.Value;
            float y = (float)Esc_Y.Value;
            float z = (float)Esc_Z.Value;
            int index = 0;
            foreach (TreeNode raiz in treeView1.Nodes)
            {
                if (raiz.Checked)
                {
                    escenario.GetElemento(raiz.Text).Escalar(x, y, z);

                    OnRenderFrame();
                }
                else
                {
                    foreach (TreeNode hijo in treeView1.Nodes[index].Nodes)
                    {
                        if (hijo.Checked)
                        {
                            escenario.GetElemento(raiz.Text).GetElemento(hijo.Text).Escalar(x, y, z);

                            OnRenderFrame();
                        }
                    }
                }

                index++;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            escenario.LimpiarTransform();
        }

        
    }
}
