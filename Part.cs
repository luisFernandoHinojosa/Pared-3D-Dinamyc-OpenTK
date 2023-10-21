using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Object_3D
{
    public class Part
    {
        private List<Poligono> poligonos;
        public Part() 
        {
            poligonos = new List<Poligono>();
        }

        public void addPolygon(Poligono poligono)
        {
            poligonos.Add(poligono);
        }

        public void drawPolygons(Vector3 centro)
        {
            foreach (var poligono in poligonos)
            {
                poligono.draw(centro);
            }
        }

        public void RotateY(float angle)
        {
            foreach (var poligono in poligonos)
            {
                poligono.RotateY(angle);
            }
        }

        public void Scale(float scale)
        {
            foreach (var poligono in poligonos)
            {
                poligono.Scale(scale);
            }
        }

        public void Translate(Vector3 translation)
        {
            foreach (var poligono in poligonos)
            {
                poligono.Translate(translation);
            }
        }

    }
}
