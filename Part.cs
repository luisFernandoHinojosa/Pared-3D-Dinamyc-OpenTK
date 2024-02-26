using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Object_3D
{
    [Serializable]
    public class Part : ISerializable
    {
       
        private List<Poligono> poligonos;
        public int id { get; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Serializa cada polígono individualmente
            for (int i = 0; i < poligonos.Count; i++)
            {
                info.AddValue($"Poligono_{i}", poligonos[i]);
            }
        }

        public Part(SerializationInfo info, StreamingContext context)
        {
            // Deserializa cada polígono individualmente
            poligonos = new List<Poligono>();
            int i = 0;
            try
            {
                while (true)
                {
                    Poligono poligono = (Poligono)info.GetValue($"Poligono_{i}", typeof(Poligono));
                    poligonos.Add(poligono);
                    i++;
                }
            }
            catch (SerializationException)
            {
                // Cuando se lanza esta excepción, significa que no hay más polígonos
            }
        }

        public Part(int id =0) 
        {
            this.id = id;
            poligonos = new List<Poligono>();
        }

        public void addPolygon(Poligono poligono)
        {
            poligonos.Add(poligono);
        }

        public void drawPolygons(Points centro)
        {
            foreach (var poligono in poligonos)
            {
                poligono.draw(centro);
            }
        }

        public void Rotate(float angle)
        {
            foreach (var poligono in poligonos)
            {
                poligono.Rotate(angle);
            }
        }

        public void Scale(float scale)
        {
            foreach (var poligono in poligonos)
            {
                poligono.Scale(scale);
            }
        }

        public void Translate(Points translation)
        {
            foreach (var poligono in poligonos)
            {
                poligono.Translate(translation);
            }
        }

        public void RotateXPart(float angle, Points centro)
        {
            foreach (var poligono in poligonos)
            {
                poligono.RotateXPart(angle, centro);
            }
        }

    }
}
