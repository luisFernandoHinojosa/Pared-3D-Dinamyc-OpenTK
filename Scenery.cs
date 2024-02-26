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

        public Part autoPartCuerpo = new Part();
      
        public Part partRuedas1 = new Part(1);
        public Part partRuedas2 = new Part(2);
        public Part partRuedas3 = new Part(3);
        public Part partRuedas4 = new Part(4);

        public Poligono poli;

        public List<Poligono> polygonos = new List<Poligono>();

        List<Points> verticesPared = new List<Points>();
        List<Points> verticesRepisa = new List<Points>();
        List<Points> verticesAutoChasis = new List<Points>();
        List<Points> verticesAutoArriba = new List<Points>();
        List<Points> verticesAutoRueda1 = new List<Points>();
        List<Points> verticesAutoRueda2 = new List<Points>();
        List<Points> verticesAutoRueda3 = new List<Points>();
        List<Points> verticesAutoRueda4 = new List<Points>();
        List<Points> verticesAutoEspejos = new List<Points>();
        public void loadObjects()

        {

            //decomentar todo esto para poder serealizar de nuevo si agregamos nuevos vertices
            /*verticesPared = new List<Points>
            {
                new Points(-2.0f, -2.0f, 0.0f),
                new Points(2.0f, -2.0f, 0.0f),
                new Points(2.0f, 2.0f, 0.0f),
                new Points(-2.0f, 2.0f, 0.0f),
                
                new Points(-2.0f, -2.0f, 0.30f),
                new Points(2.0f, -2.0f, 0.30f),
                new Points(2.0f, 2.0f, 0.30f),
                new Points(-2.0f, 2.0f, 0.30f),
                
                new Points(-2.0f, 2.0f, 0.30f),
                new Points(2.0f, 2.0f, 0.30f),
                new Points(2.0f, 2.0f, 0.0f),
                new Points(-2.0f, 2.0f, 0.0f),
                
                new Points(-2.0f, -2.0f, 0.0f),
                new Points(2.0f, -2.0f, 0.0f),
                new Points(2.0f, -2.0f, 0.30f),
                new Points(-2.0f, -2.0f, 0.30f),
                
                new Points(-2.0f, -2.0f, 0.0f),
                new Points(-2.0f, 2.0f, 0.0f),
                new Points(-2.0f, 2.0f, 0.30f),
                new Points(-2.0f, -2.0f, 0.30f),
                
                new Points(2.0f, -2.0f, 0.30f),
                new Points(2.0f, 2.0f, 0.30f),
                new Points(2.0f, 2.0f, 0.0f),
                new Points(2.0f, -2.0f, 0.0f),
            };

               



                //repisa

            verticesRepisa = new List<Points>
            {
                new Points(-2.0f, .4f, 0.90f),
                new Points(2.0f, .4f, 0.90f),
                new Points(2.0f, .56f, 0.90f),
                new Points(-2.0f, .56f, 0.90f),

                new Points(-2.0f, .4f, 0.30f),
                new Points(2.0f, .4f, 0.30f),
                new Points(2.0f, .56f, 0.30f),
                new Points(-2.0f, .56f, 0.30f),
                    
                //  Pointserior 
                new Points(-2.0f, .56f, 0.90f),
                new Points(2.0f, .56f, 0.90f),
                new Points(2.0f, .56f, 0.90f),
                new Points(-2.0f, .56f, 0.90f),
                    
                //  Pointserior
                new Points(-2.0f, .4f, 0.90f),
                new Points(2.0f, .4f, 0.90f),
                new Points(2.0f, .4f, 0.30f),
                new Points(-2.0f, .4f, 0.30f),
                    
                //  Pointsuierda
                new Points(-2.0f, .4f, 0.90f),
                new Points(-2.0f, .56f, 0.90f),
                new Points(-2.0f, .56f, 0.30f),
                new Points(-2.0f, .4f, 0.30f),
                    
                //  Pointsecha 
                new Points(2.0f, .4f, 0.30f),//x inferior
                new Points(2.0f, .56f, 0.30f),//y inferior
                new Points(2.0f, .56f, 0.90f),//y superior
                new Points(2.0f, .4f, 0.90f),//x superior
            };
           

            verticesAutoChasis = new List<Points>
            {
                 new Points(-0.40f, .70f, 0.40f), //x inferior           
                 new Points(-0.40f, .90f, 0.40f),//x superior
                 new Points(0.40f, .90f, 0.40f),//y superior
                 new Points(0.40f, .70f, 0.40f),//y inferior
                     
                 new Points(-0.40f, .70f, 0.810f), //x inferior           
                 new Points(-0.40f, .90f, 0.810f),//x superior
                 new Points(0.40f, .90f, 0.810f),//y superior
                 new Points(0.40f, .70f, 0.810f),//y inferior
                     
                 new Points(-0.40f, .90f, 0.40f), //x inferior           
                 new Points(-0.40f, .90f, 0.810f),//x superior
                 new Points(0.40f, .90f, 0.810f),//y superior
                 new Points(0.40f, .90f, 0.40f),//y inferior
                     
                 new Points(-0.40f, .70f, 0.40f), //x inferior           
                 new Points(-0.40f, .70f, 0.810f),//x superior
                 new Points(0.40f, .70f, 0.810f),//y superior
                 new Points(0.40f, .70f, 0.40f),//y inferior
                     
                 new Points(0.40f, .70f, 0.40f), //x inferior           
                 new Points(0.40f, .90f, 0.40f),//x superior
                 new Points(0.40f, .90f, 0.810f),//y superior
                 new Points(0.40f, .70f, 0.810f),//y inferior
                     
                 new Points(-0.40f, .70f, 0.40f), //x inferior           
                 new Points(-0.40f, .90f, 0.40f),//x superior
                 new Points(-0.40f, .90f, 0.810f),//y superior
                 new Points(-0.40f, .70f, 0.810f),//y inferior

               
            };

            verticesAutoArriba = new List<Points>
            {
                new Points(-0.25f, .90f, 0.40f), //x inferior           
                new Points(-0.10f, 1.10f, 0.40f),//x superior
                new Points(0.40f, 1.10f, 0.40f),//y superior ///atras
                new Points(0.40f, .90f, 0.40f),//y inferior
                    
                new Points(-0.25f, .90f, 0.810f), //x inferior           
                new Points(-0.10f, 1.10f, 0.810f),//x superior//delante
                new Points(0.40f, 1.10f, 0.810f),//y superior
                new Points(0.40f, .90f, 0.810f),//y inferior
                    
                new Points(-0.10f, 1.10f, 0.40f), //x inferior     //arriba      
                new Points(-0.10f, 1.10f, 0.810f),//x superior
                new Points(0.40f, 1.10f, 0.810f),//y superior
                new Points(0.40f, 1.10f, 0.40f),//y inferior
                    
                new Points(-0.10f, .90f, 0.40f), //x inferior   //abajo        
                new Points(-0.10f, .90f, 0.810f),//x superior
                new Points(0.40f, .90f, 0.810f),//y superior
                new Points(0.40f, .90f, 0.40f),//y inferior
                    
                new Points(0.40f, .90f, 0.40f), //x inferior           
                new Points(0.40f, 1.10f, 0.40f),//x superior //parte trasera del auto
                new Points(0.40f, 1.10f, 0.810f),//y superior
                new Points(0.40f, .90f, 0.810f),//y inferior
                    
                new Points(-0.25f, .90f, 0.40f), //x inferior           
                new Points(-0.10f, 1.10f, 0.40f),//x superior
                new Points(-0.10f, 1.10f, 0.810f),//y superior
                new Points(-0.25f, .90f, 0.810f),//y inferior
        
                
             };



            verticesAutoEspejos = new List<Points>
            {
                new Points(-0.20f, .90f, 0.38f), //x inferior           
                new Points(-0.11f, 1.05f, 0.38f),//x superior
                new Points(0.10f, 1.05f, 0.38f),//y superior ///espejo de la puerta de atras
                new Points(0.10f, .90f, 0.38f),//y inferior
                    
                new Points(-0.20f, .90f, 0.815f), //x inferior           
                new Points(-0.11f, 1.05f, 0.815f),//x superior//espejo de la puerta de adelante
                new Points(0.10f, 1.05f, 0.815f),//y superior
                new Points(0.10f, .90f, 0.815f),//y inferior
                    
                new Points(0.15f, .90f, 0.38f), //x inferior           
                new Points(0.14f, 1.05f, 0.38f),//x superior
                new Points(0.30f, 1.05f, 0.38f),//y superior ///espejo de la puerta de atras de atras
                new Points(0.30f, .90f, 0.38f),//y inferior
                    
                new Points(0.15f, .90f, 0.815f), //x inferior           
                new Points(0.14f, 1.05f, 0.815f),//x superior//espejo de la puerta de adelante de atras
                new Points(0.30f, 1.05f, 0.815f),//y superior
                new Points(0.30f, .90f, 0.815f),//y inferior
                    
                new Points(0.41f, .92f, 0.44f), //x inferior           
                new Points(0.41f, 1.08f, 0.44f),//x superior //espejo parte trasera del auto
                new Points(0.41f, 1.08f, 0.800f),//y superior
                new Points(0.41f, .92f, 0.800f),//y inferior
                    
                new Points(-0.25f, .92f, 0.42f), //x inferior           
                new Points(-0.12f, 1.08f, 0.42f),//x superior//espejo delante del auto
                new Points(-0.12f, 1.08f, 0.808f),//y superior
                new Points(-0.25f, .92f, 0.808f),//y inferior
                   
                
           };



            verticesAutoRueda1 = new List<Points>
            {
                 new Points(-0.35f, .56f, 0.40f), //x inferior           
                 new Points(-0.35f, .70f, 0.40f),//x superior//atras 
                 new Points(-0.20f, .70f, 0.40f),//y superior
                 new Points(-0.20f, .56f, 0.40f),//y inferior
                     
                 new Points(-0.35f, .56f, 0.46f), //x inferior           
                 new Points(-0.35f, .70f, 0.46f),//x superior adelante de la rueda de atras
                 new Points(-0.20f, .70f, 0.46f),//y superior
                 new Points(-0.20f, .56f, 0.46f),//y inferior
                     
                 new Points(-0.20f, .56f, 0.40f), //x inferior           
                 new Points(-0.20f, .70f, 0.40f),//x superior atras de la rueda de atras
                 new Points(-0.20f, .70f, 0.46f),//y superior
                 new Points(-0.20f, .56f, 0.46f),//y inferior
                     
                 new Points(-0.35f, .56f, 0.40f), //x inferior           
                 new Points(-0.35f, .70f, 0.40f),//x superior frente de la rueda de atras
                 new Points(-0.35f, .70f, 0.46f),//y superior
                 new Points(-0.35f, .56f, 0.46f),//y inferior
            };
            verticesAutoRueda2 = new List<Points>
            {

                new Points(-0.35f, .56f, 0.810f), //x inferior           
                new Points(-0.35f, .70f, 0.810f),//x superior
                new Points(-0.20f, .70f, 0.810f),//y superior
                new Points(-0.20f, .56f, 0.810f),//y inferior
                
                new Points(-0.35f, .56f, 0.770f), //x inferior           
                new Points(-0.35f, .70f, 0.770f),//x superior
                new Points(-0.20f, .70f, 0.770f),//y superior
                new Points(-0.20f, .56f, 0.770f),//y inferior
                    
                new Points(-0.20f, .56f, 0.770f), //x inferior           
                new Points(-0.20f, .70f, 0.770f),//x superior
                new Points(-0.20f, .70f, 0.810f),//y superior
                new Points(-0.20f, .56f, 0.810f),//y inferior
                    
                new Points(-0.35f, .56f, 0.770f), //x inferior           
                new Points(-0.35f, .70f, 0.770f),//x superior
                new Points(-0.35f, .70f, 0.810f),//y superior
                new Points(-0.35f, .56f, 0.810f),//y inferior
            };
            verticesAutoRueda3 = new List<Points>
            {

                new Points(0.35f, .56f, 0.40f), //x inferior           
                new Points(0.35f, .70f, 0.40f),//x superior
                new Points(0.20f, .70f, 0.40f),//y superior
                new Points(0.20f, .56f, 0.40f),//y inferior
                   
                new Points(0.35f, .56f, 0.46f), //x inferior           
                new Points(0.35f, .70f, 0.46f),//x superior
                new Points(0.20f, .70f, 0.46f),//y superior
                new Points(0.20f, .56f, 0.46f),//y inferior
                    
                new Points(0.20f, .56f, 0.40f), //x inferior           
                new Points(0.20f, .70f, 0.40f),//x superior atras de la rueda de atras
                new Points(0.20f, .70f, 0.46f),//y superior
                new Points(0.20f, .56f, 0.46f),//y inferior
                    
                new Points(0.35f, .56f, 0.40f), //x inferior           
                new Points(0.35f, .70f, 0.40f),//x superior atras de la rueda de atras
                new Points(0.35f, .70f, 0.46f),//y superior
                new Points(0.35f, .56f, 0.46f),//y inferior
            };
            verticesAutoRueda4 = new List<Points>
            { 
                 new Points(0.35f, .56f, 0.810f), //x inferior           
                 new Points(0.35f, .70f, 0.810f),//x superior
                 new Points(.20f, .70f, 0.810f),//y superior
                 new Points(.20f, .56f, 0.810f),//y inferior 
                     
                 new Points(0.35f, .56f, 0.770f), //x inferior           
                 new Points(0.35f, .70f, 0.770f),//x superior
                 new Points(0.20f, .70f, 0.770f),//y superior
                 new Points(0.20f, .56f, 0.770f),//y inferior
                     
                 new Points(0.20f, .56f, 0.770f), //x inferior           
                 new Points(0.20f, .70f, 0.770f),//x superior
                 new Points(0.20f, .70f, 0.810f),//y superior
                 new Points(0.20f, .56f, 0.810f),//y inferior
                     
                 new Points(0.35f, .56f, 0.770f), //x inferior           
                 new Points(0.35f, .70f, 0.770f),//x superior
                 new Points(0.35f, .70f, 0.810f),//y superior
                 new Points(0.35f, .56f, 0.810f),//y inferior
            };

            //descomentar si agregamos una nueva clase u objeto
            pared = new Objecto(new Points(0, 0, 0));
            Poligono paredPart = new Poligono(verticesPared, new Color4(0.4f, 0.2f, 0.0f, 1.0f));
            Part partPared = new Part();
            partPared.addPolygon(paredPart);
            pared.addParts(partPared);

            //dibujo de la repisa
            repisa = new Objecto(new Points(0, 0, 0));
            Poligono repisaPart = new Poligono(verticesRepisa, new Color4(1.0f, 0.84f, 0.0f, 1.0f));
            Part partRepisa = new Part();
            partRepisa.addPolygon(repisaPart);
            repisa.addParts(partRepisa);

            auto = new Objecto(new Points(0, 0, 0));
            Poligono autoPart = new Poligono(verticesAutoChasis, new Color4(1.0f, 0.0f, 0.0f, 1.0f));
            Poligono autoPartRueda1 = new Poligono(verticesAutoRueda1, new Color4(0f, 0f, 0f, 0f));
            Poligono autoPartRueda2 = new Poligono(verticesAutoRueda2, new Color4(0f, 0f, 0f, 0f));
            Poligono autoPartRueda3 = new Poligono(verticesAutoRueda3, new Color4(0f, 0f, 0f, 0f));
            Poligono autoPartRueda4 = new Poligono(verticesAutoRueda4, new Color4(0f, 0f, 0f, 0f));
            Poligono autoPartArriba = new Poligono(verticesAutoArriba, new Color4(1.0f, 0.0f, 0.0f, 1.0f));
            Poligono autoPartEspejos = new Poligono(verticesAutoEspejos, new Color4(0.5f, 0.5f, 0.5f, 1.0f));

            //agregamos los poligonos de cada rueda
            partRuedas1.addPolygon(autoPartRueda1);
            partRuedas2.addPolygon(autoPartRueda2);
            partRuedas3.addPolygon(autoPartRueda3);
            partRuedas4.addPolygon(autoPartRueda4);


            autoPartCuerpo.addPolygon(autoPart);
            // autoPartCuerpo.addPolygon(autoPartRuedas);
            autoPartCuerpo.addPolygon(autoPartArriba);
            autoPartCuerpo.addPolygon(autoPartEspejos);

            auto.addParts(autoPartCuerpo);
            auto.addParts(partRuedas1);
            auto.addParts(partRuedas2);
            auto.addParts(partRuedas3);
            auto.addParts(partRuedas4);*/

            //polygonos.Add(autoPartRuedas);
            //poli = polygonos[0];

            //para deserealizar
            pared = Serealized.DeserializarObjeto<Objecto>("pared.json");
            repisa = Serealized.DeserializarObjeto<Objecto>("repisa.json");
            auto = Serealized.DeserializarObjeto<Objecto>("auto.json");


            objetos.Add(pared);
            objetos.Add(repisa);
            objetos.Add(auto);

            //para serealizar las clases pared, repisa, auto
            /*Serealized.SerializarObjeto(pared, "pared.json");
            Serealized.SerializarObjeto(repisa, "repisa.json");
            Serealized.SerializarObjeto(auto, "auto.json");*/
        }

        public void drawObjects()
        {
            pared.drawParts();
            repisa.drawParts();
            auto.drawParts();
           // auto.RotateRuedas();
        }

        public Objecto selecterObject(int index)
        {
            objetos.Add(pared);
            objetos.Add(repisa);
            objetos.Add(auto);

            if (index >= 0 && index < objetos.Count)
            {
                return objetos[index];
            }
            return null;
        }
    }
}
