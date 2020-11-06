﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }
        public override double CalculateArea()
        {
            return height * width;
        }

        public override double CalculatePerimeter() //2(l+w)
        {
            return 2 * (height + width);
        }
        public override string Draw()
        {
            return "Drawing rectangle";
        }
    }
}
