using OpenTK;///
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics;///
using OpenTK.Graphics.OpenGL;///

namespace Dynamic_Object_3D
{
    public class Game:GameWindow
    {
        private float angle = 0.0f;
        private Scenery scenary = new Scenery();

        public Game(int width, int height) : base(width, height, GraphicsMode.Default, "Game"){}
        protected override void OnLoad(EventArgs e)
        {
            //aqui duardar el archivo
            scenary.loadObjects();

            base.OnLoad(e);
            GL.Enable(EnableCap.DepthTest);
            GL.ClearColor(0.1f, 0.12f, 0.13f, 0.1f);
        }

        protected override void OnResize(EventArgs e) 
        {
            base.OnResize(e);   

            GL.Viewport(0, 0, Width, Height);
            float aspectRatio = (float)Width / Height;
            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(
                MathHelper.DegreesToRadians(45.0f), aspectRatio, 0.1f, 100.0f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            angle += (float)e.Time * 20.0f;

        }
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            Matrix4 modelview = Matrix4.LookAt(
                new Vector3(0.0f, 1, 6.0f), //0.0f, .8f, 6.0f
                new Vector3(0.0f, 0.0f, 0.0f), //0.0f, 0.0f, 0.0f
                Vector3.UnitY);
            GL.LoadMatrix(ref modelview);
            GL.Rotate(angle, Vector3.UnitY);
            
            scenary.drawObjects();

            GL.End();
            SwapBuffers();

        }




    }
}
