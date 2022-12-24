using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Rectangle : Triangle
    {
        public float width;   
        public float height;   


        // Checking value
        // convert negative value into positive one if needed
        public float Width
        {
            get { return width; }
            set { width = value < 0 ? -value : value; }
        }

        public float Height
        {
            get { return height; }
            set { height = value < 0 ? -value : value; }
        }

        public override string GetArea()
        {
            double area = Width * Height;
            return String.Format($"{area}");

        }


        public override string GetPerimeter()
        {
            double perimeter = 2 * (Width + Height);
            return String.Format($"{perimeter}");

        }

        public override string GetName()
        {

            return String.Format("Rectangle");

        }


    }
}
