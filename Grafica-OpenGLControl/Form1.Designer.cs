
using System;
using System.Windows.Forms;

namespace Grafica_OpenGLControl
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Esc_Z = new System.Windows.Forms.NumericUpDown();
            this.Esc_Y = new System.Windows.Forms.NumericUpDown();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Esc_X = new System.Windows.Forms.NumericUpDown();
            this.Tras_Z = new System.Windows.Forms.NumericUpDown();
            this.Tras_Y = new System.Windows.Forms.NumericUpDown();
            this.Trasladar = new System.Windows.Forms.Button();
            this.Escalar = new System.Windows.Forms.Button();
            this.Tras_X = new System.Windows.Forms.NumericUpDown();
            this.Rot_Z = new System.Windows.Forms.NumericUpDown();
            this.Rot_Y = new System.Windows.Forms.NumericUpDown();
            this.Rot_X = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Rotar = new System.Windows.Forms.Button();
            this.Dibujar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Esc_Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Esc_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Esc_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tras_Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tras_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tras_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rot_Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rot_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rot_X)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1467, 786);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.Esc_Z);
            this.groupBox2.Controls.Add(this.Esc_Y);
            this.groupBox2.Controls.Add(this.treeView1);
            this.groupBox2.Controls.Add(this.Esc_X);
            this.groupBox2.Controls.Add(this.Tras_Z);
            this.groupBox2.Controls.Add(this.Tras_Y);
            this.groupBox2.Controls.Add(this.Trasladar);
            this.groupBox2.Controls.Add(this.Escalar);
            this.groupBox2.Controls.Add(this.Tras_X);
            this.groupBox2.Controls.Add(this.Rot_Z);
            this.groupBox2.Controls.Add(this.Rot_Y);
            this.groupBox2.Controls.Add(this.Rot_X);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Rotar);
            this.groupBox2.Controls.Add(this.Dibujar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(23, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 694);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Objeto";
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.OliveDrab;
            this.button3.Location = new System.Drawing.Point(107, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 44);
            this.button3.TabIndex = 20;
            this.button3.Text = "Reset Transform";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.OliveDrab;
            this.button1.Location = new System.Drawing.Point(233, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 44);
            this.button1.TabIndex = 18;
            this.button1.Text = "Reset Valores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Esc_Z
            // 
            this.Esc_Z.DecimalPlaces = 2;
            this.Esc_Z.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.Esc_Z.Location = new System.Drawing.Point(268, 272);
            this.Esc_Z.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Esc_Z.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.Esc_Z.Name = "Esc_Z";
            this.Esc_Z.Size = new System.Drawing.Size(105, 23);
            this.Esc_Z.TabIndex = 17;
            this.Esc_Z.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // Esc_Y
            // 
            this.Esc_Y.DecimalPlaces = 2;
            this.Esc_Y.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.Esc_Y.Location = new System.Drawing.Point(138, 272);
            this.Esc_Y.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Esc_Y.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.Esc_Y.Name = "Esc_Y";
            this.Esc_Y.Size = new System.Drawing.Size(105, 23);
            this.Esc_Y.TabIndex = 16;
            this.Esc_Y.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.treeView1.CheckBoxes = true;
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(21, 24);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(341, 144);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterCheck);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // Esc_X
            // 
            this.Esc_X.DecimalPlaces = 2;
            this.Esc_X.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.Esc_X.Location = new System.Drawing.Point(8, 272);
            this.Esc_X.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Esc_X.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.Esc_X.Name = "Esc_X";
            this.Esc_X.Size = new System.Drawing.Size(105, 23);
            this.Esc_X.TabIndex = 15;
            this.Esc_X.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // Tras_Z
            // 
            this.Tras_Z.DecimalPlaces = 2;
            this.Tras_Z.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.Tras_Z.Location = new System.Drawing.Point(268, 236);
            this.Tras_Z.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Tras_Z.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Tras_Z.Name = "Tras_Z";
            this.Tras_Z.Size = new System.Drawing.Size(105, 23);
            this.Tras_Z.TabIndex = 14;
            // 
            // Tras_Y
            // 
            this.Tras_Y.DecimalPlaces = 2;
            this.Tras_Y.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.Tras_Y.Location = new System.Drawing.Point(138, 236);
            this.Tras_Y.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Tras_Y.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Tras_Y.Name = "Tras_Y";
            this.Tras_Y.Size = new System.Drawing.Size(105, 23);
            this.Tras_Y.TabIndex = 13;
            // 
            // Trasladar
            // 
            this.Trasladar.ForeColor = System.Drawing.Color.OliveDrab;
            this.Trasladar.Location = new System.Drawing.Point(389, 231);
            this.Trasladar.Name = "Trasladar";
            this.Trasladar.Size = new System.Drawing.Size(98, 30);
            this.Trasladar.TabIndex = 12;
            this.Trasladar.Text = "Trasladar";
            this.Trasladar.UseVisualStyleBackColor = true;
            this.Trasladar.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Escalar
            // 
            this.Escalar.ForeColor = System.Drawing.Color.OliveDrab;
            this.Escalar.Location = new System.Drawing.Point(389, 267);
            this.Escalar.Name = "Escalar";
            this.Escalar.Size = new System.Drawing.Size(98, 30);
            this.Escalar.TabIndex = 11;
            this.Escalar.Text = "Escalar";
            this.Escalar.UseVisualStyleBackColor = true;
            this.Escalar.Click += new System.EventHandler(this.Escalar_Click);
            // 
            // Tras_X
            // 
            this.Tras_X.DecimalPlaces = 2;
            this.Tras_X.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.Tras_X.Location = new System.Drawing.Point(8, 236);
            this.Tras_X.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Tras_X.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Tras_X.Name = "Tras_X";
            this.Tras_X.Size = new System.Drawing.Size(107, 23);
            this.Tras_X.TabIndex = 10;
            // 
            // Rot_Z
            // 
            this.Rot_Z.DecimalPlaces = 2;
            this.Rot_Z.Location = new System.Drawing.Point(268, 201);
            this.Rot_Z.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Rot_Z.Name = "Rot_Z";
            this.Rot_Z.Size = new System.Drawing.Size(105, 23);
            this.Rot_Z.TabIndex = 9;
            // 
            // Rot_Y
            // 
            this.Rot_Y.DecimalPlaces = 2;
            this.Rot_Y.Location = new System.Drawing.Point(138, 201);
            this.Rot_Y.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Rot_Y.Name = "Rot_Y";
            this.Rot_Y.Size = new System.Drawing.Size(105, 23);
            this.Rot_Y.TabIndex = 8;
            // 
            // Rot_X
            // 
            this.Rot_X.DecimalPlaces = 2;
            this.Rot_X.Location = new System.Drawing.Point(6, 201);
            this.Rot_X.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Rot_X.Name = "Rot_X";
            this.Rot_X.Size = new System.Drawing.Size(107, 23);
            this.Rot_X.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.OliveDrab;
            this.label3.Location = new System.Drawing.Point(147, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Posición Y";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.OliveDrab;
            this.label2.Location = new System.Drawing.Point(278, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Posición Z";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(18, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Posición X";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Rotar
            // 
            this.Rotar.ForeColor = System.Drawing.Color.OliveDrab;
            this.Rotar.Location = new System.Drawing.Point(389, 196);
            this.Rotar.Name = "Rotar";
            this.Rotar.Size = new System.Drawing.Size(98, 30);
            this.Rotar.TabIndex = 2;
            this.Rotar.Text = "Rotar";
            this.Rotar.UseVisualStyleBackColor = true;
            this.Rotar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Dibujar
            // 
            this.Dibujar.ForeColor = System.Drawing.Color.OliveDrab;
            this.Dibujar.Location = new System.Drawing.Point(407, 68);
            this.Dibujar.Name = "Dibujar";
            this.Dibujar.Size = new System.Drawing.Size(80, 43);
            this.Dibujar.TabIndex = 1;
            this.Dibujar.Text = "Dibujar";
            this.Dibujar.UseVisualStyleBackColor = true;
            this.Dibujar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1467, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarDatosToolStripMenuItem,
            this.ingresarDatosToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarDatosToolStripMenuItem
            // 
            this.cargarDatosToolStripMenuItem.Name = "cargarDatosToolStripMenuItem";
            this.cargarDatosToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.cargarDatosToolStripMenuItem.Text = "Cargar Datos";
            this.cargarDatosToolStripMenuItem.Click += new System.EventHandler(this.CargarDatosToolStripMenuItem_Click);
            // 
            // ingresarDatosToolStripMenuItem
            // 
            this.ingresarDatosToolStripMenuItem.Name = "ingresarDatosToolStripMenuItem";
            this.ingresarDatosToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.ingresarDatosToolStripMenuItem.Text = "Nuevo Datos";
            this.ingresarDatosToolStripMenuItem.Click += new System.EventHandler(this.IngresarDatosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 777);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Esc_Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Esc_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Esc_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tras_Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tras_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tras_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rot_Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rot_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rot_X)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

      



        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Dibujar;
        private System.Windows.Forms.Button Rotar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Rot_Y;
        private System.Windows.Forms.NumericUpDown Rot_X;
        private System.Windows.Forms.NumericUpDown Rot_Z;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarDatosToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown Esc_Z;
        private System.Windows.Forms.NumericUpDown Esc_Y;
        private System.Windows.Forms.NumericUpDown Esc_X;
        private System.Windows.Forms.NumericUpDown Tras_Z;
        private System.Windows.Forms.NumericUpDown Tras_Y;
        private System.Windows.Forms.Button Trasladar;
        private System.Windows.Forms.Button Escalar;
        private System.Windows.Forms.NumericUpDown Tras_X;
        private System.Windows.Forms.TreeView treeView1;
        private Button button1;
        private Button button3;
    }
}

