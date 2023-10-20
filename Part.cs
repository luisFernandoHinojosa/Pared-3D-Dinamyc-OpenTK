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
        //adicionar centrpo
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
     }
}
