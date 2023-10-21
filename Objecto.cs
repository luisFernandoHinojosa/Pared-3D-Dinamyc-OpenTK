using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Dynamic_Object_3D
{
    public class Objecto
    {
        private List<Part> partes;
        private Vector3 centro;
   

        public Objecto(Vector3 centro) 
        {
            partes = new List<Part>();
            this.centro = centro;
    
        }

        public void addParts(Part part)
        {
            partes.Add(part);
        }

        public void drawParts()
        {
            foreach (var part in partes) 
            {   
                part.drawPolygons(centro);
            }
        }

        public void RotateY(float angle)
        {
            foreach (var part in partes)
            {
                part.RotateY(angle);
            }
        }

        public void Scale(float scale)
        {
            foreach (var part in partes)
            {
                part.Scale(scale); 
            }
        }

        public void Translate(Vector3 translation)
        {
            centro += translation;
            foreach (var part in partes)
            {
                part.Translate(translation);
            }
        }

    }
}
