using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Dynamic_Object_3D
{
    [Serializable]
    public class Poligono : ISerializable
    {
        public List<Points> Vertices;
        public Color4 color;
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Serializa cada vértice individualmente
            for (int i = 0; i < Vertices.Count; i++)
            {
                info.AddValue($"Vertex_{i}", Vertices[i]);
            }

            // También serializa el color
            info.AddValue("Color", color);
        }

        public Poligono(SerializationInfo info, StreamingContext context)
        {
            // Deserializa cada vértice individualmente
            Vertices = new List<Points>();
            int i = 0;
            try
            {
                while (true)
                {
                    Points vertex = (Points)info.GetValue($"Vertex_{i}", typeof(Points));
                    Vertices.Add(vertex);
                    i++;
                }
            }
            catch (SerializationException)
            {
                // Cuando se lanza esta excepción, significa que no hay más vértices
            }

            // También deserializa el color
            color = (Color4)info.GetValue("Color", typeof(Color4));
        }

        public Poligono(List<Points> vertices, Color4 color)
        {
            this.Vertices = vertices;
            this.color = color;
        }

        public void draw(Points centro)
        {
            GL.PushMatrix();
            GL.Translate(new Vector3(centro.x, centro.y, centro.z));

            GL.Begin(PrimitiveType.Quads);
            GL.Color4(color: color);

            foreach (var vertice in Vertices) 
            {
                GL.Vertex3(new Vector3(vertice.x, vertice.y, vertice.z));
            }

            GL.End();
            GL.PopMatrix();
        }

        public void Rotate(float angle)
        {
            for (int i = 0; i < Vertices.Count; i++)
            {
                Vertices[i] = RotateVertexY(Vertices[i], angle);
            }
        }

        public void RotateZ(float angle)
        {
            for (int i = 0; i < Vertices.Count; i++)
            {
                Vertices[i] = RotateVertexZ(Vertices[i], angle);
            }
        }

        public void Scale(float scale)
        {
            for (int i = 0; i < Vertices.Count; i++)
            {
                //Vertices[i] *= 1.0f / scaleFactor; //disminuye
                Vertices[i].x *= scale;
                Vertices[i].y *= scale;
                Vertices[i].z *= scale;
            }
        }

        public void Translate(Points translation)
        {
            for (int i = 0; i < Vertices.Count; i++)
            {
                Vertices[i].x += translation.x;
                Vertices[i].y += translation.y;
                Vertices[i].z += translation.z;
            }
        }

        private Points RotateVertexY(Points vertex, float angle)
        {
            float cosA = (float)Math.Cos(angle);
            float sinA = (float)Math.Sin(angle);
            float x = vertex.x * cosA - vertex.z * sinA;
            float z = vertex.x * sinA + vertex.z * cosA;
            return new Points(x, vertex.y, z);
        }

        private Points RotateVertexX(Points vertex, float angle)
        {
            float cosA = (float)Math.Cos(angle);
            float sinA = (float)Math.Sin(angle);
            float y = vertex.y * cosA - vertex.z * sinA;
            float z = vertex.y * sinA + vertex.z * cosA;
            return new Points(vertex.x, y, z);
        }

        private Points RotateVertexZ(Points vertex, float angle)
        {
            float cosA = (float)Math.Cos(angle);
            float sinA = (float)Math.Sin(angle);
            float y = vertex.y* cosA - vertex.z * sinA;
            float x = vertex.x * sinA + vertex.z * cosA;
            return new Points(x, y, vertex.z);
        }

        public void RotateXPart(float angle, Points center)
        {
            for (int i = 0; i < Vertices.Count; i++)
            {
                // Translate the vertex to the local coordinate system
                Vertices[i] = new Points(
                    Vertices[i].x - center.x,
                    Vertices[i].y - center.y,
                    Vertices[i].z - center.z
                );

                // Rotate around the local origin
                Vertices[i] = RotateVertexX(Vertices[i], angle);

                // Translate back to the original coordinate system
                Vertices[i] = new Points(
                    Vertices[i].x + center.x,
                    Vertices[i].y + center.y,
                    Vertices[i].z + center.z
                );
            }
        }
    }
}
