using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Figures
{
    public class Triangle : Figure
    {
        public float sideA, sideB, sideC; 
        

        // Checking value
        // convert negative value to positive one if needed
        public float SideA
        {
            get { return sideA; }
            set { sideA = value < 0 ? -value : value; }
        }

        public float SideB
        {
            get { return sideB; }
            set { sideB = value < 0 ? -value : value; }
        }

        public float SideC
        {
            get { return sideC; }
            set { sideC = value < 0 ? -value : value; }
        }


        // Heron's formula to calculate the triangle's area
        //Area = Square root of√s(s - a)(s - b)(s - c) where s is half the perimeter, or (a + b + c)/2.
        
        //OBS! The formula is not working, ckeck the calculation??

        public override string GetArea()
        {
            double halfPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(halfPerimeter * ((halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC)));
            return String.Format($"{area}");

        }

        public override string GetPerimeter()
        {
            double perimeter = sideA + sideB + sideC;
            return String.Format($"{perimeter}");


        }

        public override string GetName()
        {
            
            return String.Format("Triangle");

        }


    }
}

