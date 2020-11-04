using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Transactions;

namespace ClassBoxData
{
    public class Box
    {
        private const double SIDE_MIN_VALUE = 0;
        private const string INVALID_SIDE_MESSAGE = "{0} cannot be zero or negative.";

        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get => this.length;
            private set
            {
                this.ValidateMinValue(value, nameof(this.Length));

                this.length = value;
            }
        }

        public double Width
        {
            get => this.width;
            private set
            {
                this.ValidateMinValue(value, nameof(this.Width));

                this.width = value;
            }
        }

        public double Height
        {
            get => this.height;
            private set
            {
                this.ValidateMinValue(value, nameof(this.Height));

                this.height = value;
            }
        }

        public double CalculateSurfaceArea() => 2 * (this.Length * this.Width) + this.CalculateLateralSurfaceArea();

        public double CalculateLateralSurfaceArea() => 2 * ((this.Length * this.Height) + (this.Height * this.Width));

        public double CalculateVolume() => this.Length * this.Height * this.Width;

        private void ValidateMinValue(double value, string sideName)
        {
            if (value <= SIDE_MIN_VALUE)
            {
                throw new ArgumentException(string.Format(INVALID_SIDE_MESSAGE, sideName));
            }
        }
    }
}
