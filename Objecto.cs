using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Object_3D
{
    public class Objecto
    {
        private List<Part> partes;

        public Objecto() 
        {
            partes = new List<Part>();
        }

        public void addParts(Part part)
        {
            partes.Add(part);
        }

        public void drawParts()
        {
            foreach (var part in partes) 
            {   
                part.drawPolygons();
            }
        }
    }
}
