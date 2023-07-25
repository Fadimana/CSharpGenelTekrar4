using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alistırma4
{
    //sınıf kavramı 
    /* class Box
     {
         private double lenght;
         private double breadth;
         private double height;


         public void setLenght(double len)
         {
             lenght = len;
         }
         public void setBreadth(double bre)
         {
             breadth = bre;
         }
         public void setHeight(double hei)
         {
             height = hei;
         }
         public double getVolume()
         {
             return lenght * breadth * height;
         }


     }
     internal class Program
     {
         static void Main(string[] args)
         {
             Box box1 = new Box();
             Box box2 = new Box();
             double volume ;

             box1.setHeight(5.0);
             box1.setLenght(6.0);
             box1.setBreadth(7.0);

             box2.setHeight(10.0);
             box2.setLenght(12.0);
             box2.setBreadth(13.0);
             // volume of box1
             volume = box1.getVolume();
             Console.WriteLine("Volume of Box1: {0}", volume);

             volume = box2.getVolume();
             Console.WriteLine("Volume of Box2: {0}", volume);

             Console.ReadKey();
         }
     }*/
    /*
       // Türetilmiş ve Temel sınıflar gösterildi.
    class Shape
    {
        protected int width;
        protected int height;

        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
    }
    class rectangle :Shape
    {
        public int getArea()
        {
            //widht ve height miras aldık
            return (width * height);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            rectangle r = new rectangle();
            r.setWidth(5);//temel sınıftaki fonksiyonlara eriştik
            r.setHeight(4);

            Console.WriteLine("total area: {0}", r.getArea());
            Console.ReadKey();
        }
        
    }*/

    //Temel sınıfın başlatılması 
    class rectangle
    {
        protected double length;
        protected double width;
        public rectangle(double l,double w) //yapıcı 
        {
            length = l;
            width = w;
        }
        public double getArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("length:{ 0}", length);
            Console.WriteLine("width:{ 0}", width);
            Console.WriteLine("area:{ 0}", getArea());

        }

    }
    class Tabletop :rectangle
    {
        private double cost;
        public Tabletop(double l,double w):base (l,w) { } //yapıcı başlattık
        public double getCost()
        {
            double cost;
            cost = getArea() * 70;
            return cost;
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("const: {0}", getCost());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabletop t = new Tabletop(4.5, 7.8);
            t.Display();
            Console.ReadLine();
        }

    }
}