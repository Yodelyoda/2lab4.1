using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab_4._1
{
    class Vector
    {
        private double hight;
        private double width;
       
        public double GetHight() { return hight; }
        public double GetWidth() { return width; }

        public double GetArea() { return hight * width; }

        public double GetPerim() { return (hight + width)*2; }

        public bool SetHight(double h)
        {
            if (h > 0)
            {
                hight = h;
                return true;
            }
            else
            {
                hight = 0;
                return false;
            }
        }
        public bool SetWidth(double w)
        {
            if (w > 0)
            {
                width = w;
                return true;
            }
            else
            {
                width = 0;
                return false;
            }
        }
     
        public bool Init(double h, double w)
        {
            return SetHight (h) && SetWidth(w);
        }
        public void Read()
        {
         
            double h;
            double w;
          
            do
            {
                Console.WriteLine("Hight: ");
                h = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Width: ");
                w = Convert.ToDouble(Console.ReadLine());
            } while (!Init(h, w));
        }
        public void Display()
        {
         
            Console.WriteLine("Hight: " + hight);
            Console.WriteLine("Width: " + width);
        }

    }
}
