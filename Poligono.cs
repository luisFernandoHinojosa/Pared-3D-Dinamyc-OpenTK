using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System.Collections.Generic;

namespace Dynamic_Object_3D
{
    public class Poligono
    {
        public List<Vector3> Vertices;
        public Color4 color;

        public Poligono(List<Vector3> vertices, Color4 color)
        {
            this.Vertices = vertices;
            this.color = color;
        }

        public void draw()
        {
            //GL.PushMatrix();
            GL.Begin(PrimitiveType.Quads);
            GL.Color4(color: color);

            foreach (var vertice in Vertices) 
            {
                GL.Vertex3(vertice);
            }

            GL.End();
            //////crncjfrfrftr
        }
    }
}
