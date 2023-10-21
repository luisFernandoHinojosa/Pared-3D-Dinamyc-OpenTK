using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
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

        public void draw(Vector3 centro)
        {
            GL.PushMatrix();
            GL.Translate(centro + new Vector3(0.1f, -0.5f, -1.7f));

            GL.Begin(PrimitiveType.Quads);
            GL.Color4(color: color);

            foreach (var vertice in Vertices) 
            {
                GL.Vertex3(vertice);
            }

            GL.End();
            GL.PopMatrix();
        }

        public void RotateY(float angle)
        {
            for (int i = 0; i < Vertices.Count; i++)
            {
                Vertices[i] = RotateVertexY(Vertices[i], angle);
            }
        }

        public void Scale(float scaleFactor)
        {
            for (int i = 0; i < Vertices.Count; i++)
            {
                //Vertices[i] *= 1.0f / scaleFactor;
                Vertices[i] *= scaleFactor;
            }
        }

        public void Translate(Vector3 translation)
        {
            for (int i = 0; i < Vertices.Count; i++)
            {
                Vertices[i] += translation;
            }
        }

        private Vector3 RotateVertexY(Vector3 vertex, float angle)
        {
            float cosA = (float)Math.Cos(angle);
            float sinA = (float)Math.Sin(angle);
            float x = vertex.X * cosA - vertex.Z * sinA;
            float z = vertex.X * sinA + vertex.Z * cosA;
            return new Vector3(x, vertex.Y, z);
        }

        private Vector3 RotateVertexX(Vector3 vertex, float angle)
        {
            float cosA = (float)Math.Cos(angle);
            float sinA = (float)Math.Sin(angle);
            float y = vertex.Y * cosA - vertex.Z * sinA;
            float z = vertex.Y * sinA + vertex.Z * cosA;
            return new Vector3(vertex.X, y, z);
        }
    }
}
