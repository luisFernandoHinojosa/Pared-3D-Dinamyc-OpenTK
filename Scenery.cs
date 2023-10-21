using OpenTK;
using OpenTK.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Object_3D
{
    public class Scenery
    {
        private Objecto pared;
        private Objecto repisa;
        private Objecto auto;
        private Serealized serealized = new Serealized();
        public List<Objecto> objetos = new List<Objecto>();

        List<Vector3> verticesPared = new List<Vector3>();
        List<Vector3> verticesRepisa = new List<Vector3>();
        List<Vector3> verticesAutoChasis = new List<Vector3>();
        List<Vector3> verticesAutoArriba = new List<Vector3>();
        List<Vector3> verticesAutoRuedas = new List<Vector3>();
        List<Vector3> verticesAutoEspejos = new List<Vector3>();

        public void loadObjects()
        {
            verticesPared = serealized.readVertices("pared.txt");
            verticesRepisa = serealized.readVertices("repisa.txt");
            verticesAutoChasis = serealized.readVertices("autoChasis.txt");
            verticesAutoArriba = serealized.readVertices("autoArriba.txt");
            verticesAutoRuedas = serealized.readVertices("autoRuedas.txt");
            verticesAutoEspejos = serealized.readVertices("autoEspejos.txt");




            pared = new Objecto(new Vector3(0, 0, 0));      
            Poligono paredPart = new Poligono(verticesPared, new Color4(0.4f, 0.2f, 0.0f, 1.0f));
            Part partPared = new Part();
            partPared.addPolygon(paredPart);
            pared.addParts(partPared);

            //dibujo de la repisa
            repisa = new Objecto(new Vector3(0, 0, 0));
            Poligono repisaPart = new Poligono(verticesRepisa, new Color4(1.0f, 0.84f, 0.0f, 1.0f));
            Part partRepisa = new Part();
            partRepisa.addPolygon(repisaPart);
            repisa.addParts(partRepisa);

            auto = new Objecto(new Vector3(0, 0, 0));
            Poligono autoPart = new Poligono(verticesAutoChasis, new Color4(1.0f, 0.0f, 0.0f, 1.0f));
            Poligono autoPartRuedas = new Poligono(verticesAutoRuedas, new Color4(0f, 0f, 0f, 0f));
            Poligono autoPartArriba = new Poligono(verticesAutoArriba, new Color4(1.0f, 0.0f, 0.0f, 1.0f));
            Poligono autoPartEspejos = new Poligono(verticesAutoEspejos, new Color4(0.5f, 0.5f, 0.5f, 1.0f));
            Part autoPartCuerpo = new Part();
            autoPartCuerpo.addPolygon(autoPart);
            autoPartCuerpo.addPolygon(autoPartRuedas);
            autoPartCuerpo.addPolygon(autoPartArriba);
            autoPartCuerpo.addPolygon(autoPartEspejos);
            auto.addParts(autoPartCuerpo);

            objetos.Add(pared);
            objetos.Add(repisa);
            objetos.Add(auto);

        }

        public void drawObjects()
        {
            pared.drawParts();
            repisa.drawParts();
            auto.drawParts();

        }

       /* public Objecto seleccionarObjeto(int index)
        {
            objetos.Add(pared);
            objetos.Add(repisa);
            objetos.Add(auto);

            if (index >= 0 && index < objetos.Count)
            {
                return objetos[index];
            }
            return null; // Devuelve null si el índice está fuera de rango
        }*/



    }
}
