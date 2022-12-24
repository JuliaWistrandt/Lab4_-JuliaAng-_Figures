using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Circle : Rectangle
    {
        double radius;


        // Checking value
        // convert negative value to positive one if needed
        public double Radius
        {
            get { return radius; }
            set { radius = value < 0 ? -value : value; }
        }


        public override string GetArea()
        {
            double area = Math.PI * radius * radius;
            return String.Format($"{area}\n"); ;
        }


        public override string GetPerimeter()
        {
            double perimeter = Math.PI * radius * 2;
            return String.Format($"{perimeter}");

        }

        public override string GetName()
        {

            return String.Format("Circle");

        }


    }
}
