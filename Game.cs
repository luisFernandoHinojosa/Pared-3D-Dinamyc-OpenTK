using OpenTK;///
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics;///
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
///

namespace Dynamic_Object_3D
{
    public class Game:GameWindow
    {
        private float angle = 0.0f;
        private Scenery scenary = new Scenery();
        public bool isRotating = false;
        public bool isScaling = false;
        public bool isTranslating = false;
        public bool isTraslatingCar = false;
        Objecto objCar;


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
            if (isRotating)
            {
                foreach (var obj in scenary.objetos)
                {
                    obj.Rotate((float)e.Time);
                }
            }
            else if (isScaling)
                foreach (var obj in scenary.objetos)
                {
                    obj.Scale(1.01f);
                }
            else if (isTranslating)
            {
                foreach (var obj in scenary.objetos)
                {
                    Points translation = new Points(-0.1f, 0.0f, 0.0f); // Mueve en el eje X
                    obj.Translate(translation);
                }
            }

            //angle += (float)e.Time * 40.0f;

            if (isTraslatingCar)
            {
                objCar = scenary.selecterObject(2);
                Points translation = new Points(0.1f, 0.0f, 0.0f); // Mueve en el eje X
                objCar.Translate(translation);
               // objCar.RotateRuedas((float)e.Time);
                //scenary.Update((float)e.Time);
                //scenary.poli.Rotate(MathHelper.DegreesToRadians(45.0f));
                int partIdToSelect1 = 1; // El identificador de la parte que deseas seleccionar
                objCar.SelectPart(partIdToSelect1);
                objCar.RotateSelectedPart((float)e.Time);

                /*int partIdToSelect2 = 2; // El identificador de la parte que deseas seleccionar
                objCar.SelectPart(partIdToSelect2);
                objCar.RotateSelectedPart((float)e.Time);

                int partIdToSelect3 = 3; // El identificador de la parte que deseas seleccionar
                objCar.SelectPart(partIdToSelect3);
                objCar.RotateSelectedPart((float)e.Time);

                int partIdToSelect4 = 4; // El identificador de la parte que deseas seleccionar
                objCar.SelectPart(partIdToSelect4);
                objCar.RotateSelectedPart((float)e.Time);*/
            }

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

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            switch (e.KeyChar)
            {
                case '1':
                    isRotating = true;
                    isScaling = false;
                    isTranslating = false;
                    break;
                case '2':
                    isRotating = false;
                    isScaling = true;
                    isTranslating = false;
                    break;
                case '3':
                    isRotating = false;
                    isScaling = false;
                    isTranslating = true;
                    break;
                case ' ':
                    //isRotating = !isRotating;
                    isScaling = !isScaling;
                    //isTranslating = !isTranslating;
                    break;
            }
        }




    }
}
