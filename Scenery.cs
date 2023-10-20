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
        private Objecto pared = new Objecto(new Vector3(0.5f, 0.5f, 1f));
        private Objecto repisa = new Objecto(new Vector3(0.5f, 0.5f, 1f));
        private Objecto auto = new Objecto(new Vector3(0.5f, 0.5f, 1f));
       // private Serealized serealized = new Serealized();

        List<Vector3> verticesPared = new List<Vector3>();
        List<Vector3> verticesRepisa = new List<Vector3>();
        List<Vector3> verticesAutoChasis = new List<Vector3>();
        List<Vector3> verticesAutoArriba = new List<Vector3>();
        List<Vector3> verticesAutoRuedas = new List<Vector3>();
        List<Vector3> verticesAutoEspejos = new List<Vector3>();

        public void loadObjects()
        {
            /*verticesPared = serealized.readVertices("pared.txt");
            verticesRepisa = serealized.readVertices("repisa.txt");
            verticesAutoChasis = serealized.readVertices("autoChasis.txt");
            verticesAutoArriba = serealized.readVertices("autoArriba.txt");
            verticesAutoRuedas = serealized.readVertices("autoRuedas.txt");
            verticesAutoEspejos = serealized.readVertices("autoEspejos.txt");*/
            verticesPared = new List<Vector3>
            {
                new Vector3(-2.0f, -2.0f, 0.0f),
                new Vector3(2.0f, -2.0f, 0.0f),
                new Vector3(2.0f, 2.0f, 0.0f),
                new Vector3(-2.0f, 2.0f, 0.0f),

                new Vector3(-2.0f, -2.0f, 0.30f),
                new Vector3(2.0f, -2.0f, 0.30f),
                new Vector3(2.0f, 2.0f, 0.30f),
                new Vector3(-2.0f, 2.0f, 0.30f),


                new Vector3(-2.0f, 2.0f, 0.30f),
                new Vector3(2.0f, 2.0f, 0.30f),
                new Vector3(2.0f, 2.0f, 0.0f),
                new Vector3(-2.0f, 2.0f, 0.0f),


                new Vector3(-2.0f, -2.0f, 0.0f),
                new Vector3(2.0f, -2.0f, 0.0f),
                new Vector3(2.0f, -2.0f, 0.30f),
                new Vector3(-2.0f, -2.0f, 0.30f),

                new Vector3(-2.0f, -2.0f, 0.0f),
                new Vector3(-2.0f, 2.0f, 0.0f),
                new Vector3(-2.0f, 2.0f, 0.30f),
                new Vector3(-2.0f, -2.0f, 0.30f),

                new Vector3(2.0f, -2.0f, 0.30f),
                new Vector3(2.0f, 2.0f, 0.30f),
                new Vector3(2.0f, 2.0f, 0.0f),
                new Vector3(2.0f, -2.0f, 0.0f),
            };
           // serealized.writeVertices(verticesPared, "pared.txt");



            //repisa

            verticesRepisa = new List<Vector3>
{
    new Vector3(-2.0f, .4f, 0.90f),
    new Vector3(2.0f, .4f, 0.90f),
    new Vector3(2.0f, .56f, 0.90f),
    new Vector3(-2.0f, .56f, 0.90f),

    new Vector3(-2.0f, .4f, 0.30f),
    new Vector3(2.0f, .4f, 0.30f),
    new Vector3(2.0f, .56f, 0.30f),
    new Vector3(-2.0f, .56f, 0.30f),

    // Cara superior 
    new Vector3(-2.0f, .56f, 0.90f),
    new Vector3(2.0f, .56f, 0.90f),
    new Vector3(2.0f, .56f, 0.90f),
    new Vector3(-2.0f, .56f, 0.90f),

    // Cara inferior
    new Vector3(-2.0f, .4f, 0.90f),
    new Vector3(2.0f, .4f, 0.90f),
    new Vector3(2.0f, .4f, 0.30f),
    new Vector3(-2.0f, .4f, 0.30f),

    // Cara izquierda
    new Vector3(-2.0f, .4f, 0.90f),
    new Vector3(-2.0f, .56f, 0.90f),
    new Vector3(-2.0f, .56f, 0.30f),
    new Vector3(-2.0f, .4f, 0.30f),

    // Cara derecha 
    new Vector3(2.0f, .4f, 0.30f),//x inferior
    new Vector3(2.0f, .56f, 0.30f),//y inferior
    new Vector3(2.0f, .56f, 0.90f),//y superior
    new Vector3(2.0f, .4f, 0.90f),//x superior
};

            //serealized.writeVertices(verticesRepisa, "repisa.txt");

            verticesAutoChasis = new List<Vector3>
{
    new Vector3(-0.40f, .70f, 0.40f), //x inferior           
    new Vector3(-0.40f, .90f, 0.40f),//x superior
    new Vector3(0.40f, .90f, 0.40f),//y superior
    new Vector3(0.40f, .70f, 0.40f),//y inferior
    
    new Vector3(-0.40f, .70f, 0.810f), //x inferior           
    new Vector3(-0.40f, .90f, 0.810f),//x superior
    new Vector3(0.40f, .90f, 0.810f),//y superior
    new Vector3(0.40f, .70f, 0.810f),//y inferior
    
    new Vector3(-0.40f, .90f, 0.40f), //x inferior           
    new Vector3(-0.40f, .90f, 0.810f),//x superior
    new Vector3(0.40f, .90f, 0.810f),//y superior
    new Vector3(0.40f, .90f, 0.40f),//y inferior
    
    new Vector3(-0.40f, .70f, 0.40f), //x inferior           
    new Vector3(-0.40f, .70f, 0.810f),//x superior
    new Vector3(0.40f, .70f, 0.810f),//y superior
    new Vector3(0.40f, .70f, 0.40f),//y inferior
    
    new Vector3(0.40f, .70f, 0.40f), //x inferior           
    new Vector3(0.40f, .90f, 0.40f),//x superior
    new Vector3(0.40f, .90f, 0.810f),//y superior
    new Vector3(0.40f, .70f, 0.810f),//y inferior
    
    new Vector3(-0.40f, .70f, 0.40f), //x inferior           
    new Vector3(-0.40f, .90f, 0.40f),//x superior
    new Vector3(-0.40f, .90f, 0.810f),//y superior
    new Vector3(-0.40f, .70f, 0.810f),//y inferior
    
};
            //serealized.writeVertices(verticesAutoChasis, "autoChasis.txt");

            verticesAutoArriba = new List<Vector3>
{
    new Vector3(-0.25f, .90f, 0.40f), //x inferior           
    new Vector3(-0.10f, 1.10f, 0.40f),//x superior
    new Vector3(0.40f, 1.10f, 0.40f),//y superior ///atras
    new Vector3(0.40f, .90f, 0.40f),//y inferior
    
    new Vector3(-0.25f, .90f, 0.810f), //x inferior           
    new Vector3(-0.10f, 1.10f, 0.810f),//x superior//delante
    new Vector3(0.40f, 1.10f, 0.810f),//y superior
    new Vector3(0.40f, .90f, 0.810f),//y inferior
    
    new Vector3(-0.10f, 1.10f, 0.40f), //x inferior     //arriba      
    new Vector3(-0.10f, 1.10f, 0.810f),//x superior
    new Vector3(0.40f, 1.10f, 0.810f),//y superior
    new Vector3(0.40f, 1.10f, 0.40f),//y inferior
    
    new Vector3(-0.10f, .90f, 0.40f), //x inferior   //abajo        
    new Vector3(-0.10f, .90f, 0.810f),//x superior
    new Vector3(0.40f, .90f, 0.810f),//y superior
    new Vector3(0.40f, .90f, 0.40f),//y inferior
    
    new Vector3(0.40f, .90f, 0.40f), //x inferior           
    new Vector3(0.40f, 1.10f, 0.40f),//x superior //parte trasera del auto
    new Vector3(0.40f, 1.10f, 0.810f),//y superior
    new Vector3(0.40f, .90f, 0.810f),//y inferior
    
    new Vector3(-0.25f, .90f, 0.40f), //x inferior           
    new Vector3(-0.10f, 1.10f, 0.40f),//x superior
    new Vector3(-0.10f, 1.10f, 0.810f),//y superior
    new Vector3(-0.25f, .90f, 0.810f),//y inferior

};
            //serealized.writeVertices(verticesAutoArriba, "autoArriba.txt");


            verticesAutoEspejos = new List<Vector3>
{
    new Vector3(-0.20f, .90f, 0.38f), //x inferior           
    new Vector3(-0.11f, 1.05f, 0.38f),//x superior
    new Vector3(0.10f, 1.05f, 0.38f),//y superior ///espejo de la puerta de atras
    new Vector3(0.10f, .90f, 0.38f),//y inferior

    new Vector3(-0.20f, .90f, 0.815f), //x inferior           
    new Vector3(-0.11f, 1.05f, 0.815f),//x superior//espejo de la puerta de adelante
    new Vector3(0.10f, 1.05f, 0.815f),//y superior
    new Vector3(0.10f, .90f, 0.815f),//y inferior

    new Vector3(0.15f, .90f, 0.38f), //x inferior           
    new Vector3(0.14f, 1.05f, 0.38f),//x superior
    new Vector3(0.30f, 1.05f, 0.38f),//y superior ///espejo de la puerta de atras de atras
    new Vector3(0.30f, .90f, 0.38f),//y inferior

    new Vector3(0.15f, .90f, 0.815f), //x inferior           
    new Vector3(0.14f, 1.05f, 0.815f),//x superior//espejo de la puerta de adelante de atras
    new Vector3(0.30f, 1.05f, 0.815f),//y superior
    new Vector3(0.30f, .90f, 0.815f),//y inferior


    new Vector3(0.41f, .92f, 0.44f), //x inferior           
    new Vector3(0.41f, 1.08f, 0.44f),//x superior //espejo parte trasera del auto
    new Vector3(0.41f, 1.08f, 0.800f),//y superior
    new Vector3(0.41f, .92f, 0.800f),//y inferior

    new Vector3(-0.25f, .92f, 0.42f), //x inferior           
    new Vector3(-0.12f, 1.08f, 0.42f),//x superior//espejo delante del auto
    new Vector3(-0.12f, 1.08f, 0.808f),//y superior
    new Vector3(-0.25f, .92f, 0.808f),//y inferior

};
         // serealized.writeVertices(verticesAutoEspejos, "autoEspejos.txt");


            ///Ruedas
            verticesAutoRuedas = new List<Vector3>
{
    new Vector3(-0.35f, .56f, 0.40f), //x inferior           
    new Vector3(-0.35f, .70f, 0.40f),//x superior//atras 
    new Vector3(-0.20f, .70f, 0.40f),//y superior
    new Vector3(-0.20f, .56f, 0.40f),//y inferior

    new Vector3(-0.35f, .56f, 0.46f), //x inferior           
    new Vector3(-0.35f, .70f, 0.46f),//x superior adelante de la rueda de atras
    new Vector3(-0.20f, .70f, 0.46f),//y superior
    new Vector3(-0.20f, .56f, 0.46f),//y inferior

    new Vector3(-0.20f, .56f, 0.40f), //x inferior           
    new Vector3(-0.20f, .70f, 0.40f),//x superior atras de la rueda de atras
    new Vector3(-0.20f, .70f, 0.46f),//y superior
    new Vector3(-0.20f, .56f, 0.46f),//y inferior

    new Vector3(-0.35f, .56f, 0.40f), //x inferior           
    new Vector3(-0.35f, .70f, 0.40f),//x superior frente de la rueda de atras
    new Vector3(-0.35f, .70f, 0.46f),//y superior
    new Vector3(-0.35f, .56f, 0.46f),//y inferior




    new Vector3(-0.35f, .56f, 0.810f), //x inferior           
    new Vector3(-0.35f, .70f, 0.810f),//x superior
    new Vector3(-0.20f, .70f, 0.810f),//y superior
    new Vector3(-0.20f, .56f, 0.810f),//y inferior

    new Vector3(-0.35f, .56f, 0.770f), //x inferior           
    new Vector3(-0.35f, .70f, 0.770f),//x superior
    new Vector3(-0.20f, .70f, 0.770f),//y superior
    new Vector3(-0.20f, .56f, 0.770f),//y inferior

    new Vector3(-0.20f, .56f, 0.770f), //x inferior           
    new Vector3(-0.20f, .70f, 0.770f),//x superior
    new Vector3(-0.20f, .70f, 0.810f),//y superior
    new Vector3(-0.20f, .56f, 0.810f),//y inferior

    new Vector3(-0.35f, .56f, 0.770f), //x inferior           
    new Vector3(-0.35f, .70f, 0.770f),//x superior
    new Vector3(-0.35f, .70f, 0.810f),//y superior
    new Vector3(-0.35f, .56f, 0.810f),//y inferior






    new Vector3(0.35f, .56f, 0.40f), //x inferior           
    new Vector3(0.35f, .70f, 0.40f),//x superior
    new Vector3(0.20f, .70f, 0.40f),//y superior
    new Vector3(0.20f, .56f, 0.40f),//y inferior

    new Vector3(0.35f, .56f, 0.46f), //x inferior           
    new Vector3(0.35f, .70f, 0.46f),//x superior
    new Vector3(0.20f, .70f, 0.46f),//y superior
    new Vector3(0.20f, .56f, 0.46f),//y inferior

    new Vector3(0.20f, .56f, 0.40f), //x inferior           
    new Vector3(0.20f, .70f, 0.40f),//x superior atras de la rueda de atras
    new Vector3(0.20f, .70f, 0.46f),//y superior
    new Vector3(0.20f, .56f, 0.46f),//y inferior

    new Vector3(0.35f, .56f, 0.40f), //x inferior           
    new Vector3(0.35f, .70f, 0.40f),//x superior atras de la rueda de atras
    new Vector3(0.35f, .70f, 0.46f),//y superior
    new Vector3(0.35f, .56f, 0.46f),//y inferior



    new Vector3(0.35f, .56f, 0.810f), //x inferior           
    new Vector3(0.35f, .70f, 0.810f),//x superior
    new Vector3(.20f, .70f, 0.810f),//y superior
    new Vector3(.20f, .56f, 0.810f),//y inferior 

    new Vector3(0.35f, .56f, 0.770f), //x inferior           
    new Vector3(0.35f, .70f, 0.770f),//x superior
    new Vector3(0.20f, .70f, 0.770f),//y superior
    new Vector3(0.20f, .56f, 0.770f),//y inferior

    new Vector3(0.20f, .56f, 0.770f), //x inferior           
    new Vector3(0.20f, .70f, 0.770f),//x superior
    new Vector3(0.20f, .70f, 0.810f),//y superior
    new Vector3(0.20f, .56f, 0.810f),//y inferior

    new Vector3(0.35f, .56f, 0.770f), //x inferior           
    new Vector3(0.35f, .70f, 0.770f),//x superior
    new Vector3(0.35f, .70f, 0.810f),//y superior
    new Vector3(0.35f, .56f, 0.810f),//y inferior
 };
           // serealized.writeVertices(verticesAutoRuedas, "autoRuedas.txt");


            Poligono paredPart = new Poligono(verticesPared, new Color4(0.4f, 0.2f, 0.0f, 1.0f));
            Part partPared = new Part();
            partPared.addPolygon(paredPart);
            pared.addParts(partPared);

            //dibujo de la repisa
            Poligono repisaPart = new Poligono(verticesRepisa, new Color4(1.0f, 0.84f, 0.0f, 1.0f));
            Part partRepisa = new Part();
            partRepisa.addPolygon(repisaPart);
            repisa.addParts(partRepisa);

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

        }

        public void drawObjects()
        {
            pared.drawParts();
            repisa.drawParts();
             auto.drawParts();

        }
    }
}
