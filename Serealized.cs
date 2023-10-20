using OpenTK;
using System;
using System.Collections.Generic;
using System.IO;

namespace Dynamic_Object_3D
{
    public class Serealized
    {
        
        public void writeVertices(List<Vector3> vertices, string nameFile)
        {           
                using (StreamWriter writer = new StreamWriter(nameFile))
                {
                    foreach (Vector3 vertex in vertices)
                    {
                        writer.WriteLine($"{vertex.X}, {vertex.Y}, {vertex.Z}");
                    }
                }              
        }


        public List<Vector3> readVertices(string nameFile)
        {
            List<Vector3> vertices = new List<Vector3>();
            
                using (StreamReader reader = new StreamReader(nameFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(',');
                        if (values.Length >= 3)
                        {
                            float x = float.Parse(values[0]);
                            float y = float.Parse(values[1]);
                            float z = float.Parse(values[2]);
                            vertices.Add(new Vector3(x, y, z));
                        }
                    }
                }
               
            return vertices;
        }

        /*public Object  readObject(Object objeto, string nameObject)
        {
            objeto.FirstName = "Jeff";

        }*/
    }
}
