using OpenTK;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
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

        public static void SerializarObjeto<T>(T obj, string fileName)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static T DeserializarObjeto<T>(string fileName)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<T>(json);
            }

            return default(T);
        }

    }
}
