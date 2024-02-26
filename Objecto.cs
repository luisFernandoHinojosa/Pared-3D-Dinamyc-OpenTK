using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace Dynamic_Object_3D
{
    [Serializable]
    public class Objecto : ISerializable
    {
        private List<Part> partes;
        private Points centro;
        public Scenery scenary = new Scenery();
        private Part selectedPart;
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Serializa el centro
            info.AddValue("Centro", centro);

            // Serializa cada parte individualmente
            for (int i = 0; i < partes.Count; i++)
            {
                info.AddValue($"Part_{i}", partes[i]);
            }
        }

        // Constructor de deserialización
        protected Objecto(SerializationInfo info, StreamingContext context)
        {
            // Deserializa el centro
            centro = (Points)info.GetValue("Centro", typeof(Points));

            // Deserializa cada parte individualmente
            partes = new List<Part>();
            int i = 0;
            try
            {
                while (true)
                {
                    Part part = (Part)info.GetValue($"Part_{i}", typeof(Part));
                    partes.Add(part);
                    i++;
                }
            }
            catch (SerializationException)
            {
                // Cuando se lanza esta excepción, significa que no hay más partes
            }
        }


        public Objecto(Points centro) 
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

        public void Rotate(float angle)
        {
            foreach (var part in partes)
            {
                part.Rotate(angle);
            }
        }

        public void Scale(float scale)
        {
            foreach (var part in partes)
            {
                part.Scale(scale); 
            }
        }

        public void Translate(Points translation)
        {
            centro.x += translation.x;
            centro.y += translation.y;
            centro.z += translation.z;
            foreach (var part in partes)
            {
                part.Translate(translation);
            }
        }

        public void RotateRuedas(float angle = 45.0f)
        {
            Part ruedasPart = scenary.autoPartCuerpo;
            Console.WriteLine("Rotando ruedas. Ángulo: " + angle);
            ruedasPart?.Rotate(angle);
        }

        public void SelectPart(int partId)
        {
            selectedPart = partes.FirstOrDefault(part => part.id == partId);
        
        }

        public void RotateSelectedPart(float angle)
        {
            if (selectedPart != null)
            {
                selectedPart.RotateXPart(angle, centro);
            }
        }

        public void ScaleSelectedPart(float scale)
        {
            if (selectedPart != null)
            {
                selectedPart.Scale(scale);
            }
        }

        public void TranslateSelectedPart(Points translation)
        {
            if (selectedPart != null)
            {
                selectedPart.Translate(translation);
            }
        }


    }
}
