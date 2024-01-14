//Joroveanu Alexandra
//3131A
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics.ES20;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using OpenTK.Platform;

using ClearBufferMask = OpenTK.Graphics.OpenGL.ClearBufferMask;
using GL = OpenTK.Graphics.OpenGL.GL;
using MatrixMode = OpenTK.Graphics.OpenGL.MatrixMode;
using PrimitiveType = OpenTK.Graphics.OpenGL.PrimitiveType;

namespace OpenTK_console_sample01
{
    class SimpleWindow : GameWindow
    {
        private object gm;


        // Constructor.
        public SimpleWindow() : base(800, 600)
        {
            KeyDown += Keyboard_KeyDown;
        }

        // Tratează evenimentul generat de apăsarea unei taste. Mecanismul standard oferit de .NET este cel utilizat.
        // Tema 1- Exercitiul 2
        void Keyboard_KeyDown(object sender, KeyboardKeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                this.Exit();
            //la apasarea butonului A imaginea se va deplasa cu 100 de pixeli mai sus si spre dreapta
            else if(e.Key ==Key.A)
            {
                base.OnResize(e);
                GL.Viewport(100,100,Width,Height);
            }
            //la apasarea butonului Q imaginea se va deplasa cu 200 de pixeli mai sus, la dreapta fata de pozitia initiala
            else if (e.Key == Key.Q)
            {
                base.OnResize(e);
                GL.Viewport(200, 200, Width, Height);
            }

            /*else if (mouse[MouseButton.Right])
            {
                base.OnResize(e);
                GL.Viewport(0, 0, Width, Height);
            }*/
            else
            {
                base.OnResize(e);
                GL.Viewport(100, 100, Width, Height);
            }
            if (e.Key == Key.F11)
                if (this.WindowState == WindowState.Fullscreen)
                    this.WindowState = WindowState.Normal;
                else
                    this.WindowState = WindowState.Fullscreen;
        }

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(Color.MidnightBlue);
        }

        // Inițierea afișării și setarea viewport-ului grafic. Metoda este invocată la redimensionarea
        // ferestrei. Va fi invocată o dată și imediat după metoda ONLOAD!
        // Viewport-ul va fi dimensionat conform mărimii ferestrei active (cele 2 obiecte pot avea și mărimi 
        // diferite). 
        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            //tema 1- exercitiul 1
            GL.MatrixMode(MatrixMode.Texture);
            GL.LoadIdentity();
            GL.Ortho(-1.0, 1.0, -1.0, 1.0, 0.0, 4.0);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            // Momentan aplicația nu face nimic!
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            GL.Begin(PrimitiveType.Triangles);

            GL.Color3(Color.MidnightBlue);
            GL.Vertex2(-1.0f, 1.0f);
            GL.Color3(Color.SpringGreen);
            GL.Vertex2(0.0f, -1.0f);
            GL.Color3(Color.Ivory);
            GL.Vertex2(1.0f, 1.0f);

            GL.End();

            this.SwapBuffers();
        }

        [STAThread]
        static void Main(string[] args)
        {

           
            using (SimpleWindow example = new SimpleWindow())
            {

                example.Run(30.0, 0.0);
            }
        }
    }
}
