using Figures;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Transactions;

Figure[] figureArray = new Figure[5];

figureArray[0] = new Triangle { SideA = 1, sideB = 2, sideC = 3 }; //OBS! The Area formula is not working, ckeck the calculation??
figureArray[1] = new Triangle { SideA = 4, sideB = 25, sideC = 7 }; //OBS! The Area formula is not working, ckeck the calculation??
figureArray[2] = new Circle { Radius = 9 };
figureArray[3] = new Circle { Radius = 10 };
figureArray[4] = new Rectangle { width = 9, height = 10 };

//get detailed info of each figure:
for (int i = 0; i < figureArray.Length; i++)
{
    Console.WriteLine($"The figure #{i+1} " +
        $"is a: {figureArray[i].GetName()}\n" +
        $"Perimeter is: {figureArray[i].GetPerimeter()}\n" +
        $"Area is:{figureArray[i].GetArea()}\n");

}

// have been trying to get sum of areas, but it doesn't seem to work correctly.
// The problem in connetion between double and string

/*foreach (var element in figureArray)
{
    int sum +=  Convert.ToInt32(element.GetArea());
    Console.WriteLine($"The sum of areas is: {sum}\n");

} */
