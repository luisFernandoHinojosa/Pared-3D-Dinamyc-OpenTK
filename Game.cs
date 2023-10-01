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
        private Objecto pared = new Objecto();
        private Objecto repisa = new Objecto();
        private Objecto Auto = new Objecto();


        //List<Vector3> vertices = new List<Vector3>();
        //private List<Poligono> poligonos = new List<Poligono>();

        public Game(int width, int height) : base(width, height, GraphicsMode.Default, "Game")
        {
            List<Vector3> vertices = new List<Vector3>
            {
                new Vector3(-2.0f, -2.0f, 0.0f),
                new Vector3(2.0f, -2.0f, 0.0f),
                new Vector3(2.0f, 2.0f, 0.0f),
                new Vector3(-2.0f, 2.0f, 0.0f),

                new Vector3(-2.0f, -2.0f, 0.30f),
                new Vector3(2.0f, -2.0f, 0.30f),
                new Vector3(2.0f, 2.0f, 0.30f),
                new Vector3(-2.0f, 2.0f, 0.30f),
                
                // Cara superior 
                new Vector3(-2.0f, 2.0f, 0.30f),
                new Vector3(2.0f, 2.0f, 0.30f),
                new Vector3(2.0f, 2.0f, 0.0f),
                new Vector3(-2.0f, 2.0f, 0.0f),

                // Cara inferior
                new Vector3(-2.0f, -2.0f, 0.0f),
                new Vector3(2.0f, -2.0f, 0.0f),
                new Vector3(2.0f, -2.0f, 0.30f),
                new Vector3(-2.0f, -2.0f, 0.30f),

                // Cara izquierda
                new Vector3(-2.0f, -2.0f, 0.0f),
                new Vector3(-2.0f, 2.0f, 0.0f),
                new Vector3(-2.0f, 2.0f, 0.30f),
                new Vector3(-2.0f, -2.0f, 0.30f),

                // Cara derecha 
                new Vector3(2.0f, -2.0f, 0.30f),
                new Vector3(2.0f, 2.0f, 0.30f),
                new Vector3(2.0f, 2.0f, 0.0f),
                new Vector3(2.0f, -2.0f, 0.0f),
             };

            List<Vector3> vertices2 = new List<Vector3>
            {
                new Vector3(-2.0f, .8f, 0.90f),
new Vector3(2.0f, .8f, 0.90f),
new Vector3(2.0f, .112f, 0.90f),
new Vector3(-2.0f, .112f, 0.90f),

new Vector3(-2.0f, .8f, 0.30f),
new Vector3(2.0f, .8f, 0.30f),
new Vector3(2.0f, .112f, 0.30f),
new Vector3(-2.0f, .112f, 0.30f),

// Cara superior 
new Vector3(-2.0f, .112f, 0.90f),
new Vector3(2.0f, .112f, 0.90f),
new Vector3(2.0f, .112f, 0.90f),
new Vector3(-2.0f, .112f, 0.90f),

// Cara inferior
new Vector3(-2.0f, .8f, 0.90f),
new Vector3(2.0f, .8f, 0.90f),
new Vector3(2.0f, .8f, 0.30f),
new Vector3(-2.0f, .8f, 0.30f),

// Cara izquierda
new Vector3(-2.0f, .8f, 0.90f),
new Vector3(-2.0f, .112f, 0.90f),
new Vector3(-2.0f, .112f, 0.30f),
new Vector3(-2.0f, .8f, 0.30f),

// Cara derecha 
new Vector3(2.0f, .8f, 0.30f),
new Vector3(2.0f, .112f, 0.30f),
new Vector3(2.0f, .112f, 0.90f),
new Vector3(2.0f, .8f, 0.90f),

            };

            

            

            //dibujo de la pared
            Poligono paredPart = new Poligono(vertices, new Color4(0.5f, 0.0f, 0.0f, 1.0f));
            Part partPared = new Part();
            partPared.addPolygon(paredPart);
            pared.addParts(partPared);

            //dibujo de la repisa
            Poligono repisaPart = new Poligono(vertices2, new Color4(0.4f, 0.2f, 0.0f, 1.0f));
            Part partRepisa = new Part();
            partRepisa.addPolygon(repisaPart);
            repisa.addParts(partRepisa);

           

          





        }


        protected override void OnLoad(EventArgs e)
        {   
            //aqui duardar el archivo
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


            //configuracion de la camara

            Matrix4 modelview = Matrix4.LookAt(
                new Vector3(0.0f, 1, 6.0f), //0.0f, .8f, 6.0f
                new Vector3(0.0f, 0.0f, 0.0f), //0.0f, 0.0f, 0.0f
                Vector3.UnitY);
            GL.LoadMatrix(ref modelview);

            //aplica una rotacion al dibujo
            GL.Rotate(angle, Vector3.UnitY);

            pared.drawParts();
            repisa.drawParts();
            //Auto.drawParts();


            GL.End();
            SwapBuffers();

        }




    }
}
